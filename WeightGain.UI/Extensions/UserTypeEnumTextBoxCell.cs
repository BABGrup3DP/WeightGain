using System.ComponentModel;
using System.Windows.Forms;
using WeightGain.DATA;

namespace WeightGain.UI.Extensions
{
    public class UserTypeEnumTextBoxCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            var enumName = (UserTypeEnum)(int)value;
            try
            {
                switch (enumName)
                {
                    case UserTypeEnum.Admin: return "Admin";
                    case UserTypeEnum.Dietitian: return "Diyetisyen";
                    case UserTypeEnum.User: return "Kullanıcı";
                    default:
                        return "";
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
