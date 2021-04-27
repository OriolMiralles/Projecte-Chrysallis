using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class EventosOrm
    {
        public static List<esdeveniments> Select(ref String missatge, comunitats comunitat)
        {
            List<esdeveniments> _esdeveniments = null;
            try
            {
                _esdeveniments = Orm.bd.esdeveniments.Where(e => e.id_comunitat == comunitat.id).OrderBy(e => e.data).ThenBy(e => e).ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return _esdeveniments;
        }

        public static String Insert(ref String missatge, esdeveniments nouEsdeveniment)
        {
            Orm.bd.esdeveniments.Add(nouEsdeveniment);

            missatge = Orm.mySaveChanges();

            return missatge;
        }

        public static String Update(ref String missatge, esdeveniments esdeveniment)
        {
            try
            {
                Orm.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                missatge = Orm.missatgeError(sqlException);
            }

            return missatge;
        }

        public static String Delete(ref String missatge, esdeveniments esdeveniment)
        {
            Orm.bd.esdeveniments.Remove(esdeveniment);

            missatge = Orm.mySaveChanges();

            return missatge;
        }

    }
}
