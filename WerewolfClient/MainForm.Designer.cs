﻿namespace WerewolfClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GBPlayers = new System.Windows.Forms.GroupBox();
            this.GBChat = new System.Windows.Forms.GroupBox();
            this.TbChatBox = new System.Windows.Forms.TextBox();
            this.TbChatInput = new System.Windows.Forms.TextBox();
            this.BtnPlayer15 = new System.Windows.Forms.Button();
            this.GBAction = new System.Windows.Forms.GroupBox();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnVote = new System.Windows.Forms.Button();
            this.BtnPlayer1 = new System.Windows.Forms.Button();
            this.BtnPlayer2 = new System.Windows.Forms.Button();
            this.BtnPlayer7 = new System.Windows.Forms.Button();
            this.BtnPlayer14 = new System.Windows.Forms.Button();
            this.BtnPlayer8 = new System.Windows.Forms.Button();
            this.BtnPlayer0 = new System.Windows.Forms.Button();
            this.BtnPlayer6 = new System.Windows.Forms.Button();
            this.BtnPlayer13 = new System.Windows.Forms.Button();
            this.BtnPlayer9 = new System.Windows.Forms.Button();
            this.BtnPlayer5 = new System.Windows.Forms.Button();
            this.BtnPlayer10 = new System.Windows.Forms.Button();
            this.BtnPlayer3 = new System.Windows.Forms.Button();
            this.BtnPlayer4 = new System.Windows.Forms.Button();
            this.BtnPlayer11 = new System.Windows.Forms.Button();
            this.BtnPlayer12 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GameFnish = new System.Windows.Forms.Panel();
            this.ExitGameEnd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBPeriod = new System.Windows.Forms.Label();
            this.LBDay = new System.Windows.Forms.Label();
            this.LBTime = new System.Windows.Forms.Label();
            this.GBStatus = new System.Windows.Forms.GroupBox();
            this.GBPlayers.SuspendLayout();
            this.GBChat.SuspendLayout();
            this.GBAction.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GameFnish.SuspendLayout();
            this.GBStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBPlayers
            // 
            this.GBPlayers.Controls.Add(this.GBChat);
            this.GBPlayers.Controls.Add(this.GBStatus);
            this.GBPlayers.Controls.Add(this.BtnPlayer15);
            this.GBPlayers.Controls.Add(this.GBAction);
            this.GBPlayers.Controls.Add(this.BtnPlayer1);
            this.GBPlayers.Controls.Add(this.BtnPlayer2);
            this.GBPlayers.Controls.Add(this.BtnPlayer7);
            this.GBPlayers.Controls.Add(this.BtnPlayer14);
            this.GBPlayers.Controls.Add(this.BtnPlayer8);
            this.GBPlayers.Controls.Add(this.BtnPlayer0);
            this.GBPlayers.Controls.Add(this.BtnPlayer6);
            this.GBPlayers.Controls.Add(this.BtnPlayer13);
            this.GBPlayers.Controls.Add(this.BtnPlayer9);
            this.GBPlayers.Controls.Add(this.BtnPlayer5);
            this.GBPlayers.Controls.Add(this.BtnPlayer10);
            this.GBPlayers.Controls.Add(this.BtnPlayer3);
            this.GBPlayers.Controls.Add(this.BtnPlayer4);
            this.GBPlayers.Controls.Add(this.BtnPlayer11);
            this.GBPlayers.Controls.Add(this.BtnPlayer12);
            this.GBPlayers.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPlayers.ForeColor = System.Drawing.Color.Black;
            this.GBPlayers.Location = new System.Drawing.Point(21, 9);
            this.GBPlayers.Name = "GBPlayers";
            this.GBPlayers.Size = new System.Drawing.Size(1060, 624);
            this.GBPlayers.TabIndex = 0;
            this.GBPlayers.TabStop = false;
            this.GBPlayers.Text = "Players";
            // 
            // GBChat
            // 
            this.GBChat.Controls.Add(this.TbChatBox);
            this.GBChat.Controls.Add(this.TbChatInput);
            this.GBChat.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBChat.ForeColor = System.Drawing.Color.Black;
            this.GBChat.Location = new System.Drawing.Point(768, 232);
            this.GBChat.Name = "GBChat";
            this.GBChat.Size = new System.Drawing.Size(282, 374);
            this.GBChat.TabIndex = 2;
            this.GBChat.TabStop = false;
            this.GBChat.Text = "Chat";
            this.GBChat.Enter += new System.EventHandler(this.GBChat_Enter);
            // 
            // TbChatBox
            // 
            this.TbChatBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TbChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChatBox.Location = new System.Drawing.Point(12, 34);
            this.TbChatBox.Multiline = true;
            this.TbChatBox.Name = "TbChatBox";
            this.TbChatBox.ReadOnly = true;
            this.TbChatBox.Size = new System.Drawing.Size(260, 288);
            this.TbChatBox.TabIndex = 0;
            this.TbChatBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TbChatBox_MouseDown);
            this.TbChatBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TbChatBox_MouseUp);
            // 
            // TbChatInput
            // 
            this.TbChatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChatInput.Location = new System.Drawing.Point(13, 330);
            this.TbChatInput.Name = "TbChatInput";
            this.TbChatInput.Size = new System.Drawing.Size(259, 26);
            this.TbChatInput.TabIndex = 1;
            this.TbChatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbChatInput_Enter);
            // 
            // BtnPlayer15
            // 
            this.BtnPlayer15.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer15.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer15.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer15.Image")));
            this.BtnPlayer15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer15.Location = new System.Drawing.Point(590, 479);
            this.BtnPlayer15.Name = "BtnPlayer15";
            this.BtnPlayer15.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer15.TabIndex = 16;
            this.BtnPlayer15.Tag = "15";
            this.BtnPlayer15.Text = "Player";
            this.BtnPlayer15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer15.UseVisualStyleBackColor = false;
            // 
            // GBAction
            // 
            this.GBAction.Controls.Add(this.BtnJoin);
            this.GBAction.Controls.Add(this.BtnAction);
            this.GBAction.Controls.Add(this.BtnVote);
            this.GBAction.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAction.ForeColor = System.Drawing.Color.Black;
            this.GBAction.Location = new System.Drawing.Point(806, 27);
            this.GBAction.Name = "GBAction";
            this.GBAction.Size = new System.Drawing.Size(244, 82);
            this.GBAction.TabIndex = 3;
            this.GBAction.TabStop = false;
            this.GBAction.Text = "Action";
            // 
            // BtnJoin
            // 
            this.BtnJoin.BackColor = System.Drawing.Color.Gray;
            this.BtnJoin.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJoin.ForeColor = System.Drawing.Color.White;
            this.BtnJoin.Location = new System.Drawing.Point(152, 25);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(84, 46);
            this.BtnJoin.TabIndex = 9;
            this.BtnJoin.Text = "Join Game";
            this.BtnJoin.UseVisualStyleBackColor = false;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Gray;
            this.BtnAction.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.Color.White;
            this.BtnAction.Location = new System.Drawing.Point(80, 25);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(66, 46);
            this.BtnAction.TabIndex = 1;
            this.BtnAction.Text = "Action";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // BtnVote
            // 
            this.BtnVote.BackColor = System.Drawing.Color.Gray;
            this.BtnVote.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVote.ForeColor = System.Drawing.Color.White;
            this.BtnVote.Location = new System.Drawing.Point(6, 25);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(68, 46);
            this.BtnVote.TabIndex = 0;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = false;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnPlayer1
            // 
            this.BtnPlayer1.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer1.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer1.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer1.Image")));
            this.BtnPlayer1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer1.Location = new System.Drawing.Point(207, 33);
            this.BtnPlayer1.Name = "BtnPlayer1";
            this.BtnPlayer1.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer1.TabIndex = 2;
            this.BtnPlayer1.Tag = "1";
            this.BtnPlayer1.Text = "Player";
            this.BtnPlayer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer1.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer2
            // 
            this.BtnPlayer2.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer2.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer2.Image")));
            this.BtnPlayer2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer2.Location = new System.Drawing.Point(399, 33);
            this.BtnPlayer2.Name = "BtnPlayer2";
            this.BtnPlayer2.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer2.TabIndex = 3;
            this.BtnPlayer2.Tag = "2";
            this.BtnPlayer2.Text = "Player";
            this.BtnPlayer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer2.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer7
            // 
            this.BtnPlayer7.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer7.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer7.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer7.Image")));
            this.BtnPlayer7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer7.Location = new System.Drawing.Point(590, 183);
            this.BtnPlayer7.Name = "BtnPlayer7";
            this.BtnPlayer7.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer7.TabIndex = 8;
            this.BtnPlayer7.Tag = "7";
            this.BtnPlayer7.Text = "Player";
            this.BtnPlayer7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer7.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer14
            // 
            this.BtnPlayer14.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer14.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer14.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer14.Image")));
            this.BtnPlayer14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer14.Location = new System.Drawing.Point(399, 479);
            this.BtnPlayer14.Name = "BtnPlayer14";
            this.BtnPlayer14.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer14.TabIndex = 15;
            this.BtnPlayer14.Tag = "14";
            this.BtnPlayer14.Text = "Player";
            this.BtnPlayer14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer14.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer8
            // 
            this.BtnPlayer8.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer8.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer8.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer8.Image")));
            this.BtnPlayer8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer8.Location = new System.Drawing.Point(15, 333);
            this.BtnPlayer8.Name = "BtnPlayer8";
            this.BtnPlayer8.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer8.TabIndex = 9;
            this.BtnPlayer8.Tag = "8";
            this.BtnPlayer8.Text = "Player";
            this.BtnPlayer8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer8.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer0
            // 
            this.BtnPlayer0.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer0.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer0.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer0.Image")));
            this.BtnPlayer0.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer0.Location = new System.Drawing.Point(18, 33);
            this.BtnPlayer0.Name = "BtnPlayer0";
            this.BtnPlayer0.Size = new System.Drawing.Size(153, 130);
            this.BtnPlayer0.TabIndex = 1;
            this.BtnPlayer0.Tag = "0";
            this.BtnPlayer0.Text = "Player";
            this.BtnPlayer0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer0.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer6
            // 
            this.BtnPlayer6.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer6.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer6.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer6.Image")));
            this.BtnPlayer6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer6.Location = new System.Drawing.Point(399, 183);
            this.BtnPlayer6.Name = "BtnPlayer6";
            this.BtnPlayer6.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer6.TabIndex = 7;
            this.BtnPlayer6.Tag = "6";
            this.BtnPlayer6.Text = "Player";
            this.BtnPlayer6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer6.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer13
            // 
            this.BtnPlayer13.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer13.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer13.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer13.Image")));
            this.BtnPlayer13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer13.Location = new System.Drawing.Point(212, 479);
            this.BtnPlayer13.Name = "BtnPlayer13";
            this.BtnPlayer13.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer13.TabIndex = 14;
            this.BtnPlayer13.Tag = "13";
            this.BtnPlayer13.Text = "Player";
            this.BtnPlayer13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer13.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer9
            // 
            this.BtnPlayer9.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer9.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer9.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer9.Image")));
            this.BtnPlayer9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer9.Location = new System.Drawing.Point(211, 333);
            this.BtnPlayer9.Name = "BtnPlayer9";
            this.BtnPlayer9.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer9.TabIndex = 10;
            this.BtnPlayer9.Tag = "9";
            this.BtnPlayer9.Text = "Player";
            this.BtnPlayer9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer9.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer5
            // 
            this.BtnPlayer5.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer5.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer5.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer5.Image")));
            this.BtnPlayer5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer5.Location = new System.Drawing.Point(213, 183);
            this.BtnPlayer5.Name = "BtnPlayer5";
            this.BtnPlayer5.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer5.TabIndex = 6;
            this.BtnPlayer5.Tag = "5";
            this.BtnPlayer5.Text = "Player";
            this.BtnPlayer5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer5.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer10
            // 
            this.BtnPlayer10.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer10.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer10.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer10.Image")));
            this.BtnPlayer10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer10.Location = new System.Drawing.Point(399, 333);
            this.BtnPlayer10.Name = "BtnPlayer10";
            this.BtnPlayer10.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer10.TabIndex = 11;
            this.BtnPlayer10.Tag = "10";
            this.BtnPlayer10.Text = "Player";
            this.BtnPlayer10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer10.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer3
            // 
            this.BtnPlayer3.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer3.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer3.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer3.Image")));
            this.BtnPlayer3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer3.Location = new System.Drawing.Point(590, 36);
            this.BtnPlayer3.Name = "BtnPlayer3";
            this.BtnPlayer3.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer3.TabIndex = 4;
            this.BtnPlayer3.Tag = "3";
            this.BtnPlayer3.Text = "Player";
            this.BtnPlayer3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer3.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer4
            // 
            this.BtnPlayer4.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer4.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer4.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer4.Image")));
            this.BtnPlayer4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer4.Location = new System.Drawing.Point(18, 183);
            this.BtnPlayer4.Name = "BtnPlayer4";
            this.BtnPlayer4.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer4.TabIndex = 5;
            this.BtnPlayer4.Tag = "4";
            this.BtnPlayer4.Text = "Player";
            this.BtnPlayer4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer4.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer11
            // 
            this.BtnPlayer11.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer11.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer11.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer11.Image")));
            this.BtnPlayer11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer11.Location = new System.Drawing.Point(590, 333);
            this.BtnPlayer11.Name = "BtnPlayer11";
            this.BtnPlayer11.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer11.TabIndex = 12;
            this.BtnPlayer11.Tag = "11";
            this.BtnPlayer11.Text = "Player";
            this.BtnPlayer11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer11.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer12
            // 
            this.BtnPlayer12.BackColor = System.Drawing.Color.Black;
            this.BtnPlayer12.ForeColor = System.Drawing.Color.White;
            this.BtnPlayer12.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlayer12.Image")));
            this.BtnPlayer12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer12.Location = new System.Drawing.Point(15, 479);
            this.BtnPlayer12.Name = "BtnPlayer12";
            this.BtnPlayer12.Size = new System.Drawing.Size(153, 127);
            this.BtnPlayer12.TabIndex = 13;
            this.BtnPlayer12.Tag = "12";
            this.BtnPlayer12.Text = "Player";
            this.BtnPlayer12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer12.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(739, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 488);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(47, 323);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(47, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(332, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GameFnish
            // 
            this.GameFnish.BackColor = System.Drawing.Color.Gray;
            this.GameFnish.Controls.Add(this.label5);
            this.GameFnish.Controls.Add(this.label4);
            this.GameFnish.Controls.Add(this.ExitGameEnd);
            this.GameFnish.Location = new System.Drawing.Point(386, 48);
            this.GameFnish.Margin = new System.Windows.Forms.Padding(2);
            this.GameFnish.Name = "GameFnish";
            this.GameFnish.Size = new System.Drawing.Size(337, 500);
            this.GameFnish.TabIndex = 13;
            this.GameFnish.Visible = false;
            this.GameFnish.Paint += new System.Windows.Forms.PaintEventHandler(this.GameFnish_Paint);
            // 
            // ExitGameEnd
            // 
            this.ExitGameEnd.BackColor = System.Drawing.Color.Gray;
            this.ExitGameEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ExitGameEnd.ForeColor = System.Drawing.Color.White;
            this.ExitGameEnd.Location = new System.Drawing.Point(55, 356);
            this.ExitGameEnd.Margin = new System.Windows.Forms.Padding(2);
            this.ExitGameEnd.Name = "ExitGameEnd";
            this.ExitGameEnd.Size = new System.Drawing.Size(224, 50);
            this.ExitGameEnd.TabIndex = 12;
            this.ExitGameEnd.Text = "Exit";
            this.ExitGameEnd.UseVisualStyleBackColor = false;
            this.ExitGameEnd.Click += new System.EventHandler(this.ExitGameEnd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(62, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 101);
            this.label4.TabIndex = 18;
            this.label4.Text = "GAME";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(38, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 101);
            this.label5.TabIndex = 19;
            this.label5.Text = "FINISH !!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // LBPeriod
            // 
            this.LBPeriod.AutoSize = true;
            this.LBPeriod.Location = new System.Drawing.Point(6, 22);
            this.LBPeriod.Name = "LBPeriod";
            this.LBPeriod.Size = new System.Drawing.Size(56, 21);
            this.LBPeriod.TabIndex = 10;
            this.LBPeriod.Text = "Night of";
            // 
            // LBDay
            // 
            this.LBDay.AutoSize = true;
            this.LBDay.Location = new System.Drawing.Point(51, 46);
            this.LBDay.Name = "LBDay";
            this.LBDay.Size = new System.Drawing.Size(17, 21);
            this.LBDay.TabIndex = 11;
            this.LBDay.Text = "0";
            // 
            // LBTime
            // 
            this.LBTime.AutoSize = true;
            this.LBTime.Location = new System.Drawing.Point(40, 68);
            this.LBTime.Name = "LBTime";
            this.LBTime.Size = new System.Drawing.Size(17, 21);
            this.LBTime.TabIndex = 12;
            this.LBTime.Text = "0";
            // 
            // GBStatus
            // 
            this.GBStatus.BackColor = System.Drawing.Color.DimGray;
            this.GBStatus.Controls.Add(this.LBTime);
            this.GBStatus.Controls.Add(this.LBDay);
            this.GBStatus.Controls.Add(this.LBPeriod);
            this.GBStatus.Controls.Add(this.label2);
            this.GBStatus.Controls.Add(this.label1);
            this.GBStatus.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBStatus.ForeColor = System.Drawing.Color.White;
            this.GBStatus.Location = new System.Drawing.Point(943, 125);
            this.GBStatus.Name = "GBStatus";
            this.GBStatus.Size = new System.Drawing.Size(107, 101);
            this.GBStatus.TabIndex = 8;
            this.GBStatus.TabStop = false;
            this.GBStatus.Text = "Status";
            this.GBStatus.Enter += new System.EventHandler(this.GBStatus_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1093, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GameFnish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GBPlayers);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Werewolf Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GBPlayers.ResumeLayout(false);
            this.GBChat.ResumeLayout(false);
            this.GBChat.PerformLayout();
            this.GBAction.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GameFnish.ResumeLayout(false);
            this.GameFnish.PerformLayout();
            this.GBStatus.ResumeLayout(false);
            this.GBStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBPlayers;
        private System.Windows.Forms.Button BtnPlayer15;
        private System.Windows.Forms.Button BtnPlayer14;
        private System.Windows.Forms.Button BtnPlayer13;
        private System.Windows.Forms.Button BtnPlayer12;
        private System.Windows.Forms.Button BtnPlayer11;
        private System.Windows.Forms.Button BtnPlayer10;
        private System.Windows.Forms.Button BtnPlayer9;
        private System.Windows.Forms.Button BtnPlayer8;
        private System.Windows.Forms.Button BtnPlayer7;
        private System.Windows.Forms.Button BtnPlayer6;
        private System.Windows.Forms.Button BtnPlayer5;
        private System.Windows.Forms.Button BtnPlayer4;
        private System.Windows.Forms.Button BtnPlayer3;
        private System.Windows.Forms.Button BtnPlayer2;
        private System.Windows.Forms.Button BtnPlayer1;
        private System.Windows.Forms.Button BtnPlayer0;
        private System.Windows.Forms.GroupBox GBChat;
        private System.Windows.Forms.TextBox TbChatInput;
        private System.Windows.Forms.TextBox TbChatBox;
        private System.Windows.Forms.GroupBox GBAction;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.Button BtnAction;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel GameFnish;
        private System.Windows.Forms.Button ExitGameEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GBStatus;
        private System.Windows.Forms.Label LBTime;
        private System.Windows.Forms.Label LBDay;
        private System.Windows.Forms.Label LBPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

