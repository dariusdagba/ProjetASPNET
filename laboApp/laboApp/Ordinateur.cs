using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboApp
{
    public class Ordinateur
    {
        public Ordinateur(string marque, string modele, int prix):base(marque,modele,prix){}
        public override void allumer()
        {
			Console.WriteLine("L'ordinateur est allumé");
        }

       public override void eteindre()
        {
			Console.WriteLine("L'ordinateur est éteint");
        }
    }
}
