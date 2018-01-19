using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBroad_Click(object sender, EventArgs e)
        {

            string str = txtBroad.Text;
            IntPtr pSzToDeal = System.Runtime.InteropServices.Marshal.StringToCoTaskMemAuto(str);
            WeSpeak.DoSpeak(pSzToDeal, str.Length);

        }
    }
    public static class WeSpeak
    {
        [DllImport("Win32Speak.dll", EntryPoint = "DoSpeak", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int DoSpeak(IntPtr pSzToDeal, int nLength);
    }

}
