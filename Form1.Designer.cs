namespace Joe_Automotive
{
    partial class frmJoeAutomotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxLubeJob = new System.Windows.Forms.CheckBox();
            this.cboxOilChange = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxTransmissionFlush = new System.Windows.Forms.CheckBox();
            this.cboxRadiatorFlush = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxTireRotation = new System.Windows.Forms.CheckBox();
            this.cboxReplaceMuffler = new System.Windows.Forms.CheckBox();
            this.cboxInspection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tboxParts = new System.Windows.Forms.TextBox();
            this.tboxLabor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblOutTotalFees = new System.Windows.Forms.Label();
            this.lblOutTax = new System.Windows.Forms.Label();
            this.lblOutParts = new System.Windows.Forms.Label();
            this.lblOutServiceLabor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxLubeJob);
            this.groupBox1.Controls.Add(this.cboxOilChange);
            this.groupBox1.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // cboxLubeJob
            // 
            this.cboxLubeJob.AutoSize = true;
            this.cboxLubeJob.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLubeJob.Location = new System.Drawing.Point(6, 68);
            this.cboxLubeJob.Name = "cboxLubeJob";
            this.cboxLubeJob.Size = new System.Drawing.Size(168, 30);
            this.cboxLubeJob.TabIndex = 1;
            this.cboxLubeJob.Text = "Lube Job ($18.00)";
            this.cboxLubeJob.UseVisualStyleBackColor = true;
            // 
            // cboxOilChange
            // 
            this.cboxOilChange.AutoSize = true;
            this.cboxOilChange.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxOilChange.Location = new System.Drawing.Point(6, 32);
            this.cboxOilChange.Name = "cboxOilChange";
            this.cboxOilChange.Size = new System.Drawing.Size(183, 30);
            this.cboxOilChange.TabIndex = 0;
            this.cboxOilChange.Text = "Oil Change ($26.00)";
            this.cboxOilChange.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxTransmissionFlush);
            this.groupBox2.Controls.Add(this.cboxRadiatorFlush);
            this.groupBox2.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(362, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // cboxTransmissionFlush
            // 
            this.cboxTransmissionFlush.AutoSize = true;
            this.cboxTransmissionFlush.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTransmissionFlush.Location = new System.Drawing.Point(6, 68);
            this.cboxTransmissionFlush.Name = "cboxTransmissionFlush";
            this.cboxTransmissionFlush.Size = new System.Drawing.Size(247, 30);
            this.cboxTransmissionFlush.TabIndex = 1;
            this.cboxTransmissionFlush.Text = "Transmission Flush ($80.00)";
            this.cboxTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // cboxRadiatorFlush
            // 
            this.cboxRadiatorFlush.AutoSize = true;
            this.cboxRadiatorFlush.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRadiatorFlush.Location = new System.Drawing.Point(6, 32);
            this.cboxRadiatorFlush.Name = "cboxRadiatorFlush";
            this.cboxRadiatorFlush.Size = new System.Drawing.Size(211, 30);
            this.cboxRadiatorFlush.TabIndex = 0;
            this.cboxRadiatorFlush.Text = "Radiator Flush ($30.00)";
            this.cboxRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxTireRotation);
            this.groupBox3.Controls.Add(this.cboxReplaceMuffler);
            this.groupBox3.Controls.Add(this.cboxInspection);
            this.groupBox3.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // cboxTireRotation
            // 
            this.cboxTireRotation.AutoSize = true;
            this.cboxTireRotation.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTireRotation.Location = new System.Drawing.Point(6, 102);
            this.cboxTireRotation.Name = "cboxTireRotation";
            this.cboxTireRotation.Size = new System.Drawing.Size(199, 30);
            this.cboxTireRotation.TabIndex = 2;
            this.cboxTireRotation.Text = "Tire Rotation ($20.00)";
            this.cboxTireRotation.UseVisualStyleBackColor = true;
            // 
            // cboxReplaceMuffler
            // 
            this.cboxReplaceMuffler.AutoSize = true;
            this.cboxReplaceMuffler.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxReplaceMuffler.Location = new System.Drawing.Point(6, 66);
            this.cboxReplaceMuffler.Name = "cboxReplaceMuffler";
            this.cboxReplaceMuffler.Size = new System.Drawing.Size(230, 30);
            this.cboxReplaceMuffler.TabIndex = 1;
            this.cboxReplaceMuffler.Text = "Replace Muffler ($100.00)";
            this.cboxReplaceMuffler.UseVisualStyleBackColor = true;
            // 
            // cboxInspection
            // 
            this.cboxInspection.AutoSize = true;
            this.cboxInspection.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxInspection.Location = new System.Drawing.Point(6, 30);
            this.cboxInspection.Name = "cboxInspection";
            this.cboxInspection.Size = new System.Drawing.Size(178, 30);
            this.cboxInspection.TabIndex = 0;
            this.cboxInspection.Text = "Inspection ($15.00)";
            this.cboxInspection.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tboxParts);
            this.groupBox4.Controls.Add(this.tboxLabor);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(362, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 145);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // tboxParts
            // 
            this.tboxParts.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxParts.Location = new System.Drawing.Point(92, 47);
            this.tboxParts.Name = "tboxParts";
            this.tboxParts.Size = new System.Drawing.Size(246, 31);
            this.tboxParts.TabIndex = 3;
            // 
            // tboxLabor
            // 
            this.tboxLabor.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxLabor.Location = new System.Drawing.Point(92, 90);
            this.tboxLabor.Name = "tboxLabor";
            this.tboxLabor.Size = new System.Drawing.Size(246, 31);
            this.tboxLabor.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Labor ($)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Parts";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblOutTotalFees);
            this.groupBox5.Controls.Add(this.lblOutTax);
            this.groupBox5.Controls.Add(this.lblOutParts);
            this.groupBox5.Controls.Add(this.lblOutServiceLabor);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(694, 213);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // lblOutTotalFees
            // 
            this.lblOutTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTotalFees.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTotalFees.Location = new System.Drawing.Point(179, 161);
            this.lblOutTotalFees.Name = "lblOutTotalFees";
            this.lblOutTotalFees.Size = new System.Drawing.Size(509, 35);
            this.lblOutTotalFees.TabIndex = 7;
            this.lblOutTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutTax
            // 
            this.lblOutTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutTax.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutTax.Location = new System.Drawing.Point(179, 116);
            this.lblOutTax.Name = "lblOutTax";
            this.lblOutTax.Size = new System.Drawing.Size(509, 35);
            this.lblOutTax.TabIndex = 6;
            this.lblOutTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutParts
            // 
            this.lblOutParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutParts.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutParts.Location = new System.Drawing.Point(179, 73);
            this.lblOutParts.Name = "lblOutParts";
            this.lblOutParts.Size = new System.Drawing.Size(509, 34);
            this.lblOutParts.TabIndex = 5;
            this.lblOutParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOutServiceLabor
            // 
            this.lblOutServiceLabor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutServiceLabor.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutServiceLabor.Location = new System.Drawing.Point(179, 27);
            this.lblOutServiceLabor.Name = "lblOutServiceLabor";
            this.lblOutServiceLabor.Size = new System.Drawing.Size(509, 37);
            this.lblOutServiceLabor.TabIndex = 4;
            this.lblOutServiceLabor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax (on parts)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service and Labor";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 517);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(389, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(407, 517);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(590, 517);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmJoeAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 577);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmJoeAutomotive";
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cboxLubeJob;
        private System.Windows.Forms.CheckBox cboxOilChange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxTransmissionFlush;
        private System.Windows.Forms.CheckBox cboxRadiatorFlush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cboxTireRotation;
        private System.Windows.Forms.CheckBox cboxReplaceMuffler;
        private System.Windows.Forms.CheckBox cboxInspection;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblOutTotalFees;
        private System.Windows.Forms.Label lblOutTax;
        private System.Windows.Forms.Label lblOutParts;
        private System.Windows.Forms.Label lblOutServiceLabor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxParts;
        private System.Windows.Forms.TextBox tboxLabor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

