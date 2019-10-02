namespace PhysicsBasics
{
    partial class TestMG
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
            this.lblTest = new System.Windows.Forms.Label();
            this.lblAnsw = new System.Windows.Forms.Label();
            this.tbF = new System.Windows.Forms.TextBox();
            this.lblGValue = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblMValue = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTest.Location = new System.Drawing.Point(14, 7);
            this.lblTest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(2, 22);
            this.lblTest.TabIndex = 14;
            // 
            // lblAnsw
            // 
            this.lblAnsw.AutoSize = true;
            this.lblAnsw.Location = new System.Drawing.Point(14, 182);
            this.lblAnsw.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnsw.Name = "lblAnsw";
            this.lblAnsw.Size = new System.Drawing.Size(0, 20);
            this.lblAnsw.TabIndex = 13;
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(14, 138);
            this.tbF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(214, 26);
            this.tbF.TabIndex = 12;
            this.tbF.Leave += new System.EventHandler(this.tbF_Leave);
            // 
            // lblGValue
            // 
            this.lblGValue.AutoSize = true;
            this.lblGValue.Location = new System.Drawing.Point(43, 92);
            this.lblGValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGValue.Name = "lblGValue";
            this.lblGValue.Size = new System.Drawing.Size(86, 20);
            this.lblGValue.TabIndex = 11;
            this.lblGValue.Text = "9,81 Н/Кг";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(14, 92);
            this.lblG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(34, 20);
            this.lblG.TabIndex = 10;
            this.lblG.Text = "g =";
            // 
            // lblMValue
            // 
            this.lblMValue.AutoSize = true;
            this.lblMValue.Location = new System.Drawing.Point(43, 42);
            this.lblMValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMValue.Name = "lblMValue";
            this.lblMValue.Size = new System.Drawing.Size(0, 20);
            this.lblMValue.TabIndex = 9;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(14, 42);
            this.lblM.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(38, 20);
            this.lblM.TabIndex = 8;
            this.lblM.Text = "m =";
            // 
            // TestMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblAnsw);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.lblGValue);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblMValue);
            this.Controls.Add(this.lblM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TestMG";
            this.Size = new System.Drawing.Size(240, 244);
            this.Load += new System.EventHandler(this.TestMG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblAnsw;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.Label lblGValue;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblMValue;
        private System.Windows.Forms.Label lblM;
    }
}
