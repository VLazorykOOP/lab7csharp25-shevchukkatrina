using System;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();  
            this.Hide();   
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();  
            this.Hide();   
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();  
            this.Hide();  
        }
    }
}
