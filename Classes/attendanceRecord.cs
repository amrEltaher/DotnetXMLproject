﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetXmlProject.Classes
{
    enum Status
    {
        absent,
        present,
        notAsssigned
    }
    internal class attendanceRecord
    {
        public int ID { get; set; }
        public string studentName { get; set; }
        public Status studentStatus { get; set; }

    }
}
