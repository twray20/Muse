using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class Genre
    {
        private String genreName;

        public Genre()
        {
            genreName = " ";
        }

        public Genre(String genreName)
        {
            this.genreName = genreName;
        }

        public String getGenreName()
        {
            return genreName;
        }
    }
}
