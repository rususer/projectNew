namespace Mir
{
    partial class Mir
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
            this.btvoid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btvoid
            // 
            this.btvoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btvoid.Location = new System.Drawing.Point(220, 198);
            this.btvoid.Name = "btvoid";
            this.btvoid.Size = new System.Drawing.Size(113, 52);
            this.btvoid.TabIndex = 0;
            this.btvoid.Text = "Войти";
            this.btvoid.UseVisualStyleBackColor = true;
            this.btvoid.Click += new System.EventHandler(this.btvoid_Click);
            // 
            // Mir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.btvoid);
            this.Name = "Mir";
            this.Text = "Mir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btvoid;
    }
}

