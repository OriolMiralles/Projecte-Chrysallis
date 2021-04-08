using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class Orm
    {
        public static ChrysallisEntities bd = new ChrysallisEntities();

        public static String missatgeError(SqlException sqlException)
        {
            String missatge = "";

            switch (sqlException.Number)
            {
                case 2:
                    missatge = "El servidor no está operatiu";
                    break;
                case 547:
                    missatge = "El registre té dades relacionades";
                    break;
                case 2601:
                    missatge = "Registre duplicat";
                    break;
                case 2627:
                    missatge = "Registre duplicat";
                    break;
                case 4060:
                    missatge = "No es pot obrir la base de dades";
                    break;
                default:
                    missatge = sqlException.Number + ": " + sqlException.Message;
                    break;
            }

            return missatge;
        }
        public static String mySaveChanges()
        {
            String missatge = "";
            try
            {
                Orm.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                missatge = Orm.missatgeError(sqlException);
                rejectChanges();
            }
            return missatge;
        }

        public static void rejectChanges()
        {
            foreach (DbEntityEntry item in bd.ChangeTracker.Entries())
            {
                switch (item.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added:
                        item.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        item.Reload();
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        item.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    
}
