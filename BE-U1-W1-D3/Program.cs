using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listanomi = { "francesco", "marco", "mario", "chiara", "lorenzo" };
            string nome;
            int i;
            bool verifica = false;

            Console.WriteLine("Inserire il nome da ricercare");
            nome = Console.ReadLine();

            for (i = 0; i < listanomi.Length; i++)
            {
                if (listanomi[i] == nome)
                {
                    Console.WriteLine("Il nome è presente nella lista");
                    verifica = true;
                }

            }
            if (verifica == false)
            {
                Console.WriteLine("Il nome non è presente nella lista");
            }

            Console.ReadLine();
        }
      
    }
}
