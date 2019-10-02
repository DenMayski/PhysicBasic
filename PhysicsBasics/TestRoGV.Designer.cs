namespace PhysicsBasics
{
    partial class TestRoGV
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRo = new System.Windows.Forms.Label();
            this.lblRoValue = new System.Windows.Forms.Label();
            this.lblGValue = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.tbF = new System.Windows.Forms.TextBox();
            this.lblAnsw = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblVValue = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRo
            // 
            this.lblRo.AutoSize = true;
            this.lblRo.Location = new System.Drawing.Point(14, 42);
            this.lblRo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRo.Name = "lblRo";
            this.lblRo.Size = new System.Drawing.Size(34, 20);
            this.lblRo.TabIndex = 0;
            this.lblRo.Text = "p =";
            // 
            // lblRoValue
            // 
            this.lblRoValue.AutoSize = true;
            this.lblRoValue.Location = new System.Drawing.Point(43, 42);
            this.lblRoValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRoValue.Name = "lblRoValue";
            this.lblRoValue.Size = new System.Drawing.Size(0, 20);
            this.lblRoValue.TabIndex = 1;
            // 
            // lblGValue
            // 
            this.lblGValue.AutoSize = true;
            this.lblGValue.Location = new System.Drawing.Point(43, 74);
            this.lblGValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGValue.Name = "lblGValue";
            this.lblGValue.Size = new System.Drawing.Size(86, 20);
            this.lblGValue.TabIndex = 3;
            this.lblGValue.Text = "9,81 Н/Кг";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(14, 74);
            this.lblG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(34, 20);
            this.lblG.TabIndex = 2;
            this.lblG.Text = "g =";
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(14, 138);
            this.tbF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(214, 26);
            this.tbF.TabIndex = 5;
            this.tbF.Leave += new System.EventHandler(this.tbF_Leave);
            // 
            // lblAnsw
            // 
            this.lblAnsw.AutoSize = true;
            this.lblAnsw.Location = new System.Drawing.Point(14, 182);
            this.lblAnsw.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsw.Name = "lblAnsw";
            this.lblAnsw.Size = new System.Drawing.Size(0, 20);
            this.lblAnsw.TabIndex = 6;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(14, 7);
            this.lblTest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(2, 22);
            this.lblTest.TabIndex = 7;
            // 
            // lblVValue
            // 
            this.lblVValue.AutoSize = true;
            this.lblVValue.Location = new System.Drawing.Point(43, 106);
            this.lblVValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVValue.Name = "lblVValue";
            this.lblVValue.Size = new System.Drawing.Size(0, 20);
            this.lblVValue.TabIndex = 4;
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(14, 106);
            this.lblV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(36, 20);
            this.lblV.TabIndex = 4;
            this.lblV.Text = "V =";
            // 
            // TestRoGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblAnsw);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.lblVValue);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblGValue);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblRoValue);
            this.Controls.Add(this.lblRo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TestRoGV";
            this.Size = new System.Drawing.Size(240, 244);
            this.Load += new System.EventHandler(this.TestRoGV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRo;
        private System.Windows.Forms.Label lblRoValue;
        private System.Windows.Forms.Label lblGValue;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.Label lblAnsw;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblVValue;
        private System.Windows.Forms.Label lblV;
    }
}
