using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioAsync
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task.Run(async () => 
            {

                Barman oBarman = new Barman();

                Task<bool> Tbool = oBarman.CalientaSnack();

                oBarman.HacerCoctel();


                bool boolResult = await Tbool;

            }).GetAwaiter().GetResult();
            

            
            
        }
    }

    public class Barman
    {
        public async Task<bool> CalientaSnack()
        {
            Console.WriteLine("Mete el snack al horno");

            HttpClient cliente = new HttpClient();
            await cliente.GetAsync("http://hdeleon.net");

            Console.WriteLine("Saca el snack del horno");

            return true;
        }

        public void HacerCoctel()
        {
            Console.WriteLine("Comienza ha hacer el coctel");

            Thread.Sleep(5000);

            Console.WriteLine("Termina de hacer el coctel");
        }

    }
}
