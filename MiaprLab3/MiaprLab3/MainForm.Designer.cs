namespace MiaprLab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VerTrackBar = new System.Windows.Forms.TrackBar();
            this.VerOneLabel = new System.Windows.Forms.Label();
            this.VerTwoLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumErrorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.error2TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.error1TextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.CoordinationPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VerTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VerTrackBar
            // 
            this.VerTrackBar.Location = new System.Drawing.Point(875, 22);
            this.VerTrackBar.Maximum = 100;
            this.VerTrackBar.Name = "VerTrackBar";
            this.VerTrackBar.Size = new System.Drawing.Size(104, 45);
            this.VerTrackBar.TabIndex = 0;
            this.VerTrackBar.ValueChanged += new System.EventHandler(this.VerTrackBar_ValueChanged);
            // 
            // VerOneLabel
            // 
            this.VerOneLabel.AutoSize = true;
            this.VerOneLabel.Location = new System.Drawing.Point(969, 80);
            this.VerOneLabel.Name = "VerOneLabel";
            this.VerOneLabel.Size = new System.Drawing.Size(13, 13);
            this.VerOneLabel.TabIndex = 1;
            this.VerOneLabel.Text = "0";
            // 
            // VerTwoLabel
            // 
            this.VerTwoLabel.AutoSize = true;
            this.VerTwoLabel.Location = new System.Drawing.Point(969, 110);
            this.VerTwoLabel.Name = "VerTwoLabel";
            this.VerTwoLabel.Size = new System.Drawing.Size(13, 13);
            this.VerTwoLabel.TabIndex = 2;
            this.VerTwoLabel.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вероятность 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(950, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(950, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Суммарная ошибка классификации";
            // 
            // sumErrorTextBox
            // 
            this.sumErrorTextBox.Location = new System.Drawing.Point(885, 390);
            this.sumErrorTextBox.Name = "sumErrorTextBox";
            this.sumErrorTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumErrorTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Вероятность пропуска обнаружения";
            // 
            // error2TextBox
            // 
            this.error2TextBox.Location = new System.Drawing.Point(885, 364);
            this.error2TextBox.Name = "error2TextBox";
            this.error2TextBox.Size = new System.Drawing.Size(100, 20);
            this.error2TextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Вероятность ложной тревоги";
            // 
            // error1TextBox
            // 
            this.error1TextBox.Location = new System.Drawing.Point(885, 339);
            this.error1TextBox.Name = "error1TextBox";
            this.error1TextBox.Size = new System.Drawing.Size(100, 20);
            this.error1TextBox.TabIndex = 14;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(904, 154);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 21;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CoordinationPanel
            // 
            this.CoordinationPanel.Location = new System.Drawing.Point(13, 13);
            this.CoordinationPanel.Name = "CoordinationPanel";
            this.CoordinationPanel.Size = new System.Drawing.Size(842, 326);
            this.CoordinationPanel.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 419);
            this.Controls.Add(this.CoordinationPanel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumErrorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error2TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.error1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VerTwoLabel);
            this.Controls.Add(this.VerOneLabel);
            this.Controls.Add(this.VerTrackBar);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.VerTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar VerTrackBar;
        private System.Windows.Forms.Label VerOneLabel;
        private System.Windows.Forms.Label VerTwoLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumErrorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox error2TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox error1TextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Panel CoordinationPanel;
    }
}

