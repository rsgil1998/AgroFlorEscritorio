//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUAgroFlor
{
    using System;
    using System.Collections.Generic;
    
    public partial class registro
    {
        public int id { get; set; }
        public int variedad_id { get; set; }
        public int floricola_id { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string bonche_med { get; set; }
        public Nullable<double> precio_tall_exp { get; set; }
        public Nullable<int> tall_nacional { get; set; }
        public Nullable<int> total_tallos { get; set; }
        public Nullable<double> precio_nac { get; set; }
    
        public virtual floricola floricola { get; set; }
        public virtual variedades variedades { get; set; }
    }
}