using System.Collections.Generic;
namespace ConsoleApp{
    class Program{
        static void Main(string[] args){
            //exception
            //system.formatException - yanlış tip veri
            //system.dividebyzeroexception - 0 bölme hatası
            //system.nullreferenceException - alan ayrımama hatası
            
            try{

                Console.Write("1.Sayi : ");
                int sayi1= Convert.ToInt32(Console.ReadLine());

                Console.Write("2.Sayi : ");
                int sayi2= Convert.ToInt32(Console.ReadLine());

                var sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }

            
            }catch(FormatException){
                Console.WriteLine("sayısıal bilgileri doğru gir");

            }catch(DivideByZeroException){
                Console.WriteLine("sayi2 sıfır olmamalıdır.");
            }
            
            catch(Exception ex){
                Console.WriteLine("bir hata oluştu");
                Console.WriteLine(ex.Message);
            }
            
            
            
            //exception handling
        }
    }

}