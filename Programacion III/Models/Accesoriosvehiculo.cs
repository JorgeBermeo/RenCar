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
    
    
    public class Accesoriosvehiculo
    {
        
        private Connection conx = new Connection();
        
        public string ACCV_ID { get; set; }
        
        public string ACCV_ACCESORIO { get; set; }
        
        public string ACCV_VEHILUCO { get; set; }
        
        public  System.Data.DataTable QueryAccesoriosvehiculo()
        {
            return conx.Query("PR_QERYACCESORIOSVEHICULO", null);
        }
        
        public  bool InsertAccesoriosvehiculo(Accesoriosvehiculo obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PACCV_ID", obj.ACCV_ID);
            para[1] = new Parameter("PACCV_ACCESORIO", obj.ACCV_ACCESORIO);
            para[2] = new Parameter("PACCV_VEHILUCO", obj.ACCV_VEHILUCO);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTACCESORIOSVEHICULO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateAccesoriosvehiculo(Accesoriosvehiculo obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PACCV_ID", obj.ACCV_ID);
            para[1] = new Parameter("PACCV_ACCESORIO", obj.ACCV_ACCESORIO);
            para[2] = new Parameter("PACCV_VEHILUCO", obj.ACCV_VEHILUCO);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTACCESORIOSVEHICULO", para);
            return conx.Transaction(trans);
        }
    }
}
