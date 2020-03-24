using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestRecordMusic.Controllers
{
    public class MusicForDR
    {
        
            // instance field
            public string title;
            public string artist;
            public int id;
            public double duration;
            public int yearOfPublication;

            // propetories
            public string Title { get; set; }
            public string Artist { get; set; }
            public int Id { get; set; }
            public double Duration { get; set; }
            public int YearOfPublication { get; set; }

            // constructor
            public MusicForDR(string title, string artist, int id, double duration, int yearOfPublication)
            {
                this.title = title;
                this.artist = artist;
                this.id = id;
                this.duration = duration;
                this.yearOfPublication = yearOfPublication;
            }
            public MusicForDR()
            {

            }

            public override string ToString()
            {
                return Title + Artist.ToString();
            }
        
    }


}
