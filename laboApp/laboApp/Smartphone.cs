using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboApp
{
    public class Smartphone : AppareilElectronique
    {
        public Smartphone(string marque,string modele, int prix):base(marque,modele,prix) { }

        public override void allumer()
        {
            Console.WriteLine("Le Smartphone est allumé");
        }

       public override void eteindre()
        {
			Console.WriteLine("Le Smartphone est éteint");
        }
    }
}
