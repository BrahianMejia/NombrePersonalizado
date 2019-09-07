using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NombrePersonalizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblnombre.Visible = false;
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            lblnombre.Text = nombre;
            lblnombre.Font = new System.Drawing.Font(label1.Font, FontStyle.Bold);
            lblnombre.ForeColor = Color.Red;
            lblnombre.BorderStyle = BorderStyle.FixedSingle;
            lblnombre.Visible = true;
        }
    }
}
