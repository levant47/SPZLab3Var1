namespace SPZLab3Var1
{
    public class Device
    {
        public string Name { get; set; }

        public DeviceType Type { get; set; }

        public Driver Driver { get; set; }

        public bool IsReady => Driver != null;

        public bool IsCompatible(Driver driver) => Type == driver.DeviceType;

        public override string ToString() => Name;
    }
}

