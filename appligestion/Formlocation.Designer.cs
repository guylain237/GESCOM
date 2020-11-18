namespace appligestion
{
    partial class Formlocation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxobserv = new System.Windows.Forms.TextBox();
            this.textBoxquantite = new System.Windows.Forms.TextBox();
            this.textBoxnom = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonactual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltitre = new System.Windows.Forms.Label();
            this.picturelocat = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturelocat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.textBoxobserv);
            this.panel2.Controls.Add(this.textBoxquantite);
            this.panel2.Controls.Add(this.textBoxnom);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.buttonactual);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labeltitre);
            this.panel2.Controls.Add(this.picturelocat);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 529);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBoxobserv
            // 
            this.textBoxobserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxobserv.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxobserv.ForeColor = System.Drawing.Color.White;
            this.textBoxobserv.Location = new System.Drawing.Point(536, 322);
            this.textBoxobserv.Multiline = true;
            this.textBoxobserv.Name = "textBoxobserv";
            this.textBoxobserv.Size = new System.Drawing.Size(310, 32);
            this.textBoxobserv.TabIndex = 15;
            this.textBoxobserv.Text = "Observation";
            this.textBoxobserv.Enter += new System.EventHandler(this.textBoxobserv_Enter);
            this.textBoxobserv.Leave += new System.EventHandler(this.textBoxobserv_Leave);
            // 
            // textBoxquantite
            // 
            this.textBoxquantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxquantite.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxquantite.ForeColor = System.Drawing.Color.White;
            this.textBoxquantite.Location = new System.Drawing.Point(536, 258);
            this.textBoxquantite.Name = "textBoxquantite";
            this.textBoxquantite.Size = new System.Drawing.Size(310, 29);
            this.textBoxquantite.TabIndex = 14;
            this.textBoxquantite.Text = "Quantite";
            this.textBoxquantite.TextChanged += new System.EventHandler(this.textBoxquantite_TextChanged);
            this.textBoxquantite.Enter += new System.EventHandler(this.textBoxquantite_Enter);
            this.textBoxquantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxquantite_KeyPress);
            this.textBoxquantite.Leave += new System.EventHandler(this.textBoxquantite_Leave);
            // 
            // textBoxnom
            // 
            this.textBoxnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxnom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnom.ForeColor = System.Drawing.Color.White;
            this.textBoxnom.Location = new System.Drawing.Point(536, 189);
            this.textBoxnom.Name = "textBoxnom";
            this.textBoxnom.Size = new System.Drawing.Size(310, 29);
            this.textBoxnom.TabIndex = 12;
            this.textBoxnom.Text = "Nom materiel";
            this.textBoxnom.TextChanged += new System.EventHandler(this.textBoxnom_TextChanged);
            this.textBoxnom.Enter += new System.EventHandler(this.textBoxnom_Enter);
            this.textBoxnom.Leave += new System.EventHandler(this.textBoxnom_Leave);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackgroundImage = global::appligestion.Properties.Resources.exit;
            this.button4.Image = global::appligestion.Properties.Resources.exit;
            this.button4.Location = new System.Drawing.Point(778, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "   ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(439, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "categorie :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(536, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(310, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(614, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Enregistrer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonactual
            // 
            this.buttonactual.BackColor = System.Drawing.Color.Red;
            this.buttonactual.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonactual.ForeColor = System.Drawing.Color.White;
            this.buttonactual.Location = new System.Drawing.Point(103, 466);
            this.buttonactual.Name = "buttonactual";
            this.buttonactual.Size = new System.Drawing.Size(162, 37);
            this.buttonactual.TabIndex = 4;
            this.buttonactual.Text = "actualiser";
            this.buttonactual.UseVisualStyleBackColor = false;
            this.buttonactual.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "parcourir...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "image";
            // 
            // labeltitre
            // 
            this.labeltitre.AutoSize = true;
            this.labeltitre.BackColor = System.Drawing.Color.Green;
            this.labeltitre.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitre.ForeColor = System.Drawing.Color.White;
            this.labeltitre.Location = new System.Drawing.Point(210, 19);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(458, 41);
            this.labeltitre.TabIndex = 1;
            this.labeltitre.Text = "ajout materiel de location";
            // 
            // picturelocat
            // 
            this.picturelocat.BackColor = System.Drawing.Color.White;
            this.picturelocat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturelocat.Location = new System.Drawing.Point(129, 126);
            this.picturelocat.Name = "picturelocat";
            this.picturelocat.Size = new System.Drawing.Size(215, 152);
            this.picturelocat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturelocat.TabIndex = 0;
            this.picturelocat.TabStop = false;
            this.picturelocat.Click += new System.EventHandler(this.picturelocat_Click);
            // 
            // Formlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formlocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlocation";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturelocat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picturelocat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxobserv;
        private System.Windows.Forms.TextBox textBoxquantite;
        private System.Windows.Forms.TextBox textBoxnom;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labeltitre;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button buttonactual;
    }
}