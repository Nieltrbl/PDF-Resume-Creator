using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PDFResumeCreator
{
    public partial class PDFResumeCreator : Form
    {
        public PDFResumeCreator()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "cmd.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = @"/c resume export resume.pdf --theme flat";
            Process.Start(ps);

            msgboxSuccess m = new msgboxSuccess();
            m.Show();
        }
    }
}
