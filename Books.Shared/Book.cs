﻿using System;

namespace Books.Shared
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Publisher { get; set; }
    }
}
