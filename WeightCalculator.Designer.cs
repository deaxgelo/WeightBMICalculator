namespace WeightCalculator
{
    partial class WeightCalculator
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
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.grpAge = new System.Windows.Forms.GroupBox();
            this.rdoOver30 = new System.Windows.Forms.RadioButton();
            this.rdo30aU = new System.Windows.Forms.RadioButton();
            this.grpWeight = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblPounds = new System.Windows.Forms.Label();
            this.grpMeasurements = new System.Windows.Forms.GroupBox();
            this.lblCalf = new System.Windows.Forms.Label();
            this.lblThighs = new System.Windows.Forms.Label();
            this.txtWrist = new System.Windows.Forms.TextBox();
            this.txtCalf = new System.Windows.Forms.TextBox();
            this.txtThigh = new System.Windows.Forms.TextBox();
            this.txtWaist = new System.Windows.Forms.TextBox();
            this.lblWrist = new System.Windows.Forms.Label();
            this.lblWaist = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            this.grpAge.SuspendLayout();
            this.grpWeight.SuspendLayout();
            this.grpMeasurements.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Location = new System.Drawing.Point(12, 12);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(169, 43);
            this.grpGender.TabIndex = 0;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoFemale
            // 
            this.rdoFemale.Location = new System.Drawing.Point(80, 18);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(83, 19);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 18);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 19);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // grpAge
            // 
            this.grpAge.Controls.Add(this.rdoOver30);
            this.grpAge.Controls.Add(this.rdo30aU);
            this.grpAge.Location = new System.Drawing.Point(202, 12);
            this.grpAge.Name = "grpAge";
            this.grpAge.Size = new System.Drawing.Size(187, 43);
            this.grpAge.TabIndex = 1;
            this.grpAge.TabStop = false;
            this.grpAge.Text = "Age";
            // 
            // rdoOver30
            // 
            this.rdoOver30.Location = new System.Drawing.Point(110, 18);
            this.rdoOver30.Name = "rdoOver30";
            this.rdoOver30.Size = new System.Drawing.Size(71, 19);
            this.rdoOver30.TabIndex = 1;
            this.rdoOver30.Text = "Over 30";
            this.rdoOver30.UseVisualStyleBackColor = true;
            // 
            // rdo30aU
            // 
            this.rdo30aU.Checked = true;
            this.rdo30aU.Location = new System.Drawing.Point(6, 18);
            this.rdo30aU.Name = "rdo30aU";
            this.rdo30aU.Size = new System.Drawing.Size(98, 19);
            this.rdo30aU.TabIndex = 0;
            this.rdo30aU.TabStop = true;
            this.rdo30aU.Text = "30 and under";
            this.rdo30aU.UseVisualStyleBackColor = true;
            // 
            // grpWeight
            // 
            this.grpWeight.Controls.Add(this.txtWeight);
            this.grpWeight.Controls.Add(this.lblPounds);
            this.grpWeight.Location = new System.Drawing.Point(395, 12);
            this.grpWeight.Name = "grpWeight";
            this.grpWeight.Size = new System.Drawing.Size(107, 43);
            this.grpWeight.TabIndex = 2;
            this.grpWeight.TabStop = false;
            this.grpWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(6, 18);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(51, 21);
            this.txtWeight.TabIndex = 1;
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPounds.Location = new System.Drawing.Point(58, 20);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(43, 13);
            this.lblPounds.TabIndex = 0;
            this.lblPounds.Text = "Pounds";
            // 
            // grpMeasurements
            // 
            this.grpMeasurements.Controls.Add(this.lblCalf);
            this.grpMeasurements.Controls.Add(this.lblThighs);
            this.grpMeasurements.Controls.Add(this.txtWrist);
            this.grpMeasurements.Controls.Add(this.txtCalf);
            this.grpMeasurements.Controls.Add(this.txtThigh);
            this.grpMeasurements.Controls.Add(this.txtWaist);
            this.grpMeasurements.Controls.Add(this.lblWrist);
            this.grpMeasurements.Controls.Add(this.lblWaist);
            this.grpMeasurements.Location = new System.Drawing.Point(12, 85);
            this.grpMeasurements.Name = "grpMeasurements";
            this.grpMeasurements.Size = new System.Drawing.Size(490, 155);
            this.grpMeasurements.TabIndex = 3;
            this.grpMeasurements.TabStop = false;
            this.grpMeasurements.Text = "Measurements in inches";
            // 
            // lblCalf
            // 
            this.lblCalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalf.Location = new System.Drawing.Point(77, 98);
            this.lblCalf.Name = "lblCalf";
            this.lblCalf.Size = new System.Drawing.Size(411, 19);
            this.lblCalf.TabIndex = 7;
            this.lblCalf.Text = "CALF - Stand with weight on both feet. Widest part midway between knee and ankle";
            this.lblCalf.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblThighs
            // 
            this.lblThighs.AllowDrop = true;
            this.lblThighs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThighs.Location = new System.Drawing.Point(77, 64);
            this.lblThighs.Name = "lblThighs";
            this.lblThighs.Size = new System.Drawing.Size(392, 19);
            this.lblThighs.TabIndex = 8;
            this.lblThighs.Text = "THIGH - Stand with feet 12 inches apart. Measure widest part of upper thigh.";
            this.lblThighs.UseWaitCursor = true;
            this.lblThighs.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtWrist
            // 
            this.txtWrist.Location = new System.Drawing.Point(16, 128);
            this.txtWrist.Name = "txtWrist";
            this.txtWrist.Size = new System.Drawing.Size(55, 21);
            this.txtWrist.TabIndex = 7;
            // 
            // txtCalf
            // 
            this.txtCalf.Location = new System.Drawing.Point(16, 98);
            this.txtCalf.Name = "txtCalf";
            this.txtCalf.Size = new System.Drawing.Size(55, 21);
            this.txtCalf.TabIndex = 6;
            // 
            // txtThigh
            // 
            this.txtThigh.Location = new System.Drawing.Point(16, 64);
            this.txtThigh.Name = "txtThigh";
            this.txtThigh.Size = new System.Drawing.Size(55, 21);
            this.txtThigh.TabIndex = 5;
            // 
            // txtWaist
            // 
            this.txtWaist.Location = new System.Drawing.Point(16, 30);
            this.txtWaist.Name = "txtWaist";
            this.txtWaist.Size = new System.Drawing.Size(55, 21);
            this.txtWaist.TabIndex = 4;
            // 
            // lblWrist
            // 
            this.lblWrist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrist.Location = new System.Drawing.Point(77, 133);
            this.lblWrist.Name = "lblWrist";
            this.lblWrist.Size = new System.Drawing.Size(388, 19);
            this.lblWrist.TabIndex = 3;
            this.lblWrist.Text = "WRIST - Measure just aboce bony protuberance towards the hand.";
            // 
            // lblWaist
            // 
            this.lblWaist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaist.Location = new System.Drawing.Point(77, 30);
            this.lblWaist.Name = "lblWaist";
            this.lblWaist.Size = new System.Drawing.Size(388, 19);
            this.lblWaist.TabIndex = 0;
            this.lblWaist.Text = "WAIST - Measure at greatest circumference: relaxed and comfortable.";
            this.lblWaist.Click += new System.EventHandler(this.lblWaist_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 279);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(80, 39);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResults);
            this.grpResults.Location = new System.Drawing.Point(141, 279);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(373, 69);
            this.grpResults.TabIndex = 6;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(17, 24);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(342, 32);
            this.lblResults.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 24);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // WeightCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 404);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpMeasurements);
            this.Controls.Add(this.grpWeight);
            this.Controls.Add(this.grpAge);
            this.Controls.Add(this.grpGender);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeightCalculator";
            this.Text = "Convert Bailey\'s Tape-Measure Fat Formula";
            this.grpGender.ResumeLayout(false);
            this.grpAge.ResumeLayout(false);
            this.grpWeight.ResumeLayout(false);
            this.grpWeight.PerformLayout();
            this.grpMeasurements.ResumeLayout(false);
            this.grpMeasurements.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.GroupBox grpAge;
        private System.Windows.Forms.RadioButton rdoOver30;
        private System.Windows.Forms.RadioButton rdo30aU;
        private System.Windows.Forms.GroupBox grpWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.GroupBox grpMeasurements;
        private System.Windows.Forms.Label lblWaist;
        private System.Windows.Forms.Label lblWrist;
        private System.Windows.Forms.TextBox txtCalf;
        private System.Windows.Forms.TextBox txtThigh;
        private System.Windows.Forms.TextBox txtWaist;
        private System.Windows.Forms.TextBox txtWrist;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblThighs;
        private System.Windows.Forms.Label lblCalf;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnReset;
    }
}

