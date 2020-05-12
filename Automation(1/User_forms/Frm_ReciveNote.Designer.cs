namespace Automation_1.User_forms
{
    partial class Frm_ReciveNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReciveNote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.timpepicker_ta = new FreeControls.PersianDateTimePicker();
            this.timepicker_az = new FreeControls.PersianDateTimePicker();
            this.picboc_search = new System.Windows.Forms.PictureBox();
            this.txt_Sender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Subject = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgv_ReciveNote = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Note_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userid_Recive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboc_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReciveNote)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSubject
            // 
            // 
            // 
            // 
            this.txtSubject.Border.Class = "TextBoxBorder";
            this.txtSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSubject.Location = new System.Drawing.Point(172, 28);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PreventEnterBeep = true;
            this.txtSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubject.Size = new System.Drawing.Size(197, 31);
            this.txtSubject.TabIndex = 40;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtSubject);
            this.groupPanel2.Controls.Add(this.timpepicker_ta);
            this.groupPanel2.Controls.Add(this.timepicker_az);
            this.groupPanel2.Controls.Add(this.picboc_search);
            this.groupPanel2.Controls.Add(this.txt_Sender);
            this.groupPanel2.Controls.Add(this.txt_Subject);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(6, 577);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1235, 126);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 9;
            this.groupPanel2.Text = "جستجو";
            // 
            // timpepicker_ta
            // 
            this.timpepicker_ta.BackColor = System.Drawing.Color.White;
            this.timpepicker_ta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.timpepicker_ta.Location = new System.Drawing.Point(737, 28);
            this.timpepicker_ta.Name = "timpepicker_ta";
            this.timpepicker_ta.ShowTime = false;
            this.timpepicker_ta.Size = new System.Drawing.Size(129, 22);
            this.timpepicker_ta.TabIndex = 39;
            this.timpepicker_ta.Text = "persianDateTimePicker4";
            this.timpepicker_ta.Value = ((FreeControls.PersianDate)(resources.GetObject("timpepicker_ta.Value")));
            // 
            // timepicker_az
            // 
            this.timepicker_az.BackColor = System.Drawing.Color.White;
            this.timepicker_az.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.timepicker_az.Location = new System.Drawing.Point(939, 28);
            this.timepicker_az.Name = "timepicker_az";
            this.timepicker_az.ShowTime = false;
            this.timepicker_az.Size = new System.Drawing.Size(128, 22);
            this.timepicker_az.TabIndex = 1;
            this.timepicker_az.Text = "persianDateTimePicker1";
            this.timepicker_az.Value = ((FreeControls.PersianDate)(resources.GetObject("timepicker_az.Value")));
            // 
            // picboc_search
            // 
            this.picboc_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboc_search.Image = global::Automation_1.Properties.Resources.search_icon;
            this.picboc_search.Location = new System.Drawing.Point(69, 23);
            this.picboc_search.Name = "picboc_search";
            this.picboc_search.Size = new System.Drawing.Size(57, 47);
            this.picboc_search.TabIndex = 22;
            this.picboc_search.TabStop = false;
            this.picboc_search.Click += new System.EventHandler(this.picboc_search_Click);
            // 
            // txt_Sender
            // 
            // 
            // 
            // 
            this.txt_Sender.Border.Class = "TextBoxBorder";
            this.txt_Sender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Sender.Location = new System.Drawing.Point(459, 26);
            this.txt_Sender.Name = "txt_Sender";
            this.txt_Sender.PreventEnterBeep = true;
            this.txt_Sender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Sender.Size = new System.Drawing.Size(197, 31);
            this.txt_Sender.TabIndex = 18;
            // 
            // txt_Subject
            // 
            // 
            // 
            // 
            this.txt_Subject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Subject.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Subject.Location = new System.Drawing.Point(357, 28);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Subject.Size = new System.Drawing.Size(73, 27);
            this.txt_Subject.TabIndex = 4;
            this.txt_Subject.Text = "موضوع :";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX4.Location = new System.Drawing.Point(638, 28);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(73, 27);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "گیرنده :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(850, 23);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(73, 27);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "تا تاریخ :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX2.Location = new System.Drawing.Point(1048, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(73, 27);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "از تاریخ :";
            // 
            // dgv_ReciveNote
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReciveNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ReciveNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReciveNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Note_ID,
            this.Userid_Recive,
            this.Subject,
            this.TextNote,
            this.NoteDate,
            this.SendUser});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ReciveNote.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ReciveNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ReciveNote.EnableHeadersVisualStyles = false;
            this.dgv_ReciveNote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_ReciveNote.Location = new System.Drawing.Point(0, 0);
            this.dgv_ReciveNote.Name = "dgv_ReciveNote";
            this.dgv_ReciveNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReciveNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ReciveNote.RowTemplate.Height = 24;
            this.dgv_ReciveNote.Size = new System.Drawing.Size(1238, 472);
            this.dgv_ReciveNote.TabIndex = 0;
            // 
            // Note_ID
            // 
            this.Note_ID.HeaderText = "Column1";
            this.Note_ID.Name = "Note_ID";
            this.Note_ID.Visible = false;
            // 
            // Userid_Recive
            // 
            this.Userid_Recive.HeaderText = "Column1";
            this.Userid_Recive.Name = "Userid_Recive";
            this.Userid_Recive.Visible = false;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "موضوع";
            this.Subject.Name = "Subject";
            this.Subject.Width = 240;
            // 
            // TextNote
            // 
            this.TextNote.HeaderText = "متن یاداشت";
            this.TextNote.Name = "TextNote";
            this.TextNote.Width = 400;
            // 
            // NoteDate
            // 
            this.NoteDate.HeaderText = "زمان ارسال یاداشت";
            this.NoteDate.Name = "NoteDate";
            this.NoteDate.Width = 300;
            // 
            // SendUser
            // 
            this.SendUser.HeaderText = "فرستنده";
            this.SendUser.Name = "SendUser";
            this.SendUser.Width = 250;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dgv_ReciveNote);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(3, 72);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1244, 478);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 8;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ImageTextSpacing = 10;
            this.labelX1.Location = new System.Drawing.Point(527, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(295, 33);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "فرم نمایش یاداشت های وارده";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1247, 750);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 12;
            // 
            // Frm_ReciveNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 750);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Mitra", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ReciveNote";
            this.Load += new System.EventHandler(this.Frm_ReciveNote_Load);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboc_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReciveNote)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtSubject;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private FreeControls.PersianDateTimePicker timpepicker_ta;
        private FreeControls.PersianDateTimePicker timepicker_az;
        private System.Windows.Forms.PictureBox picboc_search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Sender;
        private DevComponents.DotNetBar.LabelX txt_Subject;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_ReciveNote;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userid_Recive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendUser;
    }
}