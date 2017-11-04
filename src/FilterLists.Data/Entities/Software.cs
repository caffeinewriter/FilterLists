﻿using System.Collections.Generic;

namespace FilterLists.Data.Entities
{
    public class Software : BaseEntity
    {
        public string DownloadUrl { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public ICollection<SoftwareSyntax> SoftwareSyntaxes { get; set; }
    }
}