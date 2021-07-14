using System;
using System.Collections.Generic;
using System.Text;

namespace Nuxiba.Services.Entity
{
    public class LogError
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Exception { get; set; }


        public LogError(Exception ex)
        {
            this.PartitionKey = "Error";
            this.RowKey = Guid.NewGuid().ToString();
            this.Exception = $" { ex.Message } stack trace { (ex.StackTrace != null ? ex.StackTrace.ToString() : string.Empty)}";
        }
    }
}
