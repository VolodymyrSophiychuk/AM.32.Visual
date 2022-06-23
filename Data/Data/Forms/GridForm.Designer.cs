using Data.EF;
using Data.Templates;
using System.ComponentModel;

namespace Data.Forms
{
    partial class GridForm
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SampleGrid = new System.Windows.Forms.DataGridView();
            this.Sample = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.Town = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleGrid)).BeginInit();
            this.Sample.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 72;
            this.DataGrid.RowTemplate.Height = 37;
            this.DataGrid.Size = new System.Drawing.Size(1496, 508);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridRowPreDelete);
            // 
            // SampleGrid
            // 
            this.SampleGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SampleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SampleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SampleGrid.Location = new System.Drawing.Point(0, 508);
            this.SampleGrid.Margin = new System.Windows.Forms.Padding(0);
            this.SampleGrid.Name = "SampleGrid";
            this.SampleGrid.RowHeadersWidth = 72;
            this.SampleGrid.RowTemplate.Height = 37;
            this.SampleGrid.Size = new System.Drawing.Size(1496, 508);
            this.SampleGrid.TabIndex = 1;
            this.SampleGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridRowPreDelete);
            // 
            // Sample
            // 
            this.Sample.Controls.Add(this.label1);
            this.Sample.Controls.Add(this.Date);
            this.Sample.Controls.Add(this.Town);
            this.Sample.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sample.Location = new System.Drawing.Point(0, 916);
            this.Sample.Margin = new System.Windows.Forms.Padding(0);
            this.Sample.Name = "Sample";
            this.Sample.Size = new System.Drawing.Size(1496, 100);
            this.Sample.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter town and date for looking for samples(only XML)";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(1086, 32);
            this.Date.Margin = new System.Windows.Forms.Padding(0);
            this.Date.Name = "Date";
            this.Date.PlaceholderText = "1/1/2002";
            this.Date.Size = new System.Drawing.Size(400, 35);
            this.Date.TabIndex = 1;
            // 
            // Town
            // 
            this.Town.Location = new System.Drawing.Point(10, 32);
            this.Town.Margin = new System.Windows.Forms.Padding(0);
            this.Town.Name = "Town";
            this.Town.PlaceholderText = "Town";
            this.Town.Size = new System.Drawing.Size(400, 35);
            this.Town.TabIndex = 0;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 1016);
            this.Controls.Add(this.Sample);
            this.Controls.Add(this.SampleGrid);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GridForm";
            this.Text = "GridForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleGrid)).EndInit();
            this.Sample.ResumeLayout(false);
            this.Sample.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region DataGrid

        public void FillDataGrid<T>(List<T> data)
        {
            DataGrid.DataSource = new BindingList<T>(data)
            {
                AllowNew = true
            };
        }

        public List<JSONObject> ExtractDataAsJson()
        {
            List<JSONObject> data = new List<JSONObject>();

            for (int trigger = 0; trigger < DataGrid.Rows.Count - 1; trigger++)
            {
                data.Add(new JSONObject(DataGrid.Rows[trigger].Cells));
            }

            return data;
        }
        public List<XMLObject> ExtractDataAsXml()
        {
            List<XMLObject> data = new List<XMLObject>();

            for (int trigger = 0; trigger < DataGrid.Rows.Count - 1; trigger++)
            {
                data.Add(new XMLObject(DataGrid.Rows[trigger].Cells));
            }

            return data;
        }
        public List<Accounting> ExtractDataAsAccountingType()
        {
            List<Accounting> data = new List<Accounting>();

            for (int trigger = 0; trigger < DataGrid.Rows.Count - 1; trigger++)
            {
                data.Add(new Accounting(DataGrid.Rows[trigger].Cells));
            }

            return data;
        }
        public List<Transaction> ExtractDataAsTransactionType()
        {
            List<Transaction> data = new List<Transaction>();

            for (int trigger = 0; trigger < SampleGrid.Rows.Count - 1; trigger++)
            {
                data.Add(new Transaction(SampleGrid.Rows[trigger].Cells));
            }

            return data;
        }
        public List<int> DoesDataGridContainPreDeletedRows()
        {
            List<int> amount = new List<int>();

            for (int trigger = 0; trigger < DataGrid.Rows.Count - 1; trigger++)
            {
                if (DataGrid.Rows[trigger].ReadOnly)
                {
                    amount.Add((int)DataGrid.Rows[trigger].Cells[0].Value);
                }
            }
            amount.Sort();

            return amount;
        }

        public List<int> DoesSampleGridContainPreDeletedRows()
        {
            List<int> amount = new List<int>();

            for (int trigger = 0; trigger < SampleGrid.Rows.Count - 1; trigger++)
            {
                if (SampleGrid.Rows[trigger].ReadOnly)
                {
                    amount.Add(trigger + 1);
                }
            }
            amount.Sort();

            return amount;
        }

        #endregion

        #region SampleGrid

        public void FillSampleGrid<T>(List<T> names)
        {
            SampleGrid.DataSource = new BindingList<T>(names);
        }

        #endregion

        public (string town, DateTime date) ExtractSampleData()
        {
            return (Town.Text, DateTime.Parse(Date.Text == "" ? "1/1/0001" : Date.Text));
        }

        private DataGridView DataGrid;
        private DataGridView SampleGrid;
        private Panel Sample;
        private TextBox Date;
        private TextBox Town;
        private Label label1;
    }
}