//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrupoI.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using GrupoI.Models.UTILITIES;
    
    
    public class Propietariovehiculo
    {
        
        private Connection conx = new Connection();
        
        public string PROV_ID { get; set; }
        
        public string PROP_PROPIETARIO { get; set; }
        
        public string PROP_VEHILUCO { get; set; }
        
        public  System.Data.DataTable QueryPropietariovehiculo()
        {
            return conx.Query("PR_QERYPROPIETARIOVEHICULO", null);
        }
        
        public  bool InsertPropietariovehiculo(Propietariovehiculo obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PPROV_ID", obj.PROV_ID);
            para[1] = new Parameter("PPROP_PROPIETARIO", obj.PROP_PROPIETARIO);
            para[2] = new Parameter("PPROP_VEHILUCO", obj.PROP_VEHILUCO);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTPROPIETARIOVEHICULO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdatePropietariovehiculo(Propietariovehiculo obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PPROV_ID", obj.PROV_ID);
            para[1] = new Parameter("PPROP_PROPIETARIO", obj.PROP_PROPIETARIO);
            para[2] = new Parameter("PPROP_VEHILUCO", obj.PROP_VEHILUCO);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTPROPIETARIOVEHICULO", para);
            return conx.Transaction(trans);
        }
    }
}
