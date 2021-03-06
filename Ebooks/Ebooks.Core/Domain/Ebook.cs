﻿using System.Collections.Generic;

namespace Ebooks.Core.Domain
{
    public class Ebook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public IList<Page> Pages { get; set; }
    }
}
