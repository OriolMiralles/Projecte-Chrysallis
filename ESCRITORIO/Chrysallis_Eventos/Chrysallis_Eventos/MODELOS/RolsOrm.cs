using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class RolsOrm
    {
        public static List<rols> Select(ref String missatge)
        {
            List<rols> rols = new List<rols>();
            try
            {
                rols = Orm.bd.rols.ToList();

            }catch(SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }
            

            return rols;
        }
    }
}
