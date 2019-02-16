namespace PhoneC_
{
    public class Nokia : Phone, IRingable 
            {
                public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
                   : base(versionNumber, batteryPercentage, carrier, ringTone) {}
                    public string Ring() 
                    {
                        return $"....{RingTone1}....";
                    }
                    public string Unlock() 
                    {
                        return $"Nokia {Version} unlock by Anger";
                    }
                    public override void DisplayInfo() 
                    {
                         System.Console.WriteLine("wmwmwmwmwmwmwmwmwmwmwmwm");
                    
                        System.Console.WriteLine("Nokia "+ Version);
                        System.Console.WriteLine("Batterry Percentage " + Battery);
                        System.Console.WriteLine(RingTone1);
                        System.Console.WriteLine(Carrier);

                        System.Console.WriteLine("wmwmwmwmwmwmwmwmwmwmwmwm");
         
                    }
            }
}
