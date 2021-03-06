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
    
    
    public class Empleado
    {
        
        private Connection conx = new Connection();
        
        public string EMPL_ID { get; set; }
        
        public string EMPL_NOMBRES { get; set; }
        
        public string EMPL_APELLIDOS { get; set; }
        
        public string EMP_FIJO { get; set; }
        
        public string EMPL_CELULAR { get; set; }
        
        public string TIPO_DOCUMENTO_TIPD_ID { get; set; }
        
        public string EMPL_NUMERODOCUMENTO { get; set; }
        
        public string GENERO_GENE_ID { get; set; }
        
        public string MUNICIPIO_MUNI_ID { get; set; }
        
        public string TIPO_EMPLEADO_TIPE_ID { get; set; }
        
        public string TIPOSANGRE_TIPS_ID { get; set; }
        
        public  System.Data.DataTable QueryEmpleado()
        {
            return conx.Query("PR_QERYEMPLEADO", null);
        }
        
        public  bool InsertEmpleado(Empleado obj)
        {
            Parameter []para = new Parameter[11];
            para[0] = new Parameter("PEMPL_ID", obj.EMPL_ID);
            para[1] = new Parameter("PEMPL_NOMBRES", obj.EMPL_NOMBRES);
            para[2] = new Parameter("PEMPL_APELLIDOS", obj.EMPL_APELLIDOS);
            para[3] = new Parameter("PEMP_FIJO", obj.EMP_FIJO);
            para[4] = new Parameter("PEMPL_CELULAR", obj.EMPL_CELULAR);
            para[5] = new Parameter("PTIPO_DOCUMENTO_TIPD_ID", obj.TIPO_DOCUMENTO_TIPD_ID);
            para[6] = new Parameter("PEMPL_NUMERODOCUMENTO", obj.EMPL_NUMERODOCUMENTO);
            para[7] = new Parameter("PGENERO_GENE_ID", obj.GENERO_GENE_ID);
            para[8] = new Parameter("PMUNICIPIO_MUNI_ID", obj.MUNICIPIO_MUNI_ID);
            para[9] = new Parameter("PTIPO_EMPLEADO_TIPE_ID", obj.TIPO_EMPLEADO_TIPE_ID);
            para[10] = new Parameter("PTIPOSANGRE_TIPS_ID", obj.TIPOSANGRE_TIPS_ID);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_NSRTEMPLEADO", para);
            return conx.Transaction(trans);
        }
        
        public  bool UpdateEmpleado(Empleado obj)
        {
            Parameter []para = new Parameter[11];
            para[0] = new Parameter("PEMPL_ID", obj.EMPL_ID);
            para[1] = new Parameter("PEMPL_NOMBRES", obj.EMPL_NOMBRES);
            para[2] = new Parameter("PEMPL_APELLIDOS", obj.EMPL_APELLIDOS);
            para[3] = new Parameter("PEMP_FIJO", obj.EMP_FIJO);
            para[4] = new Parameter("PEMPL_CELULAR", obj.EMPL_CELULAR);
            para[5] = new Parameter("PTIPO_DOCUMENTO_TIPD_ID", obj.TIPO_DOCUMENTO_TIPD_ID);
            para[6] = new Parameter("PEMPL_NUMERODOCUMENTO", obj.EMPL_NUMERODOCUMENTO);
            para[7] = new Parameter("PGENERO_GENE_ID", obj.GENERO_GENE_ID);
            para[8] = new Parameter("PMUNICIPIO_MUNI_ID", obj.MUNICIPIO_MUNI_ID);
            para[9] = new Parameter("PTIPO_EMPLEADO_TIPE_ID", obj.TIPO_EMPLEADO_TIPE_ID);
            para[10] = new Parameter("PTIPOSANGRE_TIPS_ID", obj.TIPOSANGRE_TIPS_ID);
            Transaction []trans = new Transaction[1];
            trans[0] = new Transaction("PR_UPDTEMPLEADO", para);
            return conx.Transaction(trans);
        }
    }
}
