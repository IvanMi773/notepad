namespace blocknote
{
    partial class FontSettings
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
            this.ExampleLabel = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.AutoSize = true;
            this.ExampleLabel.Location = new System.Drawing.Point(25, 132);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(55, 17);
            this.ExampleLabel.TabIndex = 0;
            this.ExampleLabel.Text = "Зразок";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.ExampleText.Location = new System.Drawing.Point(33, 153);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(227, 51);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbYyZz";
            // 
            // fontBox
            // 
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.fontBox.Location = new System.Drawing.Point(12, 47);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(100, 24);
            this.fontBox.TabIndex = 4;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Розмір шрифту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стиль шрифту";
            // 
            // styleBox
            // 
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "звичайний",
            "курсив",
            "жирний"});
            this.styleBox.Location = new System.Drawing.Point(175, 48);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(100, 24);
            this.styleBox.TabIndex = 7;
            this.styleBox.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Застосувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.ExampleLabel);
            this.Name = "FontSettings";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExampleLabel;
        private System.Windows.Forms.Label ExampleText;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Button button1;
    }
}