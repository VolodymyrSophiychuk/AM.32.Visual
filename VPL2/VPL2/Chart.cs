using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VPL2
{
    public partial class VPL2 : Form
    {
        public VPL2()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            ResetConponents();
            Iterate();
        }
        private void Iterate()
        {
            if (IsReadyToIterate())
            {
                InitializeDGV(ReturnTabPointsCount());
                CallFunctionIterator(ReturnTabRange(), ReturnTabPointsCount(), ReturnCurrentMode());
                TransferExtremum(FindFunctionExtremum(ReturnTabPointsCount()));
                InitializeChart(ReturnTabRange(), ReturnTabPointsCount());
            }
        }
        private void Reload(object sender, EventArgs e)
        {
            IsCalculating(Lib.IndicatorState.Unready);
            Start();
            IsCalculating(Lib.IndicatorState.Ready);
        }
        private (short, short) ReturnTabRange()
        {
            return
                (
                    CheckInput(LeftRange),
                    CheckInput(RightRange)
                );
        }
        private short ReturnTabPointsCount()
        {
            return CheckInput(TabPoints);
        }
        private short CheckInput(object sender)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                try
                {
                    if ((sender as TextBox).Name == "LeftRange" || (sender as TextBox).Name == "RightRange")
                    {
                        if (ReturnCurrentMode() == Lib.ActiveMode.Fx && Convert.ToInt16((sender as TextBox).Text) < 0)
                            return 0;
                        return Convert.ToInt16((sender as TextBox).Text);
                    }
                    else
                        return Math.Abs(Convert.ToInt16((sender as TextBox).Text));
                }
                catch (FormatException)
                {
                    return 0;
                }
            }
            return 0;
        }
        private void CallFunctionIterator((short left, short right) range, short count, Lib.ActiveMode mode)
        {
            double value = range.left;
            double delta = Math.Round((double)(Math.Abs(range.left) + range.right) / (count - 1), 4);

            double innerCount = 0;

            for (short gridHeight = 0; gridHeight < ReturnGridHeight(); gridHeight += 2)
            {
                for (short gridWidth = 1; gridWidth < ReturnGridWidth(); gridWidth++)
                {
                    if (innerCount < count)
                    {
                        switch (mode)
                        {
                            case Lib.ActiveMode.Fx:
                                SetGridCellValue(gridHeight, gridWidth, Lib.Fx(value));
                                SetGridCellValue((short)(gridHeight + 1), gridWidth, value);
                                break;
                            case Lib.ActiveMode.Xt:
                                SetGridCellValue(gridHeight, gridWidth, Lib.Xt(value));
                                SetGridCellValue((short)(gridHeight + 1), gridWidth, value);
                                break;
                            case Lib.ActiveMode.Yt:
                                SetGridCellValue(gridHeight, gridWidth, Lib.Yt(value));
                                SetGridCellValue((short)(gridHeight + 1), gridWidth, value);
                                break;
                            case Lib.ActiveMode.Xy:
                                SetGridCellValue(gridHeight, gridWidth, Lib.Xy(value));
                                SetGridCellValue((short)(gridHeight + 1), gridWidth, value);
                                break;
                            case Lib.ActiveMode.Yx:
                                SetGridCellValue(gridHeight, gridWidth, Lib.Yx(value));
                                SetGridCellValue((short)(gridHeight + 1), gridWidth, value);
                                break;
                        }
                        value = Math.Round(value + delta, 4);
                    }
                    innerCount++;
                }
            }
        }
        private (double, double) FindFunctionExtremum(short count)
        {
            (double min, double max) extremum = (Double.MaxValue, Double.MinValue);

            for (short gridHeight = 0; gridHeight < ReturnGridHeight(); gridHeight += 2)
            {
                for (short gridWidth = 1; gridWidth < ReturnGridWidth(); gridWidth++)
                {
                    if (IsGridCellValueNull(gridHeight, gridWidth))
                        continue;
                    extremum.min = Lib.IsMin(extremum.min, ReturnGridCellValue(gridHeight, gridWidth));
                    extremum.max = Lib.IsMax(extremum.max, ReturnGridCellValue(gridHeight, gridWidth));
                }
            }

            return extremum;
        }
        private void ExtractGridValuesToFile(object sender, EventArgs e)
        {
            using (StreamWriter writer = File.CreateText(@"Output.txt"))
            {
                writer.WriteLine("Y\tX");
                for (short gridHeight = 0; gridHeight < ReturnGridHeight(); gridHeight += 2)
                {
                    for (short gridWidth = 1; gridWidth < ReturnGridWidth(); gridWidth++)
                    {
                        if (IsGridCellValueNull(gridHeight, gridWidth))
                            continue;
                        writer.Write(ReturnGridCellValue(gridHeight, gridWidth));
                        writer.Write('\t');
                        writer.WriteLine(ReturnGridCellValue((short)(gridHeight + 1), gridWidth));
                    }
                }
            }
        }

        private void VPL2_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog()
            {
                Filter = "XML (*.xml)|*.xml",
                FileName = "config",
                InitialDirectory = @"D:\WorkFolder\VS\VP\VPL2\VPL2\bin\Debug"
            };

            using (dlg)
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(dlg.OpenFile()))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                        xmlSerializer.Serialize(writer, new Config()
                        {
                            LeftRange = Convert.ToInt32(LeftRange.Text),
                            RightRange = Convert.ToInt32(RightRange.Text),
                            PointAmount = Convert.ToInt32(TabPoints.Text),
                            ActiveMode = ReturnCurrentMode()
                        });
                    }
                }
            }
        }

        private void VPL2_Load(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                Filter = "XML (*.xml)|*.xml",
                FileName = "config",
                InitialDirectory = @"D:\WorkFolder\VS\VP\VPL2\VPL2\bin\Debug"
            };

            using (dlg)
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(dlg.OpenFile()))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Config));
                        Config config = new Config(xmlSerializer.Deserialize(reader));

                        LeftRange.Text = config.LeftRange.ToString();
                        RightRange.Text = config.RightRange.ToString();
                        TabPoints.Text = config.PointAmount.ToString();
                        SetCurrentMode(config.ActiveMode);
                    }
                }
            }
        }
    }
}