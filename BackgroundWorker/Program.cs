using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackgroundWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            var backgroundWorker = new System.ComponentModel.BackgroundWorker();
            backgroundWorker.DoWork += DoWork;
            backgroundWorker.RunWorkerAsync();
        }

        private static void DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i <= 10000; i++)
            {
                sum += i;
            }
        }
    }
}
