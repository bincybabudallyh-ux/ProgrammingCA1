//Food truck application that serves delicious Churros.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Quic;

public class Order
{
      public int order_no;
      public string order_details;
      public int quantity;
      public double bill;

    public Order (int order, string details, int qty, double price)
    {
        order_no = order;
        order_details= details;
        quantity= qty;
        bill = price;
        
    }
    public double pay_bill()
    {
        double total = quantity * bill;
        return total;
    }
}
    class Churros
    {
        public string churrosName;
        public double churrosPrice;

        public Churros(string name , double price)
        {
            churrosName =name;
            churrosPrice= price;
        }
    }

    class Program
    {
        static Queue<Order> q = new Queue<Order>();
        static int count =1;

        static void Main(string[] args)
        {
            int choice;
            do
            {
    
                Console.WriteLine("\nDelicious Churros");
                Console.WriteLine(". Churros with plain sugar: €6.00");
                Console.WriteLine(". Churros with cinnamon sugar: €6.00");
                Console.WriteLine(". Churros with cholocate sugar: €8.00");
                Console.WriteLine(". Churros with Nutella: €6.00");
                Console.WriteLine("Choose your option");                
                Console.WriteLine("1. Place Order");
                Console.WriteLine("2. Deliver Order");
                Console.WriteLine("0. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if(choice == 1)
                {
                    Place_order();
                }
                else if(choice == 2)
                {
                    collect_order();
                }
            } while (choice != 0);
            
        }

        static void Place_order()
        {
            Console.WriteLine("\nSelect item:");
            Console.WriteLine("1. Plain Sugar");
            Console.WriteLine("2. Cinnamon Sugar");
            Console.WriteLine("3. Chocolate sauce");
            Console.WriteLine("4. Nutella");
    
            int option = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            string item = "";
            double price = 0;

            if (option == 1 ) {item = "Plain"; price=6;}
            else if (option == 2 ) {item = "Cinnamon"; price=6;}
            else if (option == 3 ) {item = "Chocolate"; price=8;}
            else if (option == 4 ) {item = "Nutella"; price=8;}

            Order or = new Order (count , item, quantity, price);
            q.Enqueue(or);
            Console.WriteLine("Bill amount =" + or.pay_bill());
            count++ ;
        }

    static void collect_order()
    {
        if(q.Count > 0)
        {
            Order o =  q.Dequeue();
            Console.WriteLine("Order delivered: " + o.order_no);
        }
        else
        {
            Console.WriteLine("Queue empty");
        }
    }
          
} 