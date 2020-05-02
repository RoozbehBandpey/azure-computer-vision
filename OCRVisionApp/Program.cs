﻿using System;
using System.Collections.Generic;
using System.Text;
using OCRVisionApp;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

namespace OCRVisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string subscriptionName = Environment.GetEnvironmentVariable("COGNITIVE_SERVICE_NAME");
            string endpoint = Environment.GetEnvironmentVariable("COGNITIVE_SERVICE_ENDPOINT");
            string key = Environment.GetEnvironmentVariable("COGNITIVE_SERVICE_KEY");
            Console.WriteLine(subscriptionName);
            Console.WriteLine(endpoint);
            Console.WriteLine(key);
            ComputerVisionClient client = OCRVisionApp.OCRVision.Authenticate(endpoint, key);

            Console.WriteLine(client);
        }
    }
}
