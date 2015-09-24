namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbE1 = new System.Windows.Forms.TextBox();
            this.tbE2 = new System.Windows.Forms.TextBox();
            this.btExecute = new System.Windows.Forms.Button();
            this.lbOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbvFuß = new System.Windows.Forms.RadioButton();
            this.rbvZoll = new System.Windows.Forms.RadioButton();
            this.rbvMeter = new System.Windows.Forms.RadioButton();
            this.rbvYard = new System.Windows.Forms.RadioButton();
            this.rbvÅngström = new System.Windows.Forms.RadioButton();
            this.rbvFathom = new System.Windows.Forms.RadioButton();
            this.rbvparsec = new System.Windows.Forms.RadioButton();
            this.rbvRod = new System.Windows.Forms.RadioButton();
            this.rbvLichtjahre = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFuß = new System.Windows.Forms.RadioButton();
            this.rbZoll = new System.Windows.Forms.RadioButton();
            this.rbMeter = new System.Windows.Forms.RadioButton();
            this.rbYard = new System.Windows.Forms.RadioButton();
            this.rbFathom = new System.Windows.Forms.RadioButton();
            this.rbÅngström = new System.Windows.Forms.RadioButton();
            this.rbRod = new System.Windows.Forms.RadioButton();
            this.rbparsec = new System.Windows.Forms.RadioButton();
            this.rbLichtjahre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btM = new System.Windows.Forms.Button();
            this.lbMout = new System.Windows.Forms.Label();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbE1
            // 
            this.tbE1.Location = new System.Drawing.Point(9, 45);
            this.tbE1.Name = "tbE1";
            this.tbE1.Size = new System.Drawing.Size(100, 20);
            this.tbE1.TabIndex = 0;
            this.tbE1.Text = "0";
            // 
            // tbE2
            // 
            this.tbE2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbE2.Location = new System.Drawing.Point(238, 41);
            this.tbE2.Name = "tbE2";
            this.tbE2.Size = new System.Drawing.Size(100, 20);
            this.tbE2.TabIndex = 1;
            this.tbE2.Text = "0";
            // 
            // btExecute
            // 
            this.btExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btExecute.Location = new System.Drawing.Point(3, 257);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(340, 59);
            this.btExecute.TabIndex = 2;
            this.btExecute.Text = "Vergleichen";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOut.Location = new System.Drawing.Point(3, 224);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(32, 33);
            this.lbOut.TabIndex = 3;
            this.lbOut.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zahl 1";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zahl 2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(354, 345);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tbE1);
            this.tabPage1.Controls.Add(this.lbOut);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btExecute);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbE2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vergleich";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btM);
            this.tabPage2.Controls.Add(this.lbMout);
            this.tabPage2.Controls.Add(this.tbM1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Längenumrechnung";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbvFuß);
            this.groupBox2.Controls.Add(this.rbvZoll);
            this.groupBox2.Controls.Add(this.rbvMeter);
            this.groupBox2.Controls.Add(this.rbvYard);
            this.groupBox2.Controls.Add(this.rbvÅngström);
            this.groupBox2.Controls.Add(this.rbvFathom);
            this.groupBox2.Controls.Add(this.rbvparsec);
            this.groupBox2.Controls.Add(this.rbvRod);
            this.groupBox2.Controls.Add(this.rbvLichtjahre);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 228);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // rbvFuß
            // 
            this.rbvFuß.AutoSize = true;
            this.rbvFuß.Location = new System.Drawing.Point(6, 18);
            this.rbvFuß.Name = "rbvFuß";
            this.rbvFuß.Size = new System.Drawing.Size(43, 17);
            this.rbvFuß.TabIndex = 13;
            this.rbvFuß.TabStop = true;
            this.rbvFuß.Text = "Fuß";
            this.rbvFuß.UseVisualStyleBackColor = true;
            // 
            // rbvZoll
            // 
            this.rbvZoll.AutoSize = true;
            this.rbvZoll.Location = new System.Drawing.Point(6, 41);
            this.rbvZoll.Name = "rbvZoll";
            this.rbvZoll.Size = new System.Drawing.Size(42, 17);
            this.rbvZoll.TabIndex = 15;
            this.rbvZoll.TabStop = true;
            this.rbvZoll.Text = "Zoll";
            this.rbvZoll.UseVisualStyleBackColor = true;
            // 
            // rbvMeter
            // 
            this.rbvMeter.AutoSize = true;
            this.rbvMeter.Location = new System.Drawing.Point(6, 200);
            this.rbvMeter.Name = "rbvMeter";
            this.rbvMeter.Size = new System.Drawing.Size(52, 17);
            this.rbvMeter.TabIndex = 22;
            this.rbvMeter.TabStop = true;
            this.rbvMeter.Text = "Meter";
            this.rbvMeter.UseVisualStyleBackColor = true;
            // 
            // rbvYard
            // 
            this.rbvYard.AutoSize = true;
            this.rbvYard.Location = new System.Drawing.Point(6, 64);
            this.rbvYard.Name = "rbvYard";
            this.rbvYard.Size = new System.Drawing.Size(47, 17);
            this.rbvYard.TabIndex = 16;
            this.rbvYard.TabStop = true;
            this.rbvYard.Text = "Yard";
            this.rbvYard.UseVisualStyleBackColor = true;
            // 
            // rbvÅngström
            // 
            this.rbvÅngström.AutoSize = true;
            this.rbvÅngström.Location = new System.Drawing.Point(6, 177);
            this.rbvÅngström.Name = "rbvÅngström";
            this.rbvÅngström.Size = new System.Drawing.Size(69, 17);
            this.rbvÅngström.TabIndex = 21;
            this.rbvÅngström.TabStop = true;
            this.rbvÅngström.Text = "Ångström";
            this.rbvÅngström.UseVisualStyleBackColor = true;
            // 
            // rbvFathom
            // 
            this.rbvFathom.AutoSize = true;
            this.rbvFathom.Location = new System.Drawing.Point(6, 85);
            this.rbvFathom.Name = "rbvFathom";
            this.rbvFathom.Size = new System.Drawing.Size(60, 17);
            this.rbvFathom.TabIndex = 17;
            this.rbvFathom.TabStop = true;
            this.rbvFathom.Text = "Fathom";
            this.rbvFathom.UseVisualStyleBackColor = true;
            // 
            // rbvparsec
            // 
            this.rbvparsec.AutoSize = true;
            this.rbvparsec.Location = new System.Drawing.Point(6, 154);
            this.rbvparsec.Name = "rbvparsec";
            this.rbvparsec.Size = new System.Drawing.Size(57, 17);
            this.rbvparsec.TabIndex = 20;
            this.rbvparsec.TabStop = true;
            this.rbvparsec.Text = "parsec";
            this.rbvparsec.UseVisualStyleBackColor = true;
            // 
            // rbvRod
            // 
            this.rbvRod.AutoSize = true;
            this.rbvRod.Location = new System.Drawing.Point(6, 108);
            this.rbvRod.Name = "rbvRod";
            this.rbvRod.Size = new System.Drawing.Size(45, 17);
            this.rbvRod.TabIndex = 18;
            this.rbvRod.TabStop = true;
            this.rbvRod.Text = "Rod";
            this.rbvRod.UseVisualStyleBackColor = true;
            // 
            // rbvLichtjahre
            // 
            this.rbvLichtjahre.AutoSize = true;
            this.rbvLichtjahre.Location = new System.Drawing.Point(6, 131);
            this.rbvLichtjahre.Name = "rbvLichtjahre";
            this.rbvLichtjahre.Size = new System.Drawing.Size(71, 17);
            this.rbvLichtjahre.TabIndex = 19;
            this.rbvLichtjahre.TabStop = true;
            this.rbvLichtjahre.Text = "Lichtjahre";
            this.rbvLichtjahre.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "von";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbFuß);
            this.groupBox1.Controls.Add(this.rbZoll);
            this.groupBox1.Controls.Add(this.rbMeter);
            this.groupBox1.Controls.Add(this.rbYard);
            this.groupBox1.Controls.Add(this.rbFathom);
            this.groupBox1.Controls.Add(this.rbÅngström);
            this.groupBox1.Controls.Add(this.rbRod);
            this.groupBox1.Controls.Add(this.rbparsec);
            this.groupBox1.Controls.Add(this.rbLichtjahre);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(262, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // rbFuß
            // 
            this.rbFuß.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFuß.AutoSize = true;
            this.rbFuß.Location = new System.Drawing.Point(8, 19);
            this.rbFuß.Name = "rbFuß";
            this.rbFuß.Size = new System.Drawing.Size(43, 17);
            this.rbFuß.TabIndex = 3;
            this.rbFuß.TabStop = true;
            this.rbFuß.Text = "Fuß";
            this.rbFuß.UseVisualStyleBackColor = true;
            // 
            // rbZoll
            // 
            this.rbZoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbZoll.AutoSize = true;
            this.rbZoll.Location = new System.Drawing.Point(8, 42);
            this.rbZoll.Name = "rbZoll";
            this.rbZoll.Size = new System.Drawing.Size(42, 17);
            this.rbZoll.TabIndex = 4;
            this.rbZoll.TabStop = true;
            this.rbZoll.Text = "Zoll";
            this.rbZoll.UseVisualStyleBackColor = true;
            // 
            // rbMeter
            // 
            this.rbMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMeter.AutoSize = true;
            this.rbMeter.Location = new System.Drawing.Point(8, 201);
            this.rbMeter.Name = "rbMeter";
            this.rbMeter.Size = new System.Drawing.Size(52, 17);
            this.rbMeter.TabIndex = 12;
            this.rbMeter.TabStop = true;
            this.rbMeter.Text = "Meter";
            this.rbMeter.UseVisualStyleBackColor = true;
            // 
            // rbYard
            // 
            this.rbYard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbYard.AutoSize = true;
            this.rbYard.Location = new System.Drawing.Point(8, 63);
            this.rbYard.Name = "rbYard";
            this.rbYard.Size = new System.Drawing.Size(47, 17);
            this.rbYard.TabIndex = 5;
            this.rbYard.TabStop = true;
            this.rbYard.Text = "Yard";
            this.rbYard.UseVisualStyleBackColor = true;
            // 
            // rbFathom
            // 
            this.rbFathom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFathom.AutoSize = true;
            this.rbFathom.Location = new System.Drawing.Point(8, 86);
            this.rbFathom.Name = "rbFathom";
            this.rbFathom.Size = new System.Drawing.Size(60, 17);
            this.rbFathom.TabIndex = 6;
            this.rbFathom.TabStop = true;
            this.rbFathom.Text = "Fathom";
            this.rbFathom.UseVisualStyleBackColor = true;
            // 
            // rbÅngström
            // 
            this.rbÅngström.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbÅngström.AutoSize = true;
            this.rbÅngström.Location = new System.Drawing.Point(8, 178);
            this.rbÅngström.Name = "rbÅngström";
            this.rbÅngström.Size = new System.Drawing.Size(69, 17);
            this.rbÅngström.TabIndex = 10;
            this.rbÅngström.TabStop = true;
            this.rbÅngström.Text = "Ångström";
            this.rbÅngström.UseVisualStyleBackColor = true;
            // 
            // rbRod
            // 
            this.rbRod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRod.AutoSize = true;
            this.rbRod.Location = new System.Drawing.Point(8, 109);
            this.rbRod.Name = "rbRod";
            this.rbRod.Size = new System.Drawing.Size(45, 17);
            this.rbRod.TabIndex = 7;
            this.rbRod.TabStop = true;
            this.rbRod.Text = "Rod";
            this.rbRod.UseVisualStyleBackColor = true;
            // 
            // rbparsec
            // 
            this.rbparsec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbparsec.AutoSize = true;
            this.rbparsec.Location = new System.Drawing.Point(8, 155);
            this.rbparsec.Name = "rbparsec";
            this.rbparsec.Size = new System.Drawing.Size(57, 17);
            this.rbparsec.TabIndex = 9;
            this.rbparsec.TabStop = true;
            this.rbparsec.Text = "parsec";
            this.rbparsec.UseVisualStyleBackColor = true;
            // 
            // rbLichtjahre
            // 
            this.rbLichtjahre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLichtjahre.AutoSize = true;
            this.rbLichtjahre.Location = new System.Drawing.Point(8, 132);
            this.rbLichtjahre.Name = "rbLichtjahre";
            this.rbLichtjahre.Size = new System.Drawing.Size(71, 17);
            this.rbLichtjahre.TabIndex = 8;
            this.rbLichtjahre.TabStop = true;
            this.rbLichtjahre.Text = "Lichtjahre";
            this.rbLichtjahre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "zu";
            // 
            // btM
            // 
            this.btM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btM.AutoSize = true;
            this.btM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btM.Location = new System.Drawing.Point(170, 211);
            this.btM.Name = "btM";
            this.btM.Size = new System.Drawing.Size(63, 23);
            this.btM.TabIndex = 2;
            this.btM.Text = "Berechen";
            this.btM.UseVisualStyleBackColor = true;
            this.btM.Click += new System.EventHandler(this.btM_Click);
            // 
            // lbMout
            // 
            this.lbMout.AutoSize = true;
            this.lbMout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMout.Location = new System.Drawing.Point(3, 277);
            this.lbMout.Name = "lbMout";
            this.lbMout.Size = new System.Drawing.Size(0, 39);
            this.lbMout.TabIndex = 1;
            // 
            // tbM1
            // 
            this.tbM1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbM1.Location = new System.Drawing.Point(134, 29);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(88, 20);
            this.tbM1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(354, 345);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Rechner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbE1;
        private System.Windows.Forms.TextBox tbE2;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbM1;
        private System.Windows.Forms.Button btM;
        private System.Windows.Forms.Label lbMout;
        private System.Windows.Forms.RadioButton rbZoll;
        private System.Windows.Forms.RadioButton rbFuß;
        private System.Windows.Forms.RadioButton rbYard;
        private System.Windows.Forms.RadioButton rbFathom;
        private System.Windows.Forms.RadioButton rbRod;
        private System.Windows.Forms.RadioButton rbLichtjahre;
        private System.Windows.Forms.RadioButton rbparsec;
        private System.Windows.Forms.RadioButton rbÅngström;
        private System.Windows.Forms.RadioButton rbvFuß;
        private System.Windows.Forms.RadioButton rbMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbvZoll;
        private System.Windows.Forms.RadioButton rbvYard;
        private System.Windows.Forms.RadioButton rbvFathom;
        private System.Windows.Forms.RadioButton rbvRod;
        private System.Windows.Forms.RadioButton rbvLichtjahre;
        private System.Windows.Forms.RadioButton rbvparsec;
        private System.Windows.Forms.RadioButton rbvÅngström;
        private System.Windows.Forms.RadioButton rbvMeter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}

