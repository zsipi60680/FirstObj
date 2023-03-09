using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribbutes
{
    internal class Happy
    {
        [StringAttribbute(30)]
        public string NameHappy { get; set; }
        [StringAttribbute(100)]
        public string KindHappy { get; set; }

        public Happy(string nameHappy, string kindHappy)
        {
            NameHappy = nameHappy;
            KindHappy = kindHappy;
        }

        
    }
}
