using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoServiceReference1;
using ProductServiceReference;

namespace ClientApp.Pages
{
    public class Index1Model : PageModel
    {
        public string Result1;
        public string Result2;
        public double Result3;

        public Product product;
        public Product[] products;

        public void OnGet()
        {
            DemoServiceClient demoServiceClient = new DemoServiceClient();
            Result1 = demoServiceClient.DoWorkAsync().Result;
            Result2 = demoServiceClient.HiAsync("ABC").Result;
            Result3 = demoServiceClient.SumAsync(1,2).Result;

            ProductService1Client productService1Client = new ProductService1Client();
            product = productService1Client.findAsync().Result;
            products = productService1Client.findAllAsync().Result;

        }
    }
}