using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Digitacao {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            txtSenha.Enabled = false;
            txtDigitar.Enabled = false;
        }

        int TamanhoDaSenha;      

        private void ValidaTamanhoSenha() {

            //if (!string.IsNullOrWhiteSpace(txtTamanhoSenha.Text)) {
            //    TamanhoDaSenha = Convert.ToInt32(txtTamanhoSenha.Text);
            //    if (TamanhoDaSenha > 99) {
            //        TamanhoDaSenha = 99;
            //        txtTamanhoSenha.Text = "99";
            //    }
            //    if (TamanhoDaSenha < 8) {
            //        TamanhoDaSenha = 8;
            //        txtTamanhoSenha.Text = "8";
            //    }
            //}
            //else {

            //TamanhoDaSenha = '6';

            TamanhoDaSenha = Convert.ToInt32(txtTamanhoSenha.Text);

            txtDigitar.Enabled = true;
        }

        private void geracaoPalavra() {

            ValidaTamanhoSenha();

            if (txtDigitar.Text == txtSenha.Text) {
                txtDigitar.Text = "";
                ValidaTamanhoSenha();
                string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyz";
                char[] chars = new char[TamanhoDaSenha];

                Random rd = new Random();

                for (int i = 0; i < TamanhoDaSenha; i++) {
                    chars[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
                }

                txtSenha.Text = new string(chars);
            }
        }


        private void TamanhoDaSenha_TextChanged(object sender, EventArgs e) {
            geracaoPalavra();

        }

        private void TxtFinalizar_Click(object sender, EventArgs e) {
            geracaoPalavra();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {
            geracaoPalavra();

        }

        private void TxtDigitar_TextChanged(object sender, EventArgs e) {
            geracaoPalavra();
        }


        private void TxtSenha_TextChanged(object sender, EventArgs e) {
            geracaoPalavra();
        }

        private void TxtDigitar_KeyDown(object sender, KeyEventArgs e) {
            geracaoPalavra();
        }

        private void TxtDigitar_KeyPress(object sender, KeyPressEventArgs e) {
            geracaoPalavra();
        }

        private void TxtFinalizar_MouseClick(object sender, MouseEventArgs e) {

            txtDigitar.Focus();
        }

        private void Timer1_Tick(object sender, EventArgs e) {

        }

        private void btnGerarSenha1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void txtTamanhoSenha_KeyPress(object sender, KeyPressEventArgs e) {
            geracaoPalavra();

        }
    }
}

