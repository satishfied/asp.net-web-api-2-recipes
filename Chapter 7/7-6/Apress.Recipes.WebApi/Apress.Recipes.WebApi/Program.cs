﻿using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace Apress.Recipes.WebApi
{
    class Program
    {
        static void Main()
        {
            var address = "http://localhost:9000/";

            using (WebApp.Start<Startup>(address))
            {
                var client = new HttpClient();
                var response = client.GetAsync(address + "demo").Result;
                Console.WriteLine(response.StatusCode);
            }

            Console.ReadLine();
        } 
    }
}
