using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal class Post
    {
        public virtual string CreatePost(PostDatabase db ,string post)
        {
            return db.Add(post);
        }

        public class TagPost : Post
        {
            public override string CreatePost(PostDatabase db , string post)
            {
                return db.AddTagPost(post);
            }
        }

        public class MentionPost: Post
        {

            public override string CreatePost(PostDatabase db, string post)
            {
                return db.AddMentionPost(post);
            }
        }
        public class LinkPost : Post
        {

            public override string CreatePost(PostDatabase db, string post)
            {
                return db.AddLinkPost(post);
            }
        }
    }
}
