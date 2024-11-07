﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Inheritance_SalesDetails
    {
        public int Saleno { get; private set; }
        public int Productno { get; private set; }
        public decimal Price { get; private set; }
        public DateTime DateOfSale { get; private set; }
        public int Qty { get; private set; }
        public decimal TotalAmount { get; private set; }

        public Inheritance_SalesDetails(int saleno, int productno, decimal price, int qty, DateTime dateOfSale)
        {
            Saleno = saleno;
            Productno = productno;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
            Sales();
        }

        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public static void ShowData(Inheritance_SalesDetails sale)
        {
            Console.WriteLine("Sale No: " + sale.Saleno);
            Console.WriteLine("Product No: " + sale.Productno);
            Console.WriteLine("Price: " + sale.Price);
            Console.WriteLine("Quantity: " + sale.Qty);
            Console.WriteLine("Date of Sale: " + sale.DateOfSale.ToShortDateString());
            Console.WriteLine("Total Amount: " + sale.TotalAmount);
        }
    }

    public class Program1
    {
        public static void Main()
        {
            Inheritance_SalesDetails sale = new Inheritance_SalesDetails(12, 78, 150.8m, 5, DateTime.Now);
            Inheritance_SalesDetails.ShowData(sale);
            Console.ReadLine();
        }
    }
}
