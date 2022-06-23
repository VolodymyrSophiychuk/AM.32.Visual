using System.ComponentModel;

namespace Radio
{
    partial class Radio
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Canvas = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tools = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1040, 822);
            this.Canvas.TabIndex = 0;
            this.Canvas.Click += new System.EventHandler(this.Canvas_Click);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseHover += new System.EventHandler(this.Canvas_MouseHover);
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.pointBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(1058, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 72;
            this.DataGrid.RowTemplate.Height = 37;
            this.DataGrid.Size = new System.Drawing.Size(406, 822);
            this.DataGrid.TabIndex = 1;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            // 
            // pointBindingSource
            // 
            this.pointBindingSource.DataSource = typeof(System.Drawing.Point);
            // 
            // Tools
            // 
            this.Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tools.Controls.Add(this.Start);
            this.Tools.Location = new System.Drawing.Point(12, 840);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(1452, 84);
            this.Tools.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1275, 22);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(131, 40);
            this.Start.TabIndex = 0;
            this.Start.Text = "button1";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 936);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Canvas);
            this.Name = "Radio";
            this.Text = "Radio";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
            this.Tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void FillGrid()
        {
            DataGrid.DataSource = new BindingList<Point>(stations);
        }

        private Panel Canvas;
        private DataGridView DataGrid;
        private Panel Tools;
        private DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private BindingSource pointBindingSource;
        private Button Start;
    }
}