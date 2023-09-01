using System;

namespace MetodUygulama{
    class Program{
        static void Main(string[] args){
            var soru1 = new Soru(){
                SoruMetni = "Hangisi programlama dili değildir?",
                Secenekler = new string[4] { "Python", "C#", "Java", "HTML"},
                Cevap = "Html"
            };

            var soru2 = new Soru(){
                SoruMetni = "Hangisi  en programlama dilidir?",
                Secenekler = new string[4] { "Python", "C#", "Java", "HTML"},
                Cevap = "C#"
            };


            var soru3 = new Soru(){
                SoruMetni = "Hangisi en popüler web programlama platformudur?",
                Secenekler = new string[4] { "Dijango", "ASP.NET", "Spring", "Python"},
                Cevap = "Python"
            };


            var soru4 = new Soru(10);
            Console.WriteLine(soru4.SoruId);

            var soru5 = new Soru(5,"Soru Metin",new string[1]{"Python"},"Python");


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

        public string SoruMetni {get;set;}
        public string[] Secenekler{get;set;}
        public string Cevap{get;set;}

        public bool cevapkontrol(string cevap){
            return this.Cevap.ToLower() == cevap.ToLower();
        }

    }
}