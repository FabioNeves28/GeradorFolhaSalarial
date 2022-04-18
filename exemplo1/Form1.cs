using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double vh, ht, sb, inss, bs, sl;

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgsair_Click(imgsair, e);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Visible == false)
            {
                dateTimePicker1.Visible = true;
            }
            else
            {
                dateTimePicker1.Visible = false;
            }
        }

        private void barraDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void txtht_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8
           || e.KeyChar == 46 ? false : true;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtvh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8
           || e.KeyChar == 46 ? false : true;
        }

        private void imgfoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imgfoto.Load(openFileDialog1.FileName);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar) || e.KeyChar == 8
          || e.KeyChar == 46 ? false : true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusStrip1.Items[0].Text = "Data:" + DateTime.Now.ToString("dd/MM/yyyy");
            statusStrip1.Items[1].Text = "Hora:" + DateTime.Now.ToString("HH:mm:ss");
            statusStrip1.Items[2].Text = "Programador: Fábio Alves Neves" ;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void calcularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            imgcalcular_Click(imgcalcular, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void limparToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            imglimpar_Click(imglimpar, e);
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void imgsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar", "Confirme",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imglimpar_Click(imglimpar, e);
        }

        private void imglimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtvh.Clear();
            txtht.Clear();
            txtsb.Clear();
            txtinss.Clear();
            txtbs.Clear();
            txtsl.Clear();
            cbocargo.Text = "selecione ...";
            imgfoto.Image = Properties.Resources.download;
            txtcodigo.Focus();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgcalcular_Click(imgcalcular, e);
        }

        private void imgcalcular_Click(object sender, EventArgs e)
        {
            if (txtht.Text == "" || txtvh.Text == "")
            {
                MessageBox.Show("Favor, verifique os valores da Horas Trabalhadas e/ou Valor por Hora",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcodigo.Focus();
            }
            else
            {
                vh = Convert.ToDouble(txtvh.Text);
                ht = Convert.ToDouble(txtht.Text);
                sb = vh * ht;
                txtsb.Text = sb.ToString("###,##0.00");
                inss = sb * 11 / 100;
                txtinss.Text = inss.ToString("###,##0.00");
                if (cbocargo.Text == "Gerente de T.I")
                {
                    bs = 1200;
                }
                txtbs.Text = bs.ToString("###,##0.00");
                sl = sb - inss + bs;
                txtsl.Text = sl.ToString("###,##0.00");
            }
        }
    }
}
