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
    
    
    public class Genero
    {
        
        private Connection conx = new Connection();
        
        public string GENE_ID { get; set; }
        
        public string GENE_NOMBRE { get; set; }
        
        public  System.Data.DataTable QueryGenero()
        {
            return conx.Query("PR_QERYGENERO", null);
        }
        
        public  bool InsertGenero(Genero obj)
        {
            Parameter []para = new Parameter[2];
            para[0] = new Parameter("PGENE_ID", obj.GENE_ID);
            para[1] = new Parameter("PGENE_NOMBRE", obj.GENE_NOMBRE);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTGENERO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateGenero(Genero obj)
        {
            Parameter []para = new Parameter[2];
            para[0] = new Parameter("PGENE_ID", obj.GENE_ID);
            para[1] = new Parameter("PGENE_NOMBRE", obj.GENE_NOMBRE);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTGENERO", para);
            return conx.Transaction(trans);
        }
    }
}
