using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            

            FortuneTelling userFortuneTelling = new FortuneTelling();



            //// Greet User

            userFortuneTelling.Greeting();

            userFortuneTelling.ToRetirement();

            userFortuneTelling.VacationHome();

            userFortuneTelling.FavoriteColor();

            userFortuneTelling.RetirementPay();

            userFortuneTelling.FirstName();


            //// Give Fortune

            Console.WriteLine();
            

           

            //// Judge Fortune
            userFortuneTelling.Judgement();
            

          


        }

        
    }
}

