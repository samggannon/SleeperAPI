using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace SleeperAPI
{
    internal class TableVisualization
    {

        public static void ShowTable<T>(List<T> tableData, string tableName) where T : class
        {
            Console.Clear();
            Console.WriteLine("\n");

            ConsoleTableBuilder
                .From(tableData)
                .WithTitle(tableName)
                .ExportAndWriteLine(TableAligntment.Center);
            Console.WriteLine("\n\n");
        }
    }
}
