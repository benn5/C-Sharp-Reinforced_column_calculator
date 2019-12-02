namespace Zadanie_zaliczeniowe_3
{
    partial class WyboczenieWybor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WyboczenieWybor));
            this.WyboczenieRadio1 = new System.Windows.Forms.RadioButton();
            this.WyboczenieRadio2 = new System.Windows.Forms.RadioButton();
            this.WyboczenieRadio3 = new System.Windows.Forms.RadioButton();
            this.WyboczenieRadio4 = new System.Windows.Forms.RadioButton();
            this.WyboczenieRadio5 = new System.Windows.Forms.RadioButton();
            this.WyboczenieOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WyboczenieRadio1
            // 
            this.WyboczenieRadio1.AutoSize = true;
            this.WyboczenieRadio1.Location = new System.Drawing.Point(150, 284);
            this.WyboczenieRadio1.Name = "WyboczenieRadio1";
            this.WyboczenieRadio1.Size = new System.Drawing.Size(21, 20);
            this.WyboczenieRadio1.TabIndex = 0;
            this.WyboczenieRadio1.TabStop = true;
            this.WyboczenieRadio1.UseVisualStyleBackColor = true;
            this.WyboczenieRadio1.CheckedChanged += new System.EventHandler(this.WyboczenieRadio1_CheckedChanged);
            // 
            // WyboczenieRadio2
            // 
            this.WyboczenieRadio2.AutoSize = true;
            this.WyboczenieRadio2.Location = new System.Drawing.Point(261, 284);
            this.WyboczenieRadio2.Name = "WyboczenieRadio2";
            this.WyboczenieRadio2.Size = new System.Drawing.Size(21, 20);
            this.WyboczenieRadio2.TabIndex = 1;
            this.WyboczenieRadio2.TabStop = true;
            this.WyboczenieRadio2.UseVisualStyleBackColor = true;
            this.WyboczenieRadio2.CheckedChanged += new System.EventHandler(this.WyboczenieRadio2_CheckedChanged);
            // 
            // WyboczenieRadio3
            // 
            this.WyboczenieRadio3.AutoSize = true;
            this.WyboczenieRadio3.Location = new System.Drawing.Point(375, 284);
            this.WyboczenieRadio3.Name = "WyboczenieRadio3";
            this.WyboczenieRadio3.Size = new System.Drawing.Size(21, 20);
            this.WyboczenieRadio3.TabIndex = 2;
            this.WyboczenieRadio3.TabStop = true;
            this.WyboczenieRadio3.UseVisualStyleBackColor = true;
            this.WyboczenieRadio3.CheckedChanged += new System.EventHandler(this.WyboczenieRadio3_CheckedChanged);
            // 
            // WyboczenieRadio4
            // 
            this.WyboczenieRadio4.AutoSize = true;
            this.WyboczenieRadio4.Location = new System.Drawing.Point(484, 284);
            this.WyboczenieRadio4.Name = "WyboczenieRadio4";
            this.WyboczenieRadio4.Size = new System.Drawing.Size(21, 20);
            this.WyboczenieRadio4.TabIndex = 3;
            this.WyboczenieRadio4.TabStop = true;
            this.WyboczenieRadio4.UseVisualStyleBackColor = true;
            this.WyboczenieRadio4.CheckedChanged += new System.EventHandler(this.WyboczenieRadio4_CheckedChanged);
            // 
            // WyboczenieRadio5
            // 
            this.WyboczenieRadio5.AutoSize = true;
            this.WyboczenieRadio5.Location = new System.Drawing.Point(584, 284);
            this.WyboczenieRadio5.Name = "WyboczenieRadio5";
            this.WyboczenieRadio5.Size = new System.Drawing.Size(21, 20);
            this.WyboczenieRadio5.TabIndex = 4;
            this.WyboczenieRadio5.TabStop = true;
            this.WyboczenieRadio5.UseVisualStyleBackColor = true;
            this.WyboczenieRadio5.CheckedChanged += new System.EventHandler(this.WyboczenieRadio5_CheckedChanged);
            // 
            // WyboczenieOK
            // 
            this.WyboczenieOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.WyboczenieOK.Location = new System.Drawing.Point(13, 317);
            this.WyboczenieOK.Name = "WyboczenieOK";
            this.WyboczenieOK.Size = new System.Drawing.Size(90, 57);
            this.WyboczenieOK.TabIndex = 5;
            this.WyboczenieOK.Text = "OK";
            this.WyboczenieOK.UseVisualStyleBackColor = true;
            this.WyboczenieOK.Click += new System.EventHandler(this.WyboczenieOK_Click);
            // 
            // WyboczenieWybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 386);
            this.Controls.Add(this.WyboczenieOK);
            this.Controls.Add(this.WyboczenieRadio5);
            this.Controls.Add(this.WyboczenieRadio4);
            this.Controls.Add(this.WyboczenieRadio3);
            this.Controls.Add(this.WyboczenieRadio2);
            this.Controls.Add(this.WyboczenieRadio1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "WyboczenieWybor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybór wsp. dług. wyboczeniowej";
            this.Load += new System.EventHandler(this.WyboczenieWybor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton WyboczenieRadio1;
        private System.Windows.Forms.RadioButton WyboczenieRadio2;
        private System.Windows.Forms.RadioButton WyboczenieRadio3;
        private System.Windows.Forms.RadioButton WyboczenieRadio4;
        private System.Windows.Forms.RadioButton WyboczenieRadio5;
        private System.Windows.Forms.Button WyboczenieOK;
    }
}