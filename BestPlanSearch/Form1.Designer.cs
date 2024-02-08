namespace BestPlanSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LbGB = new System.Windows.Forms.Label();
            this.LbMin = new System.Windows.Forms.Label();
            this.LbText = new System.Windows.Forms.Label();
            this.LbDuration = new System.Windows.Forms.Label();
            this.LbPrice = new System.Windows.Forms.Label();
            this.Lb5G = new System.Windows.Forms.Label();
            this.LbResult = new System.Windows.Forms.Label();
            this.NUDGB = new System.Windows.Forms.NumericUpDown();
            this.NUDMin = new System.Windows.Forms.NumericUpDown();
            this.NUDText = new System.Windows.Forms.NumericUpDown();
            this.NUDDuration = new System.Windows.Forms.NumericUpDown();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.CB5G = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // LbGB
            // 
            this.LbGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbGB.AutoSize = true;
            this.LbGB.Location = new System.Drawing.Point(876, 9);
            this.LbGB.Name = "LbGB";
            this.LbGB.Size = new System.Drawing.Size(77, 16);
            this.LbGB.TabIndex = 7;
            this.LbGB.Text = "Internet(GB)";
            // 
            // LbMin
            // 
            this.LbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbMin.AutoSize = true;
            this.LbMin.Location = new System.Drawing.Point(1002, 9);
            this.LbMin.Name = "LbMin";
            this.LbMin.Size = new System.Drawing.Size(28, 16);
            this.LbMin.TabIndex = 7;
            this.LbMin.Text = "Min";
            // 
            // LbText
            // 
            this.LbText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbText.AutoSize = true;
            this.LbText.Location = new System.Drawing.Point(1127, 9);
            this.LbText.Name = "LbText";
            this.LbText.Size = new System.Drawing.Size(78, 16);
            this.LbText.TabIndex = 7;
            this.LbText.Text = "SMS(Count)";
            // 
            // LbDuration
            // 
            this.LbDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbDuration.AutoSize = true;
            this.LbDuration.Location = new System.Drawing.Point(876, 131);
            this.LbDuration.Name = "LbDuration";
            this.LbDuration.Size = new System.Drawing.Size(87, 16);
            this.LbDuration.TabIndex = 7;
            this.LbDuration.Text = "Plan Duration";
            // 
            // LbPrice
            // 
            this.LbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPrice.AutoSize = true;
            this.LbPrice.Location = new System.Drawing.Point(1000, 131);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(48, 16);
            this.LbPrice.TabIndex = 7;
            this.LbPrice.Text = "Price €";
            // 
            // Lb5G
            // 
            this.Lb5G.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lb5G.AutoSize = true;
            this.Lb5G.Location = new System.Drawing.Point(1127, 131);
            this.Lb5G.Name = "Lb5G";
            this.Lb5G.Size = new System.Drawing.Size(31, 16);
            this.Lb5G.TabIndex = 7;
            this.Lb5G.Text = "5G?";
            // 
            // LbResult
            // 
            this.LbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbResult.AutoSize = true;
            this.LbResult.Location = new System.Drawing.Point(876, 253);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(45, 16);
            this.LbResult.TabIndex = 9;
            this.LbResult.Text = "Result";
            // 
            // NUDGB
            // 
            this.NUDGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDGB.Location = new System.Drawing.Point(879, 28);
            this.NUDGB.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NUDGB.Name = "NUDGB";
            this.NUDGB.Size = new System.Drawing.Size(120, 22);
            this.NUDGB.TabIndex = 11;
            // 
            // NUDMin
            // 
            this.NUDMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDMin.Location = new System.Drawing.Point(1005, 28);
            this.NUDMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NUDMin.Name = "NUDMin";
            this.NUDMin.Size = new System.Drawing.Size(120, 22);
            this.NUDMin.TabIndex = 11;
            this.NUDMin.ValueChanged += new System.EventHandler(this.NUDMin_ValueChanged);
            // 
            // NUDText
            // 
            this.NUDText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDText.Location = new System.Drawing.Point(1130, 28);
            this.NUDText.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NUDText.Name = "NUDText";
            this.NUDText.Size = new System.Drawing.Size(120, 22);
            this.NUDText.TabIndex = 11;
            this.NUDText.ValueChanged += new System.EventHandler(this.NUDText_ValueChanged);
            // 
            // NUDDuration
            // 
            this.NUDDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDDuration.Location = new System.Drawing.Point(876, 150);
            this.NUDDuration.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NUDDuration.Name = "NUDDuration";
            this.NUDDuration.Size = new System.Drawing.Size(120, 22);
            this.NUDDuration.TabIndex = 11;
            this.NUDDuration.ValueChanged += new System.EventHandler(this.NUDDuration_ValueChanged);
            // 
            // NUDPrice
            // 
            this.NUDPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDPrice.Location = new System.Drawing.Point(1002, 150);
            this.NUDPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(120, 22);
            this.NUDPrice.TabIndex = 11;
            this.NUDPrice.ValueChanged += new System.EventHandler(this.NUDPrice_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(876, 72);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(1005, 72);
            this.trackBar2.Maximum = 200;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 56);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(1127, 72);
            this.trackBar3.Maximum = 200;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 56);
            this.trackBar3.TabIndex = 12;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(876, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Priorities";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1002, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Priorities";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1127, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Priorities";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(876, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priorities";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1002, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Priorities";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1127, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Priorities";
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(876, 194);
            this.trackBar4.Maximum = 200;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 56);
            this.trackBar4.TabIndex = 12;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // trackBar5
            // 
            this.trackBar5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar5.LargeChange = 1;
            this.trackBar5.Location = new System.Drawing.Point(1005, 194);
            this.trackBar5.Maximum = 200;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 56);
            this.trackBar5.TabIndex = 12;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // trackBar6
            // 
            this.trackBar6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar6.LargeChange = 1;
            this.trackBar6.Location = new System.Drawing.Point(1127, 194);
            this.trackBar6.Maximum = 200;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 56);
            this.trackBar6.TabIndex = 12;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar4_ValueChanged);
            // 
            // CB5G
            // 
            this.CB5G.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CB5G.AutoSize = true;
            this.CB5G.Location = new System.Drawing.Point(1130, 150);
            this.CB5G.Name = "CB5G";
            this.CB5G.Size = new System.Drawing.Size(53, 20);
            this.CB5G.TabIndex = 13;
            this.CB5G.Text = "Yes";
            this.CB5G.UseVisualStyleBackColor = true;
            this.CB5G.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CB5G_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 450);
            this.Controls.Add(this.CB5G);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.NUDText);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.NUDMin);
            this.Controls.Add(this.NUDDuration);
            this.Controls.Add(this.NUDGB);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.Lb5G);
            this.Controls.Add(this.LbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LbDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbMin);
            this.Controls.Add(this.LbGB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Priorities";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LbGB;
        private System.Windows.Forms.Label LbMin;
        private System.Windows.Forms.Label LbText;
        private System.Windows.Forms.Label LbDuration;
        private System.Windows.Forms.Label LbPrice;
        private System.Windows.Forms.Label Lb5G;
        private System.Windows.Forms.Label LbResult;
        private System.Windows.Forms.NumericUpDown NUDGB;
        private System.Windows.Forms.NumericUpDown NUDMin;
        private System.Windows.Forms.NumericUpDown NUDText;
        private System.Windows.Forms.NumericUpDown NUDDuration;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.CheckBox CB5G;
    }
}

