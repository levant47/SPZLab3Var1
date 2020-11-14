using System.ComponentModel;

namespace SPZLab3Var1
{
    public enum DeviceType
    {
        [Description("Mouse")]
        Mouse = 1,
        [Description("Flash Card")]
        FlashCard = 2,
        [Description("CD/DVD Drive")]
        CDDVDDrive = 3,
        [Description("Monitor")]
        Monitor = 4,
        [Description("Printer")]
        Printer = 5,
        [Description("Scanner")]
        Scanner = 6,
        [Description("Network Card")]
        NetworkCard = 7,
        [Description("Mother Board")]
        MotherBoard = 8,
        [Description("CPU")]
        CPU = 9,
        [Description("Graphics Card")]
        GraphicsCard = 10,
        [Description("RAM")]
        RAM = 11,
        [Description("Hard Drive")]
        HardDrive = 12,
        [Description("Keyboard")]
        Keyboard = 13,
    }
}

