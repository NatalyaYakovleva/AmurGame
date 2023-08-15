namespace ArrowShooting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.b_4 = new System.Windows.Forms.PictureBox();
            this.b_3 = new System.Windows.Forms.PictureBox();
            this.b_2 = new System.Windows.Forms.PictureBox();
            this.b_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.White;
            this.lbl_score.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_score.Location = new System.Drawing.Point(491, 22);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(26, 31);
            this.lbl_score.TabIndex = 8;
            this.lbl_score.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ArrowShooting.Properties.Resources._79;
            this.pictureBox1.Location = new System.Drawing.Point(453, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ArrowShooting.Properties.Resources.cloud2;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(986, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ArrowShooting.Properties.Resources.cloud1;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(986, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::ArrowShooting.Properties.Resources.Valentine1__2_;
            this.player.Location = new System.Drawing.Point(21, 152);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(122, 177);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Arrow
            // 
            this.Arrow.Image = global::ArrowShooting.Properties.Resources.arr;
            this.Arrow.Location = new System.Drawing.Point(160, 204);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(81, 20);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Arrow.TabIndex = 1;
            this.Arrow.TabStop = false;
            // 
            // b_4
            // 
            this.b_4.Image = global::ArrowShooting.Properties.Resources.frame_4;
            this.b_4.Location = new System.Drawing.Point(847, 222);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(45, 46);
            this.b_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_4.TabIndex = 7;
            this.b_4.TabStop = false;
            // 
            // b_3
            // 
            this.b_3.Image = global::ArrowShooting.Properties.Resources.frame_3;
            this.b_3.Location = new System.Drawing.Point(741, 143);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(45, 46);
            this.b_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_3.TabIndex = 6;
            this.b_3.TabStop = false;
            // 
            // b_2
            // 
            this.b_2.Image = global::ArrowShooting.Properties.Resources.frame_2;
            this.b_2.Location = new System.Drawing.Point(654, 260);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(45, 46);
            this.b_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_2.TabIndex = 5;
            this.b_2.TabStop = false;
            // 
            // b_1
            // 
            this.b_1.Image = global::ArrowShooting.Properties.Resources.frame_1;
            this.b_1.Location = new System.Drawing.Point(552, 190);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(45, 46);
            this.b_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.b_1.TabIndex = 4;
            this.b_1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 462);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Arrow);
            this.Controls.Add(this.b_4);
            this.Controls.Add(this.b_3);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valentin Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox b_1;
        private System.Windows.Forms.PictureBox b_2;
        private System.Windows.Forms.PictureBox b_3;
        private System.Windows.Forms.PictureBox b_4;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

