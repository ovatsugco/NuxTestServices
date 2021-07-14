using System;
using System.Collections.Generic;
using System.Text;

namespace Nuxiba.Services.Entity
{
    public class LogInformation
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string Message { get; set; }


        public LogInformation(string message)
        {
            this.PartitionKey = "Information";
            this.RowKey = Guid.NewGuid().ToString();
            this.Message = message;
        }
    }
}
