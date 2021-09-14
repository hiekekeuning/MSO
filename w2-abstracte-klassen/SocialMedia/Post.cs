using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    abstract class Post
    {
        public string Username { get; set; }

        public DateTime Timestamp { get; set; }

        public int Likes { get; set; }

        public List<string> Comments { get; set; }

        public Post(string username)
        {
            this.Username = username;
            Timestamp = DateTime.Now;
        }

        public void Like()
        {
            Likes++;
        }

        public void Unlike()
        {
            if (Likes > 0)
            {
                Likes--;
            }
        }

        public abstract void Display();
    }

    class MessagePost : Post
    {
        public string Message { get; set; }
        public MessagePost(string username, string msg) : base(username)
        {
            this.Message = msg;
        }

        public override void Display()
        {
            Console.WriteLine(Message);
        }
    }

    class PhotoPost : Post
    {
        public string Filename { get; set; }

        public PhotoPost(string username, string filename) : base(username)
        {
            this.Filename = filename;
        }
        public override void Display()
        {
            Console.WriteLine($"Picture {Filename}");
        }

        public void ApplyFilter()
        {
            // apply filter
        }
    }
}
