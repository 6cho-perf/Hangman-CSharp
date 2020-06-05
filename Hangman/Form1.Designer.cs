namespace Hangman
{
    partial class Hangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetOutput = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.targetWordOutput = new System.Windows.Forms.Label();
            this.statusOutput = new System.Windows.Forms.Label();
            this.livesOutput = new System.Windows.Forms.Label();
            this.guessOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giveUpBtn = new System.Windows.Forms.Button();
            this.startOverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attemptOutput = new System.Windows.Forms.Label();
            this.winOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // targetOutput
            // 
            this.targetOutput.Location = new System.Drawing.Point(0, 0);
            this.targetOutput.Name = "targetOutput";
            this.targetOutput.Size = new System.Drawing.Size(100, 23);
            this.targetOutput.TabIndex = 10;
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBtn.Location = new System.Drawing.Point(12, 304);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(309, 37);
            this.checkBtn.TabIndex = 1;
            this.checkBtn.Text = "check Letter";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // inputText
            // 
            this.inputText.BackColor = System.Drawing.Color.Black;
            this.inputText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputText.Location = new System.Drawing.Point(12, 275);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(310, 23);
            this.inputText.TabIndex = 2;
            // 
            // targetWordOutput
            // 
            this.targetWordOutput.AutoSize = true;
            this.targetWordOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.targetWordOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.targetWordOutput.Location = new System.Drawing.Point(13, 35);
            this.targetWordOutput.Name = "targetWordOutput";
            this.targetWordOutput.Size = new System.Drawing.Size(276, 50);
            this.targetWordOutput.TabIndex = 3;
            this.targetWordOutput.Text = "TARGET WORD";
            // 
            // statusOutput
            // 
            this.statusOutput.AutoSize = true;
            this.statusOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusOutput.ForeColor = System.Drawing.Color.Salmon;
            this.statusOutput.Location = new System.Drawing.Point(12, 437);
            this.statusOutput.Name = "statusOutput";
            this.statusOutput.Size = new System.Drawing.Size(76, 13);
            this.statusOutput.TabIndex = 4;
            this.statusOutput.Text = "statusOutput";
            // 
            // livesOutput
            // 
            this.livesOutput.AutoSize = true;
            this.livesOutput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.livesOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.livesOutput.Location = new System.Drawing.Point(13, 119);
            this.livesOutput.Name = "livesOutput";
            this.livesOutput.Size = new System.Drawing.Size(120, 32);
            this.livesOutput.TabIndex = 5;
            this.livesOutput.Text = "Lives Left ";
            // 
            // guessOutput
            // 
            this.guessOutput.AutoSize = true;
            this.guessOutput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guessOutput.Location = new System.Drawing.Point(12, 195);
            this.guessOutput.Name = "guessOutput";
            this.guessOutput.Size = new System.Drawing.Size(151, 32);
            this.guessOutput.TabIndex = 6;
            this.guessOutput.Text = "guessOutput";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Your Guess Below";
            // 
            // giveUpBtn
            // 
            this.giveUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.giveUpBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.giveUpBtn.Location = new System.Drawing.Point(12, 390);
            this.giveUpBtn.Name = "giveUpBtn";
            this.giveUpBtn.Size = new System.Drawing.Size(309, 37);
            this.giveUpBtn.TabIndex = 8;
            this.giveUpBtn.Text = "Give Up";
            this.giveUpBtn.UseVisualStyleBackColor = false;
            this.giveUpBtn.Click += new System.EventHandler(this.giveUpBtn_Click);
            // 
            // startOverBtn
            // 
            this.startOverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startOverBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.startOverBtn.Location = new System.Drawing.Point(12, 347);
            this.startOverBtn.Name = "startOverBtn";
            this.startOverBtn.Size = new System.Drawing.Size(310, 37);
            this.startOverBtn.TabIndex = 9;
            this.startOverBtn.Text = "Start Over";
            this.startOverBtn.UseVisualStyleBackColor = false;
            this.startOverBtn.Click += new System.EventHandler(this.startOverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Previous Guesses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lives Remaining";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(227, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Attempts: ";
            // 
            // attemptOutput
            // 
            this.attemptOutput.AutoSize = true;
            this.attemptOutput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.attemptOutput.Location = new System.Drawing.Point(284, 435);
            this.attemptOutput.Name = "attemptOutput";
            this.attemptOutput.Size = new System.Drawing.Size(87, 15);
            this.attemptOutput.TabIndex = 14;
            this.attemptOutput.Text = "attemptOutput";
            // 
            // winOutput
            // 
            this.winOutput.AutoSize = true;
            this.winOutput.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.winOutput.Location = new System.Drawing.Point(135, 9);
            this.winOutput.Name = "winOutput";
            this.winOutput.Size = new System.Drawing.Size(63, 15);
            this.winOutput.TabIndex = 15;
            this.winOutput.Text = "Win Status";
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.winOutput);
            this.Controls.Add(this.attemptOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startOverBtn);
            this.Controls.Add(this.giveUpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guessOutput);
            this.Controls.Add(this.livesOutput);
            this.Controls.Add(this.statusOutput);
            this.Controls.Add(this.targetWordOutput);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.targetOutput);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label targetOutput;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label targetWordOutput;
        private System.Windows.Forms.Label statusOutput;
        private System.Windows.Forms.Label livesOutput;
        private System.Windows.Forms.Label guessOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button giveUpBtn;
        private System.Windows.Forms.Button startOverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label attemptOutput;
        private System.Windows.Forms.Label winOutput;
    }
}

