using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab_05_LogToEventViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog.WriteEntry("Application", "Your system is about to expire", EventLogEntryType.Error, 5000, 1234);
        }
    }
}
