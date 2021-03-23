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
<<<<<<< HEAD
            { 
                // comunitats = Orm.bd.comunitats.ToList();
                comunitats = Orm.bd.comunitats.Where(c => c.usuaris.Equals(user)).ToList();
=======
            {
                comunitats = Orm.bd.comunitats.ToList();
>>>>>>> de205f61424069c788f49a9fe4d94e4ef9f7aa7c
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }

            return comunitats;
        }

    }
}
