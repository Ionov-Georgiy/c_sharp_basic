
namespace WF_Udvoitel
{
    partial class Game
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
            this.CurrentValue = new System.Windows.Forms.Label();
            this.buttonPlus1 = new System.Windows.Forms.Button();
            this.buttonX2 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.labelCurrValue = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.labelMaxSteps = new System.Windows.Forms.Label();
            this.MaxSteps = new System.Windows.Forms.Label();
            this.labelCurStep = new System.Windows.Forms.Label();
            this.CurrentStep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentValue
            // 
            this.CurrentValue.AutoSize = true;
            this.CurrentValue.Location = new System.Drawing.Point(137, 12);
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.Size = new System.Drawing.Size(13, 13);
            this.CurrentValue.TabIndex = 0;
            this.CurrentValue.Text = "0";
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.Location = new System.Drawing.Point(169, 7);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus1.TabIndex = 1;
            this.buttonPlus1.Text = "+1";
            this.buttonPlus1.UseVisualStyleBackColor = true;
            this.buttonPlus1.Click += new System.EventHandler(this.buttonPlus1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.Location = new System.Drawing.Point(169, 36);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.TabIndex = 2;
            this.buttonX2.Text = "x2";
            this.buttonX2.UseVisualStyleBackColor = true;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(169, 94);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // labelCurrValue
            // 
            this.labelCurrValue.AutoSize = true;
            this.labelCurrValue.Location = new System.Drawing.Point(12, 12);
            this.labelCurrValue.Name = "labelCurrValue";
            this.labelCurrValue.Size = new System.Drawing.Size(105, 13);
            this.labelCurrValue.TabIndex = 4;
            this.labelCurrValue.Text = "Текущее значение:";
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(12, 41);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(36, 13);
            this.labelTarget.TabIndex = 5;
            this.labelTarget.Text = "Цель:";
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Location = new System.Drawing.Point(137, 41);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(13, 13);
            this.Target.TabIndex = 6;
            this.Target.Text = "0";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(169, 65);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Шаг назад";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelMaxSteps
            // 
            this.labelMaxSteps.AutoSize = true;
            this.labelMaxSteps.Location = new System.Drawing.Point(12, 99);
            this.labelMaxSteps.Name = "labelMaxSteps";
            this.labelMaxSteps.Size = new System.Drawing.Size(98, 13);
            this.labelMaxSteps.TabIndex = 8;
            this.labelMaxSteps.Text = "Максимум шагов:";
            // 
            // MaxSteps
            // 
            this.MaxSteps.AutoSize = true;
            this.MaxSteps.Location = new System.Drawing.Point(137, 99);
            this.MaxSteps.Name = "MaxSteps";
            this.MaxSteps.Size = new System.Drawing.Size(13, 13);
            this.MaxSteps.TabIndex = 9;
            this.MaxSteps.Text = "0";
            // 
            // labelCurStep
            // 
            this.labelCurStep.AutoSize = true;
            this.labelCurStep.Location = new System.Drawing.Point(13, 70);
            this.labelCurStep.Name = "labelCurStep";
            this.labelCurStep.Size = new System.Drawing.Size(77, 13);
            this.labelCurStep.TabIndex = 10;
            this.labelCurStep.Text = "Текущий шаг:";
            // 
            // CurrentStep
            // 
            this.CurrentStep.AutoSize = true;
            this.CurrentStep.Location = new System.Drawing.Point(137, 70);
            this.CurrentStep.Name = "CurrentStep";
            this.CurrentStep.Size = new System.Drawing.Size(13, 13);
            this.CurrentStep.TabIndex = 11;
            this.CurrentStep.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 125);
            this.Controls.Add(this.CurrentStep);
            this.Controls.Add(this.labelCurStep);
            this.Controls.Add(this.MaxSteps);
            this.Controls.Add(this.labelMaxSteps);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelCurrValue);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonPlus1);
            this.Controls.Add(this.CurrentValue);
            this.Name = "Game";
            this.Text = "Удвоитель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentValue;
        private System.Windows.Forms.Button buttonPlus1;
        private System.Windows.Forms.Button buttonX2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label labelCurrValue;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label labelMaxSteps;
        private System.Windows.Forms.Label MaxSteps;
        private System.Windows.Forms.Label labelCurStep;
        private System.Windows.Forms.Label CurrentStep;
    }
}

