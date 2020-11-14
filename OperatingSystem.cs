using System;
using System.ComponentModel;
using System.Linq;

namespace SPZLab3Var1
{
    public enum OperatingSystem
    {
        [Description("Windows")]
        Windows = 1,
        [Description("macOS")]
        MacOS = 2,
        [Description("Linux")]
        Linux = 3,
    }
}

