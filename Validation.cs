using System.Collections.Generic;
using System.Windows.Forms;

namespace SPZLab3Var1
{
    public static class Validation
    {
        public static (int?, string) SafeGetPositiveInteger(string source)
        {
            var maybePositiveInteger = Utilities.SafeParseInt(source);
            if (maybePositiveInteger == null)
            {
                return (null, "Должны быть числом");
            }

            if (maybePositiveInteger <= 0)
            {
                return (null, "Должно быть положительным числом");
            }

            return (maybePositiveInteger, null);
        }

        public static (string, string) SafeGetNonEmptyString(string source)
        {
            if (source == "")
            {
                return (null, "Не должно быть пустым");
            }
            return (source, null);
        }

        public static (string, string) SafeGetRequiredComboBoxOption(ComboBox source)
        {
            if (source.SelectedItem == null)
            {
                return (null, "Вы должны выбрать хотя бы одну опцию");
            }
            return (source.SelectedItem as string, null);
        }

        public static T AssertValidationPassed<T>(string fieldName, (T, string) valueErrorPair, List<(string, string)> errors)
        {
            var (value, errorMessage) = valueErrorPair;
            if (errorMessage != null)
            {
                errors.Add((fieldName, errorMessage));
            }
            return value;
        }
    }
}
