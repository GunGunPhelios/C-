namespace RenataApplikáció
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.Label();
            this.txtTerulet = new System.Windows.Forms.Label();
            this.txtNepesseg = new System.Windows.Forms.Label();
            this.txtFovaros = new System.Windows.Forms.Label();
            this.txtFovarosLakossag = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.lblUzenet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(487, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új Ország Felvétele";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(576, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(576, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(576, 308);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(576, 381);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(167, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(576, 442);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(167, 20);
            this.textBox5.TabIndex = 5;
            // 
            // txtOrszag
            // 
            this.txtOrszag.AutoSize = true;
            this.txtOrszag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtOrszag.Location = new System.Drawing.Point(464, 161);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(61, 19);
            this.txtOrszag.TabIndex = 6;
            this.txtOrszag.Text = "Ország:";
            // 
            // txtTerulet
            // 
            this.txtTerulet.AutoSize = true;
            this.txtTerulet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTerulet.Location = new System.Drawing.Point(464, 237);
            this.txtTerulet.Name = "txtTerulet";
            this.txtTerulet.Size = new System.Drawing.Size(57, 19);
            this.txtTerulet.TabIndex = 7;
            this.txtTerulet.Text = "Terület";
            this.txtTerulet.Click += new System.EventHandler(this.txtTerulet_Click);
            // 
            // txtNepesseg
            // 
            this.txtNepesseg.AutoSize = true;
            this.txtNepesseg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNepesseg.Location = new System.Drawing.Point(441, 307);
            this.txtNepesseg.Name = "txtNepesseg";
            this.txtNepesseg.Size = new System.Drawing.Size(80, 19);
            this.txtNepesseg.TabIndex = 8;
            this.txtNepesseg.Text = "Népesség:";
            // 
            // txtFovaros
            // 
            this.txtFovaros.AutoSize = true;
            this.txtFovaros.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFovaros.Location = new System.Drawing.Point(453, 382);
            this.txtFovaros.Name = "txtFovaros";
            this.txtFovaros.Size = new System.Drawing.Size(68, 19);
            this.txtFovaros.TabIndex = 9;
            this.txtFovaros.Text = "Főváros:";
            // 
            // txtFovarosLakossag
            // 
            this.txtFovarosLakossag.AutoSize = true;
            this.txtFovarosLakossag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFovarosLakossag.Location = new System.Drawing.Point(407, 441);
            this.txtFovarosLakossag.Name = "txtFovarosLakossag";
            this.txtFovarosLakossag.Size = new System.Drawing.Size(145, 19);
            this.txtFovarosLakossag.TabIndex = 10;
            this.txtFovarosLakossag.Text = "Főváros Lakossága:";
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(624, 498);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(57, 26);
            this.btnMentes.TabIndex = 11;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // lblUzenet
            // 
            this.lblUzenet.AutoSize = true;
            this.lblUzenet.Location = new System.Drawing.Point(622, 555);
            this.lblUzenet.Name = "lblUzenet";
            this.lblUzenet.Size = new System.Drawing.Size(35, 13);
            this.lblUzenet.TabIndex = 12;
            this.lblUzenet.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1210, 589);
            this.Controls.Add(this.lblUzenet);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.txtFovarosLakossag);
            this.Controls.Add(this.txtFovaros);
            this.Controls.Add(this.txtNepesseg);
            this.Controls.Add(this.txtTerulet);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtOrszag;
        private System.Windows.Forms.Label txtTerulet;
        private System.Windows.Forms.Label txtNepesseg;
        private System.Windows.Forms.Label txtFovaros;
        private System.Windows.Forms.Label txtFovarosLakossag;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label lblUzenet;

    }
}

