﻿using MedicoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicoWeb1.Controllers
{
    public class PatientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Patients (Patients Cm)
        {
            return View();
        }
    }
}