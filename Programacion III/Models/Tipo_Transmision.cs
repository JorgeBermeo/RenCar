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
    
    
    public class Tipo_Transmision
    {
        
        private Connection conx = new Connection();
        
        public string TIPT_ID { get; set; }
        
        public string TIPT_NOMBRE { get; set; }
        
        public  System.Data.DataTable QueryTipo_Transmision()
        {
            return conx.Query("PR_QERYTIPO_TRANSMISION", null);
        }
        
        public  bool InsertTipo_Transmision(Tipo_Transmision obj)
        {
            Parameter []para = new Parameter[2];
            para[0] = new Parameter("PTIPT_ID", obj.TIPT_ID);
            para[1] = new Parameter("PTIPT_NOMBRE", obj.TIPT_NOMBRE);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTTIPO_TRANSMISION", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateTipo_Transmision(Tipo_Transmision obj)
        {
            Parameter []para = new Parameter[2];
            para[0] = new Parameter("PTIPT_ID", obj.TIPT_ID);
            para[1] = new Parameter("PTIPT_NOMBRE", obj.TIPT_NOMBRE);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTTIPO_TRANSMISION", para);
            return conx.Transaction(trans);
        }
    }
}
