using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class AsistirOrm
    {
        public static dynamic Select(esdeveniments esdeveniment)
        {           
                var data = esdeveniment.assistir.Join(
                                                    Orm.bd.socis,
                                                    assistir => assistir.id_soci,
                                                    socis => socis.id,
                                                    (assistir, socis) => new
                                                    {
                                                        numSoci = socis.num,
                                                        nomSoci = socis.nom,
                                                        text = assistir.textValoracio,
                                                        puntuacio = assistir.valoracio,
                                                        id = socis.id,
                                                        cognoms = socis.cognoms,
                                                        asistents = assistir.quantitat_persones
                                                    }).ToList();

            return data;
        }
        
    }
}
