using System.ComponentModel;
using System.Windows.Forms;
using WeightGain.DATA;

namespace WeightGain.UI.Extensions
{
    public class MealTimeEnumTextBoxCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            try
            {
                MealTimeEnum enumName = (MealTimeEnum)(int)value;
                switch (enumName)
                {
                    case MealTimeEnum.Breakfast: return "Kahvaltı";
                    case MealTimeEnum.FirstSnack: return "1. Atıştırmalık";
                    case MealTimeEnum.Lunch: return "Öğle Yemeği";
                    case MealTimeEnum.SecondSnack: return "2. Atıştırmalık";
                    case MealTimeEnum.Dinner: return "Akşam Yemeği";
                    case MealTimeEnum.LastSnack: return "3. Atıştırmalık";
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