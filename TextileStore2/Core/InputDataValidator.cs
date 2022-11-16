using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextileStore2.Core
{
    public class InputDataValidator
    {
        public static bool ValidateValueAddNewProduct(string articul, string name, string description,
            string category, string manufacter, double cost, double discount, double maxDiscount,
            int quantityInStock, string status, string unit, string provider)
        {
            if (articul == "" || name == "" || description == "" || category == ""
                || manufacter == "" || cost < 0 || discount < 0 || maxDiscount > 100 || maxDiscount < 0
                || quantityInStock <0 || status == "" || unit == "" || provider == "")
            {
                return false;
            }
            else return true;
        }
    }
}
