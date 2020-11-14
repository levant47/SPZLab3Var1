using System;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab3Var1
{
    public partial class Form1 : Form
    {
        private DriverDispatcher _dispatcher = new DriverDispatcher();

        public Form1()
        {
            InitializeComponent();

            RefreshComputerReadinessStatusMessage();
        }

        private void generateDriverButton_Click(object sender, EventArgs e)
        {
            _dispatcher.AddRandomDrivers();
            RefreshDriverView();
        }

        private void deleteDriverButton_Click(object sender, EventArgs e)
        {
            var selectedDriverKey = driversListBox.SelectedItem as DriverKey;
            if (selectedDriverKey == null)
            {
                return;
            }
            _dispatcher.DeleteDriver(selectedDriverKey);
            RefreshDriverView();
        }

        private void RefreshDriverView()
        {
            driversListBox.Items.Clear();
            driversListBox.Items.AddRange(_dispatcher.DriverDictionary.Keys.ToArray());
        }

        private void compareDriversButton_Click(object sender, EventArgs e)
        {
            var selectedDriverKeys = driversListBox.SelectedItems.Cast<DriverKey>().ToList();
            if (selectedDriverKeys.Count != 2)
            {
                return;
            }
            MessageBox.Show(_dispatcher.Compare(_dispatcher.DriverDictionary[selectedDriverKeys[0]], _dispatcher.DriverDictionary[selectedDriverKeys[1]]));
        }

        private void driversListBox_DoubleClick(object sender, EventArgs e)
        {
            var index = driversListBox.IndexFromPoint((e as MouseEventArgs).Location);
            if (index == ListBox.NoMatches)
            {
                return;
            }
            var originalKey = driversListBox.Items[index] as DriverKey;
            new DriverForm
            (
                _dispatcher.DriverDictionary[originalKey],
                updatedDriver =>
                {
                    var updatedDriverKey = updatedDriver.ExtractKey();
                    if (originalKey.Name == updatedDriverKey.Name && originalKey.Version == updatedDriver.Version)
                    {
                        _dispatcher.DriverDictionary[originalKey] = updatedDriver;
                        RefreshDriverView();
                        return true;
                    }

                    var wasSuccessful = _dispatcher.AddDriver(updatedDriver);
                    if (!wasSuccessful)
                    {
                        MessageBox.Show("Драйвер с таким именем и версией уже существует");
                        return false;
                    }
                    _dispatcher.DeleteDriver(originalKey);
                    RefreshDriverView();
                    return true;
                }
            ).Show();
        }

        private void createDeviceButton_Click(object sender, EventArgs e) => new DeviceForm
        (
            null,
            _dispatcher.DriverDictionary.Select(keyDriverPair => keyDriverPair.Value).ToArray(),
            newDevice =>
            {
                var wasSuccessful = _dispatcher.AddDevice(newDevice);
                if (!wasSuccessful)
                {
                    MessageBox.Show("Устройство с таким имемнем уже существует");
                    return false;
                }

                deviceListBox.Items.Add(newDevice);

                RefreshComputerReadinessStatusMessage();

                return true;
            }
        ).Show();

        private void deleteDeviceButton_Click(object sender, EventArgs e)
        {
            var selectedDevice = deviceListBox.SelectedItem as Device;
            if (selectedDevice == null)
            {
                return;
            }
            _dispatcher.DeleteDeviceByName(selectedDevice.Name);
            deviceListBox.Items.Remove(selectedDevice);

            RefreshComputerReadinessStatusMessage();
        }

        private void deviceListBox_DoubleClick(object sender, EventArgs e)
        {
            var index = deviceListBox.IndexFromPoint((e as MouseEventArgs).Location);
            if (index == ListBox.NoMatches)
            {
                return;
            }
            var device = deviceListBox.Items[index] as Device;
            new DeviceForm
            (
                device,
                _dispatcher.DriverDictionary.Values.ToArray(),
                updatedDevice =>
                {
                    if (device.Name == updatedDevice.Name)
                    {
                        _dispatcher.Devices[device.Name] = updatedDevice;
                        deviceListBox.Items[index] = updatedDevice;
                        return true;
                    }

                    var wasSuccessful = _dispatcher.AddDevice(updatedDevice);
                    if (!wasSuccessful)
                    {
                        MessageBox.Show("Устройство с таким именем уже существует");
                        return false;
                    }

                    _dispatcher.DeleteDeviceByName(device.Name);
                    deviceListBox.Items.RemoveAt(index);
                    deviceListBox.Items.Add(updatedDevice);

                    RefreshComputerReadinessStatusMessage();

                    return true;
                }
            ).Show();
        }

        private void RefreshComputerReadinessStatusMessage() =>
            computerReadinessLabel.Text = "Готовность к работе: " + (_dispatcher.IsComputerReady() ? "готов" : "не готов");
    }
}

