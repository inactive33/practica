namespace pract02_4
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
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblXk = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtBoxValueX0 = new System.Windows.Forms.TextBox();
            this.txtBoxValueXk = new System.Windows.Forms.TextBox();
            this.txtBoxValueDx = new System.Windows.Forms.TextBox();
            this.txtBoxValueA = new System.Windows.Forms.TextBox();
            this.txtBoxTotalValue = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.txtBoxValueB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX0 - Label
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Location = new System.Drawing.Point(12, 18);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(32, 13);
            this.lblX0.TabIndex = 0;
            this.lblX0.Text = "X0 = ";
            // 
            // lblXk - Label
            // 
            this.lblXk.AutoSize = true;
            this.lblXk.Location = new System.Drawing.Point(12, 50);
            this.lblXk.Name = "lblXk";
            this.lblXk.Size = new System.Drawing.Size(32, 13);
            this.lblXk.TabIndex = 1;
            this.lblXk.Text = "Xk = ";
            // 
            // lblDx - Label
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.Location = new System.Drawing.Point(12, 83);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(32, 13);
            this.lblDx.TabIndex = 2;
            this.lblDx.Text = "Dx = ";
            // 
            // lblA - Label
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 114);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(26, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A = ";
            // 
            // txtBoxValueX0 - TextBox
            // 
            this.txtBoxValueX0.Location = new System.Drawing.Point(50, 15);
            this.txtBoxValueX0.Name = "txtBoxValueX0";
            this.txtBoxValueX0.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValueX0.TabIndex = 4;
            // 
            // txtBoxValueXk - TextBox
            // 
            this.txtBoxValueXk.Location = new System.Drawing.Point(50, 47);
            this.txtBoxValueXk.Name = "txtBoxValueXk";
            this.txtBoxValueXk.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValueXk.TabIndex = 5;
            // 
            // txtBoxValueDx - TextBox
            // 
            this.txtBoxValueDx.Location = new System.Drawing.Point(50, 80);
            this.txtBoxValueDx.Name = "txtBoxValueDx";
            this.txtBoxValueDx.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValueDx.TabIndex = 6;
            // 
            // txtBoxValueA - TextBox
            // 
            this.txtBoxValueA.Location = new System.Drawing.Point(50, 111);
            this.txtBoxValueA.Name = "txtBoxValueA";
            this.txtBoxValueA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValueA.TabIndex = 7;
            // 
            // txtBoxTotalValue - TextBox
            // 
            this.txtBoxTotalValue.Location = new System.Drawing.Point(12, 200);
            this.txtBoxTotalValue.Multiline = true;
            this.txtBoxTotalValue.Name = "txtBoxTotalValue";
            this.txtBoxTotalValue.Size = new System.Drawing.Size(234, 141);
            this.txtBoxTotalValue.TabIndex = 8;
            // 
            // btnTotal - Button
            // 
            this.btnTotal.Location = new System.Drawing.Point(67, 347);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(108, 36);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "Решить";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // lblB - label
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 144);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(26, 13);
            this.lblB.TabIndex = 10;
            this.lblB.Text = "B = ";
            // 
            // txtBoxValueB - TxtBox
            // 
            this.txtBoxValueB.Location = new System.Drawing.Point(50, 141);
            this.txtBoxValueB.Name = "txtBoxValueB";
            this.txtBoxValueB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValueB.TabIndex = 11;
            // 
            // SolutionForm - Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 404);
            this.Controls.Add(this.txtBoxValueB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtBoxTotalValue);
            this.Controls.Add(this.txtBoxValueA);
            this.Controls.Add(this.txtBoxValueDx);
            this.Controls.Add(this.txtBoxValueXk);
            this.Controls.Add(this.txtBoxValueX0);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDx);
            this.Controls.Add(this.lblXk);
            this.Controls.Add(this.lblX0);
            this.Name = "SolutionForm";
            this.Text = "SolutionForm";
            this.Load += new System.EventHandler(this.SolutionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblXk;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtBoxValueX0;
        private System.Windows.Forms.TextBox txtBoxValueXk;
        private System.Windows.Forms.TextBox txtBoxValueDx;
        private System.Windows.Forms.TextBox txtBoxValueA;
        private System.Windows.Forms.TextBox txtBoxTotalValue;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtBoxValueB;
    }
}

