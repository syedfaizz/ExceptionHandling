﻿using System;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        private static void GetDetails()
        {
            string name = null;
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name is Empty");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
        }
    }
}
