using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurables
{
    public class Municipality
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Municipality(int code, string municipality)
        {
            Code = code;
            Name = municipality;
        }

        public override string ToString()
        {
            return $"{Name}: {Code}";
        }
    }
}
