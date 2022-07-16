using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PDFResumeCreator
{
    public partial class msgboxSuccess : Form
    {
        public msgboxSuccess()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string source = @"C:\Users\D'Aviador\source\repos\PDFResumeCreator\PDFResumeCreator\bin\Debug\resume.pdf";
            const string destination = @"C:\Users\D'Aviador\source\repos\PDFResumeCreator\PDFResumeCreator\bin\Debug\AVIADOR_DANIEL.pdf";

            try
            {
                File.Move(source, destination);
            }
            catch
            {

            }
            this.Hide();
        }
    }
}
