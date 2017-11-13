using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class SongDescriptor
    {
        private Genre genre;
        private int songID;
        private int approvals;  //How many people agree that this descriptor matches the song

        public SongDescriptor()
        {
            songID = -1;
        }

        public SongDescriptor(int songID, Genre genre)
        {
            this.songID = songID;
            this.genre = genre;
            this.approvals = 1;
        }

        public Genre getGenre()
        {
            return this.genre;
        }

        public int getSongID()
        {
            return this.songID;
        }

        public int getApprovals()
        {
            return this.approvals;
        }

        public void approveSong()
        {
            approvals = approvals + 1;
        }
    }
}
