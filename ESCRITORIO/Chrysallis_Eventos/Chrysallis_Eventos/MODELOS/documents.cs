//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chrysallis_Eventos.MODELOS
{
    using System;
    using System.Collections.Generic;
    
    public partial class documents
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string ruta { get; set; }
        public int id_esdeveniment { get; set; }
    
        public virtual esdeveniments esdeveniments { get; set; }
    }
}
