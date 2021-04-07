namespace CIS162AD_BowenEmily_Assignment_11
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
            this.laborTB = new System.Windows.Forms.TextBox();
            this.materialTB = new System.Windows.Forms.TextBox();
            this.subtotalTB = new System.Windows.Forms.TextBox();
            this.taxTB = new System.Windows.Forms.TextBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.laborLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laborTB
            // 
            this.laborTB.Location = new System.Drawing.Point(105, 76);
            this.laborTB.Name = "laborTB";
            this.laborTB.Size = new System.Drawing.Size(100, 20);
            this.laborTB.TabIndex = 0;
            this.laborTB.TextChanged += new System.EventHandler(this.labelTB_TextChanged);
            // 
            // materialTB
            // 
            this.materialTB.Location = new System.Drawing.Point(105, 131);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(100, 20);
            this.materialTB.TabIndex = 1;
            // 
            // subtotalTB
            // 
            this.subtotalTB.Location = new System.Drawing.Point(501, 76);
            this.subtotalTB.Name = "subtotalTB";
            this.subtotalTB.Size = new System.Drawing.Size(100, 20);
            this.subtotalTB.TabIndex = 2;
            // 
            // taxTB
            // 
            this.taxTB.Location = new System.Drawing.Point(501, 131);
            this.taxTB.Name = "taxTB";
            this.taxTB.Size = new System.Drawing.Size(100, 20);
            this.taxTB.TabIndex = 3;
            // 
            // costTB
            // 
            this.costTB.Location = new System.Drawing.Point(501, 184);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(100, 20);
            this.costTB.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(130, 194);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(428, 237);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(525, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(64, 79);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(37, 13);
            this.laborLabel.TabIndex = 8;
            this.laborLabel.Text = "Labor:";
            this.laborLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(54, 134);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(47, 13);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material:";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Location = new System.Drawing.Point(446, 79);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(49, 13);
            this.subLabel.TabIndex = 10;
            this.subLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(438, 134);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(57, 13);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Sales Tax:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(438, 187);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(58, 13);
            this.costLabel.TabIndex = 12;
            this.costLabel.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.taxTB);
            this.Controls.Add(this.subtotalTB);
            this.Controls.Add(this.materialTB);
            this.Controls.Add(this.laborTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox laborTB;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.TextBox subtotalTB;
        private System.Windows.Forms.TextBox taxTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label costLabel;
    }
}

