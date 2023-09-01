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

            var sorular = new Soru[] {soru1,soru2,soru3};
            foreach(var soru in sorular){
                Console.WriteLine(soru.SoruMetni);
                foreach(var secenek in soru.Secenekler){
                    Console.WriteLine(secenek);
                }

                Console.Write("cevabınız : ");
                var cevap = Console.ReadLine();
                if(soru.cevapkontrol(cevap)){
                    Console.WriteLine("doğru");
                }
                else{
                    Console.WriteLine("yanlış");
                }
            }

        }
    }

    class Soru{
        public string SoruMetni {get;set;}
        public string[] Secenekler{get;set;}
        public string Cevap{get;set;}

        public bool cevapkontrol(string cevap){
            return this.Cevap.ToLower() == cevap.ToLower();
        }

    }
}