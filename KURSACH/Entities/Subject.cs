﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSACH
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }

        public virtual List<Mark> Marks { get; set; }
    }
}