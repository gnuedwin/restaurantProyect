using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ING
{
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirmesasform(object mesasform)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form nuevo = mesasform as Form;
            nuevo.TopLevel = false;
            nuevo.Dock = DockStyle.Fill;
            this.panel.Controls.Add(nuevo);
            this.panel.Tag = nuevo;
            nuevo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirmesasform(new mesasform());
        }

        private void articulos_bt_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        private void abrirbebidasform(object bebidas)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form nuevo = bebidas as Form;
            nuevo.TopLevel = false;
            nuevo.Dock = DockStyle.Fill;
            this.panel.Controls.Add(nuevo);
            this.panel.Tag = nuevo;
            nuevo.Show();
        }

      
            private void button1_Click_1(object sender, EventArgs e)
        {
            abrirbebidasform(new bebidas());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            login abrir = new login();
            abrir.Show();
        }
    }
}
