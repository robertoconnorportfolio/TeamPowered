﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public bool Favorite { get; set; }
        public int Id { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public string SeriesTitle { get; set;}
        public Artists[] Artists { get; set; }
        
    }
}