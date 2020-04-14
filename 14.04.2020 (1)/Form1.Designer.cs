namespace _14._04._2020__1_
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
            this.back = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.gamebol = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamebol)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Controls.Add(this.gamebol);
            this.back.Controls.Add(this.gamePanel);
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(800, 450);
            this.back.TabIndex = 0;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gamePanel.Location = new System.Drawing.Point(286, 363);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(262, 50);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // gamebol
            // 
            this.gamebol.BackColor = System.Drawing.Color.Red;
            this.gamebol.Location = new System.Drawing.Point(247, 261);
            this.gamebol.Name = "gamebol";
            this.gamebol.Size = new System.Drawing.Size(50, 50);
            this.gamebol.TabIndex = 1;
            this.gamebol.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.back.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamebol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.PictureBox gamebol;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Timer timer;
    }
}

