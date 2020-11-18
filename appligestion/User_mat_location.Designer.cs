namespace appligestion
{
    partial class User_mat_location
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oobservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonimage = new System.Windows.Forms.Button();
            this.buttonsupprim = new System.Windows.Forms.Button();
            this.buttonmodif = new System.Windows.Forms.Button();
            this.buttonajout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1190, 10);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(16, 177);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1190, 10);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.equipement,
            this.quantite,
            this.oobservation});
            this.dataGridView1.Location = new System.Drawing.Point(16, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 455);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 125;
            // 
            // equipement
            // 
            this.equipement.HeaderText = "materiels";
            this.equipement.MinimumWidth = 6;
            this.equipement.Name = "equipement";
            this.equipement.Width = 500;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "quantite";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.Width = 125;
            // 
            // oobservation
            // 
            this.oobservation.HeaderText = "observation";
            this.oobservation.MinimumWidth = 6;
            this.oobservation.Name = "oobservation";
            this.oobservation.Width = 700;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 34);
            this.textBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(599, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 34);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "recherche";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(522, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 5);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::appligestion.Properties.Resources.microsoft_excel_2019_48px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(897, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "sauvegarder dans excel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonimage
            // 
            this.buttonimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonimage.BackColor = System.Drawing.Color.Black;
            this.buttonimage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonimage.ForeColor = System.Drawing.Color.White;
            this.buttonimage.Image = global::appligestion.Properties.Resources.aaiii;
            this.buttonimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonimage.Location = new System.Drawing.Point(938, 23);
            this.buttonimage.Name = "buttonimage";
            this.buttonimage.Size = new System.Drawing.Size(223, 49);
            this.buttonimage.TabIndex = 3;
            this.buttonimage.Text = "Image";
            this.buttonimage.UseVisualStyleBackColor = false;
            // 
            // buttonsupprim
            // 
            this.buttonsupprim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonsupprim.BackColor = System.Drawing.Color.Black;
            this.buttonsupprim.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupprim.ForeColor = System.Drawing.Color.White;
            this.buttonsupprim.Image = global::appligestion.Properties.Resources.aaaaaaaaaaaaa;
            this.buttonsupprim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsupprim.Location = new System.Drawing.Point(657, 23);
            this.buttonsupprim.Name = "buttonsupprim";
            this.buttonsupprim.Size = new System.Drawing.Size(223, 49);
            this.buttonsupprim.TabIndex = 2;
            this.buttonsupprim.Text = "Supprimer";
            this.buttonsupprim.UseVisualStyleBackColor = false;
            this.buttonsupprim.Click += new System.EventHandler(this.buttonsupprim_Click);
            // 
            // buttonmodif
            // 
            this.buttonmodif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonmodif.BackColor = System.Drawing.Color.Black;
            this.buttonmodif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodif.ForeColor = System.Drawing.Color.White;
            this.buttonmodif.Image = global::appligestion.Properties.Resources.amooooo;
            this.buttonmodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmodif.Location = new System.Drawing.Point(326, 23);
            this.buttonmodif.Name = "buttonmodif";
            this.buttonmodif.Size = new System.Drawing.Size(223, 49);
            this.buttonmodif.TabIndex = 1;
            this.buttonmodif.Text = "Modifier";
            this.buttonmodif.UseVisualStyleBackColor = false;
            this.buttonmodif.Click += new System.EventHandler(this.buttonmodif_Click);
            // 
            // buttonajout
            // 
            this.buttonajout.BackColor = System.Drawing.Color.Black;
            this.buttonajout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajout.ForeColor = System.Drawing.Color.White;
            this.buttonajout.Image = global::appligestion.Properties.Resources.aplus;
            this.buttonajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonajout.Location = new System.Drawing.Point(16, 23);
            this.buttonajout.Name = "buttonajout";
            this.buttonajout.Size = new System.Drawing.Size(223, 49);
            this.buttonajout.TabIndex = 0;
            this.buttonajout.Text = "Ajouter";
            this.buttonajout.UseVisualStyleBackColor = false;
            this.buttonajout.Click += new System.EventHandler(this.buttonajout_Click);
            // 
            // User_mat_location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonimage);
            this.Controls.Add(this.buttonsupprim);
            this.Controls.Add(this.buttonmodif);
            this.Controls.Add(this.buttonajout);
            this.Name = "User_mat_location";
            this.Size = new System.Drawing.Size(1244, 731);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonajout;
        private System.Windows.Forms.Button buttonmodif;
        private System.Windows.Forms.Button buttonsupprim;
        private System.Windows.Forms.Button buttonimage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipement;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn oobservation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
    }
}
