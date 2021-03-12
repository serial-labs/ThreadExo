using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Lequipe
    {

        public delegate void InfoEventHandler(object sender, EventArgs e);

        public event InfoEventHandler InfoL1;
        public event InfoEventHandler InfoLdc;

        public void OnInfoL1(InfoEventArgs resultat)
        {
            if (InfoL1 != null)
            {
                Delegate[] supporters = InfoL1.GetInvocationList();
                foreach(Delegate _supporter in supporters)
                {
                    InfoEventHandler supporter = (InfoEventHandler)_supporter;
                    supporter.BeginInvoke(this, resultat, null, null);
                }


            }
        }

        public void OnInfoLdc(InfoEventArgs resultat)
        {
            if (InfoLdc != null)
            {
                InfoLdc(this, resultat);
            }
        }

    }
}
