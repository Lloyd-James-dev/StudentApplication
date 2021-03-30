using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApplication {

    public class ValidateInput {

        // -- Public Validation Functions --

        /// <summary>
        /// Validate TextBox if not empty
        /// </summary>
        /// <param name="tb"></param>
        /// <returns>true if the TextBox is not empty; otherwise, false.</returns>
        public static bool IsValid(TextBox tb) {
            return Regex.IsMatch(tb.Text, @"[\S\w\d]+");
        }

        /// <summary>
        /// Validate if TextBox value is an email address
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="isEmail"></param>
        /// <returns>if the isEmail flag is set to true,<br/>    true if the string is a valid email address; otherwise, false.<br/>if the isEmail flag is set to false,<br/>    true if the TextBox is not empty; otherwise, false.</returns>
        public static bool IsValid(TextBox tb, bool isEmail) {
            if (isEmail) {
                try {
                    return Regex.IsMatch(tb.Text,
                        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                } catch (RegexMatchTimeoutException) {
                    return false;
                }
            } else {
                return IsValid(tb);
            }
        }

        /// <summary>
        /// Validate if TextBox with regular expression
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="rgx"></param>
        /// <returns>true if the regular expression finds a match; otherwise, false.</returns>
        public static bool IsValid(TextBox tb, string rgx) {
            return Regex.IsMatch(tb.Text, rgx);
        }

        /// <summary>
        /// Validate monetary amount in current culture of TextBox value with option for a positive number
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="isPositive"></param>
        /// <param name="number"></param>
        /// <returns>A decimal value of the currency</returns>
        public static bool IsValid(TextBox tb, bool isPositive, out decimal number) {
            decimal i = -1;
            if (decimal.TryParse(tb.Text.Trim(), NumberStyles.AllowCurrencySymbol | NumberStyles.Number, CultureInfo.CurrentCulture, out i)) { 
                number = i;
                return isPositive ? i>=0 : true;
            } else { 
                number = i;
                return false;
            }
        }

        /// <summary>
        /// Validate monetary amount in current culture of TextBox value
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="number"></param>
        /// <returns>A decimal value of the currency</returns>
        public static bool IsValid(string amount, out decimal number) {
            if (decimal.TryParse(amount, NumberStyles.AllowCurrencySymbol | NumberStyles.Number, CultureInfo.CurrentCulture, out decimal i)) {
                number = i;
                return true;
            }
            number = i;
            return false;
        }

        /// <summary>
        /// Validate if selection has been made in a ComboBox
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public static bool IsValid(ComboBox cb) {
            return cb.SelectedIndex >= 0;
        }

        /// <summary>
        /// Validate if a selection has been made to a RadioButton or CheckBox group
        /// </summary>
        /// <param name="gb"></param>
        /// <returns></returns>
        public static bool IsValid(GroupBox gb) {
            bool ctrlValid = false;
            if (gb.Controls.OfType<RadioButton>().Count() > 0) {
                foreach (RadioButton radbtn in gb.Controls.OfType<RadioButton>()) {
                    if (radbtn.Checked) {
                        ctrlValid = true;
                        break;
                    }
                }
            }
            else if (gb.Controls.OfType<CheckBox>().Count() > 0) {
                foreach (CheckBox chkbox in gb.Controls.OfType<CheckBox>()) {
                    if (chkbox.Checked) {
                        ctrlValid = true;
                        break;
                    }
                }
            }
            return ctrlValid;
        }

        /// <summary>
        /// Validate if a date has been selected in a DateTimePicker
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool IsValid(DateTimePicker dt) {
            return dt.Checked;
        }

        /// <summary>
        /// Validates from a comparison of two (2) DateTimePicker.Values
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public static bool IsValid(DateTimePicker before, DateTimePicker after) {
            return DateTime.Compare(before.Value, after.Value) < 0 ;
        }

        /// <summary>
        /// Validates from a comparison of a DateTime and from a DateTimePicker.Value
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public static bool IsValid(DateTime before, DateTimePicker after) {
            return DateTime.Compare(before, after.Value) < 0;
        }

        /// <summary>
        /// Validates from a comparison of two DateTimes
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public static bool IsValid(DateTime before, DateTime after)
        {
            return DateTime.Compare(before, after) < 0;
        }
    }
}
