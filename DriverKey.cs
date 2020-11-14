using System;

namespace SPZLab3Var1
{
    public class DriverKey
    {
        public string Name { get; set; }
        public int Version { get; set; }
        public override string ToString() => Name + " v" + Version;

        public override bool Equals(object otherObject)
        {
            var other = otherObject as DriverKey;
            return !(other is null) && Name == other.Name && Version == other.Version;
        }

        public override int GetHashCode() => HashCode.Combine(Name, Version);
    }
}
