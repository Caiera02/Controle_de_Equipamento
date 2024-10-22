namespace Controle_Equipamentos
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtPwd = new TextBox();
            txtUser = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 39);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(106, 146);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(58, 183);
            txtPwd.MaximumSize = new Size(200, 200);
            txtPwd.MinimumSize = new Size(0, 30);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(169, 30);
            txtPwd.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(58, 78);
            txtUser.MaximumSize = new Size(200, 200);
            txtUser.MinimumSize = new Size(0, 30);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(169, 30);
            txtUser.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(106, 272);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(75, 23);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Entrar";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(298, 318);
            ControlBox = false;
            Controls.Add(btnEnter);
            Controls.Add(txtUser);
            Controls.Add(txtPwd);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.FromArgb(255, 192, 192);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPwd;
        private TextBox txtUser;
        private Button btnEnter;
    }
}
