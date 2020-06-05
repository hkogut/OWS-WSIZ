using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace OWS_WSIZ.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        /// <summary>
        /// Metody odpowiedzialne za ładowanie odpowiednich UserControl
        /// </summary>
        public void LoadPageOne()
        {
            ActivateItem(new SlupPrzelotowyViewModel());
        }
    }
}