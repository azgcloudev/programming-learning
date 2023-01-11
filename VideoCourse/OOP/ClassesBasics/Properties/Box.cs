using System;

namespace Properties
{
    class Box
    {
        // member variables
        private int length = 3;
        private int height;
        private int volume;

        // properties
        public int Width { get; set; }


        // properties
        public int Volume
        {
            get
            {
                return this.volume;
            }
            set
            {
                this.volume = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public Box()
        {

        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        // setter
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }

            this.length = length;
        }

        // getter
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                length, height, Width, volume = length * height * Width);
        }

    }
}