using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfdbToZedGraph;
using WfdbToZedGraph.LocalFilesManager;

namespace ConsoleTestField
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WfdbToZedGraphBinder binder = new WfdbToZedGraphBinder();
                binder.AutomaticSetTempLocation();
                binder.OpendRecordFromFile(@"C:\test\data\100s.atr");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }
            Console.WriteLine("\n\r\n\rPres any key ...\n\r");
            Console.ReadLine();
        }
    }
}
