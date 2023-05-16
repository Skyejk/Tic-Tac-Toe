namespace TicTakToe
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(67, 58);
            this.btn20.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 75);
            this.btn20.TabIndex = 0;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(154, 58);
            this.btn21.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 75);
            this.btn21.TabIndex = 0;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(243, 58);
            this.btn22.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 75);
            this.btn22.TabIndex = 0;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(67, 143);
            this.btn10.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 75);
            this.btn10.TabIndex = 0;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(154, 143);
            this.btn11.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 75);
            this.btn11.TabIndex = 0;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(243, 143);
            this.btn12.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 75);
            this.btn12.TabIndex = 0;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(67, 228);
            this.btn00.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 75);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(154, 228);
            this.btn01.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 75);
            this.btn01.TabIndex = 0;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(243, 228);
            this.btn02.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 75);
            this.btn02.TabIndex = 0;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // statusText
            // 
            this.statusText.Location = new System.Drawing.Point(67, 9);
            this.statusText.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(251, 44);
            this.statusText.TabIndex = 1;
            this.statusText.Text = "Текст";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "FormMain";
            this.Text = "Крестики - Нолики";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Label statusText;
    }
}

