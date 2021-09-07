
namespace SistemaLaBocana
{
    partial class SplashSceen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashSceen));
            this.PanelBase = new System.Windows.Forms.Panel();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.PanelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBase
            // 
            this.PanelBase.BackColor = System.Drawing.SystemColors.Control;
            this.PanelBase.BackgroundImage = global::SistemaLaBocana.Properties.Resources.MenuLog;
            this.PanelBase.Controls.Add(this.buttonOrdenar);
            this.PanelBase.Controls.Add(this.buttonIniciar);
            this.PanelBase.Location = new System.Drawing.Point(1, 2);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(882, 576);
            this.PanelBase.TabIndex = 3;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackColor = System.Drawing.Color.Transparent;
            this.buttonOrdenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOrdenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrdenar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOrdenar.FlatAppearance.BorderSize = 0;
            this.buttonOrdenar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOrdenar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrdenar.Image = global::SistemaLaBocana.Properties.Resources.botonOrdenar;
            this.buttonOrdenar.Location = new System.Drawing.Point(488, 364);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(300, 96);
            this.buttonOrdenar.TabIndex = 5;
            this.buttonOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.Transparent;
            this.buttonIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIniciar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonIniciar.FlatAppearance.BorderSize = 0;
            this.buttonIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciar.Image = global::SistemaLaBocana.Properties.Resources.botonAdministracion;
            this.buttonIniciar.Location = new System.Drawing.Point(101, 364);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(300, 96);
            this.buttonIniciar.TabIndex = 4;
            this.buttonIniciar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // SplashSceen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.PanelBase);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashSceen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.PanelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonIniciar;
    }
}