using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // default constructor
        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Aldair Zamora";
        }

        // three properties constructor
        public Post(string title, string sendByUserne, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUserne;
            IsPublic = isPublic;
        }

        // create the next ID number
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        // update the post details
        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        // override the Object class ToString method
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", ID, Title, SendByUsername);
        }
    }
}