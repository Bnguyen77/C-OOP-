namespace PhoneC_
{
    public class Galaxy : Phone, IRingable 
            {
                public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
                    : base(versionNumber, batteryPercentage, carrier, ringTone) {}
                public string Ring() 
                {
                    return $"....{RingTone1}....";
                }
                
                public string Unlock() 
                {
                    return $"Galaxy {Version} unlock by heat sensor";
                }
                public override void DisplayInfo() 
                {
                    System.Console.WriteLine("wmwmwmwmwmwmwmwmwmwmwmwm");
                    
                    System.Console.WriteLine("Galaxy " + Version);
                    System.Console.WriteLine("Batterry Percentage " + Battery);
                    System.Console.WriteLine(RingTone1);
                    System.Console.WriteLine(Carrier);

                    System.Console.WriteLine("wmwmwmwmwmwmwmwmwmwmwmwm");

                }
            }
}
