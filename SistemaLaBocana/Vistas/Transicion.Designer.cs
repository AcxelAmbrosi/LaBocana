
namespace SistemaLaBocana.Vistas
{
    partial class Transicion
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaLaBocana.Properties.Resources.ezgif_com_gif_maker__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.buttonOrdenar.Image = global::SistemaLaBocana.Properties.Resources.BtnOrdenar1;
            this.buttonOrdenar.Location = new System.Drawing.Point(265, 362);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(300, 85);
            this.buttonOrdenar.TabIndex = 6;
            this.buttonOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // Transicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 499);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Transicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transicion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOrdenar;
    }
}