using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    internal class OEF6
    {

        protected string mTitle;
        protected string mArtist;
        protected List<string> mSongs;

        public OEF6(string title, string artist)
        {
            Title = title;
            Artist = artist;
            Songs = new List<string>();

        }
        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public string Artist
        {
            get { return mArtist; }
            set { mArtist = value; }

        }
        public List<string> Songs 
        {
            get {return mSongs; }
            set { mSongs = value; } 
        }

        public void AddSongs( string song)
        {
            Songs.Add(song);
        }
        

        public override string ToString()
        {
            string songs = string.Join(", ", Songs);

            string result =
                string.Format("Artist: {0}, Title: {1}, Song:{2} ", Artist,
                Title, songs);
                
            

            return result;
        }

    }
}
