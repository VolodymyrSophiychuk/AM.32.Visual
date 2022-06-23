using System.Text.RegularExpressions;

namespace VPL1
{
    public partial class Calculator : Form
    {
        private TextBox left;
        private TextBox right;
        private TextBox output;
        private TableLayoutPanel grid;
        private RadioButton permutation;
        private RadioButton placing;
        private RadioButton compound;
        private enum Ops {
            PERM,
            PLAC,
            COMP
        };

        private Ops current = Ops.PERM;
        private bool leftActive = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Init_TextBox();
            Init_Grid();
            Init_RadioButton();
        }
        private void Init_TextBox()
        {
            left = new TextBox();
            right = new TextBox();
            output = new TextBox();

            left.Location = new Point(100, 10);
            left.Size = new Size(150, 20);
            right.Location = new Point(350, 10);
            right.Size = new Size(150, 20);
            if (current == Ops.PERM)
                right.Enabled = false;
            output.Location = new Point(50, 650);
            output.Size = new Size(500, 20);
            output.ReadOnly = true;

            Controls.Add(left);
            Controls.Add(right);
            Controls.Add(output);
        }
        private void Init_RadioButton()
        {
            permutation = new RadioButton();
            placing = new RadioButton();
            compound = new RadioButton();

            permutation.Location = new Point(50, 680);
            permutation.Size = new Size(200, 40);
            permutation.Text = "Permutation";
            permutation.Checked = true;
            permutation.CheckedChanged += RadioButton_CheckedChanged;
            permutation.Name = "Perm";
            placing.Location = new Point(50, 720);
            placing.Size = new Size(200, 40);
            placing.Text = "Placing";
            placing.CheckedChanged += RadioButton_CheckedChanged;
            placing.Name = "Plac";
            compound.Location = new Point(50, 760);
            compound.Size = new Size(200, 40);
            compound.Text = "Compound";
            compound.CheckedChanged += RadioButton_CheckedChanged;
            compound.Name = "Comp";

            Controls.Add(permutation);
            Controls.Add(placing);
            Controls.Add(compound);
        }
        private void Init_Grid()
        {
            grid = new TableLayoutPanel();

            grid.Size = new Size(600, 600);
            grid.Location = new Point(0, 50);
            grid.RowCount = 4;
            grid.ColumnCount = 3;

            for (sbyte outer = 0; outer < grid.RowCount; outer++)
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            for (sbyte outer = 0; outer < grid.ColumnCount; outer++)
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            for (sbyte outer = 7; outer < 10; outer++)
            {
                Init_GridButtons(outer.ToString());
            }
            for (sbyte outer = 4; outer < 7; outer++)
            {
                Init_GridButtons(outer.ToString());
            }
            for (sbyte outer = 1; outer < 4; outer++)
            {
                Init_GridButtons(outer.ToString());
            }
            Init_GridButtons("0");
            Init_GridButtons("Clear");
            Init_GridButtons("Enter");

            Controls.Add(grid);
        }
        private void Init_GridButtons(string value)
        {
            Button button = new Button();

            button.Click += Button_Click;
            button.Dock = DockStyle.Fill;
            button.Text = value;

            grid.Controls.Add(button);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch((sender as Button).Text, @"\d"))
            {
                if (leftActive)
                    left.Text += (sender as Button).Text;
                else
                    right.Text += (sender as Button).Text;
            }
            else if (Regex.IsMatch((sender as Button).Text, @"Clear"))
            {
                ClearInputs();
                leftActive = true;
            }
            else if (Regex.IsMatch((sender as Button).Text, @"Enter"))
            {
                if (Regex.IsMatch(left.Text, @"\d") && Regex.IsMatch(left.Text, @"\d"))
                {
                    if ((!(left.Text == "") && !(right.Text == "")) || (!(left.Text == "") && current == Ops.PERM))
                    {
                        Calc();
                        ClearInputs(false);
                        leftActive = true;
                    }
                    else if (!(left.Text == ""))
                    {
                        leftActive = false;
                    }
                }
                else
                {
                    output.Text = "Only numbers";
                    ClearInputs(false);
                }
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Name == "Perm")
                current = Ops.PERM;
            if ((sender as RadioButton).Name == "Plac")
                current = Ops.PLAC;
            if ((sender as RadioButton).Name == "Comp")
                current = Ops.COMP;
            if (current != Ops.PERM)
                right.Enabled = true;
            else
                right.Enabled = false;
            ClearInputs();
        }
        private void Calc()
        {
            switch (current)
            {
                case Ops.PERM:
                    {
                        output.Text = Factorial(Convert.ToSByte(left.Text)).ToString();
                        break;
                    }
                case Ops.PLAC:
                    {
                        if (Convert.ToSByte(left.Text) > Convert.ToSByte(right.Text))
                        {
                            output.Text = "NAN";
                            break;
                        }
                        output.Text = (Factorial(Convert.ToSByte(right.Text)) /
                            Factorial((sbyte)(Convert.ToSByte(right.Text) - Convert.ToSByte(left.Text)))).ToString();
                        break;
                    }
                case Ops.COMP:
                    {
                        if (Convert.ToSByte(left.Text) > Convert.ToSByte(right.Text))
                        {
                            output.Text = "NAN";
                            break;
                        }
                        output.Text = (Factorial(Convert.ToSByte(right.Text)) /
                            (Factorial((sbyte)(Convert.ToSByte(right.Text) - Convert.ToSByte(left.Text))) *
                            Factorial(Convert.ToSByte(left.Text)))).ToString();
                        break;
                    }
            }
        }
        private long Factorial(sbyte limit)
        {
            long result = 1;
            for (sbyte trigger = 2; trigger <= limit; trigger++)
            {
                result *= trigger;
            }
            return result;
        }
        private void ClearInputs(bool includeOutput = true)
        {
            left.Text = "";
            right.Text = "";
            if (includeOutput)
                output.Text = "";
        }
    }
}