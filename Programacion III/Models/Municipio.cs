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
    
    
    public class Municipio
    {
        
        private Connection conx = new Connection();
        
        public string MUNI_ID { get; set; }
        
        public string MUNI_NOMBRE { get; set; }
        
        public string DEPARTAMENTO_DEPA_ID { get; set; }
        
        public  System.Data.DataTable QueryMunicipio()
        {
            return conx.Query("PR_QERYMUNICIPIO", null);
        }
        
        public  bool InsertMunicipio(Municipio obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PMUNI_ID", obj.MUNI_ID);
            para[1] = new Parameter("PMUNI_NOMBRE", obj.MUNI_NOMBRE);
            para[2] = new Parameter("PDEPARTAMENTO_DEPA_ID", obj.DEPARTAMENTO_DEPA_ID);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTMUNICIPIO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateMunicipio(Municipio obj)
        {
            Parameter []para = new Parameter[3];
            para[0] = new Parameter("PMUNI_ID", obj.MUNI_ID);
            para[1] = new Parameter("PMUNI_NOMBRE", obj.MUNI_NOMBRE);
            para[2] = new Parameter("PDEPARTAMENTO_DEPA_ID", obj.DEPARTAMENTO_DEPA_ID);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTMUNICIPIO", para);
            return conx.Transaction(trans);
        }
    }
}
