//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;


namespace Interactive_Book_Reader
{
    [Serializable]
    public class Chapter
    {
        public int ChapterId { get; set; }

        public string ChapterText { get; set; }

        public Dictionary<string, int> ChapterVariants { get; set; }

    }

    [Serializable]
    public class Book
    {
        public string BookAuthor { get; set; }

        public string BookTitle { get; set; }

        public string Password { get; set; }

        public Chapter[] Chapters { get; set; }

    }

}
