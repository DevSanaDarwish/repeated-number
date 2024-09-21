using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepeatedNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random _rnd = new Random();

        private byte _counter = 0;
       
        private void CreateLabel(System.Windows.Forms.Label lbl1)
        {
            lbl1.ForeColor = Color.White;
            lbl1.BackColor = Color.Black;
            lbl1.Size = new System.Drawing.Size(68, 54);
            lbl1.Font = new Font("Tahoma", 22, FontStyle.Regular);
            lbl1.Text = _rnd.Next(0, 10).ToString();
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            lbl1.BorderStyle = BorderStyle.FixedSingle;

            flpRandomLabels2.FlowDirection = FlowDirection.LeftToRight;
            
            flpRandomLabels2.Controls.Add(lbl1);
        }

        private void AddLabelsInflp()
        {
            for (byte i = 0; i < 25; i++)
            {
                System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();

                CreateLabel(lbl1);

                if (lbl1.Text == lblNumber.Text)
                    _counter++;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            _counter = 0;
            txtResult.Text = "";
            lblResult.Visible = false;
            flpRandomLabels2.Controls.Clear();
  
            byte RandomNumber = Convert.ToByte(_rnd.Next(0, 10));

            lblNumber.Text = RandomNumber.ToString();

            AddLabelsInflp();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblResult.Visible = true;

            if (txtResult.Text == _counter.ToString())
            {
                lblResult.Text = "Correct :-)";
                lblResult.ForeColor = Color.LimeGreen;
            }

            else
            {
                lblResult.Text = "Wrong :-(";
                lblResult.ForeColor = Color.Red;
            }

        }
    }
}
