using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Core;
using Messages.UI;
using Messages.UI.Infrastructure;

namespace Dashboard.Helpers
{
    public static class DataGridViewHelper
    {
        /// <summary>
        /// Apply the column attributes on the grid
        /// </summary>
        /// <param name="showCellTooltips">The tooltips on the cells do sometime block your mouse click. The downside: If the tooltips are disabled the column header tooltips will not show either</param>
        public static void ApplyColumnDisplayFormatAttributes(this DataGridView dgv, bool showCellTooltips = false)
        {
            var type = ListBindingHelper.GetListItemType(dgv.DataSource);
            var properties = TypeDescriptor.GetProperties(type);
            dgv.ShowCellToolTips = showCellTooltips;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                var p = properties[column.DataPropertyName];
                if (p != null)
                {
                    var hide = (ColumnHideAttribute)p.Attributes[typeof(ColumnHideAttribute)];
                    if (hide != null)
                    {
                        column.Visible = false;
                        continue;
                    }
                    var format = (DisplayFormatAttribute)p.Attributes[typeof(DisplayFormatAttribute)];
                    column.ToolTipText = p.Description;
                    column.DefaultCellStyle.Format = format?.Format;
                    var underline = (ColumnCellsUnderlineAttribute)p.Attributes[typeof(ColumnCellsUnderlineAttribute)];
                    if (underline != null)
                        column.DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Underline);
                }
            }
        }

        public static DataGridViewColumn GetColumn(this DataGridView dgv, string columnName)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
                if (column.Name == columnName)
                    return column;

            throw new Exception($"Could not find column: '{columnName}'");
        }

        public static bool ColumnExists(this DataGridView dgv, string columnName)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
                if (column.Name == columnName)
                    return true;

            return false;
        }

        /// <summary>
        /// All buttons will show same text
        /// </summary>
        public static void AddButtonColumn(this DataGridView dgv, string colName, string btnText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = colName;
            buttonColumn.Text = btnText;
            buttonColumn.UseColumnTextForButtonValue = true;

            dgv.Columns.Insert(dgv.ColumnCount, buttonColumn);
        }

        /// <summary>
        /// All buttons will show same text
        /// </summary>
        public static void AddDisableButtonColumn(this DataGridView dgv, string colName, string btnText)
        {
            var buttonColumn = new DataGridViewDisableButtonColumn();
            buttonColumn.Name = colName;
            buttonColumn.Text = btnText;
            buttonColumn.UseColumnTextForButtonValue = true;

            dgv.Columns.Insert(dgv.ColumnCount, buttonColumn);
        }

        public static void SetReadOnly(this DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AllowUserToResizeColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        /// <param name="rowHeightRatio">For narrowing down the row height (0.75 - 1)</param>
        public static void SetVisualStyling(this DataGridView dgv, bool showColumnHeader = true, double rowHeightRatio = 1)
        {
            dgv.RowHeadersVisible = false; // hides most left 'column'

            dgv.BackgroundColor = Color.FromArgb(46, 51, 73);
            dgv.ForeColor = Color.Gainsboro;
            dgv.BorderStyle = BorderStyle.None;

            // Set the selection background color for all the cells.
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;

            // column header color
            if (showColumnHeader)
            {
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Constants.Blue;
                dgv.EnableHeadersVisualStyles = false;
            }
            else
                dgv.ColumnHeadersVisible = false;

            dgv.RowTemplate.Height = dgv.RowHeight(rowHeightRatio);
        }

        private static double DefaultRowHeight = 25;

        /// <summary>
        /// Taking scaling into account
        /// </summary>
        private static int RowHeight(this DataGridView dgv, double rowHeightRatio) => (int)(DefaultRowHeight * rowHeightRatio * dgv.ScaleFactor());

        /// <summary>
        /// Taking scaling into account
        /// </summary>
        public static int RealHeight(this DataGridView dgv) => (dgv.Rows.Count + (dgv.RowHeadersVisible ? 1 : 0)) * dgv.RowTemplate.Height;
    }
}