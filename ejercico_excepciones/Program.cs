using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {

            int GetAltura()
            {
             int h = Convert.ToInt32(Console.ReadLine());
                if (h < 150)
                {
                    throw new bajaAltura("Para ingresar a la montaña rusa no se acepta esta altura");
                }
                return h;
            }
            int a;
            try { 
            Console.Write("Selecciona tu altura en cm ");
            a = GetAltura();
            Console.WriteLine("Puedes ingresar a la montaña rusa");
            Console.ReadLine();
            }
            catch(bajaAltura e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

    }
    public class bajaAltura : Exception
    {
        private readonly int altura;

        public bajaAltura(string message) : base(message)
        {

        }
    }
}
