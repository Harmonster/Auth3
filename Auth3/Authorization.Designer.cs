
namespace Auth3
{
    partial class Authorization
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_auth = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_auth);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 274);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(35, 161);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(192, 27);
            this.tb_password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(35, 87);
            this.tb_login.MaxLength = 20;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(192, 27);
            this.tb_login.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.Location = new System.Drawing.Point(134, 205);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(116, 44);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_auth
            // 
            this.btn_auth.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_auth.Location = new System.Drawing.Point(12, 205);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(116, 44);
            this.btn_auth.TabIndex = 0;
            this.btn_auth.Text = "Вход";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // Authorization
            // 
            this.AcceptButton = this.btn_auth;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 274);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorization";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_password;
    }
}

