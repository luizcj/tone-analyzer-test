namespace ToneAnalyzerTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.crtEmotion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtLanguage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtSocial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtEmotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAuth
            // 
            this.grpAuth.Controls.Add(this.txtPassword);
            this.grpAuth.Controls.Add(this.txtUsername);
            this.grpAuth.Controls.Add(this.lblPassword);
            this.grpAuth.Controls.Add(this.lblUsername);
            this.grpAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAuth.Location = new System.Drawing.Point(32, 48);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(1852, 166);
            this.grpAuth.TabIndex = 3;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "Authorization";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(220, 103);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(601, 38);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "<service_password>";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(220, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(601, 38);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "<service_username>";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(41, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(142, 31);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(37, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(147, 31);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(32, 237);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(1852, 205);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = resources.GetString("txtInput.Text");
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.Location = new System.Drawing.Point(820, 467);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(292, 69);
            this.btnAnalyze.TabIndex = 4;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(32, 562);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1852, 205);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.TabStop = false;
            // 
            // crtEmotion
            // 
            this.crtEmotion.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.crtEmotion.ChartAreas.Add(chartArea1);
            this.crtEmotion.Location = new System.Drawing.Point(32, 812);
            this.crtEmotion.Name = "crtEmotion";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.crtEmotion.Series.Add(series1);
            this.crtEmotion.Size = new System.Drawing.Size(600, 418);
            this.crtEmotion.TabIndex = 7;
            this.crtEmotion.TabStop = false;
            this.crtEmotion.Text = "chart1";
            // 
            // crtLanguage
            // 
            this.crtLanguage.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.crtLanguage.ChartAreas.Add(chartArea2);
            this.crtLanguage.Location = new System.Drawing.Point(656, 812);
            this.crtLanguage.Name = "crtLanguage";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.crtLanguage.Series.Add(series2);
            this.crtLanguage.Size = new System.Drawing.Size(600, 418);
            this.crtLanguage.TabIndex = 8;
            this.crtLanguage.TabStop = false;
            this.crtLanguage.Text = "chart1";
            // 
            // crtSocial
            // 
            this.crtSocial.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.Name = "ChartArea1";
            this.crtSocial.ChartAreas.Add(chartArea3);
            this.crtSocial.Location = new System.Drawing.Point(1284, 812);
            this.crtSocial.Name = "crtSocial";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.crtSocial.Series.Add(series3);
            this.crtSocial.Size = new System.Drawing.Size(600, 418);
            this.crtSocial.TabIndex = 9;
            this.crtSocial.TabStop = false;
            this.crtSocial.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 1284);
            this.Controls.Add(this.crtSocial);
            this.Controls.Add(this.crtLanguage);
            this.Controls.Add(this.crtEmotion);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.grpAuth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tone Analyzer Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtEmotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtEmotion;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtLanguage;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtSocial;
    }
}

