using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
using System.Globalization;

namespace MockingWithIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show App");
            Console.WriteLine("Show App");

            //String jsonConvert = CreateStates().SerializeStringSafe();

            //string jsonStr = CreateStateJsonString();
            //var persons = jsonStr.DeserializeArraySafe<Person>();
            CultureInfo currInfo = CultureInfo.CurrentCulture;
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            CultureInfo info = CultureInfo.GetCultureInfo("vi-VN");
            CultureInfo.DefaultThreadCurrentCulture = info;
            CultureInfo.DefaultThreadCurrentUICulture = info;
            CultureInfo infoJP = CultureInfo.GetCultureInfo(1041);
            Console.WriteLine(infoJP.TextInfo.ANSICodePage.ToString());
            Console.WriteLine(now.ToString(infoJP));
            Console.ReadKey();
        }

        private static string CreatePersonJsonString()
        {
            StringBuilder jsonResult = new StringBuilder();
            jsonResult.AppendLine("[");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("     \"Id\": 1,");
            jsonResult.AppendLine("     \"Name\": \"T\"");
            jsonResult.AppendLine(" }");
            jsonResult.AppendLine("]");
            return jsonResult.ToString();
        }

        private static string CreateStateJsonString()
        {
            StringBuilder jsonResult = new StringBuilder();
            jsonResult.AppendLine("[");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("   \"Id\": 1, ");
            jsonResult.AppendLine("   \"Name\": \"ACT\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("   \"Id\": 2,");
            jsonResult.AppendLine("   \"Name\": \"NSW\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("   \"Id\": 3,");
            jsonResult.AppendLine("   \"Name\": \"VIC\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("   \"Id\": 4,");
            jsonResult.AppendLine("   \"Name\": \"QLD\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("     \"Id\": 5,");
            jsonResult.AppendLine("     \"Name\": \"SA\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("     \"Id\": 6,");
            jsonResult.AppendLine("     \"Name\": \"WA\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("     \"Id\": 7,");
            jsonResult.AppendLine("     \"Name\": \"NT\"");
            jsonResult.AppendLine(" },");
            jsonResult.AppendLine(" {");
            jsonResult.AppendLine("     \"Id\": 8,");
            jsonResult.AppendLine("     \"Name\": \"TAS\"");
            jsonResult.AppendLine(" }");
            jsonResult.AppendLine("]");
            return jsonResult.ToString();
        }

        private static State[] CreateStates()
        {
            return new State[]
            {
                new State
                {
                    Id=1,
                    Name="ACT",
                },
                 new State
                {
                    Id=2,
                    Name="NSW",
                },
                  new State
                {
                    Id=3,
                    Name="VIC",
                },
            };
        }
    }
}
