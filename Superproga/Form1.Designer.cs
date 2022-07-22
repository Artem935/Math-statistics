
namespace Superproga
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
            this.Name1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reform = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(33, 38);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(125, 40);
            this.Name1.TabIndex = 1;
            this.Name1.Text = "Скачать";
            this.Name1.UseVisualStyleBackColor = true;
            this.Name1.Click += new System.EventHandler(this.Name1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Reform
            // 
            this.Reform.Location = new System.Drawing.Point(633, 38);
            this.Reform.Name = "Reform";
            this.Reform.Size = new System.Drawing.Size(125, 40);
            this.Reform.TabIndex = 3;
            this.Reform.Text = "Преобразовать";
            this.Reform.UseVisualStyleBackColor = true;
            this.Reform.Click += new System.EventHandler(this.Reform_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(453, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Reform);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Name1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Name1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Reform;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

