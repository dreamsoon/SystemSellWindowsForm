namespace Automation_1.Admin_forms
{
    partial class Frm_AccessRight
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_accessRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ChangePasswprd = new System.Windows.Forms.Button();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_ChangePasswprd);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(631, 217);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(3, 173);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_exit.Size = new System.Drawing.Size(628, 43);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.Symbol = "";
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_accessRight
            // 
            this.btn_accessRight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_accessRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_accessRight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_accessRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accessRight.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_accessRight.Location = new System.Drawing.Point(0, 5);
            this.btn_accessRight.Name = "btn_accessRight";
            this.btn_accessRight.Size = new System.Drawing.Size(206, 168);
            this.btn_accessRight.TabIndex = 9;
            this.btn_accessRight.Text = "تایین حقوق دسترسی";
            this.btn_accessRight.UseVisualStyleBackColor = false;
            this.btn_accessRight.Click += new System.EventHandler(this.btn_accessRight_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(212, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 168);
            this.button1.TabIndex = 8;
            this.button1.Text = "تعریف اجزای سیستم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ChangePasswprd
            // 
            this.btn_ChangePasswprd.BackColor = System.Drawing.SystemColors.Info;
            this.btn_ChangePasswprd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePasswprd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ChangePasswprd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePasswprd.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ChangePasswprd.Location = new System.Drawing.Point(423, 5);
            this.btn_ChangePasswprd.Name = "btn_ChangePasswprd";
            this.btn_ChangePasswprd.Size = new System.Drawing.Size(206, 168);
            this.btn_ChangePasswprd.TabIndex = 14;
            this.btn_ChangePasswprd.Text = "تغیر رمز عبور";
            this.btn_ChangePasswprd.UseVisualStyleBackColor = false;
            this.btn_ChangePasswprd.Click += new System.EventHandler(this.btn_ChangePasswprd_Click);
            // 
            // Frm_AccessRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 217);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_accessRight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_AccessRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AccessRight";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private System.Windows.Forms.Button btn_accessRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ChangePasswprd;
    }
}