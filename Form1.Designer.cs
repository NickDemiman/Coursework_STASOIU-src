namespace Курсач
{
    partial class Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.UserSearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Head = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton4 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CloseAppBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            this.Panel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.Head.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(162)))), ((int)(((byte)(153)))));
            this.guna2Panel1.Controls.Add(this.Panel);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 40);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(413, 1024);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(61)))));
            this.Panel.Controls.Add(this.UserSearchBox);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(413, 80);
            this.Panel.TabIndex = 0;
            // 
            // UserSearchBox
            // 
            this.UserSearchBox.BorderThickness = 0;
            this.UserSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserSearchBox.DefaultText = "";
            this.UserSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserSearchBox.DisabledState.Parent = this.UserSearchBox;
            this.UserSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserSearchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(61)))));
            this.UserSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserSearchBox.FocusedState.Parent = this.UserSearchBox;
            this.UserSearchBox.Font = new System.Drawing.Font("Arial", 13.5F);
            this.UserSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserSearchBox.HoverState.Parent = this.UserSearchBox;
            this.UserSearchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("UserSearchBox.IconLeft")));
            this.UserSearchBox.IconLeftSize = new System.Drawing.Size(40, 40);
            this.UserSearchBox.Location = new System.Drawing.Point(10, 20);
            this.UserSearchBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.UserSearchBox.MaxLength = 30;
            this.UserSearchBox.Name = "UserSearchBox";
            this.UserSearchBox.PasswordChar = '\0';
            this.UserSearchBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(206)))), ((int)(((byte)(205)))));
            this.UserSearchBox.PlaceholderText = "Поиск пользователя";
            this.UserSearchBox.SelectedText = "";
            this.UserSearchBox.ShadowDecoration.Parent = this.UserSearchBox;
            this.UserSearchBox.Size = new System.Drawing.Size(230, 40);
            this.UserSearchBox.TabIndex = 1;
            this.UserSearchBox.TextOffset = new System.Drawing.Point(0, -2);
            this.UserSearchBox.WordWrap = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(166)))));
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Location = new System.Drawing.Point(413, 40);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(867, 1024);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(103)))));
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(103)))));
            this.guna2Panel4.Location = new System.Drawing.Point(0, 883);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(867, 100);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(103)))));
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(103)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(867, 80);
            this.guna2Panel3.TabIndex = 0;
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.Head.BorderRadius = 10;
            this.Head.Controls.Add(this.guna2ImageButton4);
            this.Head.Controls.Add(this.guna2ImageButton3);
            this.Head.Controls.Add(this.guna2ImageButton2);
            this.Head.Controls.Add(this.CloseAppBtn);
            this.Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.Head.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Head.Location = new System.Drawing.Point(0, 0);
            this.Head.Margin = new System.Windows.Forms.Padding(0);
            this.Head.Name = "Head";
            this.Head.ShadowDecoration.Parent = this.Head;
            this.Head.Size = new System.Drawing.Size(1280, 40);
            this.Head.TabIndex = 0;
            // 
            // guna2ImageButton4
            // 
            this.guna2ImageButton4.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton4.CheckedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.HoverState.Image")));
            this.guna2ImageButton4.HoverState.ImageSize = new System.Drawing.Size(233, 40);
            this.guna2ImageButton4.HoverState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton4.Image")));
            this.guna2ImageButton4.ImageRotate = 0F;
            this.guna2ImageButton4.ImageSize = new System.Drawing.Size(233, 40);
            this.guna2ImageButton4.Location = new System.Drawing.Point(0, 0);
            this.guna2ImageButton4.Name = "guna2ImageButton4";
            this.guna2ImageButton4.PressedState.ImageSize = new System.Drawing.Size(233, 40);
            this.guna2ImageButton4.PressedState.Parent = this.guna2ImageButton4;
            this.guna2ImageButton4.Size = new System.Drawing.Size(233, 40);
            this.guna2ImageButton4.TabIndex = 0;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.HoverState.Image")));
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton3.Location = new System.Drawing.Point(1160, 0);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(36, 36);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton3.TabIndex = 2;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.HoverState.Image")));
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1200, 0);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.TabIndex = 1;
            // 
            // CloseAppBtn
            // 
            this.CloseAppBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.CloseAppBtn.CheckedState.Parent = this.CloseAppBtn;
            this.CloseAppBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppBtn.HoverState.Image")));
            this.CloseAppBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.CloseAppBtn.HoverState.Parent = this.CloseAppBtn;
            this.CloseAppBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppBtn.Image")));
            this.CloseAppBtn.ImageRotate = 0F;
            this.CloseAppBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.CloseAppBtn.Location = new System.Drawing.Point(1240, 0);
            this.CloseAppBtn.Name = "CloseAppBtn";
            this.CloseAppBtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.CloseAppBtn.PressedState.Parent = this.CloseAppBtn;
            this.CloseAppBtn.Size = new System.Drawing.Size(40, 40);
            this.CloseAppBtn.TabIndex = 0;
            this.CloseAppBtn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.Head;
            // 
            // Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.Head.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel Head;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton CloseAppBtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel Panel;
        public Guna.UI2.WinForms.Guna2TextBox UserSearchBox;
    }
}

