using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_CoffeeShopPart4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab18_CoffeeShopPart4.Controllers
{
    public class CoffeeShopController : Controller
    {
        //field
        private readonly CoffeeShopDbContext _context;

        //controller
        public CoffeeShopController(CoffeeShopDbContext context)
        {
            _context = context;
        }
        List<User> users = new List<User>();
        List<Item> shoppingCart = new List<Item>();



        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {
            string userJson = HttpContext.Session.GetString("LoginSession");
            if (userJson != null)
            {
                TempData["LoggedIn"] = "Please log out before another user can log in.";
                return RedirectToAction("LogOut");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    User user = _context.User.Find(Email);
                    if (user != null)
                    {
                        if (user.Password == Password)
                        {
                            HttpContext.Session.SetString("LoginSession", JsonConvert.SerializeObject(user));
                            return RedirectToAction("Welcome", user);
                        }
                        else
                        {
                            TempData["InvalidPass"] = "Invalid Password";
                        }
                    }
                    else
                    {
                        TempData["InvalidEmail"] = "Email not registered";
                    }
                }
            }
            return View();
        }
        public IActionResult Welcome(User user)
        {
            return View("Welcome", user);
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogOut(User user)
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Shop()
        {
            List<Item> itemList = _context.Item.ToList();
            return View(itemList);
        }
        public IActionResult AddItemToCart(Item item)
        {
            List<Item> itemList = _context.Item.ToList();
            string shoppingCartJson = HttpContext.Session.GetString("CartSession");
            if (shoppingCartJson != null)
            {
                shoppingCart = JsonConvert.DeserializeObject<List<Item>>(shoppingCartJson);
            }
            shoppingCart.Add(item);
            HttpContext.Session.SetString("CartSession", JsonConvert.SerializeObject(shoppingCart));
            return View("Shop", itemList);
        }
        public IActionResult ShoppingCartList()
        {
            string shoppingCartJson = HttpContext.Session.GetString("CartSession");
            if (shoppingCartJson != null)
            {
                shoppingCart = JsonConvert.DeserializeObject<List<Item>>(shoppingCartJson);
            }
            return View("ShoppingCartList", shoppingCart);
        }
        public IActionResult RemoveItem(Item item)
        {


            string shoppingCartJson = HttpContext.Session.GetString("CartSession");

            shoppingCart = JsonConvert.DeserializeObject<List<Item>>(shoppingCartJson);

            shoppingCart.RemoveAt(0);



            HttpContext.Session.SetString("CartSession", JsonConvert.SerializeObject(shoppingCart));
            return RedirectToAction("ShoppingCartList", shoppingCart);
        }
    }
}