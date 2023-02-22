using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Collections;
using System.Net.Http;

namespace TestConfigServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationUser _auc;

        public UserRegistrationController(ApplicationUser auc)
        {
            _auc = auc;
            
        }

        private void gehtEndlich(User user)
        {
            _auc.Add(user);
            _auc.SaveChanges();
        }
        /*
        public IActionResult Create()
        {
            return View();
        }
        */

       /* private static void AddStudent()
        {

            using (var application = new ApplicationUser())
            {

                var user = new User
                {
                    EMail = "muster@mail.to",
                    Password = "qwertz",
                    ConfPassword = "qwertz",
                    Firstname = "Max",
                    Surname = "Mustermann"
                };

                application.UserRegistration.Add(user);
                application.SaveChanges();

            }
        } */

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    


        [HttpPost]
        //[ValidateAntiForgeryToken]
         public IActionResult Create(User uc)
         {
            // User user = new User();
            
            _auc.Add(uc);
            _auc.SaveChanges();
             ViewBag.message = "The user "+ uc.Firstname + " " + uc.Surname + " was created successfully!";

             //AddStudent();
             return View();
         }
        

       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public string PostDataToDB(/*User uc)
        {
           // User user = new User(uc.EMail, uc.Password, uc.ConfPassword, uc.Firstname, uc.Surname);
           // ViewBag.message = "The user " + uc.Firstname + " " + uc.Surname + " was created successfully!";
            //validate and write to database
            return "Hallo";
        }*/
    }
}
