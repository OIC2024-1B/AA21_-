namespace SalesManagement_SysDev
{
    partial class F_login
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
            btn_InsertSampleData = new Button();
            btn_CleateDabase = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            L_txPassword = new TextBox();
            L_txLoginID = new TextBox();
            L_togglePassword = new Button();
            F_btn_login = new Button();
            L_changepassword_click = new Button();
            SuspendLayout();
            // 
            // btn_InsertSampleData
            // 
            btn_InsertSampleData.Location = new Point(549, 192);
            btn_InsertSampleData.Margin = new Padding(6, 7, 6, 7);
            btn_InsertSampleData.Name = "btn_InsertSampleData";
            btn_InsertSampleData.Size = new Size(155, 35);
            btn_InsertSampleData.TabIndex = 0;
            btn_InsertSampleData.Text = "サンプルデータ登録";
            btn_InsertSampleData.UseVisualStyleBackColor = true;
            btn_InsertSampleData.Click += btn_InsertSampleData_Click;
            // 
            // btn_CleateDabase
            // 
            btn_CleateDabase.Location = new Point(549, 136);
            btn_CleateDabase.Margin = new Padding(6, 7, 6, 7);
            btn_CleateDabase.Name = "btn_CleateDabase";
            btn_CleateDabase.Size = new Size(148, 32);
            btn_CleateDabase.TabIndex = 0;
            btn_CleateDabase.Text = "データベース生成";
            btn_CleateDabase.UseVisualStyleBackColor = true;
            btn_CleateDabase.Click += btn_CleateDabase_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 65);
            label1.Name = "label1";
            label1.Size = new Size(381, 52);
            label1.TabIndex = 1;
            label1.Text = "販売在庫管理システム";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 181);
            label2.Name = "label2";
            label2.Size = new Size(136, 35);
            label2.TabIndex = 2;
            label2.Text = "ログインID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 257);
            label3.Name = "label3";
            label3.Size = new Size(135, 35);
            label3.TabIndex = 3;
            label3.Text = "パスワード";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 334);
            label4.Name = "label4";
            label4.Size = new Size(404, 35);
            label4.TabIndex = 4;
            label4.Text = "パスワードをお忘れの方はこちら ＞";
            // 
            // L_txPassword
            // 
            L_txPassword.Location = new Point(212, 262);
            L_txPassword.Name = "L_txPassword";
            L_txPassword.Size = new Size(230, 31);
            L_txPassword.TabIndex = 5;
            // 
            // L_txLoginID
            // 
            L_txLoginID.Location = new Point(212, 186);
            L_txLoginID.Name = "L_txLoginID";
            L_txLoginID.Size = new Size(230, 31);
            L_txLoginID.TabIndex = 6;
            // 
            // L_togglePassword
            // 
            L_togglePassword.BackColor = Color.LightBlue;
            L_togglePassword.Location = new Point(462, 262);
            L_togglePassword.Name = "L_togglePassword";
            L_togglePassword.Size = new Size(54, 32);
            L_togglePassword.TabIndex = 7;
            L_togglePassword.Text = "○";
            L_togglePassword.UseVisualStyleBackColor = false;
            // 
            // F_btn_login
            // 
            F_btn_login.BackColor = Color.RoyalBlue;
            F_btn_login.Font = new Font("メイリオ", 10F, FontStyle.Bold, GraphicsUnit.Point);
            F_btn_login.ForeColor = Color.White;
            F_btn_login.Location = new Point(533, 256);
            F_btn_login.Name = "F_btn_login";
            F_btn_login.Size = new Size(134, 46);
            F_btn_login.TabIndex = 8;
            F_btn_login.Text = "ログイン";
            F_btn_login.UseVisualStyleBackColor = false;
            // 
            // L_changepassword_click
            // 
            L_changepassword_click.BackColor = Color.RoyalBlue;
            L_changepassword_click.Font = new Font("メイリオ", 10F, FontStyle.Bold, GraphicsUnit.Point);
            L_changepassword_click.ForeColor = Color.White;
            L_changepassword_click.Location = new Point(533, 329);
            L_changepassword_click.Name = "L_changepassword_click";
            L_changepassword_click.Size = new Size(134, 45);
            L_changepassword_click.TabIndex = 9;
            L_changepassword_click.Text = "変更";
            L_changepassword_click.UseVisualStyleBackColor = false;
            // 
            // F_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(749, 481);
            Controls.Add(L_changepassword_click);
            Controls.Add(F_btn_login);
            Controls.Add(L_togglePassword);
            Controls.Add(L_txLoginID);
            Controls.Add(L_txPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_InsertSampleData);
            Controls.Add(btn_CleateDabase);
            Margin = new Padding(6, 7, 6, 7);
            Name = "F_login";
            Text = "販売管理システムログイン画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_InsertSampleData;
        private Button btn_CleateDabase;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox L_txPassword;
        private TextBox L_txLoginID;
        private Button L_togglePassword;
        private Button F_btn_login;
        private Button L_changepassword_click;
    }
}
