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
    
    
    public class Proveedormantenimiento
    {
        
        private Connection conx = new Connection();
        
        public string PROM_ID { get; set; }
        
        public string PROM_NOMBRE { get; set; }
        
        public string PROM_DIRECCION { get; set; }
        
        public string PROM_TELEFONO { get; set; }
        
        public  System.Data.DataTable QueryProveedormantenimiento()
        {
            return conx.Query("PR_QERYPROVEEDORMANTENIMIENTO", null);
        }
        
        public  bool InsertProveedormantenimiento(Proveedormantenimiento obj)
        {
            Parameter []para = new Parameter[4];
            para[0] = new Parameter("PPROM_ID", obj.PROM_ID);
            para[1] = new Parameter("PPROM_NOMBRE", obj.PROM_NOMBRE);
            para[2] = new Parameter("PPROM_DIRECCION", obj.PROM_DIRECCION);
            para[3] = new Parameter("PPROM_TELEFONO", obj.PROM_TELEFONO);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTPROVEEDORMANTENIMIENTO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateProveedormantenimiento(Proveedormantenimiento obj)
        {
            Parameter []para = new Parameter[4];
            para[0] = new Parameter("PPROM_ID", obj.PROM_ID);
            para[1] = new Parameter("PPROM_NOMBRE", obj.PROM_NOMBRE);
            para[2] = new Parameter("PPROM_DIRECCION", obj.PROM_DIRECCION);
            para[3] = new Parameter("PPROM_TELEFONO", obj.PROM_TELEFONO);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTPROVEEDORMANTENIMIENTO", para);
            return conx.Transaction(trans);
        }
    }
}
