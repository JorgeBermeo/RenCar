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
    
    
    public class Colorvehiculo
    {
        
        private Connection conx = new Connection();
        
        public string COLV_ID { get; set; }
        
        public string COLV_COLOR { get; set; }
        
        public  System.Data.DataTable QueryColorvehiculo()
        {
            return conx.Query("PR_QERYCOLORVEHICULO", null);
        }
        
        public  bool InsertColorvehiculo(Colorvehiculo obj)
        {
            Parameter []para = new Parameter[2];
            para[0] = new Parameter("PCOLV_ID", obj.COLV_ID);
            para[1] = new Parameter("PCOLV_COLOR", obj.COLV_COLOR);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTCOLORVEHICULO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateColorvehiculo(Colorvehiculo obj)
        {
            Parameter []para = new Parameter[2];
            para[0] = new Parameter("PCOLV_ID", obj.COLV_ID);
            para[1] = new Parameter("PCOLV_COLOR", obj.COLV_COLOR);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTCOLORVEHICULO", para);
            return conx.Transaction(trans);
        }
    }
}
