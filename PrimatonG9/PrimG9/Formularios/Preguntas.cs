﻿using PrimG9.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimG9.Formularios
{
    public partial class Preguntas : Form
    {
        #region PROPIEDADES
        ClasePreguntas cp;
        CarrerasCBA ccba;
        int preguntaActual;
        private int A;
        private int B;
        private int C;
        private int D;
        public int Resp;
        private readonly Usuario user;
        #endregion
        public Preguntas(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        #region METODOS
        private void Preguntas_Load(object sender, EventArgs e)
        {
            cp = new ClasePreguntas();
            ccba = new CarrerasCBA();
            lblPreg.Text = cp.pregunta1[0];
            rbA.Text = cp.pregunta1[1];
            rbB.Text = cp.pregunta1[2];
            rbC.Text = cp.pregunta1[3];
            rbD.Text = cp.pregunta1[4];
            preguntaActual++;
        }
        private void BtnSig_Click(object sender, EventArgs e)
        {
            preguntaActual++;
            switch (preguntaActual)
            {
                case 1:
                    lblPreg.Text = cp.pregunta2[0];
                    rbA.Text = cp.pregunta2[1];
                    rbB.Text = cp.pregunta2[2];
                    rbC.Text = cp.pregunta2[3];
                    rbD.Text = cp.pregunta2[4];
                    break;
                case 2:
                    lblPreg.Text = cp.pregunta3[0];
                    rbA.Text = cp.pregunta3[1];
                    rbB.Text = cp.pregunta3[2];
                    rbC.Text = cp.pregunta3[3];
                    rbD.Text = cp.pregunta3[4];
                    break;
                case 3:
                    lblPreg.Text = cp.pregunta2[0];
                    rbA.Text = cp.pregunta4[1];
                    rbB.Text = cp.pregunta4[2];
                    rbC.Text = cp.pregunta4[3];
                    rbD.Text = cp.pregunta4[4];
                    break;
                case 4:
                    lblPreg.Text = cp.pregunta5[0];
                    rbA.Text = cp.pregunta5[1];
                    rbB.Text = cp.pregunta5[2];
                    rbC.Text = cp.pregunta5[3];
                    rbD.Text = cp.pregunta5[4];
                    break;
                case 5:
                    lblPreg.Text = cp.pregunta6[0];
                    rbA.Text = cp.pregunta6[1];
                    rbB.Text = cp.pregunta6[2];
                    rbC.Text = cp.pregunta6[3];
                    rbD.Text = cp.pregunta6[4];
                    break;
                case 6:
                    lblPreg.Text = cp.pregunta7[0];
                    rbA.Text = cp.pregunta7[1];
                    rbB.Text = cp.pregunta7[2];
                    rbC.Text = cp.pregunta7[3];
                    rbD.Text = cp.pregunta7[4];
                    break;
                case 7:
                    lblPreg.Text = cp.pregunta8[0];
                    rbA.Text = cp.pregunta8[1];
                    rbB.Text = cp.pregunta8[2];
                    rbC.Text = cp.pregunta8[3];
                    rbD.Text = cp.pregunta8[4];
                    break;
                case 8:
                    lblPreg.Text = cp.pregunta9[0];
                    rbA.Text = cp.pregunta9[1];
                    rbB.Text = cp.pregunta9[2];
                    rbC.Text = cp.pregunta9[3];
                    rbD.Text = cp.pregunta9[4];
                    break;
            }
            if (rbA.Checked == true)
            {
                A++;
            }
            else if (rbB.Checked == true)
            {
                B++;
            }
            else if (rbC.Checked == true)
            {
                C++;
            }
            else if (rbD.Checked == true)
            {
                D++;
            }
            if (preguntaActual>=9)
            {
                MostrarResultado();
            }

           
        }
        private void MostrarResultado()
        {
            if (A > B && A > C && A > D)
            {
                Resp = 1;
            }
            else if (B > A && B > C && B > D)
            {
                Resp = 2;
            }
            else if (C > A && C > B && C > D)
            {
                Resp = 3;
            }
            else if (D > A && D > C && D > B)
            {
                Resp = 4;
            }
            this.Hide();
            Resultado resu = new Resultado(Resp, user);
            resu.Show();
        }
        #endregion
    }
}