namespace WindowsFormsApplication1
{
    partial class AutoCenterForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.packageLabel = new System.Windows.Forms.Label();
            this.fragranceLabel = new System.Windows.Forms.Label();
            this.packageComboBox = new System.Windows.Forms.ComboBox();
            this.fragranceComboBox = new System.Windows.Forms.ComboBox();
            this.packageTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(125, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(147, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "JJ Auto Center";
            // 
            // packageLabel
            // 
            this.packageLabel.AutoSize = true;
            this.packageLabel.Location = new System.Drawing.Point(25, 65);
            this.packageLabel.Name = "packageLabel";
            this.packageLabel.Size = new System.Drawing.Size(50, 13);
            this.packageLabel.TabIndex = 1;
            this.packageLabel.Text = "Package";
            // 
            // fragranceLabel
            // 
            this.fragranceLabel.AutoSize = true;
            this.fragranceLabel.Location = new System.Drawing.Point(25, 190);
            this.fragranceLabel.Name = "fragranceLabel";
            this.fragranceLabel.Size = new System.Drawing.Size(55, 13);
            this.fragranceLabel.TabIndex = 2;
            this.fragranceLabel.Text = "Fragrance";
            // 
            // packageComboBox
            // 
            this.packageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packageComboBox.FormattingEnabled = true;
            this.packageComboBox.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.packageComboBox.Location = new System.Drawing.Point(28, 90);
            this.packageComboBox.Name = "packageComboBox";
            this.packageComboBox.Size = new System.Drawing.Size(121, 21);
            this.packageComboBox.TabIndex = 3;
            // 
            // fragranceComboBox
            // 
            this.fragranceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fragranceComboBox.FormattingEnabled = true;
            this.fragranceComboBox.Items.AddRange(new object[] {
            "Hawaiian Mist",
            "Baby Powder",
            "Pine",
            "Country Floral",
            "Pina Colada",
            "Vanilla"});
            this.fragranceComboBox.Location = new System.Drawing.Point(28, 216);
            this.fragranceComboBox.Name = "fragranceComboBox";
            this.fragranceComboBox.Size = new System.Drawing.Size(121, 21);
            this.fragranceComboBox.TabIndex = 4;
            // 
            // packageTextBox
            // 
            this.packageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.packageTextBox.Location = new System.Drawing.Point(177, 90);
            this.packageTextBox.Multiline = true;
            this.packageTextBox.Name = "packageTextBox";
            this.packageTextBox.ReadOnly = true;
            this.packageTextBox.Size = new System.Drawing.Size(188, 76);
            this.packageTextBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(177, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(188, 76);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exterior Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Interior Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thomas Herr";
            // 
            // AutoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.packageTextBox);
            this.Controls.Add(this.fragranceComboBox);
            this.Controls.Add(this.packageComboBox);
            this.Controls.Add(this.fragranceLabel);
            this.Controls.Add(this.packageLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AutoCenterForm";
            this.Text = "JJ Auto Center";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label packageLabel;
        private System.Windows.Forms.Label fragranceLabel;
        private System.Windows.Forms.ComboBox packageComboBox;
        private System.Windows.Forms.ComboBox fragranceComboBox;
        private System.Windows.Forms.TextBox packageTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

