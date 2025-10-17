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
            btn_CleateDabase = new Button();
            Lbl_tag = new Label();
            btn_InsertSampleData = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_CleateDabase
            // 
            btn_CleateDabase.Location = new Point(771, 399);
            btn_CleateDabase.Margin = new Padding(4, 4, 4, 4);
            btn_CleateDabase.Name = "btn_CleateDabase";
            btn_CleateDabase.Size = new Size(124, 61);
            btn_CleateDabase.TabIndex = 0;
            btn_CleateDabase.Text = "データベース生成";
            btn_CleateDabase.UseVisualStyleBackColor = true;
            btn_CleateDabase.Click += btn_CleateDabase_Click;
            // 
            // Lbl_tag
            // 
            Lbl_tag.AutoSize = true;
            Lbl_tag.Location = new Point(310, 201);
            Lbl_tag.Margin = new Padding(4, 0, 4, 0);
            Lbl_tag.Name = "Lbl_tag";
            Lbl_tag.Size = new Size(223, 15);
            Lbl_tag.TabIndex = 1;
            Lbl_tag.Text = "このページはログイン画面として作成してください";
            // 
            // btn_InsertSampleData
            // 
            btn_InsertSampleData.Location = new Point(771, 486);
            btn_InsertSampleData.Margin = new Padding(4, 4, 4, 4);
            btn_InsertSampleData.Name = "btn_InsertSampleData";
            btn_InsertSampleData.Size = new Size(124, 61);
            btn_InsertSampleData.TabIndex = 0;
            btn_InsertSampleData.Text = "サンプルデータ登録";
            btn_InsertSampleData.UseVisualStyleBackColor = true;
            btn_InsertSampleData.Click += btn_InsertSampleData_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 409);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // F_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 562);
            Controls.Add(button1);
            Controls.Add(Lbl_tag);
            Controls.Add(btn_InsertSampleData);
            Controls.Add(btn_CleateDabase);
            Margin = new Padding(4, 4, 4, 4);
            Name = "F_login";
            Text = "販売管理システムログイン画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_CleateDabase;
        private System.Windows.Forms.Label Lbl_tag;
        private System.Windows.Forms.Button btn_InsertSampleData;
        private Button button1;
    }
}
