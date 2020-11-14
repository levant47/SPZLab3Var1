using System;
using System.Collections.Generic;
using System.Linq;

namespace SPZLab3Var1
{
    public class DriverDispatcher
    {
        public Dictionary<DriverKey, Driver> DriverDictionary { get; set; } = new Dictionary<DriverKey, Driver>();
        public Dictionary<string, Device> Devices { get; set; } = new Dictionary<string, Device>();
        public OperatingSystem OS { get; set; }
        public int CounteInactiveDevices => Devices.Where(nameDevicePair => nameDevicePair.Value.IsReady).Count();

        public void InstallDriverToDevice(string deviceName, Driver driver) => Devices[deviceName].Driver = driver;

        public void UninstallDriverToDevice(string deviceName) => InstallDriverToDevice(deviceName, null);

        public string Compare(Driver leftDriver, Driver rightDriver) =>
            leftDriver.Version < rightDriver.Version
                ? $"{leftDriver.ExtractKey()} < {rightDriver.ExtractKey()}"
                : leftDriver.Version == rightDriver.Version
                ? $"{leftDriver.ExtractKey()} == {rightDriver.ExtractKey()}"
                : $"{leftDriver.ExtractKey()} > {rightDriver.ExtractKey()}";

        public void DeleteDeviceByName(string deviceName) => Devices.Remove(deviceName);

        public bool AddDevice(Device device)
        {
            if (Devices.ContainsKey(device.Name))
            {
                return false;
            }
            Devices.Add(device.Name, device);
            return true;
        }

        public void DeleteDriver(DriverKey key) => DriverDictionary.Remove(key);

        public bool AddDriver(Driver driver)
        {
            var key = driver.ExtractKey();
            if (DriverDictionary.ContainsKey(key))
            {
                return false;
            }
            DriverDictionary.Add(key, driver);
            return true;
        }

        public void AddRandomDrivers()
        {
            var originalCount = DriverDictionary.Count;
            var driversToBeGeneratedCount = new Random().Next(1, 4);
            for (var loopCount = 0; DriverDictionary.Count < originalCount + driversToBeGeneratedCount && loopCount < 100; loopCount += 1)
            {
                AddDriver(GenerateRandomDriver());
            }
        }

        public bool IsComputerReady() => new[]
        {
            DeviceType.MotherBoard,
            DeviceType.CPU,
            DeviceType.GraphicsCard,
            DeviceType.RAM,
            DeviceType.HardDrive,
            DeviceType.Keyboard,
        }.All(deviceType => Devices.Values.Any(device => device.Type == deviceType && device.IsReady));

        private Driver GenerateRandomDriver()
        {
            var possibleNames = new List<string> { "NVidia Driver", "Intel Driver", "HP Driver", "DELL Driver" };
            var possibleDeviceTypes = Utilities.GetAllEnumValues<DeviceType>();
            var possibleOperatingSystems = Utilities.GetAllEnumValues<OperatingSystem>();
            return new Driver
            {
                Name = possibleNames.GetRandomElement(),
                Version = new Random().Next(1, 10),
                DeviceType = possibleDeviceTypes.GetRandomElement(),
                OperatingSystem = possibleOperatingSystems.GetRandomElement(),
            };
        }
    }
}

