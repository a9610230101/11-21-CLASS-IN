namespace CardsWindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.cardsImageList = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "發牌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cardsImageList
            // 
            this.cardsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cardsImageList.ImageStream")));
            this.cardsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cardsImageList.Images.SetKeyName(0, "下載 (1).jpeg");
            this.cardsImageList.Images.SetKeyName(1, "2011-05-04_170305.jpg");
            this.cardsImageList.Images.SetKeyName(2, "下載.png");
            this.cardsImageList.Images.SetKeyName(3, "images (2).png");
            this.cardsImageList.Images.SetKeyName(4, "下載 (3).jpeg");
            this.cardsImageList.Images.SetKeyName(5, "819px-Playing_card_spade_7.svg.png");
            this.cardsImageList.Images.SetKeyName(6, "images.png");
            this.cardsImageList.Images.SetKeyName(7, "819px-Playing_card_spade_9.svg.png");
            this.cardsImageList.Images.SetKeyName(8, "819px-Playing_card_spade_10.svg.png");
            this.cardsImageList.Images.SetKeyName(9, "ff2fd392f787517c302c4dce62ea83bf--jack-of-spades-the-jack.jpg");
            this.cardsImageList.Images.SetKeyName(10, "170px-Poker-sm-213-Qs.png");
            this.cardsImageList.Images.SetKeyName(11, "12586605-king-of-spades-individual-playing-card-an-isolated-vector-illustration-o" +
        "f-a-classic-face-card.jpg");
            this.cardsImageList.Images.SetKeyName(12, "2000px-Playing_card_spade_6.svg.png");
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "玩家";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "莊家";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(227, 287);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(350, 23);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CardsWindowsFormsApplication1.Properties.Resources.下載__1__jpegd;
            this.pictureBox2.Location = new System.Drawing.Point(342, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 189);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CardsWindowsFormsApplication1.Properties.Resources.下載__1__jpegd;
            this.pictureBox1.Location = new System.Drawing.Point(33, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 376);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList cardsImageList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

