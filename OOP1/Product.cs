using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {

        public int Id { get; set; }             //Ürün id
        public int CategoryId { get; set; }     //Ürün kategori id
        public string ProductName { get; set; } //Ürün adı
        public double UnitPrice { get; set; }   //Ürün fiyatı
        public int UnitInStock { get; set; }    //Ürünün stok adedi

    }
}
