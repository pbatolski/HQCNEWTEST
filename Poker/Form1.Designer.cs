using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Poker
{
    partial class PokerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.buttonFold = new Button();
            this.buttonCheck = new Button();
            this.buttonCall = new Button();
            this.buttonRaise = new Button();
            this.Timer = new ProgressBar();
            this.textBoxChips = new TextBox();
            this.botsAdd = new Button();
            this.textBoxAdd = new TextBox();
            this.textBoxBotChips5 = new TextBox();
            this.textBoxBotChips4 = new TextBox();
            this.textBoxBotChips3 = new TextBox();
            this.textBoxBotChips2 = new TextBox();
            this.textBoxBotChips1 = new TextBox();
            this.textBoxPot = new TextBox();
            this.botOptions = new Button();
            this.buttonBigBlind = new Button();
            this.textBoxSmallBind = new TextBox();
            this.buttonSmallBling = new Button();
            this.textBoxBigBlind = new TextBox();
            this.bot5Status = new Label();
            this.bot4Status = new Label();
            this.bot3Status = new Label();
            this.bot2Status = new Label();
            this.bot1Status = new Label();
            this.playerStatus = new Label();
            this.label1 = new Label();
            this.textBoxRaise = new TextBox();
            this.SuspendLayout();
            // 
            // bFold
            // 
            this.buttonFold.Anchor = AnchorStyles.Bottom;
            this.buttonFold.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonFold.Location = new Point(335, 660);
            this.buttonFold.Name = "bFold";
            this.buttonFold.Size = new Size(130, 62);
            this.buttonFold.TabIndex = 0;
            this.buttonFold.Text = "Fold";
            this.buttonFold.UseVisualStyleBackColor = true;
            this.buttonFold.Click += new EventHandler(this.bFold_Click);
            // 
            // bCheck
            // 
            this.buttonCheck.Anchor = AnchorStyles.Bottom;
            this.buttonCheck.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.Location = new Point(494, 660);
            this.buttonCheck.Name = "bCheck";
            this.buttonCheck.Size = new Size(134, 62);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new EventHandler(this.bCheck_Click);
            // 
            // bCall
            // 
            this.buttonCall.Anchor = AnchorStyles.Bottom;
            this.buttonCall.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonCall.Location = new Point(667, 661);
            this.buttonCall.Name = "bCall";
            this.buttonCall.Size = new Size(126, 62);
            this.buttonCall.TabIndex = 3;
            this.buttonCall.Text = "Call";
            this.buttonCall.UseVisualStyleBackColor = true;
            this.buttonCall.Click += new EventHandler(this.bCall_Click);
            // 
            // bRaise
            // 
            this.buttonRaise.Anchor = AnchorStyles.Bottom;
            this.buttonRaise.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.buttonRaise.Location = new Point(835, 661);
            this.buttonRaise.Name = "bRaise";
            this.buttonRaise.Size = new Size(124, 62);
            this.buttonRaise.TabIndex = 4;
            this.buttonRaise.Text = "Raise";
            this.buttonRaise.UseVisualStyleBackColor = true;
            this.buttonRaise.Click += new EventHandler(this.bRaise_Click);
            // 
            // pbTimer
            // 
            this.Timer.Anchor = AnchorStyles.Bottom;
            this.Timer.BackColor = SystemColors.Control;
            this.Timer.Location = new Point(335, 631);
            this.Timer.Maximum = 1000;
            this.Timer.Name = "pbTimer";
            this.Timer.Size = new Size(667, 23);
            this.Timer.TabIndex = 5;
            this.Timer.Value = 1000;
            // 
            // tbChips
            // 
            this.textBoxChips.Anchor = AnchorStyles.Bottom;
            this.textBoxChips.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChips.Location = new Point(755, 553);
            this.textBoxChips.Name = "tbChips";
            this.textBoxChips.Size = new Size(163, 23);
            this.textBoxChips.TabIndex = 6;
            this.textBoxChips.Text = "Chips : 0";
            // 
            // bAdd
            // 
            this.botsAdd.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.botsAdd.Location = new Point(12, 697);
            this.botsAdd.Name = "bAdd";
            this.botsAdd.Size = new Size(75, 25);
            this.botsAdd.TabIndex = 7;
            this.botsAdd.Text = "AddChips";
            this.botsAdd.UseVisualStyleBackColor = true;
            this.botsAdd.Click += new EventHandler(this.bAdd_Click);
            // 
            // tbAdd
            // 
            this.textBoxAdd.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxAdd.Location = new Point(93, 700);
            this.textBoxAdd.Name = "tbAdd";
            this.textBoxAdd.Size = new Size(125, 20);
            this.textBoxAdd.TabIndex = 8;
            // 
            // tbBotChips5
            // 
            this.textBoxBotChips5.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.textBoxBotChips5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBotChips5.Location = new Point(1012, 553);
            this.textBoxBotChips5.Name = "tbBotChips5";
            this.textBoxBotChips5.Size = new Size(152, 23);
            this.textBoxBotChips5.TabIndex = 9;
            this.textBoxBotChips5.Text = "Chips : 0";
            // 
            // tbBotChips4
            // 
            this.textBoxBotChips4.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.textBoxBotChips4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBotChips4.Location = new Point(970, 81);
            this.textBoxBotChips4.Name = "tbBotChips4";
            this.textBoxBotChips4.Size = new Size(123, 23);
            this.textBoxBotChips4.TabIndex = 10;
            this.textBoxBotChips4.Text = "Chips : 0";
            // 
            // tbBotChips3
            // 
            this.textBoxBotChips3.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.textBoxBotChips3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBotChips3.Location = new Point(755, 81);
            this.textBoxBotChips3.Name = "tbBotChips3";
            this.textBoxBotChips3.Size = new Size(125, 23);
            this.textBoxBotChips3.TabIndex = 11;
            this.textBoxBotChips3.Text = "Chips : 0";
            // 
            // tbBotChips2
            // 
            this.textBoxBotChips2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBotChips2.Location = new Point(276, 81);
            this.textBoxBotChips2.Name = "tbBotChips2";
            this.textBoxBotChips2.Size = new Size(133, 23);
            this.textBoxBotChips2.TabIndex = 12;
            this.textBoxBotChips2.Text = "Chips : 0";
            // 
            // tbBotChips1
            // 
            this.textBoxBotChips1.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.textBoxBotChips1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBotChips1.Location = new Point(181, 553);
            this.textBoxBotChips1.Name = "tbBotChips1";
            this.textBoxBotChips1.Size = new Size(142, 23);
            this.textBoxBotChips1.TabIndex = 13;
            this.textBoxBotChips1.Text = "Chips : 0";
            // 
            // tbPot
            // 
            this.textBoxPot.Anchor = AnchorStyles.None;
            this.textBoxPot.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPot.Location = new Point(606, 212);
            this.textBoxPot.Name = "tbPot";
            this.textBoxPot.Size = new Size(125, 23);
            this.textBoxPot.TabIndex = 14;
            this.textBoxPot.Text = "0";
            // 
            // bOptions
            // 
            this.botOptions.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.botOptions.Location = new Point(12, 12);
            this.botOptions.Name = "bOptions";
            this.botOptions.Size = new Size(75, 36);
            this.botOptions.TabIndex = 15;
            this.botOptions.Text = "BB/SB";
            this.botOptions.UseVisualStyleBackColor = true;
            this.botOptions.Click += new EventHandler(this.bOptions_Click);
            // 
            // bBB
            // 
            this.buttonBigBlind.Location = new Point(12, 254);
            this.buttonBigBlind.Name = "bBB";
            this.buttonBigBlind.Size = new Size(75, 23);
            this.buttonBigBlind.TabIndex = 16;
            this.buttonBigBlind.Text = "Big Blind";
            this.buttonBigBlind.UseVisualStyleBackColor = true;
            this.buttonBigBlind.Click += new EventHandler(this.bBB_Click);
            // 
            // tbSB
            // 
            this.textBoxSmallBind.Location = new Point(12, 228);
            this.textBoxSmallBind.Name = "tbSB";
            this.textBoxSmallBind.Size = new Size(75, 20);
            this.textBoxSmallBind.TabIndex = 17;
            this.textBoxSmallBind.Text = "250";
            // 
            // bSB
            // 
            this.buttonSmallBling.Location = new Point(12, 199);
            this.buttonSmallBling.Name = "bSB";
            this.buttonSmallBling.Size = new Size(75, 23);
            this.buttonSmallBling.TabIndex = 18;
            this.buttonSmallBling.Text = "Small Blind";
            this.buttonSmallBling.UseVisualStyleBackColor = true;
            this.buttonSmallBling.Click += new EventHandler(this.bSB_Click);
            // 
            // tbBB
            // 
            this.textBoxBigBlind.Location = new Point(12, 283);
            this.textBoxBigBlind.Name = "tbBB";
            this.textBoxBigBlind.Size = new Size(75, 20);
            this.textBoxBigBlind.TabIndex = 19;
            this.textBoxBigBlind.Text = "500";
            // 
            // b5Status
            // 
            this.bot5Status.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            this.bot5Status.Location = new Point(1012, 579);
            this.bot5Status.Name = "b5Status";
            this.bot5Status.Size = new Size(152, 32);
            this.bot5Status.TabIndex = 26;
            // 
            // b4Status
            // 
            this.bot4Status.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.bot4Status.Location = new Point(970, 107);
            this.bot4Status.Name = "b4Status";
            this.bot4Status.Size = new Size(123, 32);
            this.bot4Status.TabIndex = 27;
            // 
            // b3Status
            // 
            this.bot3Status.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.bot3Status.Location = new Point(755, 107);
            this.bot3Status.Name = "b3Status";
            this.bot3Status.Size = new Size(125, 32);
            this.bot3Status.TabIndex = 28;
            // 
            // b1Status
            // 
            this.bot1Status.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
            this.bot1Status.Location = new Point(181, 579);
            this.bot1Status.Name = "b1Status";
            this.bot1Status.Size = new Size(142, 32);
            this.bot1Status.TabIndex = 29;
            // 
            // pStatus
            // 
            this.playerStatus.Anchor = AnchorStyles.Bottom;
            this.playerStatus.Location = new Point(755, 579);
            this.playerStatus.Name = "pStatus";
            this.playerStatus.Size = new Size(163, 32);
            this.playerStatus.TabIndex = 30;
            // 
            // b2Status
            // 
            this.bot2Status.Location = new Point(276, 107);
            this.bot2Status.Name = "b2Status";
            this.bot2Status.Size = new Size(133, 32);
            this.bot2Status.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = AnchorStyles.None;
            this.label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new Point(654, 188);
            this.label1.Name = "label1";
            this.label1.Size = new Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pot";
            // 
            // tbRaise
            // 
            this.textBoxRaise.Anchor = AnchorStyles.Bottom;
            this.textBoxRaise.Location = new Point(965, 703);
            this.textBoxRaise.Name = "tbRaise";
            this.textBoxRaise.Size = new Size(108, 20);
            this.textBoxRaise.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackgroundImage = global::Poker.Properties.Resources.poker_table___Copy;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(1350, 729);
            this.Controls.Add(this.textBoxRaise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bot2Status);
            this.Controls.Add(this.playerStatus);
            this.Controls.Add(this.bot1Status);
            this.Controls.Add(this.bot3Status);
            this.Controls.Add(this.bot4Status);
            this.Controls.Add(this.bot5Status);
            this.Controls.Add(this.textBoxBigBlind);
            this.Controls.Add(this.buttonSmallBling);
            this.Controls.Add(this.textBoxSmallBind);
            this.Controls.Add(this.buttonBigBlind);
            this.Controls.Add(this.botOptions);
            this.Controls.Add(this.textBoxPot);
            this.Controls.Add(this.textBoxBotChips1);
            this.Controls.Add(this.textBoxBotChips2);
            this.Controls.Add(this.textBoxBotChips3);
            this.Controls.Add(this.textBoxBotChips4);
            this.Controls.Add(this.textBoxBotChips5);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.botsAdd);
            this.Controls.Add(this.textBoxChips);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.buttonRaise);
            this.Controls.Add(this.buttonCall);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonFold);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "GLS Texas Poker";
            this.Layout += new LayoutEventHandler(this.Layout_Change);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button buttonFold;
        private Button buttonCheck;
        private Button buttonCall;
        private Button buttonRaise;
        private ProgressBar Timer;
        private TextBox textBoxChips;
        private Button botsAdd;
        private TextBox textBoxAdd;
        private TextBox textBoxBotChips5;
        private TextBox textBoxBotChips4;
        private TextBox textBoxBotChips3;
        private TextBox textBoxBotChips2;
        private TextBox textBoxBotChips1;
        private TextBox textBoxPot;
        private Button botOptions;
        private Button buttonBigBlind;
        private TextBox textBoxSmallBind;
        private Button buttonSmallBling;
        private TextBox textBoxBigBlind;
        private Label bot5Status;
        private Label bot4Status;
        private Label bot3Status;
        private Label bot1Status;
        private Label playerStatus;
        private Label bot2Status;
        private Label label1;
        private TextBox textBoxRaise;
    }
}

