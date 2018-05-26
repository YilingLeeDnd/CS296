namespace PokemonRunApp
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.pokemon1HpLabel = new System.Windows.Forms.Label();
            this.pokemon2HpLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pokemon2PictureBox = new System.Windows.Forms.PictureBox();
            this.pokemon1PictureBox = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemon1HpLabel
            // 
            this.pokemon1HpLabel.AutoSize = true;
            this.pokemon1HpLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemon1HpLabel.Location = new System.Drawing.Point(123, 295);
            this.pokemon1HpLabel.Name = "pokemon1HpLabel";
            this.pokemon1HpLabel.Size = new System.Drawing.Size(64, 24);
            this.pokemon1HpLabel.TabIndex = 2;
            this.pokemon1HpLabel.Text = "label1";
            // 
            // pokemon2HpLabel
            // 
            this.pokemon2HpLabel.AutoSize = true;
            this.pokemon2HpLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pokemon2HpLabel.Location = new System.Drawing.Point(419, 295);
            this.pokemon2HpLabel.Name = "pokemon2HpLabel";
            this.pokemon2HpLabel.Size = new System.Drawing.Size(64, 24);
            this.pokemon2HpLabel.TabIndex = 3;
            this.pokemon2HpLabel.Text = "label2";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 2000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pokemon2PictureBox
            // 
            this.pokemon2PictureBox.Image = global::PokemonRunApp.Properties.Resources._004;
            this.pokemon2PictureBox.Location = new System.Drawing.Point(354, 83);
            this.pokemon2PictureBox.Name = "pokemon2PictureBox";
            this.pokemon2PictureBox.Size = new System.Drawing.Size(190, 194);
            this.pokemon2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemon2PictureBox.TabIndex = 1;
            this.pokemon2PictureBox.TabStop = false;
            this.pokemon2PictureBox.Click += new System.EventHandler(this.pokemon2PictureBox_Click);
            // 
            // pokemon1PictureBox
            // 
            this.pokemon1PictureBox.Image = global::PokemonRunApp.Properties.Resources._001;
            this.pokemon1PictureBox.Location = new System.Drawing.Point(55, 83);
            this.pokemon1PictureBox.Name = "pokemon1PictureBox";
            this.pokemon1PictureBox.Size = new System.Drawing.Size(190, 194);
            this.pokemon1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokemon1PictureBox.TabIndex = 0;
            this.pokemon1PictureBox.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.restartButton.Location = new System.Drawing.Point(21, 12);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(88, 43);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "重新開始";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 388);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.pokemon2HpLabel);
            this.Controls.Add(this.pokemon1HpLabel);
            this.Controls.Add(this.pokemon2PictureBox);
            this.Controls.Add(this.pokemon1PictureBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemon1PictureBox;
        private System.Windows.Forms.PictureBox pokemon2PictureBox;
        private System.Windows.Forms.Label pokemon1HpLabel;
        private System.Windows.Forms.Label pokemon2HpLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button restartButton;
    }
}

