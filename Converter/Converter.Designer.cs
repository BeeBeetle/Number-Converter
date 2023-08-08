namespace Converter
{
    partial class Converter
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
            cmbInput = new ComboBox();
            cmbOutput = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnConvert = new Button();
            rtbInput = new RichTextBox();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // cmbInput
            // 
            cmbInput.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInput.FormattingEnabled = true;
            cmbInput.Location = new Point(20, 45);
            cmbInput.Name = "cmbInput";
            cmbInput.Size = new Size(127, 23);
            cmbInput.TabIndex = 0;
            // 
            // cmbOutput
            // 
            cmbOutput.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOutput.FormattingEnabled = true;
            cmbOutput.Location = new Point(187, 45);
            cmbOutput.Name = "cmbOutput";
            cmbOutput.Size = new Size(127, 23);
            cmbOutput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Convert from:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 20);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Convert to:";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(129, 214);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(20, 88);
            rtbInput.Name = "rtbInput";
            rtbInput.Size = new Size(127, 104);
            rtbInput.TabIndex = 6;
            rtbInput.Text = "";
            rtbInput.TextChanged += rtbInput_TextChanged;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(187, 88);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(127, 104);
            rtbOutput.TabIndex = 7;
            rtbOutput.Text = "";
            rtbOutput.TextChanged += rtbOutput_TextChanged;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 249);
            Controls.Add(rtbOutput);
            Controls.Add(rtbInput);
            Controls.Add(btnConvert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOutput);
            Controls.Add(cmbInput);
            Name = "Converter";
            Text = "Base Converter";
            Load += Converter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbInput;
        private ComboBox cmbOutput;
        private Label label1;
        private Label label2;
        private Button btnConvert;
        private RichTextBox rtbInput;
        private RichTextBox rtbOutput;
        private TextBox txtInput;
        private TextBox txtOutput;
    }
}