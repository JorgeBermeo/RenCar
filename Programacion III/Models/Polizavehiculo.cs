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
    
    
    public class Polizavehiculo
    {
        
        private Connection conx = new Connection();
        
        public string POLV_ID { get; set; }
        
        public string POLIZA_POLI_ID { get; set; }
        
        public string VEHILUCO_PLACA { get; set; }
        
        public  System.Data.DataTable QueryPolizavehiculo()
        {
            return conx.Query("PR_QERYPOLIZAVEHICULO", null);
        }
        
        public  bool InsertPolizavehiculo(Polizavehiculo obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PPOLV_ID", obj.POLV_ID);
            para[1] = new Parameter("PPOLIZA_POLI_ID", obj.POLIZA_POLI_ID);
            para[2] = new Parameter("PVEHILUCO_PLACA", obj.VEHILUCO_PLACA);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTPOLIZAVEHICULO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdatePolizavehiculo(Polizavehiculo obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PPOLV_ID", obj.POLV_ID);
            para[1] = new Parameter("PPOLIZA_POLI_ID", obj.POLIZA_POLI_ID);
            para[2] = new Parameter("PVEHILUCO_PLACA", obj.VEHILUCO_PLACA);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTPOLIZAVEHICULO", para);
            return conx.Transaction(trans);
        }
    }
}
