namespace DoodleJump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayGame = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRecords = new System.Windows.Forms.ListBox();
            this.Rec = new System.Windows.Forms.Label();
            this.labelContr = new System.Windows.Forms.Label();
            this.Resetrecords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGame
            // 
            this.PlayGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayGame.AutoSize = true;
            this.PlayGame.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlayGame.Location = new System.Drawing.Point(189, 283);
            this.PlayGame.MaximumSize = new System.Drawing.Size(500, 0);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(119, 63);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "Play";
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // Score
            // 
            this.Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.MaximumSize = new System.Drawing.Size(500, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 63);
            this.Score.TabIndex = 1;
            this.Score.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doodle  jump";
            // 
            // listBoxRecords
            // 
            this.listBoxRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxRecords.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecords.FormattingEnabled = true;
            this.listBoxRecords.ItemHeight = 49;
            this.listBoxRecords.Location = new System.Drawing.Point(33, 590);
            this.listBoxRecords.Name = "listBoxRecords";
            this.listBoxRecords.Size = new System.Drawing.Size(421, 151);
            this.listBoxRecords.TabIndex = 3;
            // 
            // Rec
            // 
            this.Rec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Rec.AutoSize = true;
            this.Rec.BackColor = System.Drawing.Color.Transparent;
            this.Rec.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rec.Location = new System.Drawing.Point(45, 446);
            this.Rec.MaximumSize = new System.Drawing.Size(500, 0);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(400, 63);
            this.Rec.TabIndex = 4;
            this.Rec.Text = "Records(Top10):";
            // 
            // labelContr
            // 
            this.labelContr.AutoSize = true;
            this.labelContr.BackColor = System.Drawing.Color.Transparent;
            this.labelContr.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelContr.Location = new System.Drawing.Point(12, 121);
            this.labelContr.Name = "labelContr";
            this.labelContr.Size = new System.Drawing.Size(459, 49);
            this.labelContr.TabIndex = 5;
            this.labelContr.Text = "← → ↑ ↓  use to control";
            // 
            // Resetrecords
            // 
            this.Resetrecords.AutoSize = true;
            this.Resetrecords.BackColor = System.Drawing.Color.Transparent;
            this.Resetrecords.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetrecords.ForeColor = System.Drawing.Color.Teal;
            this.Resetrecords.Location = new System.Drawing.Point(152, 210);
            this.Resetrecords.Name = "Resetrecords";
            this.Resetrecords.Size = new System.Drawing.Size(189, 46);
            this.Resetrecords.TabIndex = 6;
            this.Resetrecords.Text = "New game";
            this.Resetrecords.Click += new System.EventHandler(this.Resetrecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 753);
            this.Controls.Add(this.Resetrecords);
            this.Controls.Add(this.labelContr);
            this.Controls.Add(this.Rec);
            this.Controls.Add(this.listBoxRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PlayGame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(500, 2160);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doodle jump";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayGame;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRecords;
        private System.Windows.Forms.Label Rec;
        private System.Windows.Forms.Label labelContr;
        private System.Windows.Forms.Label Resetrecords;
    }
}

