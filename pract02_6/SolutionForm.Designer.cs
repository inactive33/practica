namespace pract02_6
{
    partial class SolutionForm
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
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lstBoxOriginalValue = new System.Windows.Forms.ListBox();
            this.lstBoxModifiedValue = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFillArray = new System.Windows.Forms.Button();
            this.btnReplaceArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(12, 31);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(105, 13);
            this.lblOriginal.TabIndex = 0;
            this.lblOriginal.Text = "Исходный массив: ";
            // 
            // lstBoxOriginalValue
            // 
            this.lstBoxOriginalValue.FormattingEnabled = true;
            this.lstBoxOriginalValue.Location = new System.Drawing.Point(15, 61);
            this.lstBoxOriginalValue.Name = "lstBoxOriginalValue";
            this.lstBoxOriginalValue.Size = new System.Drawing.Size(160, 264);
            this.lstBoxOriginalValue.TabIndex = 1;
            // 
            // lstBoxModifiedValue
            // 
            this.lstBoxModifiedValue.FormattingEnabled = true;
            this.lstBoxModifiedValue.Location = new System.Drawing.Point(247, 61);
            this.lstBoxModifiedValue.Name = "lstBoxModifiedValue";
            this.lstBoxModifiedValue.Size = new System.Drawing.Size(160, 264);
            this.lstBoxModifiedValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Измененный массив: ";
            // 
            // btnFillArray
            // 
            this.btnFillArray.Location = new System.Drawing.Point(25, 344);
            this.btnFillArray.Name = "btnFillArray";
            this.btnFillArray.Size = new System.Drawing.Size(131, 44);
            this.btnFillArray.TabIndex = 4;
            this.btnFillArray.Text = "Заполнить";
            this.btnFillArray.UseVisualStyleBackColor = true;
            this.btnFillArray.Click += new System.EventHandler(this.btnFillArray_Click);
            // 
            // btnReplaceArray
            // 
            this.btnReplaceArray.Location = new System.Drawing.Point(256, 344);
            this.btnReplaceArray.Name = "btnReplaceArray";
            this.btnReplaceArray.Size = new System.Drawing.Size(131, 44);
            this.btnReplaceArray.TabIndex = 5;
            this.btnReplaceArray.Text = "Замена";
            this.btnReplaceArray.UseVisualStyleBackColor = true;
            this.btnReplaceArray.Click += new System.EventHandler(this.btnReplaceArray_Click);
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 422);
            this.Controls.Add(this.btnReplaceArray);
            this.Controls.Add(this.btnFillArray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBoxModifiedValue);
            this.Controls.Add(this.lstBoxOriginalValue);
            this.Controls.Add(this.lblOriginal);
            this.Name = "SolutionForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.ListBox lstBoxOriginalValue;
        private System.Windows.Forms.ListBox lstBoxModifiedValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFillArray;
        private System.Windows.Forms.Button btnReplaceArray;
    }
}

