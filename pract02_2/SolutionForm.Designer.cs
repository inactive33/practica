namespace pract02_2
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
            this.lblB = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.TxtValueX = new System.Windows.Forms.TextBox();
            this.TxtValueY = new System.Windows.Forms.TextBox();
            this.TxtValueZ = new System.Windows.Forms.TextBox();
            this.TxtValueB = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblX - label
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblX.Location = new System.Drawing.Point(4, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(54, 25);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X = ";
            // 
            // lblY - label
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblY.Location = new System.Drawing.Point(4, 40);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(55, 25);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y = ";
            // 
            // lblZ - label
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZ.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblZ.Location = new System.Drawing.Point(4, 77);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(46, 25);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "Z =";
            // 
            // lblB - label
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblB.Location = new System.Drawing.Point(4, 111);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(54, 25);
            this.lblB.TabIndex = 6;
            this.lblB.Text = "B = ";
            // 
            // lblTotal - label
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(18, 243);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Ответ = ";
            // 
            // btnSolve - Button
            // 
            this.btnSolve.BackColor = System.Drawing.SystemColors.Info;
            this.btnSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSolve.Location = new System.Drawing.Point(16, 164);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(120, 46);
            this.btnSolve.TabIndex = 9;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // TxtValueX - TextBox
            // 
            this.TxtValueX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtValueX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtValueX.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TxtValueX.Location = new System.Drawing.Point(50, 6);
            this.TxtValueX.Multiline = true;
            this.TxtValueX.Name = "TxtValueX";
            this.TxtValueX.Size = new System.Drawing.Size(86, 31);
            this.TxtValueX.TabIndex = 10;
            // 
            // TxtValueY - TextBox
            // 
            this.TxtValueY.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtValueY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtValueY.Location = new System.Drawing.Point(50, 43);
            this.TxtValueY.Multiline = true;
            this.TxtValueY.Name = "TxtValueY";
            this.TxtValueY.Size = new System.Drawing.Size(86, 31);
            this.TxtValueY.TabIndex = 11;
            // 
            // TxtValueZ
            // 
            this.TxtValueZ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtValueZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtValueZ.Location = new System.Drawing.Point(50, 80);
            this.TxtValueZ.Multiline = true;
            this.TxtValueZ.Name = "TxtValueZ";
            this.TxtValueZ.Size = new System.Drawing.Size(86, 31);
            this.TxtValueZ.TabIndex = 12;
            // 
            // TxtValueB - TextBox
            // 
            this.TxtValueB.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtValueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtValueB.Location = new System.Drawing.Point(50, 117);
            this.TxtValueB.Multiline = true;
            this.TxtValueB.Name = "TxtValueB";
            this.TxtValueB.Size = new System.Drawing.Size(86, 31);
            this.TxtValueB.TabIndex = 13;
            // 
            // lblTotalValue - label
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalValue.Location = new System.Drawing.Point(121, 243);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(0, 25);
            this.lblTotalValue.TabIndex = 14;
            // 
            // SolutionForm - Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(371, 276);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.TxtValueB);
            this.Controls.Add(this.TxtValueZ);
            this.Controls.Add(this.TxtValueY);
            this.Controls.Add(this.TxtValueX);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "SolutionForm";
            this.Text = "SolutionForm";
            this.Load += new System.EventHandler(this.SolutionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox TxtValueX;
        private System.Windows.Forms.TextBox TxtValueY;
        private System.Windows.Forms.TextBox TxtValueZ;
        private System.Windows.Forms.TextBox TxtValueB;
        private System.Windows.Forms.Label lblTotalValue;
    }
}

