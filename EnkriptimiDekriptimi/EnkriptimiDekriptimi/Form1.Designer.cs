namespace EnkriptimiDekriptimi
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
            this.components = new System.ComponentModel.Container();
            this.txtplaintexti = new System.Windows.Forms.TextBox();
            this.txtciphertexti = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plaintexti = new System.Windows.Forms.Label();
            this.ciphertexti = new System.Windows.Forms.Label();
            this.btnEnkriptimi = new System.Windows.Forms.Button();
            this.btnDekriptimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtplaintexti
            // 
            this.txtplaintexti.Location = new System.Drawing.Point(142, 78);
            this.txtplaintexti.Name = "txtplaintexti";
            this.txtplaintexti.Size = new System.Drawing.Size(399, 22);
            this.txtplaintexti.TabIndex = 0;
            // 
            // txtciphertexti
            // 
            this.txtciphertexti.Location = new System.Drawing.Point(142, 132);
            this.txtciphertexti.Name = "txtciphertexti";
            this.txtciphertexti.Size = new System.Drawing.Size(399, 22);
            this.txtciphertexti.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // plaintexti
            // 
            this.plaintexti.AutoSize = true;
            this.plaintexti.Location = new System.Drawing.Point(67, 78);
            this.plaintexti.Name = "plaintexti";
            this.plaintexti.Size = new System.Drawing.Size(64, 17);
            this.plaintexti.TabIndex = 3;
            this.plaintexti.Text = "Plaintexti";
            // 
            // ciphertexti
            // 
            this.ciphertexti.AutoSize = true;
            this.ciphertexti.Location = new System.Drawing.Point(57, 137);
            this.ciphertexti.Name = "ciphertexti";
            this.ciphertexti.Size = new System.Drawing.Size(74, 17);
            this.ciphertexti.TabIndex = 4;
            this.ciphertexti.Text = "Ciphertexti";
            // 
            // btnEnkriptimi
            // 
            this.btnEnkriptimi.Location = new System.Drawing.Point(297, 176);
            this.btnEnkriptimi.Name = "btnEnkriptimi";
            this.btnEnkriptimi.Size = new System.Drawing.Size(117, 51);
            this.btnEnkriptimi.TabIndex = 5;
            this.btnEnkriptimi.Text = "Enkriptimi";
            this.btnEnkriptimi.UseVisualStyleBackColor = true;
            this.btnEnkriptimi.Click += new System.EventHandler(this.btnEnkriptimi_Click);
            // 
            // btnDekriptimi
            // 
            this.btnDekriptimi.Location = new System.Drawing.Point(420, 176);
            this.btnDekriptimi.Name = "btnDekriptimi";
            this.btnDekriptimi.Size = new System.Drawing.Size(121, 51);
            this.btnDekriptimi.TabIndex = 6;
            this.btnDekriptimi.Text = "Dekriptimi";
            this.btnDekriptimi.UseVisualStyleBackColor = true;
            this.btnDekriptimi.Click += new System.EventHandler(this.btnDekriptimi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 251);
            this.Controls.Add(this.btnDekriptimi);
            this.Controls.Add(this.btnEnkriptimi);
            this.Controls.Add(this.ciphertexti);
            this.Controls.Add(this.plaintexti);
            this.Controls.Add(this.txtciphertexti);
            this.Controls.Add(this.txtplaintexti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtplaintexti;
        private System.Windows.Forms.TextBox txtciphertexti;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label plaintexti;
        private System.Windows.Forms.Label ciphertexti;
        private System.Windows.Forms.Button btnEnkriptimi;
        private System.Windows.Forms.Button btnDekriptimi;
    }
}

