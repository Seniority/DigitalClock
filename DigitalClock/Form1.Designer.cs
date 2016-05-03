namespace DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAlarmStatus = new System.Windows.Forms.Label();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.radioAlarmOff = new System.Windows.Forms.RadioButton();
            this.radioAlarmOn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTime.Font = new System.Drawing.Font("Digital-7", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTime.Location = new System.Drawing.Point(10, 9);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(340, 80);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("Digital-7", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDate.Location = new System.Drawing.Point(12, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(338, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAlarmStatus
            // 
            this.lblAlarmStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblAlarmStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAlarmStatus.Font = new System.Drawing.Font("Digital-7", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmStatus.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblAlarmStatus.Location = new System.Drawing.Point(12, 134);
            this.lblAlarmStatus.Name = "lblAlarmStatus";
            this.lblAlarmStatus.Size = new System.Drawing.Size(173, 23);
            this.lblAlarmStatus.TabIndex = 2;
            this.lblAlarmStatus.Text = "Alarm Disabled";
            this.lblAlarmStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSetAlarm.Enabled = false;
            this.btnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetAlarm.Location = new System.Drawing.Point(10, 167);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(340, 30);
            this.btnSetAlarm.TabIndex = 3;
            this.btnSetAlarm.TabStop = false;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = false;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // radioAlarmOff
            // 
            this.radioAlarmOff.AutoSize = true;
            this.radioAlarmOff.Checked = true;
            this.radioAlarmOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAlarmOff.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioAlarmOff.Location = new System.Drawing.Point(273, 137);
            this.radioAlarmOff.Name = "radioAlarmOff";
            this.radioAlarmOff.Size = new System.Drawing.Size(75, 19);
            this.radioAlarmOff.TabIndex = 4;
            this.radioAlarmOff.TabStop = true;
            this.radioAlarmOff.Text = "Alarm Off";
            this.radioAlarmOff.UseVisualStyleBackColor = true;
            this.radioAlarmOff.CheckedChanged += new System.EventHandler(this.radioAlarmOff_CheckedChanged);
            // 
            // radioAlarmOn
            // 
            this.radioAlarmOn.AutoSize = true;
            this.radioAlarmOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAlarmOn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioAlarmOn.Location = new System.Drawing.Point(191, 137);
            this.radioAlarmOn.Name = "radioAlarmOn";
            this.radioAlarmOn.Size = new System.Drawing.Size(76, 19);
            this.radioAlarmOn.TabIndex = 5;
            this.radioAlarmOn.Text = "Alarm On";
            this.radioAlarmOn.UseVisualStyleBackColor = true;
            this.radioAlarmOn.CheckedChanged += new System.EventHandler(this.radioAlarmOn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(360, 202);
            this.Controls.Add(this.radioAlarmOn);
            this.Controls.Add(this.radioAlarmOff);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.lblAlarmStatus);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAlarmStatus;
        private System.Windows.Forms.RadioButton radioAlarmOff;
        private System.Windows.Forms.RadioButton radioAlarmOn;
        private System.Windows.Forms.Button btnSetAlarm;
    }
}

