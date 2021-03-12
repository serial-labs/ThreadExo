using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Supporter
    {
        private string nom;
        public Supporter(string _nom)
        {
            this.nom = _nom;
        }

        public void ReceptionInfo(object sender,EventArgs e)
        {
            InfoEventArgs info = e as InfoEventArgs;
            if(info != null)
            {
                Console.WriteLine(nom + " reçoit le resultat : " + ((InfoEventArgs)e).resultat);
            }
        }
    }
}
