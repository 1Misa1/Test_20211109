namespace Test_20211109
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtjmeno = new System.Windows.Forms.TextBox();
            this.numStav = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVytvorucet = new System.Windows.Forms.Button();
            this.lblJmeno = new System.Windows.Forms.Label();
            this.lblStav = new System.Windows.Forms.Label();
            this.btnVklad = new System.Windows.Forms.Button();
            this.numVklad = new System.Windows.Forms.NumericUpDown();
            this.btnVyber = new System.Windows.Forms.Button();
            this.numVyber = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.btnstorno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAktualne = new System.Windows.Forms.Label();
            this.btnPlatba = new System.Windows.Forms.Button();
            this.numPlatba = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStav)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVyber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlatba)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numPlatba);
            this.groupBox1.Controls.Add(this.btnPlatba);
            this.groupBox1.Controls.Add(this.lblAktualne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numVyber);
            this.groupBox1.Controls.Add(this.btnVyber);
            this.groupBox1.Controls.Add(this.numVklad);
            this.groupBox1.Controls.Add(this.btnVklad);
            this.groupBox1.Controls.Add(this.lblStav);
            this.groupBox1.Controls.Add(this.lblJmeno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(436, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Účet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum na účtě :";
            // 
            // txtjmeno
            // 
            this.txtjmeno.Location = new System.Drawing.Point(110, 45);
            this.txtjmeno.Name = "txtjmeno";
            this.txtjmeno.Size = new System.Drawing.Size(154, 29);
            this.txtjmeno.TabIndex = 2;
            this.txtjmeno.TextChanged += new System.EventHandler(this.txtjmeno_TextChanged);
            // 
            // numStav
            // 
            this.numStav.Location = new System.Drawing.Point(231, 91);
            this.numStav.Name = "numStav";
            this.numStav.Size = new System.Drawing.Size(132, 29);
            this.numStav.TabIndex = 3;
            this.numStav.ValueChanged += new System.EventHandler(this.numStav_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(418, 394);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnstorno);
            this.groupBox2.Controls.Add(this.btnVytvorucet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtjmeno);
            this.groupBox2.Controls.Add(this.numStav);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(36, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vytvoř účet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jméno :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Maximum peněz na účtě :";
            // 
            // btnVytvorucet
            // 
            this.btnVytvorucet.Location = new System.Drawing.Point(71, 133);
            this.btnVytvorucet.Name = "btnVytvorucet";
            this.btnVytvorucet.Size = new System.Drawing.Size(154, 35);
            this.btnVytvorucet.TabIndex = 6;
            this.btnVytvorucet.Text = "Vytvoř účet";
            this.btnVytvorucet.UseVisualStyleBackColor = true;
            this.btnVytvorucet.Click += new System.EventHandler(this.btnVytvorucet_Click);
            // 
            // lblJmeno
            // 
            this.lblJmeno.AutoSize = true;
            this.lblJmeno.Location = new System.Drawing.Point(145, 83);
            this.lblJmeno.Name = "lblJmeno";
            this.lblJmeno.Size = new System.Drawing.Size(103, 25);
            this.lblJmeno.TabIndex = 5;
            this.lblJmeno.Text = "__Jméno__";
            // 
            // lblStav
            // 
            this.lblStav.AutoSize = true;
            this.lblStav.Location = new System.Drawing.Point(212, 122);
            this.lblStav.Name = "lblStav";
            this.lblStav.Size = new System.Drawing.Size(134, 25);
            this.lblStav.TabIndex = 6;
            this.lblStav.Text = "__Maximum__";
            // 
            // btnVklad
            // 
            this.btnVklad.Location = new System.Drawing.Point(40, 218);
            this.btnVklad.Name = "btnVklad";
            this.btnVklad.Size = new System.Drawing.Size(99, 33);
            this.btnVklad.TabIndex = 7;
            this.btnVklad.Text = "Vklad :";
            this.btnVklad.UseVisualStyleBackColor = true;
            this.btnVklad.Click += new System.EventHandler(this.btnVklad_Click);
            // 
            // numVklad
            // 
            this.numVklad.Location = new System.Drawing.Point(150, 218);
            this.numVklad.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.numVklad.Name = "numVklad";
            this.numVklad.Size = new System.Drawing.Size(120, 33);
            this.numVklad.TabIndex = 8;
            // 
            // btnVyber
            // 
            this.btnVyber.Location = new System.Drawing.Point(40, 276);
            this.btnVyber.Name = "btnVyber";
            this.btnVyber.Size = new System.Drawing.Size(99, 34);
            this.btnVyber.TabIndex = 9;
            this.btnVyber.Text = "Výběr :";
            this.btnVyber.UseVisualStyleBackColor = true;
            this.btnVyber.Click += new System.EventHandler(this.btnVyber_Click);
            // 
            // numVyber
            // 
            this.numVyber.Location = new System.Drawing.Point(150, 276);
            this.numVyber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVyber.Name = "numVyber";
            this.numVyber.Size = new System.Drawing.Size(120, 33);
            this.numVyber.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(12, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Vytvoř účet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnstorno
            // 
            this.btnstorno.Location = new System.Drawing.Point(231, 133);
            this.btnstorno.Name = "btnstorno";
            this.btnstorno.Size = new System.Drawing.Size(77, 35);
            this.btnstorno.TabIndex = 7;
            this.btnstorno.Text = "Storno";
            this.btnstorno.UseVisualStyleBackColor = true;
            this.btnstorno.Click += new System.EventHandler(this.btnstorno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Aktuálně na účtě :";
            // 
            // lblAktualne
            // 
            this.lblAktualne.AutoSize = true;
            this.lblAktualne.Location = new System.Drawing.Point(212, 163);
            this.lblAktualne.Name = "lblAktualne";
            this.lblAktualne.Size = new System.Drawing.Size(124, 25);
            this.lblAktualne.TabIndex = 12;
            this.lblAktualne.Text = "__Aktuálně__";
            // 
            // btnPlatba
            // 
            this.btnPlatba.Location = new System.Drawing.Point(40, 333);
            this.btnPlatba.Name = "btnPlatba";
            this.btnPlatba.Size = new System.Drawing.Size(99, 33);
            this.btnPlatba.TabIndex = 13;
            this.btnPlatba.Text = "Platba :";
            this.btnPlatba.UseVisualStyleBackColor = true;
            this.btnPlatba.Click += new System.EventHandler(this.btnPlatba_Click);
            // 
            // numPlatba
            // 
            this.numPlatba.Location = new System.Drawing.Point(150, 333);
            this.numPlatba.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPlatba.Name = "numPlatba";
            this.numPlatba.Size = new System.Drawing.Size(120, 33);
            this.numPlatba.TabIndex = 14;
            this.numPlatba.ValueChanged += new System.EventHandler(this.numPlatba_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "GitHub : 1Misa1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStav)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVyber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlatba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numVyber;
        private System.Windows.Forms.Button btnVyber;
        private System.Windows.Forms.NumericUpDown numVklad;
        private System.Windows.Forms.Button btnVklad;
        private System.Windows.Forms.Label lblStav;
        private System.Windows.Forms.Label lblJmeno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtjmeno;
        private System.Windows.Forms.NumericUpDown numStav;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVytvorucet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnstorno;
        private System.Windows.Forms.Label lblAktualne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPlatba;
        private System.Windows.Forms.Button btnPlatba;
        private System.Windows.Forms.Label label6;
    }
}

