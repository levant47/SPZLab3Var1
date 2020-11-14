using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SPZLab3Var1
{
    public partial class DriverForm : Form
    {
        private readonly Func<Driver, bool> _onSubmit;

        public DriverForm(Driver driver, Func<Driver, bool> onSubmit)
        {
            InitializeComponent();

            _onSubmit = onSubmit;

            operatingSystemComboBox.Items.AddRange(typeof(OperatingSystem).GetAllDescriptions());
            typeComboBox.Items.AddRange(typeof(DeviceType).GetAllDescriptions());

            nameTextBox.Text = driver.Name;
            versionTextBox.Text = driver.Version.ToString();
            operatingSystemComboBox.SelectedItem = driver.OperatingSystem.GetDescription();
            typeComboBox.SelectedItem = driver.DeviceType.GetDescription();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var errors = new List<(string, string)>();
            var name = Validation.AssertValidationPassed("Название", Validation.SafeGetNonEmptyString(nameTextBox.Text), errors);
            var version = Validation.AssertValidationPassed("Версия", Validation.SafeGetPositiveInteger(versionTextBox.Text), errors);
            var operatingSystemDescription = Validation.AssertValidationPassed("ОС", Validation.SafeGetRequiredComboBoxOption(operatingSystemComboBox), errors);
            var type = Validation.AssertValidationPassed("Тип", Validation.SafeGetRequiredComboBoxOption(typeComboBox), errors);
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

            var wasSuccessful = _onSubmit(new Driver
            {
                Name = name,
                Version = (int)version,
                OperatingSystem = operatingSystemDescription.GetEnumByDescription<OperatingSystem>(),
                DeviceType = type.GetEnumByDescription<DeviceType>(),
            });

            if (wasSuccessful)
            {
                Close();
            }
        }
    }
}
