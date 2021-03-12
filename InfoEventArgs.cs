using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class InfoEventArgs: EventArgs
    {
        public string resultat { get; private set; }
        public InfoEventArgs(string res)
        {
            resultat = res;
        }
    }
}
