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
    
    public partial class assistir
    {
        public int id_soci { get; set; }
        public int id_esdeveniment { get; set; }
        public int quantitat_persones { get; set; }
        public string textValoracio { get; set; }
        public Nullable<decimal> cantidadTotal { get; set; }
        public Nullable<bool> haPagado { get; set; }
        public int valoracio { get; set; }
    
        public virtual socis socis { get; set; }
        public virtual esdeveniments esdeveniments { get; set; }
    }
}
