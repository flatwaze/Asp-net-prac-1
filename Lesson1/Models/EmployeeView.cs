﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeView : BasicObjectView
    {
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
