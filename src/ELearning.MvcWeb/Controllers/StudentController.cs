using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using ELearning.MvcWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json.Linq;

namespace ELearning.MvcWeb.Controllers
{
    public class StudentController : Controller
    {
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("userId") == null)
            {
                return RedirectToAction("Index", "Account");
            }

            List<Student> reservationList = new List<Student>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:5001/Student/GetAll"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();


                    string json = apiResponse.TrimStart('[').TrimEnd(']');
                    JObject o = JObject.Parse(json);
                    JArray jsonarray = (JArray)o["data"];
                    reservationList = jsonarray.ToObject<List<Student>>();
                }
            }

            return View(reservationList);
        }
    }
}
