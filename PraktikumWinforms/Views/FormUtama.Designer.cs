namespace PraktikumWinforms
{
    partial class FormUtama
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
            PanelUtama = new Panel();
            SuspendLayout();
            // 
            // PanelUtama
            // 
            PanelUtama.Dock = DockStyle.Fill;
            PanelUtama.Location = new Point(0, 0);
            PanelUtama.Name = "PanelUtama";
            PanelUtama.Size = new Size(1190, 628);
            PanelUtama.TabIndex = 0;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 628);
            Controls.Add(PanelUtama);
            Name = "FormUtama";
            Text = "FormUtama";
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelUtama;
    }
}