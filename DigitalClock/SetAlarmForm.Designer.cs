namespace DigitalClock
{
    partial class SetAlarmForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnConfSet = new System.Windows.Forms.Button();
            this.comboxDate = new System.Windows.Forms.ComboBox();
            this.comboxHour = new System.Windows.Forms.ComboBox();
            this.comboxMinute = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("Digital-7", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 23);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTime.Font = new System.Drawing.Font("Digital-7", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTime.Location = new System.Drawing.Point(12, 41);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(107, 23);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time:";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfSet
            // 
            this.btnConfSet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfSet.Enabled = false;
            this.btnConfSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfSet.Location = new System.Drawing.Point(12, 79);
            this.btnConfSet.Name = "btnConfSet";
            this.btnConfSet.Size = new System.Drawing.Size(234, 30);
            this.btnConfSet.TabIndex = 6;
            this.btnConfSet.TabStop = false;
            this.btnConfSet.Text = "Confirm and Set";
            this.btnConfSet.UseVisualStyleBackColor = false;
            // 
            // comboxDate
            // 
            this.comboxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxDate.FormattingEnabled = true;
            this.comboxDate.Location = new System.Drawing.Point(125, 9);
            this.comboxDate.Name = "comboxDate";
            this.comboxDate.Size = new System.Drawing.Size(121, 24);
            this.comboxDate.TabIndex = 7;
            // 
            // comboxHour
            // 
            this.comboxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxHour.FormattingEnabled = true;
            this.comboxHour.Location = new System.Drawing.Point(125, 41);
            this.comboxHour.Name = "comboxHour";
            this.comboxHour.Size = new System.Drawing.Size(56, 24);
            this.comboxHour.TabIndex = 8;
            this.comboxHour.Text = "HH";
            // 
            // comboxMinute
            // 
            this.comboxMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxMinute.FormattingEnabled = true;
            this.comboxMinute.Location = new System.Drawing.Point(190, 41);
            this.comboxMinute.Name = "comboxMinute";
            this.comboxMinute.Size = new System.Drawing.Size(56, 24);
            this.comboxMinute.TabIndex = 9;
            this.comboxMinute.Text = "MM";
            // 
            // SetAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(258, 116);
            this.Controls.Add(this.comboxMinute);
            this.Controls.Add(this.comboxHour);
            this.Controls.Add(this.comboxDate);
            this.Controls.Add(this.btnConfSet);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.MaximizeBox = false;
            this.Name = "SetAlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Alarm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnConfSet;
        private System.Windows.Forms.ComboBox comboxDate;
        private System.Windows.Forms.ComboBox comboxHour;
        private System.Windows.Forms.ComboBox comboxMinute;
    }
}