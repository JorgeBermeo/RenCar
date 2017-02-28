using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProgramacionIII.Conexion
{
    public class Transaction
    {
        public string Procedure { get; set; }
        public Parameter[] Parameters { get; set; }

        public Transaction(string Procedure, Parameter[] Parameters)
        {
            this.Procedure = Procedure;
            this.Parameters = Parameters;
        }
    }
}