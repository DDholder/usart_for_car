namespace usart_tool
{
    partial class Scope
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
            this.SuspendLayout();
            // 
            // Scope
            // 
            this.ClientSize = new System.Drawing.Size(1007, 516);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Scope";
            this.Load += new System.EventHandler(this.Scope_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Scope_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scope_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Scope_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Scope_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scope_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Scope_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}