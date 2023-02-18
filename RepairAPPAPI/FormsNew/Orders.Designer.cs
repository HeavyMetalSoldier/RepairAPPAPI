﻿namespace RepairAPPAPI
{
    partial class Orders
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
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Execution = new System.Windows.Forms.MaskedTextBox();
            this.textBox_ClientName = new System.Windows.Forms.ComboBox();
            this.textBox_ServiceName = new System.Windows.Forms.ComboBox();
            this.textBox_Progress = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(250)))), ((int)(((byte)(133)))));
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Save.Location = new System.Drawing.Point(299, 315);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(156, 40);
            this.button_Save.TabIndex = 38;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(133)))), ((int)(((byte)(146)))));
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Clear.Location = new System.Drawing.Point(155, 315);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(124, 40);
            this.button_Clear.TabIndex = 37;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(94, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Прогресс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Срок выполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Название услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Создание нового заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "ФИО Клиента";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Description.Location = new System.Drawing.Point(219, 161);
            this.textBox_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(236, 27);
            this.textBox_Description.TabIndex = 28;
            // 
            // textBox_Execution
            // 
            this.textBox_Execution.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Execution.Location = new System.Drawing.Point(219, 202);
            this.textBox_Execution.Mask = "00/00/0000";
            this.textBox_Execution.Name = "textBox_Execution";
            this.textBox_Execution.Size = new System.Drawing.Size(236, 30);
            this.textBox_Execution.TabIndex = 39;
            this.textBox_Execution.ValidatingType = typeof(System.DateTime);
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ClientName.FormattingEnabled = true;
            this.textBox_ClientName.Location = new System.Drawing.Point(219, 77);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.Size = new System.Drawing.Size(236, 31);
            this.textBox_ClientName.TabIndex = 43;
            this.textBox_ClientName.SelectedIndexChanged += new System.EventHandler(this.textBox_ClientID_SelectedIndexChanged);
            // 
            // textBox_ServiceName
            // 
            this.textBox_ServiceName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ServiceName.FormattingEnabled = true;
            this.textBox_ServiceName.Location = new System.Drawing.Point(219, 119);
            this.textBox_ServiceName.Name = "textBox_ServiceName";
            this.textBox_ServiceName.Size = new System.Drawing.Size(236, 31);
            this.textBox_ServiceName.TabIndex = 44;
            // 
            // textBox_Progress
            // 
            this.textBox_Progress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Progress.FormattingEnabled = true;
            this.textBox_Progress.Location = new System.Drawing.Point(219, 243);
            this.textBox_Progress.Name = "textBox_Progress";
            this.textBox_Progress.Size = new System.Drawing.Size(236, 31);
            this.textBox_Progress.TabIndex = 45;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 379);
            this.Controls.Add(this.textBox_Progress);
            this.Controls.Add(this.textBox_ServiceName);
            this.Controls.Add(this.textBox_ClientName);
            this.Controls.Add(this.textBox_Execution);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Description);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Orders";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.MaskedTextBox textBox_Execution;
        private System.Windows.Forms.ComboBox textBox_ServiceName;
        private System.Windows.Forms.ComboBox textBox_ClientName;
        private System.Windows.Forms.ComboBox textBox_Progress;
    }
}