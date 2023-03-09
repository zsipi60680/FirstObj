using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribbutes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]  
    internal class StringAttribbute:Attribute
    {
        public int MaxStr { get; set; }
        public StringAttribbute(int maxStr)
        {
            MaxStr = maxStr;
        }
    }
}
