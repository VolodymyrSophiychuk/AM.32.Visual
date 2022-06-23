namespace Data.Forms
{
    public partial class GridForm : Form
    {
        bool isPreDeleteAval;
        public GridForm(bool isPreDeleteAval)
        {
            InitializeComponent();
            this.isPreDeleteAval = isPreDeleteAval;
        }

        private void DataGridRowPreDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (isPreDeleteAval)
                e.Cancel = true;
            else
                e.Cancel = false;
            foreach (DataGridViewCell item in (sender as DataGridView)
                .Rows[(sender as DataGridView).CurrentCell.RowIndex].Cells)
            {
                item.Style.BackColor = Color.Gray;
            }
            (sender as DataGridView)
                .Rows[(sender as DataGridView).CurrentCell.RowIndex].ReadOnly = true;
        }
    }
}
