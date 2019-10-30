namespace beadando
{
    partial class kopapirollo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kopapirollo));
            this.label1 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.scissor_pictureBox3 = new System.Windows.Forms.PictureBox();
            this.paper_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rock_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jatekos_szamlalo = new System.Windows.Forms.Label();
            this.gep_szamlalo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kezdéshez kérlek nyomd meg a START gombot!";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Maroon;
            this.start_button.ForeColor = System.Drawing.Color.White;
            this.start_button.Location = new System.Drawing.Point(205, 77);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 23);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "&START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // scissor_pictureBox3
            // 
            this.scissor_pictureBox3.Image = global::beadando.Properties.Resources.scrissors;
            this.scissor_pictureBox3.Location = new System.Drawing.Point(324, 123);
            this.scissor_pictureBox3.Name = "scissor_pictureBox3";
            this.scissor_pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.scissor_pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scissor_pictureBox3.TabIndex = 5;
            this.scissor_pictureBox3.TabStop = false;
            this.scissor_pictureBox3.Visible = false;
            this.scissor_pictureBox3.Click += new System.EventHandler(this.scissor_pictureBox3_Click);
            // 
            // paper_pictureBox2
            // 
            this.paper_pictureBox2.Image = global::beadando.Properties.Resources.paper;
            this.paper_pictureBox2.InitialImage = global::beadando.Properties.Resources.paper;
            this.paper_pictureBox2.Location = new System.Drawing.Point(165, 123);
            this.paper_pictureBox2.Name = "paper_pictureBox2";
            this.paper_pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.paper_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.paper_pictureBox2.TabIndex = 4;
            this.paper_pictureBox2.TabStop = false;
            this.paper_pictureBox2.Visible = false;
            this.paper_pictureBox2.Click += new System.EventHandler(this.paper_pictureBox2_Click);
            // 
            // rock_pictureBox1
            // 
            this.rock_pictureBox1.Image = global::beadando.Properties.Resources.rock;
            this.rock_pictureBox1.Location = new System.Drawing.Point(15, 123);
            this.rock_pictureBox1.Name = "rock_pictureBox1";
            this.rock_pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.rock_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rock_pictureBox1.TabIndex = 3;
            this.rock_pictureBox1.TabStop = false;
            this.rock_pictureBox1.Visible = false;
            this.rock_pictureBox1.Click += new System.EventHandler(this.rock_pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ki nyert?";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Játékos pontja: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gép pontja: ";
            // 
            // jatekos_szamlalo
            // 
            this.jatekos_szamlalo.AutoSize = true;
            this.jatekos_szamlalo.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos_szamlalo.Location = new System.Drawing.Point(130, 294);
            this.jatekos_szamlalo.Name = "jatekos_szamlalo";
            this.jatekos_szamlalo.Size = new System.Drawing.Size(16, 19);
            this.jatekos_szamlalo.TabIndex = 9;
            this.jatekos_szamlalo.Text = "*";
            this.jatekos_szamlalo.Visible = false;
            // 
            // gep_szamlalo
            // 
            this.gep_szamlalo.AutoSize = true;
            this.gep_szamlalo.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gep_szamlalo.Location = new System.Drawing.Point(130, 323);
            this.gep_szamlalo.Name = "gep_szamlalo";
            this.gep_szamlalo.Size = new System.Drawing.Size(16, 19);
            this.gep_szamlalo.TabIndex = 10;
            this.gep_szamlalo.Text = "*";
            this.gep_szamlalo.Visible = false;
            // 
            // kopapirollo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.gep_szamlalo);
            this.Controls.Add(this.jatekos_szamlalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scissor_pictureBox3);
            this.Controls.Add(this.paper_pictureBox2);
            this.Controls.Add(this.rock_pictureBox1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kopapirollo";
            this.Text = "Kő-papír-olló";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.start_button, 0);
            this.Controls.SetChildIndex(this.rock_pictureBox1, 0);
            this.Controls.SetChildIndex(this.paper_pictureBox2, 0);
            this.Controls.SetChildIndex(this.scissor_pictureBox3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.jatekos_szamlalo, 0);
            this.Controls.SetChildIndex(this.gep_szamlalo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.scissor_pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.PictureBox rock_pictureBox1;
        private System.Windows.Forms.PictureBox paper_pictureBox2;
        private System.Windows.Forms.PictureBox scissor_pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label jatekos_szamlalo;
        private System.Windows.Forms.Label gep_szamlalo;
    }
}