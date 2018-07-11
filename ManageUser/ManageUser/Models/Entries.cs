using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageUser.Models
{
    public class Entries
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerTitle { get; set; }
        public string Content { get; set; }
    }


    public class Speaker
    {
        public int id { get; set; }
        public string legal_name { get; set; }
        public string slug { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public string url { get; set; }
        public int text_counter { get; set; }
        public string type { get; set; }
        public string speaker_name { get; set; }
        public string speaker_title { get; set; }
        public Speaker speaker { get; set; }
        public string content { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }
}