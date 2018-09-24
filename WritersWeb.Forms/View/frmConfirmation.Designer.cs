namespace WritersWeb.View
{
    partial class frmConfirmation
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
            this.lblClose = new DevComponents.DotNetBar.LabelX();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.lblCancel = new DevComponents.DotNetBar.LabelX();
            this.btnOK = new DevComponents.DotNetBar.ButtonX();
            this.lblMessage = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblClose.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.DimGray;
            this.lblClose.Location = new System.Drawing.Point(429, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.PaddingBottom = 3;
            this.lblClose.Size = new System.Drawing.Size(23, 0);
            this.lblClose.SymbolColor = System.Drawing.Color.Gray;
            this.lblClose.SymbolSize = 12F;
            this.lblClose.TabIndex = 160;
            this.lblClose.Text = "X";
            this.lblClose.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Controls.Add(this.lblCancel);
            this.pnlMain.Controls.Add(this.btnOK);
            this.pnlMain.Controls.Add(this.lblMessage);
            this.pnlMain.Controls.Add(this.lblClose);
            this.pnlMain.Controls.Add(this.labelX1);
            this.pnlMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(457, 239);
            this.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlMain.Style.BackColor1.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMain.Style.BackColor2.Color = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMain.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlMain.Style.BorderWidth = 10;
            this.pnlMain.Style.CornerDiameter = 10;
            this.pnlMain.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMain.Style.GradientAngle = 90;
            this.pnlMain.TabIndex = 28;
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblCancel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(429, 3);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.PaddingBottom = 3;
            this.lblCancel.Size = new System.Drawing.Size(23, 26);
            this.lblCancel.SymbolColor = System.Drawing.Color.White;
            this.lblCancel.SymbolSize = 12F;
            this.lblCancel.TabIndex = 178;
            this.lblCancel.Text = "X";
            this.lblCancel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.AutoExpandOnClick = true;
            this.btnOK.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.btnOK.FadeEffect = false;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
            this.btnOK.Location = new System.Drawing.Point(158, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btnOK.Size = new System.Drawing.Size(134, 43);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.SubItemsExpandWidth = 15;
            this.btnOK.SymbolColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.SymbolSize = 12F;
            this.btnOK.TabIndex = 177;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            // 
            // lblMessage
            // 
            // 
            // 
            // 
            this.lblMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(3, 90);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(449, 32);
            this.lblMessage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblMessage.TabIndex = 163;
            this.lblMessage.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(97, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(268, 32);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 118;
            this.labelX1.Text = "CONFIRMATION DIALOG";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 239);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConfirmation";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblClose;
        public DevComponents.DotNetBar.PanelEx pnlMain;
        private DevComponents.DotNetBar.ButtonX btnOK;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblCancel;
        public DevComponents.DotNetBar.LabelX lblMessage;
    }
}