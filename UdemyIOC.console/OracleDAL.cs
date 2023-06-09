﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.console
{
    public class OracleDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1, Name= "O Kalem 1", Price=200, Stock=100
                },
                new Product()
                {
                    Id = 2, Name= "O Kalem 2", Price=200, Stock=100
                },
                new Product()
                {
                    Id = 3, Name= "O Kalem 3", Price=200, Stock=100
                },
                new Product()
                {
                    Id = 4, Name= "O Kalem 4", Price=200, Stock=100
                }
            };
        }
    }
}
