using System;
using System.Text;
using Utility;

namespace MockingWithIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            String jsonConvert = CreateStates().SerializeStringSafe();

            string jsonStr = CreateStateJsonString();
            var persons = jsonStr.DeserializeArraySafe<Person>();
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
