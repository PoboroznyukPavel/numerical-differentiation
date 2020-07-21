namespace VM_Kurs
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.textBoxx0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxErr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(375, 360);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // textBoxx0
            // 
            this.textBoxx0.Location = new System.Drawing.Point(42, 416);
            this.textBoxx0.Name = "textBoxx0";
            this.textBoxx0.Size = new System.Drawing.Size(50, 20);
            this.textBoxx0.TabIndex = 1;
            this.textBoxx0.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "x(0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "T";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(42, 442);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(50, 20);
            this.textBoxT.TabIndex = 5;
            this.textBoxT.Text = "10";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(393, 12);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(375, 360);
            this.zedGraphControl2.TabIndex = 7;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "f(x) = e^-cos(x) * (sin(2 - x) / (3 + cos(3 - x))";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "N";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(42, 468);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(50, 20);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.Text = "100";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Персчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "[0,T]";
            // 
            // textBoxErr
            // 
            this.textBoxErr.Location = new System.Drawing.Point(364, 448);
            this.textBoxErr.Name = "textBoxErr";
            this.textBoxErr.ReadOnly = true;
            this.textBoxErr.Size = new System.Drawing.Size(336, 20);
            this.textBoxErr.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Глобальная погрешность методом рунге для 4 порядка точности\r\np = (x(h/2)-x(h))*2^" +
    "2/(2^2-1) ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxErr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxx0);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Поборознюк Павел 6313-020302D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox textBoxx0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxT;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxErr;
        private System.Windows.Forms.Label label6;
    }
}

