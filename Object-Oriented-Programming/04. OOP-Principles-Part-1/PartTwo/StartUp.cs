﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    using Human;
    class StartUp
    {
        static void Main(string[] args)
        {
            var students = DataGenerator.GenerateStudents();
            var workers = DataGenerator.GenerateWorkers();
        }
    }
}
