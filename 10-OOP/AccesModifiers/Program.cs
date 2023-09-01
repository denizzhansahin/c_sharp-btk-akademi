using System;

namespace MetodUygulama{
    class Program{
        static void Main(string[] args){
        

            var soru5 = new Soru(5,"Soru Metin",new string[1]{"Python"},"Python");
            //var aaaa = soru5.cevapkontrol;//sadece bu çıktı
            Console.WriteLine(soru5.cevapkontrol("html"));

            Console.WriteLine(soru5.SoruYazdir());
            Console.WriteLine(soru5.cevapkontrol("html"));


        }

           

    }

    class Soru{
        public int SoruId { get; set; }
        //bunun yerine aşağıdakine bak
        public Soru(){
            Console.WriteLine("Soru nesnesi oluşturuldu.");
            this.SoruId = (new Random()).Next(11111,99999);
        }

        public Soru(int soruId)
        {
            this.SoruId=soruId;
        }


        public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = SoruId;
            this.SoruMetni=soruMetni;
            this.Secenekler=secenekler;
            this.Cevap=cevap;
        }

        private string SoruMetni {get;set;}
        private string[] Secenekler{get;set;}
        private string Cevap{get;set;}

        public bool cevapkontrol(string cevap){
            return this.Cevap.ToLower() == cevap.ToLower();
        }


        public string SoruYazdir(){
            string soru = "";
            soru += this.SoruMetni + "\n";
            foreach(var secenek in this.Secenekler){
                soru+=secenek+"\n";
            }
            return soru;
        }

    }
}