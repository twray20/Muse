using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse
{
    public class SongDescriptor
    {
        private Keyword keyWord;
        private int songID;
        private int approvals;  //How many people agree that this descriptor matches the song

        public SongDescriptor()
        {
            songID = -1;
        }

        public SongDescriptor(int songID, Keyword keyWord)
        {
            this.songID = songID;
            this.keyWord = keyWord;
            this.approvals = 1;
        }

        public Keyword getKeyWord()
        {
            return this.keyWord;
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
