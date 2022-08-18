
using System;
using System.ComponentModel.DataAnnotations;
namespace BookTrack.Model
{
    public class Book
    {
       public int id { get; set; }
       public string Title { get; set; }
        public string Author { get; set; }
        public string categoryName { get; set; }
        public string categoryType { get; set; }
        [Range (1,10,ErrorMessage="Rating must be between 1 to 10")]
        public int Rating { get; set; }

    }
}

