namespace Autoclicker.View
{
    partial class BindingsMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.closeButton1 = new Autoclicker.CloseButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new BindingTextBox(BindingField.startRecording);
            this.textBox2 = new BindingTextBox(BindingField.stopRecording);
            this.textBox3 = new BindingTextBox(BindingField.switchClickingState);
            this.SuspendLayout();
            // 
            // closeButton1
            // 
            this.closeButton1.Location = new System.Drawing.Point(320, 5);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(60, 28);
            this.closeButton1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start recording cursor location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stop recording cursor location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start/Stop clicking";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(239, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 8;
            // 
            // BindingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(379, 125);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton1);
            this.Name = "BindingsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CloseButton closeButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BindingTextBox textBox1;
        private BindingTextBox textBox2;
        private BindingTextBox textBox3;
    }
}
