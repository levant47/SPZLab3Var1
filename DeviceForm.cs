using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab3Var1
{
    public partial class DeviceForm : Form
    {
        private readonly Func<Device, bool> _onSubmit;
        private readonly Driver[] _driverOptions;

        public DeviceForm(Device device, Driver[] driverOptions, Func<Device, bool> onSubmit)
        {
            InitializeComponent();

            _onSubmit = onSubmit;
            _driverOptions = driverOptions;

            typeComboBox.Items.AddRange(typeof(DeviceType).GetAllDescriptions());

            if (device != null)
            {
                nameTextBox.Text = device.Name;
                typeComboBox.SelectedItem = device.Type.GetDescription();
                driverComboBox.SelectedItem = device.Driver;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var errors = new List<(string, string)>();
            var name = Validation.AssertValidationPassed("Название", Validation.SafeGetNonEmptyString(nameTextBox.Text), errors);
            var typeDescription = Validation.AssertValidationPassed("Тип", Validation.SafeGetRequiredComboBoxOption(typeComboBox), errors);
            if (errors.Count != 0)
            {
                var completeErrorMessage = errors.Aggregate("", (result, fieldErrorPair) =>
                {
                    var (field, error) = fieldErrorPair;
                    return result + field + ": " + error + "\n";
                });
                MessageBox.Show(completeErrorMessage);
                return;
            }

            var wasSuccessful = _onSubmit(new Device
            {
                Name = name,
                Type = typeDescription.GetEnumByDescription<DeviceType>(),
                Driver = driverComboBox.SelectedItem as Driver,
            });
            if (wasSuccessful)
            {
                Close();
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem == null)
            {
                return;
            }
            var currentDeviceType = (typeComboBox.SelectedItem as string).GetEnumByDescription<DeviceType>();
            if ((driverComboBox.SelectedItem as Driver)?.DeviceType == currentDeviceType)
            {
                return;
            }
            driverComboBox.Items.Clear();
            driverComboBox.Items.AddRange(_driverOptions.Where(driver => driver.DeviceType == currentDeviceType).ToArray());
        }
    }
}
