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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.cbTimeMin = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSnooze = new System.Windows.Forms.Label();
            this.lblSnoozeMin = new System.Windows.Forms.Label();
            this.cbTimeHour = new System.Windows.Forms.ComboBox();
            this.cbSnoozMin = new System.Windows.Forms.ComboBox();
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
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(12, 118);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(107, 30);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbDate
            // 
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {
            "Today"});
            this.cbDate.Location = new System.Drawing.Point(125, 9);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(121, 24);
            this.cbDate.TabIndex = 7;
            // 
            // cbTimeMin
            // 
            this.cbTimeMin.DropDownHeight = 100;
            this.cbTimeMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeMin.FormattingEnabled = true;
            this.cbTimeMin.IntegralHeight = false;
            this.cbTimeMin.Items.AddRange(new object[] {
            "Min.",
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbTimeMin.Location = new System.Drawing.Point(190, 41);
            this.cbTimeMin.MaxDropDownItems = 10;
            this.cbTimeMin.Name = "cbTimeMin";
            this.cbTimeMin.Size = new System.Drawing.Size(56, 24);
            this.cbTimeMin.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(139, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSnooze
            // 
            this.lblSnooze.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSnooze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSnooze.Font = new System.Drawing.Font("Digital-7", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnooze.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblSnooze.Location = new System.Drawing.Point(12, 73);
            this.lblSnooze.Name = "lblSnooze";
            this.lblSnooze.Size = new System.Drawing.Size(107, 23);
            this.lblSnooze.TabIndex = 11;
            this.lblSnooze.Text = "Snooze:";
            this.lblSnooze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnoozeMin
            // 
            this.lblSnoozeMin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSnoozeMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSnoozeMin.Font = new System.Drawing.Font("Digital-7", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnoozeMin.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblSnoozeMin.Location = new System.Drawing.Point(190, 73);
            this.lblSnoozeMin.Name = "lblSnoozeMin";
            this.lblSnoozeMin.Size = new System.Drawing.Size(56, 23);
            this.lblSnoozeMin.TabIndex = 13;
            this.lblSnoozeMin.Text = "Minutes";
            this.lblSnoozeMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTimeHour
            // 
            this.cbTimeHour.DropDownHeight = 100;
            this.cbTimeHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeHour.FormattingEnabled = true;
            this.cbTimeHour.IntegralHeight = false;
            this.cbTimeHour.Items.AddRange(new object[] {
            "Hour",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbTimeHour.Location = new System.Drawing.Point(125, 40);
            this.cbTimeHour.MaxDropDownItems = 10;
            this.cbTimeHour.Name = "cbTimeHour";
            this.cbTimeHour.Size = new System.Drawing.Size(56, 24);
            this.cbTimeHour.TabIndex = 14;
            // 
            // cbSnoozMin
            // 
            this.cbSnoozMin.DropDownHeight = 100;
            this.cbSnoozMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSnoozMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSnoozMin.FormattingEnabled = true;
            this.cbSnoozMin.IntegralHeight = false;
            this.cbSnoozMin.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20"});
            this.cbSnoozMin.Location = new System.Drawing.Point(124, 73);
            this.cbSnoozMin.Name = "cbSnoozMin";
            this.cbSnoozMin.Size = new System.Drawing.Size(56, 24);
            this.cbSnoozMin.TabIndex = 15;
            // 
            // SetAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(258, 160);
            this.Controls.Add(this.cbSnoozMin);
            this.Controls.Add(this.cbTimeHour);
            this.Controls.Add(this.lblSnoozeMin);
            this.Controls.Add(this.lblSnooze);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbTimeMin);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.MaximizeBox = false;
            this.Name = "SetAlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Alarm";
            this.Load += new System.EventHandler(this.SetAlarmForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.ComboBox cbTimeMin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSnooze;
        private System.Windows.Forms.Label lblSnoozeMin;
        private System.Windows.Forms.ComboBox cbTimeHour;
        private System.Windows.Forms.ComboBox cbSnoozMin;
        private System.Windows.Forms.Button btnConfirm;
    }
}