using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRY_CATCH
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sayı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex) when(ex.Source=="mscorlib")
            {
                Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}
