using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class DocumentsOrm
    {
        public static String Insert(ref String missatge, documents docu)
        {
            Orm.bd.documents.Add(docu);

            missatge = Orm.mySaveChanges();

            return missatge;
        }
    }
}
