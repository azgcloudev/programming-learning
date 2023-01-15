namespace Challange1
{
    class Box
    {
        // create a read only property "FrontSurface" which calculates the
        // front surface based on height and length
        private int height;
        private int length;

        public Box(int length, int height)
        {
            this.length = length;
            this.height = height;
        }


        // methods to get frontsurface
        public int FrontSurface
        {
            get { return height * length; }

        }

    }
}
