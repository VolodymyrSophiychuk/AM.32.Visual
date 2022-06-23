namespace VPL2
{
    partial class VPL2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.Panel = new System.Windows.Forms.Panel();
            this.Output = new System.Windows.Forms.Button();
            this.TX5 = new System.Windows.Forms.TextBox();
            this.L5 = new System.Windows.Forms.Label();
            this.TX4 = new System.Windows.Forms.TextBox();
            this.L4 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.RB5 = new System.Windows.Forms.RadioButton();
            this.Rb4 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.Indicator = new System.Windows.Forms.TextBox();
            this.TabPoints = new System.Windows.Forms.TextBox();
            this.RightRange = new System.Windows.Forms.TextBox();
            this.LeftRange = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            legend2.Name = "Main";
            legend2.Title = "Function";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(0, 0);
            this.Chart.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(1776, 736);
            this.Chart.TabIndex = 0;
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(0, 739);
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 72;
            this.Grid.RowTemplate.Height = 31;
            this.Grid.Size = new System.Drawing.Size(2077, 535);
            this.Grid.TabIndex = 1;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.Output);
            this.Panel.Controls.Add(this.TX5);
            this.Panel.Controls.Add(this.L5);
            this.Panel.Controls.Add(this.TX4);
            this.Panel.Controls.Add(this.L4);
            this.Panel.Controls.Add(this.L3);
            this.Panel.Controls.Add(this.RB5);
            this.Panel.Controls.Add(this.Rb4);
            this.Panel.Controls.Add(this.RB3);
            this.Panel.Controls.Add(this.RB2);
            this.Panel.Controls.Add(this.RB1);
            this.Panel.Controls.Add(this.L2);
            this.Panel.Controls.Add(this.L1);
            this.Panel.Controls.Add(this.Indicator);
            this.Panel.Controls.Add(this.TabPoints);
            this.Panel.Controls.Add(this.RightRange);
            this.Panel.Controls.Add(this.LeftRange);
            this.Panel.Location = new System.Drawing.Point(1776, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(301, 736);
            this.Panel.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(76, 488);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(150, 50);
            this.Output.TabIndex = 16;
            this.Output.Text = "Write to file";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.ExtractGridValuesToFile);
            // 
            // TX5
            // 
            this.TX5.Enabled = false;
            this.TX5.Location = new System.Drawing.Point(76, 452);
            this.TX5.Name = "TX5";
            this.TX5.Size = new System.Drawing.Size(150, 29);
            this.TX5.TabIndex = 15;
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Location = new System.Drawing.Point(71, 424);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(130, 25);
            this.L5.TabIndex = 14;
            this.L5.Text = "Function Max";
            // 
            // TX4
            // 
            this.TX4.Enabled = false;
            this.TX4.Location = new System.Drawing.Point(76, 392);
            this.TX4.Name = "TX4";
            this.TX4.Size = new System.Drawing.Size(150, 29);
            this.TX4.TabIndex = 13;
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Location = new System.Drawing.Point(71, 364);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(124, 25);
            this.L4.TabIndex = 12;
            this.L4.Text = "Function Min";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Location = new System.Drawing.Point(71, 164);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(97, 25);
            this.L3.TabIndex = 11;
            this.L3.Text = "Functions";
            // 
            // RB5
            // 
            this.RB5.AutoSize = true;
            this.RB5.Location = new System.Drawing.Point(76, 332);
            this.RB5.Name = "RB5";
            this.RB5.Size = new System.Drawing.Size(71, 29);
            this.RB5.TabIndex = 10;
            this.RB5.Text = "y(x)";
            this.RB5.UseVisualStyleBackColor = true;
            this.RB5.Click += new System.EventHandler(this.Reload);
            // 
            // Rb4
            // 
            this.Rb4.AutoSize = true;
            this.Rb4.Location = new System.Drawing.Point(76, 297);
            this.Rb4.Name = "Rb4";
            this.Rb4.Size = new System.Drawing.Size(71, 29);
            this.Rb4.TabIndex = 9;
            this.Rb4.Text = "x(y)";
            this.Rb4.UseVisualStyleBackColor = true;
            this.Rb4.Click += new System.EventHandler(this.Reload);
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(76, 262);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(66, 29);
            this.RB3.TabIndex = 8;
            this.RB3.Text = "y(t)";
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.Click += new System.EventHandler(this.Reload);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(76, 227);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(66, 29);
            this.RB2.TabIndex = 7;
            this.RB2.Text = "x(t)";
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.Click += new System.EventHandler(this.Reload);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Location = new System.Drawing.Point(76, 192);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(66, 29);
            this.RB1.TabIndex = 6;
            this.RB1.TabStop = true;
            this.RB1.Text = "f(x)";
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.Click += new System.EventHandler(this.Reload);
            // 
            // L2
            // 
            this.L2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(71, 104);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(159, 25);
            this.L2.TabIndex = 5;
            this.L2.Text = "Number of points";
            // 
            // L1
            // 
            this.L1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(71, 9);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(163, 25);
            this.L1.TabIndex = 4;
            this.L1.Text = "Tab from x1 to x2";
            // 
            // Indicator
            // 
            this.Indicator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Indicator.Location = new System.Drawing.Point(108, 704);
            this.Indicator.Name = "Indicator";
            this.Indicator.ReadOnly = true;
            this.Indicator.Size = new System.Drawing.Size(100, 29);
            this.Indicator.TabIndex = 3;
            this.Indicator.Text = "Up to date";
            // 
            // TabPoints
            // 
            this.TabPoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabPoints.Location = new System.Drawing.Point(76, 132);
            this.TabPoints.Name = "TabPoints";
            this.TabPoints.Size = new System.Drawing.Size(150, 29);
            this.TabPoints.TabIndex = 2;
            this.TabPoints.TextChanged += new System.EventHandler(this.Reload);
            // 
            // RightRange
            // 
            this.RightRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RightRange.Location = new System.Drawing.Point(76, 72);
            this.RightRange.Name = "RightRange";
            this.RightRange.Size = new System.Drawing.Size(150, 29);
            this.RightRange.TabIndex = 1;
            this.RightRange.TextChanged += new System.EventHandler(this.Reload);
            // 
            // LeftRange
            // 
            this.LeftRange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LeftRange.Location = new System.Drawing.Point(76, 37);
            this.LeftRange.Name = "LeftRange";
            this.LeftRange.Size = new System.Drawing.Size(150, 29);
            this.LeftRange.TabIndex = 0;
            this.LeftRange.TextChanged += new System.EventHandler(this.Reload);
            // 
            // VPL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1336);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Chart);
            this.Name = "VPL2";
            this.Text = "VPL2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VPL2_FormClosing);
            this.Load += new System.EventHandler(this.VPL2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components design code

        private void InitializeChart((short left, short right) range, short count)
        {
            InitializeChartArea(range);
            InitializeChartSeries();

            short currentRow = 0;
            short currentCell = 0;
            for (short trigger = 0; trigger < count; trigger++)
            {
                if (currentCell + 1 > ReturnGridRowCellAmount() - 1)
                {
                    currentRow += 2;
                    currentCell = 0;
                }
                if (ReturnGridCellValue(currentRow, ++currentCell).ToString() == "∞")
                {
                    continue;
                }
                Chart.Series[0].Points.AddXY(ReturnGridCellValue(++currentRow, currentCell), ReturnGridCellValue(--currentRow, currentCell));
            }
        }
        private void InitializeChartArea((short left, short right) range)
        {
            ChartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();

            ChartArea.Name = "Main";
            ChartArea.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            ChartArea.AxisX.Minimum = range.left;
            ChartArea.AxisX.Maximum = range.right;
            ChartArea.AxisX.Interval = (System.Math.Abs(range.left) + range.right) / 10;
            ChartArea.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            ChartArea.AxisY.Minimum = System.Math.Floor(System.Convert.ToDouble(TX4.Text));
            ChartArea.AxisY.Maximum = IsExtremumNull() ? 10 : System.Math.Ceiling(System.Convert.ToDouble(TX5.Text));
            ChartArea.AxisY.Interval = (ChartArea.AxisY.Minimum + ChartArea.AxisY.Maximum) / 10;
            SetChartAxisNames(ReturnAxisNames(ReturnCurrentMode()));

            Chart.ChartAreas.Add(ChartArea);
        }
        private void InitializeChartSeries()
        {
            Series = new System.Windows.Forms.DataVisualization.Charting.Series();

            Series.Name = SetSeriesName(ReturnCurrentMode());
            Series.ChartArea = "Main";
            Series.Legend = "Main";
            Series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Chart.Series.Add(Series);
        }
        private void InitializeDGV(short count)
        {
            InitializeDGVColumns();
            InitializeDGVRows(count);
            SetGridAxisNames(ReturnAxisNames(ReturnCurrentMode()));
        }
        private void InitializeDGVColumns()
        {
            Grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn());
            Grid.Rows.Add(new System.Windows.Forms.DataGridViewRow());
            Grid.Rows.Add(new System.Windows.Forms.DataGridViewRow());
            Grid.Columns[0].HeaderText = "Axis";
            Grid.Columns[0].Name = "Axis";
            Grid.Rows[0].Cells[0].Style.BackColor = System.Drawing.Color.Green;
            for (short trigger = 1; trigger < ReturnGridRowCellAmount(); trigger++)
            {
                Grid.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn());
                Grid.Columns[Grid.Columns.Count - 1].HeaderText = "P" + trigger;
                Grid.Columns[Grid.Columns.Count - 1].Name = "P" + trigger;
            }
        }
        private void InitializeDGVRows(short count)
        {
            for (short trigger = 0; trigger < count / (ReturnGridRowCellAmount() - 1); trigger++)
            {
                Grid.Rows.Add(new System.Windows.Forms.DataGridViewRow());
                Grid.Rows[Grid.Rows.Count - 2].Cells[0].Style.BackColor = System.Drawing.Color.Green;
                Grid.Rows.Add(new System.Windows.Forms.DataGridViewRow());
            }
        }
        private bool IsReadyToIterate()
        {
            if (LeftRange.Text != "" && RightRange.Text != "" && TabPoints.Text != "")
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(LeftRange.Text, @"(\d+|-\d+)"))
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(RightRange.Text, @"(\d+|-\d+)"))
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(TabPoints.Text, @"[(-|0-1)][\d+]"))
                        {
                            if (System.Convert.ToInt16(LeftRange.Text) < System.Convert.ToInt16(RightRange.Text))
                                return true;
                        }
                    }
                }
            }
            return false;
        }
        private bool IsExtremumNull()
        {
            return TX5.Text == "0" || TX5.Text == "∞" || TX4.Text == "0" ? true : false;
        }
        private (string, string) ReturnAxisNames(Lib.ActiveMode mode)
        {
            switch (mode)
            {
                case Lib.ActiveMode.Fx:
                    return ("Y", "X");
                case Lib.ActiveMode.Xt:
                    return ("X", "T");
                case Lib.ActiveMode.Yt:
                    return ("Y", "T");
                case Lib.ActiveMode.Xy:
                    return ("X", "Y");
                case Lib.ActiveMode.Yx:
                    return ("Y", "X");
                default:
                    return ("F(var)", "var");
            }
        }
        private short ReturnGridRowCellAmount()
        {
            return (short)((Width / 100) - 1);
        }
        private short ReturnGridHeight()
        {
            return (short)(Grid.Rows.Count - 1);
        }
        private short ReturnGridWidth()
        {
            return (short)Grid.Columns.Count;
        }
        private double ReturnGridCellValue(short rowId, short columnId)
        {
            return (double)Grid.Rows[rowId].Cells[columnId].Value;
        }
        private bool IsGridCellValueNull(short rowId, short columnId)
        {
            return Grid.Rows[rowId].Cells[columnId].Value == null ? true : false;
        }
        private void TransferExtremum((double min, double max) extremum)
        {
            TX4.Text = extremum.min.ToString();
            TX5.Text = extremum.max.ToString();
        }
        private void ResetConponents()
        {
            Chart.ChartAreas.Clear();
            Chart.Series.Clear();
            Grid.Columns.Clear();
            Grid.Rows.Clear();
        }
        private void IsCalculating(Lib.IndicatorState status)
        {
            _ = status == 0 ? Indicator.Text = "Up to date" : Indicator.Text = "Calculation...";
            Indicator.Refresh();
        }
        private Lib.ActiveMode ReturnCurrentMode()
        {
            if (RB1.Checked)
                return Lib.ActiveMode.Fx;
            else if (RB2.Checked)
                return Lib.ActiveMode.Xt;
            else if (RB3.Checked)
                return Lib.ActiveMode.Yt;
            else if (Rb4.Checked)
                return Lib.ActiveMode.Xy;
            else if (RB5.Checked)
                return Lib.ActiveMode.Yx;
            return Lib.ActiveMode.Fx;
        }
        private void SetCurrentMode(Lib.ActiveMode mode)
        {
            if (mode == Lib.ActiveMode.Fx)
                RB1.Checked = true;
            if (mode == Lib.ActiveMode.Xt)
                RB2.Checked = true;
            if (mode == Lib.ActiveMode.Yt)
                RB3.Checked = true;
            if (mode == Lib.ActiveMode.Xy)
                Rb4.Checked = true;
            if (mode == Lib.ActiveMode.Yx)
                RB5.Checked = true;
        }
        private string SetSeriesName(Lib.ActiveMode mode)
        {
            switch (mode)
            {
                case Lib.ActiveMode.Fx:
                    return "y = x ^ (1 / x)";
                case Lib.ActiveMode.Xt:
                    return "x = (t + 1)^2 / 4";
                case Lib.ActiveMode.Yt:
                    return "y = (t - 1)^2 / 4";
                case Lib.ActiveMode.Xy:
                    return "x = (y - 1)^2 / (y + 1)^2";
                case Lib.ActiveMode.Yx:
                    return "y = (x + 1)^2 / (x - 1)^2";
            }
            return "";
        }
        private void SetChartAxisNames((string y, string x) axis)
        {
            ChartArea.AxisY.Title = axis.y;
            ChartArea.AxisX.Title = axis.x;
        }
        private void SetGridAxisNames((string y, string x) axis)
        {
            for (short trigger = 0; trigger < ReturnGridHeight(); trigger++)
            {
                Grid.Rows[trigger].Cells[0].Value = axis.y;
                Grid.Rows[++trigger].Cells[0].Value = axis.x;
            }
        }
        private void SetGridCellValue(short rowId, short columnId, double value)
        {
            Grid.Rows[rowId].Cells[columnId].Value = value;
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox RightRange;
        private System.Windows.Forms.TextBox LeftRange;
        private System.Windows.Forms.TextBox TabPoints;
        private System.Windows.Forms.TextBox Indicator;

        private System.Windows.Forms.DataVisualization.Charting.ChartArea ChartArea;
        private System.Windows.Forms.DataVisualization.Charting.Series Series;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton Rb4;
        private System.Windows.Forms.RadioButton RB5;
        private System.Windows.Forms.TextBox TX5;
        private System.Windows.Forms.Label L5;
        private System.Windows.Forms.TextBox TX4;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.Button Output;
    }
}

