using System;
using System.Collections;

namespace GenericList{
    class Program{
        static void Main(string[] args){
            //generic list
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);

            List<string> isimler = new List<string>() {"ali","ahmet","ayşe"};
            List<Product> urunler = new List<Product>();
            urunler.Add(new Product(){Id=1,Title="Iphone 14",Price=40000});
            urunler.Add(new Product(){Id=2,Title="Iphone 15",Price=50000});
            urunler.Add(new Product(){Id=3,Title="Iphone 16",Price=60000});
            
            urunler.Insert(urunler.Count, new Product() {Id=4,Title="Deneme",Price=70000});
            foreach(var urun in urunler){
                Console.WriteLine(urun.Title + " " + urun.Price);
            }

            urunler.RemoveAt(2);
            urunler.Remove(urunler[0]);

        }
    }

    class Product{
        public int Id { get; set;}
        public string Title { get; set;}
        public int Price { get; set;}
    }
}