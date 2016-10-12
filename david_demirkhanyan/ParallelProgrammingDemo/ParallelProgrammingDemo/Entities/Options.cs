﻿using CommandLine;
using ParallelProgrammingDemo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo.Entities
{
    public class Options
    {
        [Option('d', Required = false, HelpText = "Absolute path to the DataSetVectors csv file, if not provided will generate randomly")]
        public string DataSetFilePath { get; set; }

        [Option('q', Required = false, HelpText = "Absolute path to the QuerySetVectors csv file, if not provided will generate randomly")]
        public string QueryStringFilePath { get; set; }

        [Option('t', Required = true, HelpText = "Type of Calculations: sync, parallel, mpi, cuda")]
        public CalculatorType ComputationType { get; set; }
        
        public string GetUsage()
        {
            var usage = new StringBuilder();

            usage.AppendLine("Parallel Programming Demo");
            usage.AppendLine("Read user manual for usage instructions");

            return usage.ToString();
        }
    }
}
