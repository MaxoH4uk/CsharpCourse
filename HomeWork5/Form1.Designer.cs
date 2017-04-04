namespace HomeWork5
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.doorsCount = new System.Windows.Forms.NumericUpDown();
            this.wheelsCount = new System.Windows.Forms.NumericUpDown();
            this.doorNumber = new System.Windows.Forms.NumericUpDown();
            this.moveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.doorsCountLabel = new System.Windows.Forms.Label();
            this.wheelsCountLabel = new System.Windows.Forms.Label();
            this.doorNumberLabel = new System.Windows.Forms.Label();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.carName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doorsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(266, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(281, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // doorsCount
            // 
            this.doorsCount.Location = new System.Drawing.Point(60, 41);
            this.doorsCount.Name = "doorsCount";
            this.doorsCount.Size = new System.Drawing.Size(120, 20);
            this.doorsCount.TabIndex = 1;
            // 
            // wheelsCount
            // 
            this.wheelsCount.Location = new System.Drawing.Point(60, 96);
            this.wheelsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wheelsCount.Name = "wheelsCount";
            this.wheelsCount.Size = new System.Drawing.Size(120, 20);
            this.wheelsCount.TabIndex = 2;
            this.wheelsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // doorNumber
            // 
            this.doorNumber.Location = new System.Drawing.Point(60, 150);
            this.doorNumber.Name = "doorNumber";
            this.doorNumber.Size = new System.Drawing.Size(120, 20);
            this.doorNumber.TabIndex = 3;
            this.doorNumber.ValueChanged += new System.EventHandler(this.doorNumber_ValueChanged);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(35, 247);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 4;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(116, 247);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // doorsCountLabel
            // 
            this.doorsCountLabel.AutoSize = true;
            this.doorsCountLabel.Location = new System.Drawing.Point(57, 18);
            this.doorsCountLabel.Name = "doorsCountLabel";
            this.doorsCountLabel.Size = new System.Drawing.Size(105, 13);
            this.doorsCountLabel.TabIndex = 6;
            this.doorsCountLabel.Text = "Количество дверей";
            this.doorsCountLabel.Click += new System.EventHandler(this.doorsCountLabel_Click);
            // 
            // wheelsCountLabel
            // 
            this.wheelsCountLabel.AutoSize = true;
            this.wheelsCountLabel.Location = new System.Drawing.Point(57, 80);
            this.wheelsCountLabel.Name = "wheelsCountLabel";
            this.wheelsCountLabel.Size = new System.Drawing.Size(99, 13);
            this.wheelsCountLabel.TabIndex = 7;
            this.wheelsCountLabel.Text = "Количество колес";
            // 
            // doorNumberLabel
            // 
            this.doorNumberLabel.AutoSize = true;
            this.doorNumberLabel.Location = new System.Drawing.Point(57, 128);
            this.doorNumberLabel.Name = "doorNumberLabel";
            this.doorNumberLabel.Size = new System.Drawing.Size(74, 13);
            this.doorNumberLabel.TabIndex = 8;
            this.doorNumberLabel.Text = "Номер двери";
            // 
            // carNameLabel
            // 
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.Location = new System.Drawing.Point(57, 184);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(91, 13);
            this.carNameLabel.TabIndex = 9;
            this.carNameLabel.Text = "Модель машины";
            this.carNameLabel.Click += new System.EventHandler(this.carNameLabel_Click);
            // 
            // carName
            // 
            this.carName.Location = new System.Drawing.Point(60, 209);
            this.carName.Name = "carName";
            this.carName.Size = new System.Drawing.Size(120, 20);
            this.carName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 322);
            this.Controls.Add(this.carName);
            this.Controls.Add(this.carNameLabel);
            this.Controls.Add(this.doorNumberLabel);
            this.Controls.Add(this.wheelsCountLabel);
            this.Controls.Add(this.doorsCountLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.doorNumber);
            this.Controls.Add(this.wheelsCount);
            this.Controls.Add(this.doorsCount);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "HomeWork5";
            ((System.ComponentModel.ISupportInitialize)(this.doorsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown doorsCount;
        private System.Windows.Forms.NumericUpDown wheelsCount;
        private System.Windows.Forms.NumericUpDown doorNumber;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label doorsCountLabel;
        private System.Windows.Forms.Label wheelsCountLabel;
        private System.Windows.Forms.Label doorNumberLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label carNameLabel;
        private System.Windows.Forms.TextBox carName;
    }
}

