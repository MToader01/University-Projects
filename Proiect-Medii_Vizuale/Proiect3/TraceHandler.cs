using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Proiect3
{
    public class TraceHandler
    {
        public static bool isActive { get; set; } = false;

        public static void Initialization()
        {
            FileStream file = new FileStream("D:\\Facultate\\Modul II\\Medii Vizuale\\Proiect3\\Proiect3\\Log\\log.txt", FileMode.OpenOrCreate);

            TextWriterTraceListener trace = new TextWriterTraceListener(file);
            Trace.Listeners.Add(trace);

            Trace.AutoFlush = true;

            isActive= true;
        }

        public static void write(string str)
        {
            if(isActive == false)
            {
                Initialization();
            }
            Trace.WriteLine(DateTime.Now + " || " + str);
        }
    }
}