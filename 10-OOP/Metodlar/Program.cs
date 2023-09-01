namespace ConsoleApp {
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Merhaba BTK");
            Console.WriteLine("Merhaba BTK 2");

            //Directory.CreateDirectory("temp");

            Ogrenci ogr1 = new Ogrenci(){OgrenciNo = "100", AdSoyad = "Denizhan ŞAHİN", Sube = "Universite"};
            Ogrenci ogr2 = new Ogrenci() {OgrenciNo = "101", AdSoyad = "Deniz", Sube ="Lise"};
            Ogrenci ogr3 = new Ogrenci(){OgrenciNo = "100",AdSoyad = "Denizhan",Sube = "İlkokul"};
            
            Ogrenci[] ogrenciler = new Ogrenci[3]{ogr1,ogr2,ogr3};

            foreach(var ogr in ogrenciler){
                ogr.BilgileriYazdir();
                string sonuc = ogr.BilgileriYazdir2();
                Console.WriteLine(sonuc);
                Console.WriteLine(ogr.BilgileriYazdir2());

            }

        }
    }

    class Ogrenci{
        public string OgrenciNo {get;set;}
        public string AdSoyad {get;set;}
        public string Sube {get;set;}

        public void BilgileriYazdir(){
            Console.WriteLine($"{this.AdSoyad} ve {this.Sube} ve {this.OgrenciNo}");
        }

        public string BilgileriYazdir2(){
            return $"{this.OgrenciNo} , {this.AdSoyad} , {this.Sube}";
        }

    }
}