using HexiSure.Domain.Entities.Insurables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Infrastructure.Data
{
    public static class MunicipalityData
    {
        public static List<Municipality> Municipalities { get; set; }

        public static void RetrieveMunicipalities()
        {
            string path = "files/postal-codes-belgium.csv";

            var lines = File.ReadAllLines(path);

            List<Municipality> list = new List<Municipality>();

            foreach (var line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var parts = line.Split(',');

                list.Add(new Municipality(int.Parse(parts[0]), 
                        !string.IsNullOrWhiteSpace(parts[2]) ? parts[2]
                        : !string.IsNullOrWhiteSpace(parts[3]) ? parts[3]
                        : parts[1]));
            }

            Municipalities = list;
        }
    }
}
