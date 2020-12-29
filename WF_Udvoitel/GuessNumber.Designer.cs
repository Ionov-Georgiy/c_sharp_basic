
namespace WF_Udvoitel
{
    partial class GuessNumber
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
            this.buttonGenerateSecretNumber = new System.Windows.Forms.Button();
            this.buttonTryGuess = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.IsSecretNumberExist = new System.Windows.Forms.Label();
            this.StatusOfTry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerateSecretNumber
            // 
            this.buttonGenerateSecretNumber.Location = new System.Drawing.Point(13, 13);
            this.buttonGenerateSecretNumber.Name = "buttonGenerateSecretNumber";
            this.buttonGenerateSecretNumber.Size = new System.Drawing.Size(122, 23);
            this.buttonGenerateSecretNumber.TabIndex = 0;
            this.buttonGenerateSecretNumber.Text = "Загадать число";
            this.buttonGenerateSecretNumber.UseVisualStyleBackColor = true;
            this.buttonGenerateSecretNumber.Click += new System.EventHandler(this.buttonGenerateSecretNumber_Click);
            // 
            // buttonTryGuess
            // 
            this.buttonTryGuess.Location = new System.Drawing.Point(13, 43);
            this.buttonTryGuess.Name = "buttonTryGuess";
            this.buttonTryGuess.Size = new System.Drawing.Size(122, 23);
            this.buttonTryGuess.TabIndex = 1;
            this.buttonTryGuess.Text = "Попытаться угадать";
            this.buttonTryGuess.UseVisualStyleBackColor = true;
            this.buttonTryGuess.Click += new System.EventHandler(this.buttonTryGuess_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 73);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "<= Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // IsSecretNumberExist
            // 
            this.IsSecretNumberExist.AutoSize = true;
            this.IsSecretNumberExist.ForeColor = System.Drawing.Color.Red;
            this.IsSecretNumberExist.Location = new System.Drawing.Point(141, 18);
            this.IsSecretNumberExist.Name = "IsSecretNumberExist";
            this.IsSecretNumberExist.Size = new System.Drawing.Size(71, 13);
            this.IsSecretNumberExist.TabIndex = 3;
            this.IsSecretNumberExist.Text = "Не загадано";
            // 
            // StatusOfTry
            // 
            this.StatusOfTry.AutoSize = true;
            this.StatusOfTry.Location = new System.Drawing.Point(141, 48);
            this.StatusOfTry.Name = "StatusOfTry";
            this.StatusOfTry.Size = new System.Drawing.Size(0, 13);
            this.StatusOfTry.TabIndex = 4;
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 110);
            this.Controls.Add(this.StatusOfTry);
            this.Controls.Add(this.IsSecretNumberExist);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonTryGuess);
            this.Controls.Add(this.buttonGenerateSecretNumber);
            this.Name = "GuessNumber";
            this.Text = "GuessNumber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuessNumber_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateSecretNumber;
        private System.Windows.Forms.Button buttonTryGuess;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label IsSecretNumberExist;
        private System.Windows.Forms.Label StatusOfTry;
    }
}