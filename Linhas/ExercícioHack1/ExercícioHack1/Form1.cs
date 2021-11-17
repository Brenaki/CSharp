using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioHack1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                rTextName.LoadFile("Name.txt", RichTextBoxStreamType.RichText);
            }
            catch
            {
                rTextName.SaveFile("Name.txt", RichTextBoxStreamType.RichText);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntName_Click(object sender, EventArgs e)
        {
            nmrName = Convert.ToInt32(txtName.Text);
            WhereName();

        }

        int nmrName;

        void WhereName()
        {
            string dataName = rTextName.Text;
            string[] BreakData = dataName.Split('-');
            string nameSearch = BreakData[nmrName - 1];
            lblName.Text = nameSearch;
        }
    }
}
