﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nuxiba.Services.Entity
{
    public class Task
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}
