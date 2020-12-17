
namespace RussianAk47
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
            this.btnBullet = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnSafePlace = new System.Windows.Forms.Button();
            this.Bullettxt = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtsafeplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBullet
            // 
            this.btnBullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBullet.Location = new System.Drawing.Point(49, 263);
            this.btnBullet.Name = "btnBullet";
            this.btnBullet.Size = new System.Drawing.Size(123, 67);
            this.btnBullet.TabIndex = 0;
            this.btnBullet.Text = "Load Bullet";
            this.btnBullet.UseVisualStyleBackColor = true;
            this.btnBullet.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(49, 355);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(123, 64);
            this.btnSpin.TabIndex = 1;
            this.btnSpin.Text = "Spin ";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(612, 265);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(123, 65);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnSafePlace
            // 
            this.btnSafePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSafePlace.Location = new System.Drawing.Point(611, 355);
            this.btnSafePlace.Name = "btnSafePlace";
            this.btnSafePlace.Size = new System.Drawing.Size(124, 64);
            this.btnSafePlace.TabIndex = 3;
            this.btnSafePlace.Text = "Safe Chance";
            this.btnSafePlace.UseVisualStyleBackColor = true;
            this.btnSafePlace.Click += new System.EventHandler(this.btnSafePlace_Click);
            // 
            // Bullettxt
            // 
            this.Bullettxt.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bullettxt.Location = new System.Drawing.Point(591, 149);
            this.Bullettxt.Multiline = true;
            this.Bullettxt.Name = "Bullettxt";
            this.Bullettxt.Size = new System.Drawing.Size(61, 42);
            this.Bullettxt.TabIndex = 5;
            this.Bullettxt.Visible = false;
            this.Bullettxt.TextChanged += new System.EventHandler(this.Bullettxt_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(178, 335);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(427, 61);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "Ready For Load Bullet\r\n Please Load a Bullet.........";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(611, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 65);
            this.button5.TabIndex = 7;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtsafeplace
            // 
            this.txtsafeplace.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsafeplace.Location = new System.Drawing.Point(212, 41);
            this.txtsafeplace.Multiline = true;
            this.txtsafeplace.Name = "txtsafeplace";
            this.txtsafeplace.Size = new System.Drawing.Size(60, 32);
            this.txtsafeplace.TabIndex = 8;
            this.txtsafeplace.Text = "0";
            this.txtsafeplace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsafeplace.TextChanged += new System.EventHandler(this.txtsafeplace_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Points";
            // 
            // txtPoints
            // 
            this.txtPoints.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(212, 82);
            this.txtPoints.Multiline = true;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(60, 32);
            this.txtPoints.TabIndex = 11;
            this.txtPoints.Text = "0";
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianAk47.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsafeplace);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Bullettxt);
            this.Controls.Add(this.btnSafePlace);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnBullet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBullet;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnSafePlace;
        private System.Windows.Forms.TextBox Bullettxt;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtsafeplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPoints;
    }
}

