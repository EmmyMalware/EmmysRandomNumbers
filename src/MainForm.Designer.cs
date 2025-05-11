
namespace EmmysRandomNumbers
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoLabel = new System.Windows.Forms.Label();
            this.mottoLabel = new System.Windows.Forms.Label();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.genLabel = new System.Windows.Forms.Label();
            this.manPhoneGenButton = new System.Windows.Forms.Button();
            this.star67Button = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.genButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(12, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(482, 40);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "Emmy\'s Random Phone Numbers ";
            // 
            // mottoLabel
            // 
            this.mottoLabel.AutoSize = true;
            this.mottoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mottoLabel.Location = new System.Drawing.Point(153, 49);
            this.mottoLabel.Name = "mottoLabel";
            this.mottoLabel.Size = new System.Drawing.Size(179, 29);
            this.mottoLabel.TabIndex = 1;
            this.mottoLabel.Text = "for Google Voice!";
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Location = new System.Drawing.Point(100, 116);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(289, 21);
            this.selectComboBox.TabIndex = 2;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(100, 97);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(258, 13);
            this.selectLabel.TabIndex = 3;
            this.selectLabel.Text = "Select phone type (landline/cell, doesn\'t really matter)";
            // 
            // genTextBox
            // 
            this.genTextBox.Location = new System.Drawing.Point(103, 182);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(206, 20);
            this.genTextBox.TabIndex = 4;
            this.genTextBox.Text = "(909)-XXX-XXXX";
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Location = new System.Drawing.Point(100, 166);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(209, 13);
            this.genLabel.TabIndex = 5;
            this.genLabel.Text = "Generated Number (always starts with 909)";
            // 
            // manPhoneGenButton
            // 
            this.manPhoneGenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manPhoneGenButton.Location = new System.Drawing.Point(51, 281);
            this.manPhoneGenButton.Name = "manPhoneGenButton";
            this.manPhoneGenButton.Size = new System.Drawing.Size(391, 66);
            this.manPhoneGenButton.TabIndex = 6;
            this.manPhoneGenButton.Text = "Use manual phone generator";
            this.manPhoneGenButton.UseVisualStyleBackColor = true;
            this.manPhoneGenButton.Click += new System.EventHandler(this.manPhoneGenButton_Click);
            // 
            // star67Button
            // 
            this.star67Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.star67Button.Location = new System.Drawing.Point(51, 353);
            this.star67Button.Name = "star67Button";
            this.star67Button.Size = new System.Drawing.Size(391, 66);
            this.star67Button.TabIndex = 7;
            this.star67Button.Text = "Add *67 (makes you have no caller ID)";
            this.star67Button.UseVisualStyleBackColor = true;
            this.star67Button.Click += new System.EventHandler(this.star67Button_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(313, 180);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 8;
            this.copyButton.Text = "Copy!";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.Location = new System.Drawing.Point(51, 209);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(391, 66);
            this.genButton.TabIndex = 9;
            this.genButton.Text = "Generate Number!";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 429);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.star67Button);
            this.Controls.Add(this.manPhoneGenButton);
            this.Controls.Add(this.genLabel);
            this.Controls.Add(this.genTextBox);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.mottoLabel);
            this.Controls.Add(this.logoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emmy\'s Random Phone Numbers for Google Voice!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label mottoLabel;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Button manPhoneGenButton;
        private System.Windows.Forms.Button star67Button;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button genButton;
    }
}

