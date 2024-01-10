namespace InheritanceDemo
{
    class ImagePost : Post
    {
        public string? ImageUrl { get; set; }
        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, bool isPublic, string imageURL)
        {
            // properties from Post class
            ID = GetNextID();
            Title = title;
            SendByUsername = sendByUsername;
            IsPublic = isPublic;

            // ImagePost class properties
            ImageUrl = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", ID, Title, ImageUrl, SendByUsername);
        }
    }
}