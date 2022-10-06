using System.Windows.Forms;

namespace WeightGain.UI.Extensions
{
    public class DataGridViewEx : DataGridView
    {
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs args)
        {
            base.OnCellFormatting(args);
            if (args.RowIndex == 0)
                return;

            if (!IsRepeatedCellValue(args.RowIndex, args.ColumnIndex)) return;
            args.Value = "\"";
            args.FormattingApplied = true;
        }

        private bool IsRepeatedCellValue(int rowIndex, int colIndex)
        {
            var currCell = Rows[rowIndex].Cells[colIndex];
            var prevCell = Rows[rowIndex - 1].Cells[colIndex];
            return currCell.Value == prevCell.Value ||
                   (currCell.Value != null && prevCell.Value != null &&
                    currCell.Value.ToString() == prevCell.Value.ToString());
        }

        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs args)
        {
            base.OnCellPainting(args);
            args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (args.RowIndex < 1 || args.ColumnIndex < 0)
                return;
            args.AdvancedBorderStyle.Top = IsRepeatedCellValue(args.RowIndex, args.ColumnIndex) ? DataGridViewAdvancedCellBorderStyle.None : AdvancedCellBorderStyle.Top;
        }
    }
}