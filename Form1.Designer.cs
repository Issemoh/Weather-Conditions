namespace Weathher
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lebel2 = new System.Windows.Forms.Label();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.lblWeather = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(112, 16);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 23);
            this.txtCity.TabIndex = 1;
            // 
            // lebel2
            // 
            this.lebel2.AutoSize = true;
            this.lebel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebel2.Location = new System.Drawing.Point(288, 16);
            this.lebel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lebel2.Name = "lebel2";
            this.lebel2.Size = new System.Drawing.Size(41, 17);
            this.lebel2.TabIndex = 2;
            this.lebel2.Text = "State";
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeather.Location = new System.Drawing.Point(536, 16);
            this.btnGetWeather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(136, 28);
            this.btnGetWeather.TabIndex = 4;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // picWeather
            // 
            this.picWeather.Location = new System.Drawing.Point(39, 81);
            this.picWeather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(663, 344);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWeather.TabIndex = 5;
            this.picWeather.TabStop = false;
            // 
            // lblWeather
            // 
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(197, 111);
            this.lblWeather.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(356, 69);
            this.lblWeather.TabIndex = 6;
            this.lblWeather.Text = "Enter city and state to get weather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(589, 433);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 45);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(352, 17);
            this.cbxState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(160, 24);
            this.cbxState.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 553);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.lebel2);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lebel2;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxState;
    }
}

