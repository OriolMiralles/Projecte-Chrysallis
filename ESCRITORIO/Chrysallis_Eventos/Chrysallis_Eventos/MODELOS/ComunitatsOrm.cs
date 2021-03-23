using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    class ComunitatsOrm
    {
        public static List<comunitats> Select(ref String missatge, usuaris user)
        {
            List<comunitats> comunitats = new List<comunitats>();
            try
            { 
                // comunitats = Orm.bd.comunitats.ToList();
                comunitats = Orm.bd.comunitats.Where(c => c.usuaris.Equals(user)).ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return comunitats;
        }
    }
}
