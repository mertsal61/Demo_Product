﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }

        public List<Customer> customers { get; set; }
    }
}
