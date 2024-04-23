namespace ООАП_лаба_3
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
            this.forward_butt = new System.Windows.Forms.Button();
            this.back_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.singer_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forward_butt
            // 
            this.forward_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.forward_butt.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forward_butt.Location = new System.Drawing.Point(439, 168);
            this.forward_butt.Name = "forward_butt";
            this.forward_butt.Size = new System.Drawing.Size(121, 52);
            this.forward_butt.TabIndex = 0;
            this.forward_butt.Text = "Вперёд";
            this.forward_butt.UseVisualStyleBackColor = false;
            this.forward_butt.Click += new System.EventHandler(this.forward_butt_Click);
            // 
            // back_butt
            // 
            this.back_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.back_butt.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_butt.Location = new System.Drawing.Point(83, 168);
            this.back_butt.Name = "back_butt";
            this.back_butt.Size = new System.Drawing.Size(121, 52);
            this.back_butt.TabIndex = 1;
            this.back_butt.Text = "Назад";
            this.back_butt.UseVisualStyleBackColor = false;
            this.back_butt.Click += new System.EventHandler(this.back_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(250, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Плеер";
            // 
            // singer_label
            // 
            this.singer_label.AutoSize = true;
            this.singer_label.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singer_label.Location = new System.Drawing.Point(76, 110);
            this.singer_label.Name = "singer_label";
            this.singer_label.Size = new System.Drawing.Size(207, 40);
            this.singer_label.TabIndex = 3;
            this.singer_label.Text = "Исполнитель- ";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(271, 110);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(131, 40);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "название ";
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stop_button.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stop_button.Location = new System.Drawing.Point(227, 168);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(95, 52);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.start_button.Font = new System.Drawing.Font("Segoe Script", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_button.Location = new System.Drawing.Point(328, 168);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(85, 52);
            this.start_button.TabIndex = 7;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label.Location = new System.Drawing.Point(472, 110);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(88, 40);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "время";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 282);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.singer_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_butt);
            this.Controls.Add(this.forward_butt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button forward_butt;
        private System.Windows.Forms.Button back_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label singer_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label time_label;
    }
}

