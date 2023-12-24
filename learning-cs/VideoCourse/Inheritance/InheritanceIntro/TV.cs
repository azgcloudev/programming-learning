namespace InheritanceIntro
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTV()
        {
            if (IsOn == true)
            {
                Console.WriteLine("Watching TV"); 
            }
        }
    }
}
