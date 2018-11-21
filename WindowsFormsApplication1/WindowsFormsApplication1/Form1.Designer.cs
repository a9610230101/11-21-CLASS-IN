namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lightoffpicturebox = new System.Windows.Forms.PictureBox();
            this.lightonpicturebox = new System.Windows.Forms.PictureBox();
            this.light = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lightstatelbel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lightoffpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightonpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // lightoffpicturebox
            // 
            this.lightoffpicturebox.Image = global::WindowsFormsApplication1.Properties.Resources.下載;
            this.lightoffpicturebox.Location = new System.Drawing.Point(102, 57);
            this.lightoffpicturebox.Name = "lightoffpicturebox";
            this.lightoffpicturebox.Size = new System.Drawing.Size(138, 182);
            this.lightoffpicturebox.TabIndex = 0;
            this.lightoffpicturebox.TabStop = false;
            // 
            // lightonpicturebox
            // 
            this.lightonpicturebox.Image = global::WindowsFormsApplication1.Properties.Resources.下載_jpeg2;
            this.lightonpicturebox.Location = new System.Drawing.Point(102, 57);
            this.lightonpicturebox.Name = "lightonpicturebox";
            this.lightonpicturebox.Size = new System.Drawing.Size(138, 182);
            this.lightonpicturebox.TabIndex = 1;
            this.lightonpicturebox.TabStop = false;
            // 
            // light
            // 
            this.light.Location = new System.Drawing.Point(69, 371);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(75, 23);
            this.light.TabIndex = 2;
            this.light.Text = "開燈";
            this.light.UseVisualStyleBackColor = true;
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lightstatelbel
            // 
            this.lightstatelbel.Cursor = System.Windows.Forms.Cursors.Default;
            this.lightstatelbel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lightstatelbel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lightstatelbel.Location = new System.Drawing.Point(145, 294);
            this.lightstatelbel.Name = "lightstatelbel";
            this.lightstatelbel.Size = new System.Drawing.Size(46, 25);
            this.lightstatelbel.TabIndex = 4;
            this.lightstatelbel.Text = "off";
            this.lightstatelbel.Click += new System.EventHandler(this.lightstatelbel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 454);
            this.Controls.Add(this.lightstatelbel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.light);
            this.Controls.Add(this.lightoffpicturebox);
            this.Controls.Add(this.lightonpicturebox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lightoffpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightonpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lightoffpicturebox;
        private System.Windows.Forms.PictureBox lightonpicturebox;
        private System.Windows.Forms.Button light;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lightstatelbel;
    }
}

