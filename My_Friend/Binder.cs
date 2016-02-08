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
namespace My_Friend
{
    public partial class Binder : Form
    {
        String path = ""; bool fol;
        public Binder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fol = true;
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            path = Pathbox.Text.ToString();
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bid(Voicebox.Text.ToString(),Pathbox.Text.ToString());
            
        }
        void bid(String bind,String path)
        {
            String[] resultstring = {bind,path};
            if (fol== true)
            {
                File.WriteAllLines("file.txt", resultstring);
            }
            My_Friend obj = new My_Friend();
            obj.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fol = true;
            panel1.Visible = false;
            panel2.Visible = true;
        }
    }
}
