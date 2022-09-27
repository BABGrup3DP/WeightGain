﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using WeightGain.DATA;

namespace WeightGain.UI.Extensions
{
    public class ExerciseTypeEnumTextBoxCell : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            ExerciseEnum enumName = (ExerciseEnum)(int)value;
            switch (enumName)
            {
                case ExerciseEnum.Bicycle: return "Bisiklet";
                case ExerciseEnum.JumpRope: return "İp Atlama";
                case ExerciseEnum.Run: return "Koşu";
                case ExerciseEnum.Walk: return "Yürüyüş";
                case ExerciseEnum.Swim: return "Yüzme";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}