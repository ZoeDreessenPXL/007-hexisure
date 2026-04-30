using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexiSure.Domain.Entities.Insurables
{
    public interface IInsurable
    {
        public double CalculateCoverageModifier();
    }
}
