using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int id;
        public string name;
        public int stock;
        public decimal price;
        public string typeOfDrink;    // alcoholic or not
        public string stockString;     // also formerly named stockAmount, it's a string that displays if the stock is sufficient or not
        public int soldNumber;

        public Drink (string name, int stock, decimal price, string type, int id, string stockString, int soldNr)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
            this.typeOfDrink = type;
            this.id = id;   
            this.stockString = stockString;
            this.soldNumber = soldNr;
        }




    }
}
