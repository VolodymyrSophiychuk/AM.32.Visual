namespace VPL2
{
    public static class Lib
    {
        public enum ActiveMode
        {
            Fx,
            Xt,
            Yt,
            Xy,
            Yx
        }
        public enum IndicatorState
        {
            Ready,
            Unready
        }

        #region Math extremum check functions

        public static double IsMin(double min, double value)
        {
            return value < min ? value : min;
        }
        public static double IsMax(double max, double value)
        {
            return value > max ? value : max;
        }

        #endregion

        #region Task functions

        public static double Fx(double value, byte precision = 4)
        {
            return System.Math.Round(System.Math.Pow(value, 1 / value), precision);
        }
        public static double Xt(double value, byte precision = 4)
        {
            return System.Math.Round(System.Math.Pow(value + 1, 2) / 4, precision);
        }
        public static double Yt(double value, byte precision = 4)
        {
            return System.Math.Round(System.Math.Pow(value - 1, 2) / 4, precision);
        }
        public static double Yx(double value, byte precision = 4)
        {
            return System.Math.Round(System.Math.Pow(value - 1, 2) / System.Math.Pow(value + 1, 2), precision);
        }
        public static double Xy(double value, byte precision = 4)
        {
            return System.Math.Round(System.Math.Pow(value + 1, 2) / System.Math.Pow(value - 1, 2), precision);
        }

        #endregion
    }

    public class Config
    {
        public int LeftRange { get; set; }
        public int RightRange { get; set; }
        public int PointAmount { get; set; }
        public Lib.ActiveMode ActiveMode { get; set; }

        public Config() { }
        public Config(object v)
        {
            LeftRange = (v as Config).LeftRange;
            RightRange = (v as Config).RightRange;
            PointAmount = (v as Config).PointAmount;
            ActiveMode = (v as Config).ActiveMode;
        }
    }
}
