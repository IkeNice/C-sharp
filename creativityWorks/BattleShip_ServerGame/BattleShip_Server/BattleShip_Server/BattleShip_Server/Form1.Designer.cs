﻿namespace BattleShip_Server {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.startButton = new System.Windows.Forms.Button();
            this.listeningButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stopButton = new System.Windows.Forms.Button();
            this.groupBoxYourBoard = new System.Windows.Forms.GroupBox();
            this.groupBoxOpponentBoard = new System.Windows.Forms.GroupBox();
            this.reBuildYourBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(17, 331);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(77, 27);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartServer);
            // 
            // listeningButton
            // 
            this.listeningButton.Enabled = false;
            this.listeningButton.Location = new System.Drawing.Point(179, 331);
            this.listeningButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeningButton.Name = "listeningButton";
            this.listeningButton.Size = new System.Drawing.Size(77, 27);
            this.listeningButton.TabIndex = 5;
            this.listeningButton.Text = "Слушать";
            this.listeningButton.UseVisualStyleBackColor = true;
            this.listeningButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(98, 331);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(77, 27);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Остановить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxYourBoard
            // 
            this.groupBoxYourBoard.Location = new System.Drawing.Point(15, 23);
            this.groupBoxYourBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxYourBoard.Name = "groupBoxYourBoard";
            this.groupBoxYourBoard.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxYourBoard.Size = new System.Drawing.Size(284, 296);
            this.groupBoxYourBoard.TabIndex = 7;
            this.groupBoxYourBoard.TabStop = false;
            this.groupBoxYourBoard.Text = "Ваше игровое поле";
            this.groupBoxYourBoard.Enter += new System.EventHandler(this.groupBoxYourBoard_Enter);
            // 
            // groupBoxOpponentBoard
            // 
            this.groupBoxOpponentBoard.Location = new System.Drawing.Point(316, 23);
            this.groupBoxOpponentBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOpponentBoard.Name = "groupBoxOpponentBoard";
            this.groupBoxOpponentBoard.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOpponentBoard.Size = new System.Drawing.Size(284, 296);
            this.groupBoxOpponentBoard.TabIndex = 0;
            this.groupBoxOpponentBoard.TabStop = false;
            this.groupBoxOpponentBoard.Text = "Игровое поле противника";
            // 
            // reBuildYourBoard
            // 
            this.reBuildYourBoard.Enabled = false;
            this.reBuildYourBoard.Location = new System.Drawing.Point(216, 8);
            this.reBuildYourBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reBuildYourBoard.Name = "reBuildYourBoard";
            this.reBuildYourBoard.Size = new System.Drawing.Size(83, 19);
            this.reBuildYourBoard.TabIndex = 8;
            this.reBuildYourBoard.Text = "Перестроить";
            this.reBuildYourBoard.UseVisualStyleBackColor = true;
            this.reBuildYourBoard.Click += new System.EventHandler(this.reBuildYourBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 367);
            this.Controls.Add(this.reBuildYourBoard);
            this.Controls.Add(this.groupBoxOpponentBoard);
            this.Controls.Add(this.groupBoxYourBoard);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.listeningButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Сервер";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button listeningButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox groupBoxYourBoard;
        private System.Windows.Forms.GroupBox groupBoxOpponentBoard;
        private System.Windows.Forms.Button reBuildYourBoard;
    }
}

