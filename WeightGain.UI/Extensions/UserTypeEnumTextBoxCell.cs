using System;
using System.ComponentModel;
using System.Windows.Forms;
using WeightGain.DATA;

namespace WeightGain.UI.Extensions
{
    public class UserTypeEnumTextBoxCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            UserTypeEnum enumName = (UserTypeEnum)(int)value;
            switch (enumName)
            {
                case UserTypeEnum.Admin: return "Admin";
                case UserTypeEnum.Dietitian: return "Diyetisyen";
                case UserTypeEnum.ProjectManager: return "Proje Yöneticisi";
                case UserTypeEnum.User: return "Kullanıcı";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
