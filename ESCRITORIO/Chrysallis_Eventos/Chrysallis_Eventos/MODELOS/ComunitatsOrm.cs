using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class ComunitatsOrm
    {
        public static List<comunitats> Select(ref String missatge)
        {
            List<comunitats> comunitats = new List<comunitats>();
            try

            {
                comunitats = Orm.bd.comunitats.OrderBy(c => c.nom).ToList();

            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }

            return comunitats;
        }
        public static List<comunitats> Select(ref String missatge, usuaris user)
        {
            List<comunitats> comunitats = new List<comunitats>();
            try

            {
                comunitats = Orm.bd.comunitats.ToList();

            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }

            return comunitats;
        }

    }
}
