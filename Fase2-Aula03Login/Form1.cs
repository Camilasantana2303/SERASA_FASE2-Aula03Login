﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario = txtUsuário.Text;
            senha = txtSenha.Text;

            if(usuario == "camila00" && senha=="2303")
            {
                MessageBox.Show("Você se conectou!");
                panelSaldo.Show();
            }
            else
            {
                MessageBox.Show("Está incorreto...");
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
