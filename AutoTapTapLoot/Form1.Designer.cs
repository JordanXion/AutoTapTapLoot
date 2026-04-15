namespace AutoTapTapLoot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            numericUpDownPacketsPerSecond = new NumericUpDown();
            numericUpDownTapsPerPacket = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonBuffsApply = new Button();
            buttonBuffsDefault = new Button();
            tableLayoutPanelBuffs = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            buttonAutoTapEnable = new Button();
            buttonAutoTapDisable = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            labelStatusPipeTap = new Label();
            label6 = new Label();
            labelStatusPipeBuff = new Label();
            label5 = new Label();
            label7 = new Label();
            labelStatusTap = new Label();
            labelStatusBuff = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPacketsPerSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTapsPerPacket).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(numericUpDownPacketsPerSecond, 1, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownTapsPerPacket, 1, 1);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(226, 62);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Packets Per Second";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 31);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Taps Per Packet";
            // 
            // numericUpDownPacketsPerSecond
            // 
            numericUpDownPacketsPerSecond.Location = new Point(138, 3);
            numericUpDownPacketsPerSecond.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownPacketsPerSecond.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPacketsPerSecond.Name = "numericUpDownPacketsPerSecond";
            numericUpDownPacketsPerSecond.Size = new Size(85, 23);
            numericUpDownPacketsPerSecond.TabIndex = 2;
            numericUpDownPacketsPerSecond.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // numericUpDownTapsPerPacket
            // 
            numericUpDownTapsPerPacket.Location = new Point(138, 34);
            numericUpDownTapsPerPacket.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownTapsPerPacket.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownTapsPerPacket.Name = "numericUpDownTapsPerPacket";
            numericUpDownTapsPerPacket.Size = new Size(85, 23);
            numericUpDownTapsPerPacket.TabIndex = 3;
            numericUpDownTapsPerPacket.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(626, 426);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tableLayoutPanel4);
            groupBox2.Controls.Add(tableLayoutPanelBuffs);
            groupBox2.Location = new Point(253, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 420);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buff Settings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(278, 15);
            label3.TabIndex = 2;
            label3.Text = "Value is percent added to each buff (ex. 1 = +100%)";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(buttonBuffsApply, 0, 0);
            tableLayoutPanel4.Controls.Add(buttonBuffsDefault, 1, 0);
            tableLayoutPanel4.Location = new Point(6, 367);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(358, 47);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonBuffsApply
            // 
            buttonBuffsApply.Location = new Point(3, 3);
            buttonBuffsApply.Name = "buttonBuffsApply";
            buttonBuffsApply.Size = new Size(173, 41);
            buttonBuffsApply.TabIndex = 0;
            buttonBuffsApply.Text = "Apply Buffs";
            buttonBuffsApply.UseVisualStyleBackColor = true;
            buttonBuffsApply.Click += buttonBuffsApply_Click;
            // 
            // buttonBuffsDefault
            // 
            buttonBuffsDefault.Location = new Point(182, 3);
            buttonBuffsDefault.Name = "buttonBuffsDefault";
            buttonBuffsDefault.Size = new Size(173, 41);
            buttonBuffsDefault.TabIndex = 1;
            buttonBuffsDefault.Text = "Disable Buffs";
            buttonBuffsDefault.UseVisualStyleBackColor = true;
            buttonBuffsDefault.Click += buttonBuffsDefault_Click;
            // 
            // tableLayoutPanelBuffs
            // 
            tableLayoutPanelBuffs.ColumnCount = 3;
            tableLayoutPanelBuffs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelBuffs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelBuffs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelBuffs.Location = new Point(6, 37);
            tableLayoutPanelBuffs.Name = "tableLayoutPanelBuffs";
            tableLayoutPanelBuffs.RowCount = 2;
            tableLayoutPanelBuffs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBuffs.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelBuffs.Size = new Size(358, 50);
            tableLayoutPanelBuffs.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(244, 420);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel6);
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(3, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 204);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Auto Tap Settings";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(buttonAutoTapEnable, 0, 0);
            tableLayoutPanel6.Controls.Add(buttonAutoTapDisable, 1, 0);
            tableLayoutPanel6.Location = new Point(6, 151);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(226, 47);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // buttonAutoTapEnable
            // 
            buttonAutoTapEnable.Location = new Point(3, 3);
            buttonAutoTapEnable.Name = "buttonAutoTapEnable";
            buttonAutoTapEnable.Size = new Size(107, 41);
            buttonAutoTapEnable.TabIndex = 0;
            buttonAutoTapEnable.Text = "Enable Auto Tap";
            buttonAutoTapEnable.UseVisualStyleBackColor = true;
            buttonAutoTapEnable.Click += buttonAutoTapEnable_Click;
            // 
            // buttonAutoTapDisable
            // 
            buttonAutoTapDisable.Location = new Point(116, 3);
            buttonAutoTapDisable.Name = "buttonAutoTapDisable";
            buttonAutoTapDisable.Size = new Size(107, 41);
            buttonAutoTapDisable.TabIndex = 1;
            buttonAutoTapDisable.Text = "Disable Auto Tap";
            buttonAutoTapDisable.UseVisualStyleBackColor = true;
            buttonAutoTapDisable.Click += buttonAutoTapDisable_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel5);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 204);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(labelStatusPipeTap, 1, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 1);
            tableLayoutPanel5.Controls.Add(labelStatusPipeBuff, 1, 1);
            tableLayoutPanel5.Controls.Add(label5, 0, 2);
            tableLayoutPanel5.Controls.Add(label7, 0, 3);
            tableLayoutPanel5.Controls.Add(labelStatusTap, 1, 2);
            tableLayoutPanel5.Controls.Add(labelStatusBuff, 1, 3);
            tableLayoutPanel5.Location = new Point(6, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 4;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Size = new Size(226, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 0;
            label4.Text = "Tap Pipe Status";
            // 
            // labelStatusPipeTap
            // 
            labelStatusPipeTap.AutoSize = true;
            labelStatusPipeTap.Location = new Point(116, 0);
            labelStatusPipeTap.Name = "labelStatusPipeTap";
            labelStatusPipeTap.Size = new Size(38, 15);
            labelStatusPipeTap.TabIndex = 1;
            labelStatusPipeTap.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 25);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 2;
            label6.Text = "Buff Pipe Status";
            // 
            // labelStatusPipeBuff
            // 
            labelStatusPipeBuff.AutoSize = true;
            labelStatusPipeBuff.Location = new Point(116, 25);
            labelStatusPipeBuff.Name = "labelStatusPipeBuff";
            labelStatusPipeBuff.Size = new Size(38, 15);
            labelStatusPipeBuff.TabIndex = 3;
            labelStatusPipeBuff.Text = "label7";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 50);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Auto Tap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 75);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 5;
            label7.Text = "Buffs";
            // 
            // labelStatusTap
            // 
            labelStatusTap.AutoSize = true;
            labelStatusTap.Location = new Point(116, 50);
            labelStatusTap.Name = "labelStatusTap";
            labelStatusTap.Size = new Size(38, 15);
            labelStatusTap.TabIndex = 6;
            labelStatusTap.Text = "label8";
            // 
            // labelStatusBuff
            // 
            labelStatusBuff.AutoSize = true;
            labelStatusBuff.Location = new Point(116, 75);
            labelStatusBuff.Name = "labelStatusBuff";
            labelStatusBuff.Size = new Size(38, 15);
            labelStatusBuff.TabIndex = 7;
            labelStatusBuff.Text = "label9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "Form1";
            Text = "AutoTapTapLoot";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPacketsPerSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTapsPerPacket).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownPacketsPerSecond;
        private NumericUpDown numericUpDownTapsPerPacket;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanelBuffs;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button buttonBuffsApply;
        private Button buttonBuffsDefault;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private Label labelStatusPipeTap;
        private Label label6;
        private Label labelStatusPipeBuff;
        private TableLayoutPanel tableLayoutPanel6;
        private Button buttonAutoTapEnable;
        private Button buttonAutoTapDisable;
        private Label label5;
        private Label label7;
        private Label labelStatusTap;
        private Label labelStatusBuff;
    }
}
