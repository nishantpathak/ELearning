using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using ELearning.MvcWeb.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ELearning.MvcWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("https://localhost:5001/auth/login", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        string json = apiResponse.TrimStart('[').TrimEnd(']');
                        JObject o = JObject.Parse(json);
                        bool flag = o.SelectToken("success").Value<bool>();
                        if (!flag)
                        {
                            ModelState.AddModelError("Password", "Invalid login attempt.");
                            return View("Index");
                        }
                        else
                        {
                            HttpContext.Session.SetString("userId", model.Username);
                        }
                    }
                }
            }
            else
            {
                return View("Index");
            }

            return RedirectToAction("Index", "Student");
        }

        [HttpPost]
        public async Task<ActionResult> Registar(RegistrationViewModel model)
        {

            //if (ModelState.IsValid)
            //{
            //    Userdetails user = new Userdetails
            //    {
            //        Name = model.Name,
            //        Email = model.Email,
            //        Password = model.Password,
            //        Mobile = model.Mobile

            //    };
            //    _context.Add(user);
            //    await _context.SaveChangesAsync();

            //}
            //else
            //{
            //    return View("Registration");
            //}
            return RedirectToAction("Index", "Account");
        }
        // registration Page load

        public IActionResult Registration()
        {
            ViewData["Message"] = "Registration Page";

            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
        public void ValidationMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }

        }
    }
}
