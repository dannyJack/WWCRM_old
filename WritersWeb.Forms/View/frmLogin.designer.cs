namespace WritersWeb.View
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.txt_pword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_uname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sideNav = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.sideNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.DimGray;
            this.labelX4.Location = new System.Drawing.Point(979, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(17, 18);
            this.labelX4.SymbolColor = System.Drawing.Color.Gray;
            this.labelX4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX4.SymbolSize = 12F;
            this.labelX4.TabIndex = 4;
            this.labelX4.Text = "-";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.DimGray;
            this.labelX5.Location = new System.Drawing.Point(994, 5);
            this.labelX5.Name = "labelX5";
            this.labelX5.PaddingBottom = 3;
            this.labelX5.Size = new System.Drawing.Size(23, 19);
            this.labelX5.SymbolColor = System.Drawing.Color.Gray;
            this.labelX5.SymbolSize = 12F;
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "X";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.AutoExpandOnClick = true;
            this.btnLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FadeEffect = false;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnLogin.Location = new System.Drawing.Point(661, 503);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnLogin.Size = new System.Drawing.Size(336, 39);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.SubItemsExpandWidth = 15;
            this.btnLogin.SymbolColor = System.Drawing.Color.White;
            this.btnLogin.SymbolSize = 15F;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txt_pword
            // 
            this.txt_pword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_pword.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_pword.Border.BorderColor = System.Drawing.Color.Gray;
            this.txt_pword.Border.Class = "TextBoxBorder";
            this.txt_pword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txt_pword.DisabledBackColor = System.Drawing.Color.White;
            this.txt_pword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pword.ForeColor = System.Drawing.Color.Black;
            this.txt_pword.Location = new System.Drawing.Point(661, 390);
            this.txt_pword.Name = "txt_pword";
            this.txt_pword.PasswordChar = '•';
            this.txt_pword.Size = new System.Drawing.Size(336, 39);
            this.txt_pword.TabIndex = 1;
            this.txt_pword.WatermarkText = "Type your password";
            this.txt_pword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pword_KeyPress);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(660, 284);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(130, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 104;
            this.labelX1.Text = "Username:";
            // 
            // txt_uname
            // 
            this.txt_uname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_uname.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_uname.Border.BorderColor = System.Drawing.Color.Gray;
            this.txt_uname.Border.Class = "TextBoxBorder";
            this.txt_uname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txt_uname.DisabledBackColor = System.Drawing.Color.White;
            this.txt_uname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.ForeColor = System.Drawing.Color.Black;
            this.txt_uname.Location = new System.Drawing.Point(661, 313);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(336, 39);
            this.txt_uname.TabIndex = 0;
            this.txt_uname.WatermarkText = "Type your username";
            this.txt_uname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pword_KeyPress);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(661, 361);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(123, 23);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 108;
            this.labelX2.Text = "Password:";
            // 
            // line1
            // 
            this.line1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.line1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.line1.Location = new System.Drawing.Point(592, 454);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(430, 23);
            this.line1.TabIndex = 116;
            this.line1.Text = "line1";
            // 
            // line2
            // 
            this.line2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.line2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.line2.Location = new System.Drawing.Point(592, 251);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(430, 23);
            this.line2.TabIndex = 117;
            this.line2.Text = "line2";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(648, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 153);
            this.panel2.TabIndex = 118;
            // 
            // sideNav
            // 
            this.sideNav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sideNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sideNav.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sideNav.Controls.Add(this.panel1);
            this.sideNav.Controls.Add(this.labelX6);
            this.sideNav.Controls.Add(this.labelX3);
            this.sideNav.DisabledBackColor = System.Drawing.Color.Empty;
            this.sideNav.Location = new System.Drawing.Point(0, 0);
            this.sideNav.Name = "sideNav";
            this.sideNav.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sideNav.Size = new System.Drawing.Size(632, 661);
            this.sideNav.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.sideNav.Style.BackColor1.Color = System.Drawing.SystemColors.InactiveCaptionText;
            this.sideNav.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaptionText;
            this.sideNav.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine;
            this.sideNav.Style.BorderColor.Color = System.Drawing.Color.Gray;
            this.sideNav.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
            this.sideNav.Style.BorderWidth = 3;
            this.sideNav.Style.ForeColor.Color = System.Drawing.Color.Gray;
            this.sideNav.Style.GradientAngle = 90;
            this.sideNav.TabIndex = 132;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(52, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 256);
            this.panel1.TabIndex = 119;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.White;
            this.labelX6.Location = new System.Drawing.Point(12, 284);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(34, 31);
            this.labelX6.Symbol = "58132";
            this.labelX6.SymbolColor = System.Drawing.Color.White;
            this.labelX6.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX6.SymbolSize = 20F;
            this.labelX6.TabIndex = 6;
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(585, 280);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(34, 31);
            this.labelX3.Symbol = "58133";
            this.labelX3.SymbolColor = System.Drawing.Color.White;
            this.labelX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX3.SymbolSize = 20F;
            this.labelX3.TabIndex = 5;
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 600);
            this.Controls.Add(this.sideNav);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_pword);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.sideNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pword;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_uname;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.PanelEx sideNav;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Panel panel1;
    }
}