namespace Autoclicker
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BindingsMenuButton = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.closeButton1 = new Autoclicker.CloseButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.BindingsMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 201);
            this.panel1.TabIndex = 0;
            // 
            // BindingsMenuButton
            // 
            this.BindingsMenuButton.AutoSize = true;
            this.BindingsMenuButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BindingsMenuButton.ForeColor = System.Drawing.Color.White;
            this.BindingsMenuButton.Location = new System.Drawing.Point(12, 34);
            this.BindingsMenuButton.Name = "BindingsMenuButton";
            this.BindingsMenuButton.Size = new System.Drawing.Size(90, 25);
            this.BindingsMenuButton.TabIndex = 3;
            this.BindingsMenuButton.Text = "Bindings";
            this.BindingsMenuButton.Click += new System.EventHandler(this.onBindingMenuClicked);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(164, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(184, 32);
            this.Title.TabIndex = 2;
            this.Title.Text = "ENT Clicker v.1";
            // 
            // closeButton1
            // 
            this.closeButton1.Location = new System.Drawing.Point(428, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(60, 28);
            this.closeButton1.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 201);
            this.Controls.Add(this.closeButton1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label BindingsMenuButton;
        private CloseButton closeButton1;
    }
}