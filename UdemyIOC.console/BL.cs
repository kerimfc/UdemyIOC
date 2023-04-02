﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.console
{
    public class BL
    {
        private IDAL _dal { get; set; }

        public BL(IDAL dal)
        {
            //_dal = new DAL();
            //_dal = DALFactory.GetDAL();
            _dal = dal;
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
