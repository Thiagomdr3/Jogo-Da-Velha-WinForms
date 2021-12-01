using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        int contador = 0;
        int placarX = 0;
        int placarO = 0;
        bool vezX = false;
        bool vezO = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXcomeca_Click(object sender, EventArgs e)
        {
            vezX = true;
            vezO = false;
            lblVez.Text = "X";

            botoesEnable();
        }

        private void botoesEnable()
        {

            bntCol1Linha1.Enabled = true;
            bntCol1Linha2.Enabled = true;
            bntCol1Linha3.Enabled = true;
            bntCol2Linha1.Enabled = true;
            bntCol2Linha2.Enabled = true;
            bntCol2Linha3.Enabled = true;
            bntCol3Linha1.Enabled = true;
            bntCol3Linha2.Enabled = true;
            bntCol3Linha3.Enabled = true;

            btnXcomeca.Enabled = false;
            btnOcomeca.Enabled = false;
        }

        private void btnOcomeca_Click(object sender, EventArgs e)
        {
            vezO = true;
            vezX = false;
            lblVez.Text = "O";
            botoesEnable();
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            lblPlacarO.Text = "_";
            lblPlacarX.Text = "_";
            Recomecar();

        }

        private void bnt_Click(object sender, EventArgs e)
        {
            contador++;
            Button btn = (Button)sender;
            btn.Text = lblVez.Text;
            btn.Enabled = false;

            if (vezX)
            {
                lblVez.Text = "O";

            }
            else
            {
                lblVez.Text = "X";
            }

            vezX = !vezX;

            verificarVencedor();
        }

        private void verificarVencedor()
        {
            if (bntCol1Linha1.Text == bntCol2Linha1.Text && bntCol3Linha1.Text == bntCol2Linha1.Text && bntCol1Linha1.Text != "")
            {
                lblVencedor.Text = bntCol1Linha1.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }
            else if(bntCol1Linha2.Text == bntCol2Linha2.Text && bntCol3Linha2.Text == bntCol1Linha2.Text && bntCol1Linha2.Text!="") 
            {
                lblVencedor.Text = bntCol1Linha2.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }else if(bntCol1Linha3.Text == bntCol2Linha3.Text && bntCol3Linha3.Text == bntCol1Linha3.Text && bntCol1Linha3.Text != "")
            {
                lblVencedor.Text = bntCol1Linha3.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }else if(bntCol1Linha1.Text == bntCol1Linha2.Text && bntCol1Linha3.Text == bntCol1Linha1.Text && bntCol1Linha1.Text != "")
            {
                lblVencedor.Text = bntCol1Linha1.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }else if(bntCol2Linha1.Text == bntCol2Linha2.Text && bntCol2Linha3.Text == bntCol2Linha1.Text && bntCol2Linha1.Text != "")
            {
                lblVencedor.Text = bntCol2Linha1.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }else if (bntCol3Linha1.Text == bntCol3Linha2.Text && bntCol3Linha3.Text == bntCol3Linha1.Text && bntCol3Linha1.Text != "")
            {
                lblVencedor.Text = bntCol3Linha1.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();                
            }else if (bntCol1Linha1.Text == bntCol2Linha2.Text && bntCol3Linha3.Text == bntCol1Linha1.Text && bntCol1Linha1.Text != "")
            {
                lblVencedor.Text = bntCol1Linha1.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }else if (bntCol3Linha1.Text == bntCol2Linha2.Text && bntCol1Linha3.Text == bntCol3Linha1.Text && bntCol3Linha1.Text != "")
            {
                lblVencedor.Text = bntCol3Linha1.Text;
                MessageBox.Show($"o vencedor foi {lblVencedor.Text}");
                AtualizarPlacar();
            }
            else if(contador >= 9)
            {
                MessageBox.Show("O jogo ficou empatado");
            }

        }

        public void AtualizarPlacar()
        {
            if (lblVencedor.Text == "X")
            {
                placarX++;
                lblPlacarX.Text = placarX.ToString();
            }
            else
            {
                placarO++;
                lblPlacarO.Text = placarO.ToString();
            }

            Recomecar();
            
        }

        public void Recomecar()
        {
            bntCol1Linha1.Enabled = false;
            bntCol1Linha2.Enabled = false;
            bntCol1Linha3.Enabled = false;
            bntCol2Linha1.Enabled = false;
            bntCol2Linha2.Enabled = false;
            bntCol2Linha3.Enabled = false;
            bntCol3Linha1.Enabled = false;
            bntCol3Linha2.Enabled = false;
            bntCol3Linha3.Enabled = false;

            bntCol1Linha2.Text = "";
            bntCol1Linha1.Text = "";
            bntCol1Linha3.Text = "";
            bntCol2Linha1.Text = "";
            bntCol2Linha2.Text = "";
            bntCol2Linha3.Text = "";
            bntCol3Linha1.Text = "";
            bntCol3Linha2.Text = "";
            bntCol3Linha3.Text = "";

            lblVez.Text = "_";
            lblVencedor.Text = "_";
            contador = 0;

            btnXcomeca.Enabled = true;
            btnOcomeca.Enabled = true;

            vezX = false;
            vezX = false;

        }
    }
}
