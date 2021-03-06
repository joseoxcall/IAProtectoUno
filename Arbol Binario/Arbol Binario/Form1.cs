﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dato = 0;
        int cont = 0;
        int bus = 0;
        Arbol_Binario mi_Arbol = new Arbol_Binario(null);
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void BtInsertar_Click(object sender, EventArgs e)
        {
            if (TxDato.Text == "") { MessageBox.Show("Debe Ingresar una valor"); }
            else { Dato = int.Parse(TxDato.Text);
            if (Dato <= 0 || Dato >= 100)
                MessageBox.Show("solo recibe valores desde 1 a 100", "Error");
            else
            {
                mi_Arbol.Insertar(Dato);
                TxDato.Clear();
                TxDato.Focus();
                cont++;
                Refresh();
                Refresh();
               
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     Random rnd = new Random();
            int numero;
            for (int at = 0; at <= 14;at++ ) {
                numero = rnd.Next(1, 100);
                TxDato.Text = Convert.ToString(numero);
                BtInsertar.PerformClick();
                TxDato.Text = "";
            }
            button1.Visible = false;                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bus = int.Parse(TxDato.Text);
            mi_Arbol.Buscar(bus);
        

            listBox1.Items.Clear();
        }
    }
}
