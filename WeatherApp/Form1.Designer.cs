namespace WeatherApp
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
            label1 = new Label();
            txtCityName = new TextBox();
            label2 = new Label();
            lblTemprature = new Label();
            label4 = new Label();
            lblCondition = new Label();
            btnGetWeather = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter City Name :";
            label1.Click += label1_Click;
            // 
            // txtCityName
            // 
            txtCityName.Location = new Point(145, 31);
            txtCityName.Name = "txtCityName";
            txtCityName.Size = new Size(106, 23);
            txtCityName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Temprature :";
            label2.Click += label2_Click;
            // 
            // lblTemprature
            // 
            lblTemprature.AutoSize = true;
            lblTemprature.Location = new Point(145, 78);
            lblTemprature.Name = "lblTemprature";
            lblTemprature.Size = new Size(38, 15);
            lblTemprature.TabIndex = 3;
            lblTemprature.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 122);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 4;
            label4.Text = "Weather Condition :";
            label4.Click += label4_Click;
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Location = new Point(159, 122);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(38, 15);
            lblCondition.TabIndex = 5;
            lblCondition.Text = "label5";
            lblCondition.Click += lblCondition_Click;
            // 
            // btnGetWeather
            // 
            btnGetWeather.Location = new Point(317, 245);
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.Size = new Size(124, 34);
            btnGetWeather.TabIndex = 6;
            btnGetWeather.Text = "button1";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(12, 61, 135);
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetWeather);
            Controls.Add(lblCondition);
            Controls.Add(label4);
            Controls.Add(lblTemprature);
            Controls.Add(label2);
            Controls.Add(txtCityName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCityName;
        private Label label2;
        private Label lblTemprature;
        private Label label4;
        private Label lblCondition;
        private Button btnGetWeather;


    }
}
