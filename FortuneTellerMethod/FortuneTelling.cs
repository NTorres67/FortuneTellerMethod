using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    public class FortuneTelling
    {
        private string nameFirst;
        private string nameLast;
        private int retire;
        private string vac;
        private string col;
        private string pay;
       
        
        

        // Properties
        public string NameFirst
        {
            get { return this.nameFirst; }
            set { this.nameFirst = value; }
        }

        public string NameLast
        {
            get { return this.nameLast; }
            set { this.nameLast = value; }
        }

        public int Retire
        {
            get { return this.retire; }
            set { this.retire = value; }
        }

        public string Vac
        {
            get { return this.vac; }
            set { this.vac = value; }
        }

        public string Col
        {
            get { return this.col; }
            set { this.col = value; }
        }

        public string Pay
        {
            get { return this.pay; }
            set { this.pay = value; }
        }



        // Constructors
        public FortuneTelling(string nameFirst, string nameLast, int retire, string vac, string col, string pay)
        {
            this.nameFirst = nameFirst;
            this.nameLast = nameLast;
            this.retire = retire;
            this.vac = vac;
            this.col = col;
            this.pay = pay;
            
        }



        // Methods

        // Greet user
        public string Greeting()
        {
            return ("Greetings " + nameFirst + " " + nameLast + ". " + "I will tell you your fortune!");
        }


        // Calculate years to retirement
        public int ToRetirement()
        {
            return (retire);
        }

        
        // Determine vacation home utilizing number of siblings
        public string VacationHome()
        {
            return (vac);
        }
        


        // Mode of transportation utilizing ROYGBIV
        public string FavoriteColor()
        {
            return (col);
        }



        // Determine how much money will retire with as determined by month of birth
        public string RetirementPay()
        {
            return (pay);
        }


        // Judge how good the fortune is
        public void  Judgement()
        {
            Console.WriteLine("Better luck in your next life! ( *_* )");
        }


    }
}
