using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcCustomersService;
using LibraryModel.Models;

namespace IstrateBogdan_Laborator2.Controllers
{
    public class CustomersGrpcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
