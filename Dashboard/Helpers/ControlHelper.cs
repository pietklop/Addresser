using System.Windows.Forms;

namespace Dashboard.Helpers
{
    public static class ControlHelper
    {
        public static double ScaleFactor(this Control control) => control.DeviceDpi / 96.0;
    }
}