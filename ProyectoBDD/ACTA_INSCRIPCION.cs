//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACTA_INSCRIPCION
    {
        public ACTA_INSCRIPCION()
        {
            this.DEF_FETAL1 = new HashSet<DEF_FETAL>();
        }
    
        public string ACTAINSCRIPCION { get; set; }
        public Nullable<int> IDREGISTROCIVIL { get; set; }
        public Nullable<int> ID_FETAL { get; set; }
        public Nullable<int> CI_MADRE { get; set; }
        public Nullable<int> CI_MEDICO { get; set; }
        public System.DateTime FECHAINSCRIPCION { get; set; }
        public Nullable<System.DateTime> FECHACRITICA { get; set; }
    
        public virtual DEF_FETAL DEF_FETAL { get; set; }
        public virtual MADRE MADRE { get; set; }
        public virtual MEDICO MEDICO { get; set; }
        public virtual REGISTROCIVIL REGISTROCIVIL { get; set; }
        public virtual ICollection<DEF_FETAL> DEF_FETAL1 { get; set; }
    }
}
