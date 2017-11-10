using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class Keyword
    {
        private String keyName;

        public Keyword()
        {
            keyName = " ";
        }

        public Keyword(String keyName)
        {
            this.keyName = keyName;
        }

        public String getKeyName()
        {
            return keyName;
        }
    }
}
