namespace SPZLab3Var1
{
    public class Driver
    {
        public string Name { get; set; }

        public int Version { get; set; }

        public OperatingSystem OperatingSystem { get; set; }

        public DeviceType DeviceType { get; set; }

        public bool IsCompatible(Device device, OperatingSystem operatingSystem) => device.Type == DeviceType && operatingSystem == OperatingSystem;

        public void UpdateVersion() => Version++;

        public static bool operator ==(Driver left, Driver right)
        {
            if (left is null || right is null)
            {
                return left is null && right is null;
            }
            return left.Version == right.Version
                && left.DeviceType == right.DeviceType
                && left.OperatingSystem == right.OperatingSystem;
        }

        public static bool operator !=(Driver left, Driver right) => !(left == right);

        public DriverKey ExtractKey() => new DriverKey { Name = Name, Version = Version };

        public override string ToString() => ExtractKey().ToString();
    }
}

