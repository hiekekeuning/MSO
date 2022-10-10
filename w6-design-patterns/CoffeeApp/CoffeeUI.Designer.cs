
namespace CoffeeApp
{
    partial class CoffeeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeUI));
            this.baseBox = new System.Windows.Forms.ComboBox();
            this.milkBox = new System.Windows.Forms.CheckBox();
            this.syrupBox1 = new System.Windows.Forms.CheckBox();
            this.cacaoBox = new System.Windows.Forms.CheckBox();
            this.cappucinoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.makeButton = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.latteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baseBox
            // 
            this.baseBox.FormattingEnabled = true;
            this.baseBox.Items.AddRange(new object[] {
            "coffee",
            "decaf"});
            this.baseBox.Location = new System.Drawing.Point(24, 12);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(121, 23);
            this.baseBox.TabIndex = 0;
            // 
            // milkBox
            // 
            this.milkBox.AutoSize = true;
            this.milkBox.Location = new System.Drawing.Point(6, 25);
            this.milkBox.Name = "milkBox";
            this.milkBox.Size = new System.Drawing.Size(49, 19);
            this.milkBox.TabIndex = 1;
            this.milkBox.Text = "milk";
            this.milkBox.UseVisualStyleBackColor = true;
            // 
            // syrupBox1
            // 
            this.syrupBox1.AutoSize = true;
            this.syrupBox1.Location = new System.Drawing.Point(6, 50);
            this.syrupBox1.Name = "syrupBox1";
            this.syrupBox1.Size = new System.Drawing.Size(55, 19);
            this.syrupBox1.TabIndex = 2;
            this.syrupBox1.Text = "syrup";
            this.syrupBox1.UseVisualStyleBackColor = true;
            // 
            // cacaoBox
            // 
            this.cacaoBox.AutoSize = true;
            this.cacaoBox.Location = new System.Drawing.Point(6, 75);
            this.cacaoBox.Name = "cacaoBox";
            this.cacaoBox.Size = new System.Drawing.Size(57, 19);
            this.cacaoBox.TabIndex = 3;
            this.cacaoBox.Text = "cacao";
            this.cacaoBox.UseVisualStyleBackColor = true;
            // 
            // cappucinoButton
            // 
            this.cappucinoButton.Location = new System.Drawing.Point(168, 12);
            this.cappucinoButton.Name = "cappucinoButton";
            this.cappucinoButton.Size = new System.Drawing.Size(75, 23);
            this.cappucinoButton.TabIndex = 4;
            this.cappucinoButton.Text = "Cappucino";
            this.cappucinoButton.UseVisualStyleBackColor = true;
            this.cappucinoButton.Click += new System.EventHandler(this.cappucinoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cacaoBox);
            this.groupBox1.Controls.Add(this.milkBox);
            this.groupBox1.Controls.Add(this.syrupBox1);
            this.groupBox1.Location = new System.Drawing.Point(24, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condiments";
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(24, 185);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(121, 23);
            this.makeButton.TabIndex = 6;
            this.makeButton.Text = "make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(168, 64);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(140, 120);
            this.outBox.TabIndex = 7;
            // 
            // latteButton
            // 
            this.latteButton.Location = new System.Drawing.Point(249, 11);
            this.latteButton.Name = "latteButton";
            this.latteButton.Size = new System.Drawing.Size(75, 23);
            this.latteButton.TabIndex = 8;
            this.latteButton.Text = "Latte";
            this.latteButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.latteButton);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cappucinoButton);
            this.Controls.Add(this.baseBox);
            this.Name = "Form1";
            this.Text = "CoffeeApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox baseBox;
        private System.Windows.Forms.CheckBox milkBox;
        private System.Windows.Forms.CheckBox syrupBox1;
        private System.Windows.Forms.CheckBox cacaoBox;
        private System.Windows.Forms.Button cappucinoButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button makeButton;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.Button latteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

