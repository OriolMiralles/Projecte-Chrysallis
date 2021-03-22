using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chrysallis_Eventos.MODELOS;

namespace Chrysallis_Eventos.MODELOS
{
    public static class AdminOrm
    {
        public static String Insert(usuaris usuari)
        {
            String missatge = "";
            Orm.bd.usuaris.Add(usuari);
            missatge = Orm.mySaveChanges();
            return missatge;
        }
    }

}
