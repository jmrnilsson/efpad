using System;
using System.Collections.Generic;

namespace Scaffold
{
    public partial class Post
    {
        public long PostId { get; set; }
        public long BlogId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
