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
    
    public partial class MADRE
    {
        public MADRE()
        {
            this.ACTA_INSCRIPCION = new HashSet<ACTA_INSCRIPCION>();
        }
    
        public int CI_MADRE { get; set; }
        public string NOMBREMADRE { get; set; }
        public string NACIONALMADRE { get; set; }
        public System.DateTime FECHANACIMIMADRE { get; set; }
        public int EDADMADRE { get; set; }
        public short HIJOSVIVEN { get; set; }
        public short HIJOSMUERTOSVIVEN { get; set; }
        public short HIJOSMUERTOS { get; set; }
        public int NUMCONTROLES { get; set; }
        public string AUTOMADRE { get; set; }
        public string ESTADOCIVIL { get; set; }
        public string LECTURA { get; set; }
        public string NIVELINSTRUCCIONMADRE { get; set; }
        public string PROVINCIAMADRE { get; set; }
        public string CANTONMADRE { get; set; }
        public string PARROQUIAMADRE { get; set; }
        public string CIUDADMADRE { get; set; }
        public string DIREMADRE { get; set; }
    
        public virtual ICollection<ACTA_INSCRIPCION> ACTA_INSCRIPCION { get; set; }
    }
}
