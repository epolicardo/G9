﻿namespace PrimG9.Formularios
{
    partial class Preguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preguntas));
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.lblPreg = new System.Windows.Forms.Label();
            this.btnSig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.BackColor = System.Drawing.Color.Transparent;
            this.rbA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA.ForeColor = System.Drawing.Color.Black;
            this.rbA.Location = new System.Drawing.Point(268, 170);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(99, 20);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "radioButton1";
            this.rbA.UseVisualStyleBackColor = false;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.BackColor = System.Drawing.Color.Transparent;
            this.rbB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB.ForeColor = System.Drawing.Color.Black;
            this.rbB.Location = new System.Drawing.Point(268, 207);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(99, 20);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "radioButton2";
            this.rbB.UseVisualStyleBackColor = false;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.BackColor = System.Drawing.Color.Transparent;
            this.rbC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbC.ForeColor = System.Drawing.Color.Black;
            this.rbC.Location = new System.Drawing.Point(268, 243);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(99, 20);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "radioButton3";
            this.rbC.UseVisualStyleBackColor = false;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.BackColor = System.Drawing.Color.Transparent;
            this.rbD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbD.ForeColor = System.Drawing.Color.Black;
            this.rbD.Location = new System.Drawing.Point(268, 279);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(99, 20);
            this.rbD.TabIndex = 3;
            this.rbD.TabStop = true;
            this.rbD.Text = "radioButton4";
            this.rbD.UseVisualStyleBackColor = false;
            // 
            // lblPreg
            // 
            this.lblPreg.AutoSize = true;
            this.lblPreg.BackColor = System.Drawing.Color.Transparent;
            this.lblPreg.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreg.ForeColor = System.Drawing.Color.Black;
            this.lblPreg.Location = new System.Drawing.Point(70, 39);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(64, 23);
            this.lblPreg.TabIndex = 4;
            this.lblPreg.Text = "label1";
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSig.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.ForeColor = System.Drawing.Color.Black;
            this.btnSig.Location = new System.Drawing.Point(594, 377);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(84, 32);
            this.btnSig.TabIndex = 5;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.BtnSig_Click);
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 433);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.lblPreg);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.MaximizeBox = false;
            this.Name = "Preguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.Preguntas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Label lblPreg;
        private System.Windows.Forms.Button btnSig;
    }
}