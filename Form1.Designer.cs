namespace WeCare
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
            this.btnShowBmi = new System.Windows.Forms.Button();
            this.btnBloodScreen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rabYes = new System.Windows.Forms.RadioButton();
            this.rabNo = new System.Windows.Forms.RadioButton();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowBmi
            // 
            this.btnShowBmi.Location = new System.Drawing.Point(114, 178);
            this.btnShowBmi.Name = "btnShowBmi";
            this.btnShowBmi.Size = new System.Drawing.Size(139, 23);
            this.btnShowBmi.TabIndex = 0;
            this.btnShowBmi.Text = "Show my BMI";
            this.btnShowBmi.UseVisualStyleBackColor = true;
            this.btnShowBmi.Click += new System.EventHandler(this.btnShowBmi_Click);
            // 
            // btnBloodScreen
            // 
            this.btnBloodScreen.Location = new System.Drawing.Point(67, 292);
            this.btnBloodScreen.Name = "btnBloodScreen";
            this.btnBloodScreen.Size = new System.Drawing.Size(238, 23);
            this.btnBloodScreen.TabIndex = 1;
            this.btnBloodScreen.Text = "Do I need to have a Blood Screen Test?";
            this.btnBloodScreen.UseVisualStyleBackColor = true;
            this.btnBloodScreen.Click += new System.EventHandler(this.btnBloodScreen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(266, 379);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "We Care";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight ( kg ) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height ( m ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Diagnosed with PreDiabetes";
            // 
            // rabYes
            // 
            this.rabYes.AutoSize = true;
            this.rabYes.Location = new System.Drawing.Point(241, 260);
            this.rabYes.Name = "rabYes";
            this.rabYes.Size = new System.Drawing.Size(43, 17);
            this.rabYes.TabIndex = 8;
            this.rabYes.TabStop = true;
            this.rabYes.Text = "Yes";
            this.rabYes.UseVisualStyleBackColor = true;
            // 
            // rabNo
            // 
            this.rabNo.AutoSize = true;
            this.rabNo.Location = new System.Drawing.Point(302, 260);
            this.rabNo.Name = "rabNo";
            this.rabNo.Size = new System.Drawing.Size(39, 17);
            this.rabNo.TabIndex = 9;
            this.rabNo.TabStop = true;
            this.rabNo.Text = "No";
            this.rabNo.UseVisualStyleBackColor = true;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(241, 130);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 10;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(241, 83);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(67, 337);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(274, 20);
            this.txtResult.TabIndex = 12;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(241, 222);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 432);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.rabNo);
            this.Controls.Add(this.rabYes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBloodScreen);
            this.Controls.Add(this.btnShowBmi);
            this.Name = "Form1";
            this.Text = "Diabetes_Diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBmi;
        private System.Windows.Forms.Button btnBloodScreen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rabYes;
        private System.Windows.Forms.RadioButton rabNo;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtAge;
    }
}

