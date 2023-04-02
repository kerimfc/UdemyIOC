using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.console
{
    public class BL
    {
        private IDAL _dal { get; set; }

        public BL()
        {
            _dal = DALFactory.GetDAL();
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
