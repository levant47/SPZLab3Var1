namespace SPZLab3Var1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.driversListBox = new System.Windows.Forms.ListBox();
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.generateDriverButton = new System.Windows.Forms.Button();
            this.deleteDriverButton = new System.Windows.Forms.Button();
            this.compareDriversButton = new System.Windows.Forms.Button();
            this.createDeviceButton = new System.Windows.Forms.Button();
            this.deleteDeviceButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.computerReadinessStatusStrip = new System.Windows.Forms.StatusStrip();
            this.computerReadinessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДРАЙВЕРЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(378, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "УСТРОЙСТВА";
            // 
            // driversListBox
            // 
            this.driversListBox.FormattingEnabled = true;
            this.driversListBox.ItemHeight = 15;
            this.driversListBox.Location = new System.Drawing.Point(12, 37);
            this.driversListBox.Name = "driversListBox";
            this.driversListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.driversListBox.Size = new System.Drawing.Size(251, 214);
            this.driversListBox.TabIndex = 2;
            this.driversListBox.DoubleClick += new System.EventHandler(this.driversListBox_DoubleClick);
            // 
            // deviceListBox
            // 
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.ItemHeight = 15;
            this.deviceListBox.Location = new System.Drawing.Point(312, 37);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(269, 214);
            this.deviceListBox.TabIndex = 3;
            this.deviceListBox.DoubleClick += new System.EventHandler(this.deviceListBox_DoubleClick);
            // 
            // generateDriverButton
            // 
            this.generateDriverButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateDriverButton.Location = new System.Drawing.Point(12, 257);
            this.generateDriverButton.Name = "generateDriverButton";
            this.generateDriverButton.Size = new System.Drawing.Size(251, 38);
            this.generateDriverButton.TabIndex = 4;
            this.generateDriverButton.Text = "ГЕНЕРАЦИЯ ДРАЙВЕРОВ";
            this.generateDriverButton.UseVisualStyleBackColor = true;
            this.generateDriverButton.Click += new System.EventHandler(this.generateDriverButton_Click);
            // 
            // deleteDriverButton
            // 
            this.deleteDriverButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDriverButton.Location = new System.Drawing.Point(13, 302);
            this.deleteDriverButton.Name = "deleteDriverButton";
            this.deleteDriverButton.Size = new System.Drawing.Size(108, 37);
            this.deleteDriverButton.TabIndex = 5;
            this.deleteDriverButton.Text = "УДАЛИТЬ";
            this.deleteDriverButton.UseVisualStyleBackColor = true;
            this.deleteDriverButton.Click += new System.EventHandler(this.deleteDriverButton_Click);
            // 
            // compareDriversButton
            // 
            this.compareDriversButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compareDriversButton.Location = new System.Drawing.Point(128, 302);
            this.compareDriversButton.Name = "compareDriversButton";
            this.compareDriversButton.Size = new System.Drawing.Size(135, 37);
            this.compareDriversButton.TabIndex = 6;
            this.compareDriversButton.Text = "СРАВНИТЬ";
            this.compareDriversButton.UseVisualStyleBackColor = true;
            this.compareDriversButton.Click += new System.EventHandler(this.compareDriversButton_Click);
            // 
            // createDeviceButton
            // 
            this.createDeviceButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createDeviceButton.Location = new System.Drawing.Point(312, 257);
            this.createDeviceButton.Name = "createDeviceButton";
            this.createDeviceButton.Size = new System.Drawing.Size(134, 38);
            this.createDeviceButton.TabIndex = 7;
            this.createDeviceButton.Text = "ДОБАВИТЬ";
            this.createDeviceButton.UseVisualStyleBackColor = true;
            this.createDeviceButton.Click += new System.EventHandler(this.createDeviceButton_Click);
            // 
            // deleteDeviceButton
            // 
            this.deleteDeviceButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteDeviceButton.Location = new System.Drawing.Point(452, 257);
            this.deleteDeviceButton.Name = "deleteDeviceButton";
            this.deleteDeviceButton.Size = new System.Drawing.Size(128, 38);
            this.deleteDeviceButton.TabIndex = 8;
            this.deleteDeviceButton.Text = "УДАЛИТЬ";
            this.deleteDeviceButton.UseVisualStyleBackColor = true;
            this.deleteDeviceButton.Click += new System.EventHandler(this.deleteDeviceButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(269, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = ">";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(269, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 36);
            this.button7.TabIndex = 10;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // computerReadinessStatusStrip
            // 
            this.computerReadinessStatusStrip.Location = new System.Drawing.Point(0, 345);
            this.computerReadinessStatusStrip.Name = "computerReadinessStatusStrip";
            this.computerReadinessStatusStrip.Size = new System.Drawing.Size(588, 22);
            this.computerReadinessStatusStrip.TabIndex = 11;
            this.computerReadinessStatusStrip.Text = "statusStrip1";
            // 
            // computerReadinessLabel
            // 
            this.computerReadinessLabel.AutoSize = true;
            this.computerReadinessLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.computerReadinessLabel.Location = new System.Drawing.Point(0, 350);
            this.computerReadinessLabel.Name = "computerReadinessLabel";
            this.computerReadinessLabel.Size = new System.Drawing.Size(43, 17);
            this.computerReadinessLabel.TabIndex = 12;
            this.computerReadinessLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 367);
            this.Controls.Add(this.computerReadinessLabel);
            this.Controls.Add(this.computerReadinessStatusStrip);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.deleteDeviceButton);
            this.Controls.Add(this.createDeviceButton);
            this.Controls.Add(this.compareDriversButton);
            this.Controls.Add(this.deleteDriverButton);
            this.Controls.Add(this.generateDriverButton);
            this.Controls.Add(this.deviceListBox);
            this.Controls.Add(this.driversListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox driversListBox;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Button generateDriverButton;
        private System.Windows.Forms.Button deleteDriverButton;
        private System.Windows.Forms.Button compareDriversButton;
        private System.Windows.Forms.Button createDeviceButton;
        private System.Windows.Forms.Button deleteDeviceButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.StatusStrip computerReadinessStatusStrip;
        private System.Windows.Forms.Label computerReadinessLabel;
    }
}

