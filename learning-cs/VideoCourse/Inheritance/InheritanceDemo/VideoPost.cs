using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    /*
     create a VideoPost with properties VideoURL, Length

     create constructors
     adjust the ToString() method accordingly
     create a instance of VideoPost class

     MORE ADVANCE STEPS:
      use Timer an Callback method here
      create fields as  quirered
      add members method "Play" which shuld write the current duration of the video
      and "Stop" which should stop the "timer" and write "stoped at {0}s" onto the console.
      Play the video after creating the instance and pause it, when the user presses any key
     */

    class VideoPost : Post
    {

        public string? VideoURL { get; set; }
        public int Length { get; set; }

        // constructor
        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, int length)
        {
            // properties from Post class
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;

            VideoURL = videoURL;
            Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", ID, Title, VideoURL, SendByUsername);
        }
    }
}
