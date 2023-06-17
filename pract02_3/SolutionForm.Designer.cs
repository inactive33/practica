namespace pract02_3
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.TxtBoxX = new System.Windows.Forms.TextBox();
            this.TxtBoxY = new System.Windows.Forms.TextBox();
            this.TxtBoxZ = new System.Windows.Forms.TextBox();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.grpBoxFunctions = new System.Windows.Forms.GroupBox();
            this.rdoBtnSin = new System.Windows.Forms.RadioButton();
            this.rdoBtnCos = new System.Windows.Forms.RadioButton();
            this.rdoBtnExp = new System.Windows.Forms.RadioButton();
            this.grpBoxFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX - label
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(23, 46);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X = ";
            // 
            // lblY - label
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(23, 75);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(26, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y = ";
            // 
            // lblZ - label
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(23, 103);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(26, 13);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "Z = ";
            // 
            // TxtBoxX - TextBox
            // 
            this.TxtBoxX.Location = new System.Drawing.Point(55, 43);
            this.TxtBoxX.Name = "TxtBoxX";
            this.TxtBoxX.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxX.TabIndex = 3;
            // 
            // TxtBoxY - TextBox
            // 
            this.TxtBoxY.Location = new System.Drawing.Point(55, 72);
            this.TxtBoxY.Name = "TxtBoxY";
            this.TxtBoxY.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxY.TabIndex = 4;
            // 
            // TxtBoxZ - TextBox
            // 
            this.TxtBoxZ.Location = new System.Drawing.Point(55, 100);
            this.TxtBoxZ.Name = "TxtBoxZ";
            this.TxtBoxZ.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxZ.TabIndex = 5;
            // 
            // lblTotalResult - label
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Location = new System.Drawing.Point(12, 236);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(40, 13);
            this.lblTotalResult.TabIndex = 6;
            this.lblTotalResult.Text = "Ответ:";
            // 
            // lblTotalValue - label
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(58, 236);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(0, 13);
            this.lblTotalValue.TabIndex = 7;
            // 
            // btnGetResult - Button
            // 
            this.btnGetResult.Location = new System.Drawing.Point(55, 139);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(98, 32);
            this.btnGetResult.TabIndex = 8;
            this.btnGetResult.Text = "Решить";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBoxFunctions - GroupBox
            // 
            this.grpBoxFunctions.Controls.Add(this.rdoBtnExp);
            this.grpBoxFunctions.Controls.Add(this.rdoBtnCos);
            this.grpBoxFunctions.Controls.Add(this.rdoBtnSin);
            this.grpBoxFunctions.Location = new System.Drawing.Point(178, 29);
            this.grpBoxFunctions.Name = "grpBoxFunctions";
            this.grpBoxFunctions.Size = new System.Drawing.Size(119, 100);
            this.grpBoxFunctions.TabIndex = 9;
            this.grpBoxFunctions.TabStop = false;
            this.grpBoxFunctions.Text = "Выберите функции";
            // 
            // rdoBtnSin - radioButton
            // 
            this.rdoBtnSin.AutoSize = true;
            this.rdoBtnSin.Location = new System.Drawing.Point(7, 17);
            this.rdoBtnSin.Name = "rdoBtnSin";
            this.rdoBtnSin.Size = new System.Drawing.Size(40, 17);
            this.rdoBtnSin.TabIndex = 0;
            this.rdoBtnSin.TabStop = true;
            this.rdoBtnSin.Text = "Sin";
            this.rdoBtnSin.UseVisualStyleBackColor = true;
            // 
            // rdoBtnCos - radioButton
            // 
            this.rdoBtnCos.AutoSize = true;
            this.rdoBtnCos.Location = new System.Drawing.Point(7, 40);
            this.rdoBtnCos.Name = "rdoBtnCos";
            this.rdoBtnCos.Size = new System.Drawing.Size(43, 17);
            this.rdoBtnCos.TabIndex = 1;
            this.rdoBtnCos.TabStop = true;
            this.rdoBtnCos.Text = "Cos";
            this.rdoBtnCos.UseVisualStyleBackColor = true;
            // 
            // rdoBtnExp - radioButton
            // 
            this.rdoBtnExp.AutoSize = true;
            this.rdoBtnExp.Location = new System.Drawing.Point(7, 63);
            this.rdoBtnExp.Name = "rdoBtnExp";
            this.rdoBtnExp.Size = new System.Drawing.Size(43, 17);
            this.rdoBtnExp.TabIndex = 2;
            this.rdoBtnExp.TabStop = true;
            this.rdoBtnExp.Text = "Exp";
            this.rdoBtnExp.UseVisualStyleBackColor = true;
            // 
            // SolutionForm - Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 265);
            this.Controls.Add(this.grpBoxFunctions);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.TxtBoxZ);
            this.Controls.Add(this.TxtBoxY);
            this.Controls.Add(this.TxtBoxX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "SolutionForm";
            this.Text = "SolutionForm";
            this.Load += new System.EventHandler(this.SolutionForm_Load);
            this.grpBoxFunctions.ResumeLayout(false);
            this.grpBoxFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox TxtBoxX;
        private System.Windows.Forms.TextBox TxtBoxY;
        private System.Windows.Forms.TextBox TxtBoxZ;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.GroupBox grpBoxFunctions;
        private System.Windows.Forms.RadioButton rdoBtnCos;
        private System.Windows.Forms.RadioButton rdoBtnSin;
        private System.Windows.Forms.RadioButton rdoBtnExp;
    }
}

