using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StudentApplication {

    public class BuildView {

        public DataGridView GridView { get; set; }
        public DataTable TabledData { get; set; }
        public DataGridViewColumn[] DataGridViewColumns { get; set; }
        public ComboBoxColumn[] ComboBoxColumns { get; set; }
        public ButtonColumn[] ButtonColumns { get; set; }
        public bool IsFormattingComplete { get; set; } = false;
        public int ResultCount { get; set; }
        public DataGridViewEditMode EditMode { get; set; } = DataGridViewEditMode.EditProgrammatically;
        public bool MultiSelect { get; set; } = false;

        public void Create() {
            PopulateView();
            StyleView();
            AddButtonColumns();
            FormatColumns();
        }
        private void PopulateView() {
            GridView.Columns.Clear();
            ResultCount = TabledData.Rows.Count;
            GridView.DataSource = TabledData;
        }
        private void StyleView() {
            // Default properties for DataGridViews specific to this project
            GridView.VirtualMode = true;
            GridView.ColumnHeadersDefaultCellStyle = ColumnProperties.headCellStyle;
            GridView.DefaultCellStyle = ColumnProperties.defaultCellStyle;
            GridView.AlternatingRowsDefaultCellStyle = ColumnProperties.altCellStyle;
            GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.ScrollBars = ScrollBars.Both;
            GridView.EnableHeadersVisualStyles = false;
            GridView.AutoSize = true;
            GridView.Visible = true;
            GridView.TabStop = false;
            // Properties with default values defined in class specific to this project
            GridView.EditMode = EditMode;
            GridView.MultiSelect = MultiSelect;
            GridView.ReadOnly = false;
            // So only attached on first run of Create()
            if (!IsFormattingComplete) {
                GridView.CellPainting += new DataGridViewCellPaintingEventHandler(DGV_CellPainting);
            }
        }
        private void FormatColumns() {
            //IsFormattingComplete = false;
            for (int i = 0; i < GridView.Columns.Count; i++) {
                for (int ii = 0; ii < DataGridViewColumns.Length; ii++) {
                    if (GridView.Columns[i].Name == DataGridViewColumns[ii].Name ){

                        DataGridViewColumn target = GridView.Columns[i];
                        DataGridViewColumn source = DataGridViewColumns[ii];

                        // Available properties
                        target.HeaderText = source.HeaderText;
                        target.HeaderCell.Style.Alignment = source.DefaultCellStyle.Alignment;
                        target.Visible = source.Visible;
                        // AutoSizeMode must be 'None' to set widths
                        target.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        // Resetting default MinimumWidth
                        target.MinimumWidth = source.MinimumWidth == 5 ? ColumnProperties.MinimumColumnWidth : source.MinimumWidth;
                        target.Width = source.Width;
                        // Individually auto-sizing columns can be very cpu intensive
                        target.AutoSizeMode = source.AutoSizeMode;
                        target.FillWeight = source.FillWeight;

                        target.DefaultCellStyle = source.DefaultCellStyle;
                        target.SortMode = source.SortMode;

                        // Special Formatting
                        // Fixed Length Digit - Warning: This will fire DataBindingComplete on each iteration
                        if (Regex.IsMatch(source.DefaultCellStyle.Format, @"^[dD]\d+$")) {
                            for (int j = 0; j < GridView.RowCount; j++) {
                                if (int.TryParse(GridView.Rows[j].Cells[i].Value.ToString(), out int result)) {
                                    GridView.Rows[j].Cells[i].Value = result.ToString(source.DefaultCellStyle.Format);
                                }
                            }
                        }
                        // Making text cells non-editable
                        target.ReadOnly = true;
                        if(target.GetType().Equals(typeof(DataGridViewCheckBoxColumn))) {
                            target.ReadOnly = false;
                        }
                    }
                }
            }
            IsFormattingComplete = true;
        }
        private void AddButtonColumns() {
            if (ButtonColumns != null) {
                foreach (var item in ButtonColumns) {
                    GridView.Columns.Add(item);
                }
            }
        }

        public void AddComboBoxColumns() {
            if (ComboBoxColumns != null) {
                foreach (var item in ComboBoxColumns) {
                    GridView.Columns.Add(item);
                }
            }
        }
        
        // Make sort icon easier to see
        private void DGV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            var grid = (DataGridView)sender;
            var sortIconColor = Color.DarkGray;
            if (e.RowIndex == -1 && e.ColumnIndex > -1) {
                using (var b = new SolidBrush(ColumnProperties.dataHeadBackColour)) {
                    //Draw Background
                    e.PaintBackground(e.CellBounds, false);

                    //Draw Text Default
                    e.Paint(e.CellBounds, DataGridViewPaintParts.ContentForeground);

                    //Draw Text Custom
                    //TextRenderer.DrawText(e.Graphics, string.Format("{0}", e.FormattedValue),
                    //    e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor,
                    //    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    //Draw Sort Icon
                    if (grid.SortedColumn?.Index == e.ColumnIndex) {
                        var sortIcon = grid.SortOrder == SortOrder.Ascending ? "▼" : "▲";

                        //Or draw an icon here.
                        TextRenderer.DrawText(e.Graphics, sortIcon,
                            e.CellStyle.Font, e.CellBounds, sortIconColor,
                            TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
                    }

                    //Prevent Default Paint
                    e.Handled = true;
                }
            }
        }
    }

    public class ComboBoxColumn : DataGridViewComboBoxColumn {
        public DataTable ComboData { get; set; }
        public string Key { get; set; }
        public string KeyValue { get; set; } = "";
        public ComboBoxColumn() {
            DisplayMember = "Key";
            ValueMember = "Value";
        }
        public void Create() {
            DataRow comboRow;

            // add other types if required
            if (ValueType.Equals(typeof(string))) {
                Items.Add(new KeyValuePair<string, string>("·· No selection ··",  "") );
                for (int i = 0; i < ComboData.Rows.Count; i++) {
                    comboRow = ComboData.Rows[i];
                    Items.Add(new KeyValuePair<string, string>(comboRow.Field<string>(Key), comboRow.Field<string>(KeyValue) ) );
                }
            } else if (ValueType.Equals(typeof(int))) {
                Items.Add(new KeyValuePair<string, int>("·· No selection ··", 0));
                for (int i = 0; i < ComboData.Rows.Count; i++) {
                    comboRow = ComboData.Rows[i];
                    Items.Add(new KeyValuePair<string, int>(comboRow.Field<string>(Key), comboRow.Field<int>(KeyValue) ) );
                }
            }
        }
    }

    /// <summary>
    /// Hosts a collection of DataGridViewDisableButtonCell objects.<br />
    /// This ButtonColumn allows buttons to be disabled.
    /// </summary>
    public class ButtonColumn : DataGridViewButtonColumn {
        public ButtonColumn() {
            this.CellTemplate = new DataGridViewDisableButtonCell();
            UseColumnTextForButtonValue = true;
            AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
    }

    public class DataGridViewDisableButtonCell : DataGridViewButtonCell {
        private bool enabledValue;
        public bool Enabled {
            get {
                return enabledValue;
            }
            set {
                enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone() {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell() {
            this.enabledValue = true;
        }

        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates elementState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts) {


            // The button cell is disabled, so paint the border,
            // background, and disabled button for the cell.
            if (!this.enabledValue) {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background) {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }
                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) == DataGridViewPaintParts.Border) {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment = this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text.
                if (this.FormattedValue is String) {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        new Font("Calibri", 12F),
                        buttonArea, SystemColors.GrayText);
                }
            } else {
                // The button cell is enabled, so let the base class
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
            
        }
    }
}
