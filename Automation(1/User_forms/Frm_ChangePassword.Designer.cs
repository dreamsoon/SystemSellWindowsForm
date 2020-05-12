namespace Automation_1.User_forms
{
    partial class Frm_ChangePassword
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_changepassword = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_old = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_new = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_replaynew = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX4);
            this.panelEx1.Controls.Add(this.txt_replaynew);
            this.panelEx1.Controls.Add(this.btn_exit);
            this.panelEx1.Controls.Add(this.btn_changepassword);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.txt_new);
            this.panelEx1.Controls.Add(this.txt_old);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(501, 391);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ImageTextSpacing = 10;
            this.labelX1.Location = new System.Drawing.Point(166, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(176, 33);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "فرم تغیر رمز عبور";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Mitra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(327, 95);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(114, 41);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "رمز عبور قدیمی :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("B Mitra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(327, 157);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(114, 41);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "رمز عبور جدید :";
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.Location = new System.Drawing.Point(51, 296);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_exit.Size = new System.Drawing.Size(136, 45);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.Symbol = "";
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_changepassword
            // 
            this.btn_changepassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_changepassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_changepassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changepassword.Font = new System.Drawing.Font("B Mitra", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_changepassword.Location = new System.Drawing.Point(259, 296);
            this.btn_changepassword.Name = "btn_changepassword";
            this.btn_changepassword.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_changepassword.Size = new System.Drawing.Size(136, 45);
            this.btn_changepassword.Symbol = "";
            this.btn_changepassword.TabIndex = 15;
            this.btn_changepassword.Text = "ثبت";
            this.btn_changepassword.Click += new System.EventHandler(this.btn_createjob_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("B Mitra", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.Location = new System.Drawing.Point(317, 204);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(162, 41);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = " تکرار رمز عبور جدید :";
            // 
            // txt_old
            // 
            // 
            // 
            // 
            this.txt_old.Border.Class = "TextBoxBorder";
            this.txt_old.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_old.Location = new System.Drawing.Point(73, 105);
            this.txt_old.Name = "txt_old";
            this.txt_old.PasswordChar = '*';
            this.txt_old.PreventEnterBeep = true;
            this.txt_old.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_old.Size = new System.Drawing.Size(224, 31);
            this.txt_old.TabIndex = 11;
            // 
            // txt_new
            // 
            // 
            // 
            // 
            this.txt_new.Border.Class = "TextBoxBorder";
            this.txt_new.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_new.Location = new System.Drawing.Point(73, 157);
            this.txt_new.Name = "txt_new";
            this.txt_new.PasswordChar = '*';
            this.txt_new.PreventEnterBeep = true;
            this.txt_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_new.Size = new System.Drawing.Size(224, 31);
            this.txt_new.TabIndex = 12;
            // 
            // txt_replaynew
            // 
            // 
            // 
            // 
            this.txt_replaynew.Border.Class = "TextBoxBorder";
            this.txt_replaynew.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_replaynew.Location = new System.Drawing.Point(73, 204);
            this.txt_replaynew.Name = "txt_replaynew";
            this.txt_replaynew.PasswordChar = '*';
            this.txt_replaynew.PreventEnterBeep = true;
            this.txt_replaynew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_replaynew.Size = new System.Drawing.Size(224, 31);
            this.txt_replaynew.TabIndex = 17;
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 391);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChangePassword";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_changepassword;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_replaynew;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_new;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_old;
    }
}