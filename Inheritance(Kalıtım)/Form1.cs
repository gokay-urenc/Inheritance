using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Kalıtım_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Text";

            TextBox txt = new TextBox();
            txt.Text = "Text";

            Label lbl = new Label();
            lbl.Text = "Text";

            MyClass myc = new MyClass();
            myc.MyProperty = 7;
            myc.para = 23; // Sınıftan sınıfa özellik miras verme sayesinde eriştik.

            Deneme dnm = new Deneme();
            dnm.para = 10;
        }
    }
}
