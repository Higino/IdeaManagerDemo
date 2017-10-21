using System;

namespace IdeaManager_FE.Models
{
    public class Idea
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime IdeaDate { get; set; }
        public string Author { get; set; }
    }
}