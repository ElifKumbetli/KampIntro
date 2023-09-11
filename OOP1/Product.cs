using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snipped
    internal class Product // Entity
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        //UnitPrice --> Ürünün birim fiyatı 
        public double UnitPrice { get; set; }

        //UnitsInStock --> Ürünün stok adeti
        public double UnitsInStock { get; set; }
        public string ProductName { get; internal set; }

        //CRUD --> Create, Read, Update, Delete
    }
}
