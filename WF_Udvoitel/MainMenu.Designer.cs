
namespace WF_Udvoitel
{
    partial class MainMenu
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonGuessNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 13);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(164, 29);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Удвоитель";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonGuessNumber
            // 
            this.buttonGuessNumber.Location = new System.Drawing.Point(12, 48);
            this.buttonGuessNumber.Name = "buttonGuessNumber";
            this.buttonGuessNumber.Size = new System.Drawing.Size(164, 29);
            this.buttonGuessNumber.TabIndex = 1;
            this.buttonGuessNumber.Text = "Отгадай число";
            this.buttonGuessNumber.UseVisualStyleBackColor = true;
            this.buttonGuessNumber.Click += new System.EventHandler(this.buttonGuessNumber_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 91);
            this.Controls.Add(this.buttonGuessNumber);
            this.Controls.Add(this.buttonStart);
            this.MaximumSize = new System.Drawing.Size(210, 130);
            this.MinimumSize = new System.Drawing.Size(210, 130);
            this.Name = "MainMenu";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonGuessNumber;
    }
}