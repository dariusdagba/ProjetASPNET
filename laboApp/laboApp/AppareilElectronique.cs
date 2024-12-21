using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboApp
{
    public abstract class AppareilElectronique
    {
        private string marque;
        private string modele;
        private int prix;

        public AppareilElectronique(string marque, string modele, int prix)
        {
            this.marque = marque;
            this.modele=modele;
            this.prix = prix;   
        }

        public string getMarque()
        {
            return this.marque;
        }
        public string getModele() 
        { 
            return this.modele;
        }

        public int getInt()
        {
            return this.prix;
        }

        public void setMarque(string marque)
        {
            this.marque = marque;
        }

        public void setModele(string modele)
        {
            this.modele = modele;
        }

        public void setInt(int prix) 
        { 
            this.prix = prix;
        }

        public abstract void allumer();
        public abstract void eteindre();
       
    }
}
