using System;
using System.Collections.Generic;
using System.Text;

namespace Nuxiba.Services.Entity
{
    public class User
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }

        public string Phone { get; set; }
        public string Website { get; set; }

        public Address Address { get; set; }
        public Company Company { get; set; }

    }
}
