﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine(7.5M);
            var users = new List<User>
            {
                new User { Group = "T+1", Name = "Angas" },
                new User { Group = "T+2", Name = "Chris" },
                new User { Group = "S+1", Name = "Mark" },
                new User { Group = "S+2", Name = "Ryan" }
            };

            var result = new Dictionary<string, IEnumerable<User>>();

            var groups = users
                .GroupBy(u => u.Group.Split('+')[0])
                .ToDictionary(g => g.Key, g => g.AsEnumerable())
                .OrderBy(d => d.Key);
                */

            var candidate = "<input type=\"input\" name=\"Workflow.InterviewPrepare.LogicLoad.JavaFunction.className\" value=\"com.speedlegal.workflow.demofunction.load.ProtectValues\" />";
            var source = "abc<input type=\"input\" name=\"Workflow.InterviewPrepare.LogicLoad.JavaFunction.className\" value=\"com.speedlegal.workflow.demofunction.load.ProtectValues\" />efg";


            var result = source.Remove(source.IndexOf(candidate), candidate.Length);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class User
    {
        public string Group { get; set; }
        public string Name { get; set; }

    }
}
