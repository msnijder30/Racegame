﻿namespace Racegame
{
    partial class Racegame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Racegame));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FuelBox = new System.Windows.Forms.PictureBox();
            this.HealthBox = new System.Windows.Forms.PictureBox();
            this.ItemBox = new System.Windows.Forms.PictureBox();
            this.Speed2 = new System.Windows.Forms.Label();
            this.Ronde1 = new System.Windows.Forms.Label();
            this.Groen = new System.Windows.Forms.PictureBox();
            this.Checkpoint = new System.Windows.Forms.PictureBox();
            this.Finish = new System.Windows.Forms.PictureBox();
            this.Fueladder = new System.Windows.Forms.Timer(this.components);
            this.ItemFrame = new System.Windows.Forms.PictureBox();
            this.FuelBox2 = new System.Windows.Forms.PictureBox();
            this.Speed1 = new System.Windows.Forms.Label();
            this.Ronde2 = new System.Windows.Forms.Label();
            this.Fueladder2 = new System.Windows.Forms.Timer(this.components);
            this.HealthBox1 = new System.Windows.Forms.PictureBox();
            this.FinishMessage = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FuelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 17;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // FuelBox
            // 
            this.FuelBox.BackColor = System.Drawing.Color.Blue;
            this.FuelBox.Location = new System.Drawing.Point(12, 12);
            this.FuelBox.Name = "FuelBox";
            this.FuelBox.Size = new System.Drawing.Size(200, 10);
            this.FuelBox.TabIndex = 1;
            this.FuelBox.TabStop = false;
            // 
            // HealthBox
            // 
            this.HealthBox.BackColor = System.Drawing.Color.Red;
            this.HealthBox.Location = new System.Drawing.Point(545, 12);
            this.HealthBox.Name = "HealthBox";
            this.HealthBox.Size = new System.Drawing.Size(200, 10);
            this.HealthBox.TabIndex = 2;
            this.HealthBox.TabStop = false;
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.Color.Yellow;
            this.ItemBox.Location = new System.Drawing.Point(278, 416);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(43, 41);
            this.ItemBox.TabIndex = 3;
            this.ItemBox.TabStop = false;
            // 
            // Speed2
            // 
            this.Speed2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Speed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed2.Location = new System.Drawing.Point(773, 540);
            this.Speed2.Name = "Speed2";
            this.Speed2.Size = new System.Drawing.Size(200, 50);
            this.Speed2.TabIndex = 4;
            this.Speed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ronde1
            // 
            this.Ronde1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ronde1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ronde1.Location = new System.Drawing.Point(773, 600);
            this.Ronde1.Name = "Ronde1";
            this.Ronde1.Size = new System.Drawing.Size(200, 50);
            this.Ronde1.TabIndex = 5;
            this.Ronde1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Groen
            // 
            this.Groen.BackColor = System.Drawing.Color.Transparent;
            this.Groen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Groen.ErrorImage")));
            this.Groen.Image = ((System.Drawing.Image)(resources.GetObject("Groen.Image")));
            this.Groen.Location = new System.Drawing.Point(929, 44);
            this.Groen.Name = "Groen";
            this.Groen.Size = new System.Drawing.Size(65, 62);
            this.Groen.TabIndex = 6;
            this.Groen.TabStop = false;
            // 
            // Checkpoint
            // 
            this.Checkpoint.Location = new System.Drawing.Point(429, -3);
            this.Checkpoint.Name = "Checkpoint";
            this.Checkpoint.Size = new System.Drawing.Size(100, 197);
            this.Checkpoint.TabIndex = 7;
            this.Checkpoint.TabStop = false;
            this.Checkpoint.Visible = false;
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(457, 309);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(45, 180);
            this.Finish.TabIndex = 8;
            this.Finish.TabStop = false;
            this.Finish.Visible = false;
            // 
            // Fueladder
            // 
            this.Fueladder.Interval = 17;
            this.Fueladder.Tick += new System.EventHandler(this.Fueladder_Tick);
            // 
            // ItemFrame
            // 
            this.ItemFrame.BackColor = System.Drawing.Color.Transparent;
            this.ItemFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemFrame.Location = new System.Drawing.Point(12, 44);
            this.ItemFrame.Name = "ItemFrame";
            this.ItemFrame.Size = new System.Drawing.Size(64, 64);
            this.ItemFrame.TabIndex = 8;
            this.ItemFrame.TabStop = false;
            this.ItemFrame.Visible = false;
            // 
            // FuelBox2
            // 
            this.FuelBox2.BackColor = System.Drawing.Color.Blue;
            this.FuelBox2.Location = new System.Drawing.Point(12, 28);
            this.FuelBox2.Name = "FuelBox2";
            this.FuelBox2.Size = new System.Drawing.Size(200, 10);
            this.FuelBox2.TabIndex = 9;
            this.FuelBox2.TabStop = false;
            // 
            // Speed1
            // 
            this.Speed1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Speed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed1.Location = new System.Drawing.Point(773, 481);
            this.Speed1.Name = "Speed1";
            this.Speed1.Size = new System.Drawing.Size(200, 50);
            this.Speed1.TabIndex = 10;
            this.Speed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ronde2
            // 
            this.Ronde2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ronde2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ronde2.Location = new System.Drawing.Point(773, 663);
            this.Ronde2.Name = "Ronde2";
            this.Ronde2.Size = new System.Drawing.Size(200, 50);
            this.Ronde2.TabIndex = 11;
            this.Ronde2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fueladder2
            // 
            this.Fueladder2.Interval = 17;
            this.Fueladder2.Tick += new System.EventHandler(this.Fueladder2_Tick);
            // 
            // HealthBox1
            // 
            this.HealthBox1.BackColor = System.Drawing.Color.Red;
            this.HealthBox1.Location = new System.Drawing.Point(545, 28);
            this.HealthBox1.Name = "HealthBox1";
            this.HealthBox1.Size = new System.Drawing.Size(200, 10);
            this.HealthBox1.TabIndex = 12;
            this.HealthBox1.TabStop = false;
            // 
            // FinishMessage
            // 
            this.FinishMessage.BackColor = System.Drawing.Color.Transparent;
            this.FinishMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FinishMessage.Location = new System.Drawing.Point(143, 197);
            this.FinishMessage.Name = "FinishMessage";
            this.FinishMessage.Size = new System.Drawing.Size(781, 248);
            this.FinishMessage.TabIndex = 13;
            this.FinishMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FinishMessage.Visible = false;
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(401, 434);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(198, 41);
            this.MainMenu.TabIndex = 14;
            this.MainMenu.Text = "Back To Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Visible = false;
            // 
            // Racegame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.HealthBox1);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.HealthBox);
            this.Controls.Add(this.Ronde2);
            this.Controls.Add(this.Speed1);
            this.Controls.Add(this.FuelBox2);
            this.Controls.Add(this.ItemFrame);
            this.Controls.Add(this.Checkpoint);
            this.Controls.Add(this.Groen);
            this.Controls.Add(this.Ronde1);
            this.Controls.Add(this.Speed2);
            this.Controls.Add(this.FuelBox);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.FinishMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "Racegame";
            this.Text = "Racegame";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Racegame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.FuelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Checkpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FuelBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox FuelBox;
        private System.Windows.Forms.PictureBox HealthBox;
        private System.Windows.Forms.PictureBox ItemBox;
        private System.Windows.Forms.Label Speed2;
        private System.Windows.Forms.Label Ronde1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Groen;
        private System.Windows.Forms.PictureBox Checkpoint;
        private System.Windows.Forms.PictureBox Finish;
        private System.Windows.Forms.Timer Fueladder;
        private System.Windows.Forms.PictureBox ItemFrame;
        private System.Windows.Forms.PictureBox FuelBox2;
        private System.Windows.Forms.Label Speed1;
        private System.Windows.Forms.Label Ronde2;
        private System.Windows.Forms.Timer Fueladder2;
        private System.Windows.Forms.PictureBox HealthBox1;
        private System.Windows.Forms.Label FinishMessage;
        private System.Windows.Forms.Button MainMenu;
    }
}

