using CorePortfolio.Models;
using CorePortfolio.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace CorePortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (WebClient webClient = new WebClient())
            {
                //Dev WP API
                //string blogUrl = @"http://devpi/wp-json/wp/v2/posts?categories=3&_embed";
                //Live WP API
                string blogUrl = @"https://chandler-ryan.com/blog/wp-json/wp/v2/posts?categories=8&_embed";
                string response = webClient.DownloadString(blogUrl);

                var blogPosts = JsonConvert.DeserializeObject<List<WPViewModel>>(response);




                return View(blogPosts);
            }
        }

        public ActionResult About(string id)
        {
            if (id == null)
            {
                return Redirect("/Home/About/aMe");
            }
            ViewBag.id = id;

            return View();
        }

        public ActionResult Projects()
        {
            List<Project> projects = new List<Project>();
            projects.Add(new Project()
            {
                Name = "Northwind",
                Description = "This is an online retailer project.",
                StartDate = DateTime.Parse("01/23/2018"),
                Status = "Current - Secondary",
                IsSchoolProj = true
            });

            projects.Add(new Project()
            {
                Name = "Portfolio",
                Description = "It is this project. My online portfolio.",
                StartDate = DateTime.Parse("03/25,2018"),
                Status = "Current - Primary",
                IsSchoolProj = false
            });

            projects.Add(new Project()
            {
                Name = "StepApp",
                Description = "This is a web app that will contain user accounts, allow for entering daily step totals" +
                " and allow for competitions. Will use to practice as many web development skills as possible.",
                StartDate = DateTime.Parse("11/24/2017"),
                Status = "On-Hold",
                IsSchoolProj = false
            });

            return View(projects);
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactFormModel contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var sysLogin = "portfolio@chandler-ryan.com";
                    var sysPass = "kDct97%0";
                    var mailFrom = new MailAddress(contact.Email, contact.Name);
                    var mailTo = new MailAddress(sysLogin, "Portfolio Contact");

                    var smtp = new SmtpClient
                    {
                        Host = "mail.chandler-ryan.com",
                        Port = 587,
                        EnableSsl = false,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(sysLogin, sysPass)
                    };
                    /*Helper.RenderViewToString(ControllerContext, "~/Views/Email/ContactEmailHtml.cshtml", contact, true),
                                            IsBodyHtml = true*/
                    //contact.BuildEmailBody()
                    using (var message = new MailMessage(mailFrom, mailTo)
                    {
                        Subject = contact.Subject,
                        Body = MyHelpers.RenderViewToString(ControllerContext, "~/Views/Email/ContactEmailHtml.cshtml", contact, true),
                        IsBodyHtml = true
                    })
                    {
                        smtp.Send(message);
                    }
                }
            }
            catch
            {
                return View("Contact");
            }
            return RedirectToAction("Index");
        }
    }
}
