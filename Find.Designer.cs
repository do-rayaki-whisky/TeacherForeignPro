namespace TeacherForeignPro
{
    partial class FORM_FIND
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FIND_INPUT_Bowin = new System.Windows.Forms.RadioButton();
            this.FIND_INPUT_Sattahip = new System.Windows.Forms.RadioButton();
            this.FIND_INPUT_Pattaya = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FIND_INPUT_FindWord = new System.Windows.Forms.TextBox();
            this.FIND_INPUT_All = new System.Windows.Forms.RadioButton();
            this.FIND_OUTPUT_ListView = new System.Windows.Forms.ListView();
            this._Passport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._HisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Th_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Th_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Th_Lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._School = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIND_BTN_Send = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.FIND_INPUT_Bowin, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.FIND_INPUT_Sattahip, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.FIND_INPUT_Pattaya, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FIND_INPUT_FindWord, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FIND_INPUT_All, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FIND_INPUT_Bowin
            // 
            this.FIND_INPUT_Bowin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FIND_INPUT_Bowin.AutoSize = true;
            this.FIND_INPUT_Bowin.Location = new System.Drawing.Point(813, 10);
            this.FIND_INPUT_Bowin.Name = "FIND_INPUT_Bowin";
            this.FIND_INPUT_Bowin.Size = new System.Drawing.Size(56, 20);
            this.FIND_INPUT_Bowin.TabIndex = 6;
            this.FIND_INPUT_Bowin.Text = "บ่อวิน";
            this.FIND_INPUT_Bowin.UseVisualStyleBackColor = true;
            this.FIND_INPUT_Bowin.Click += new System.EventHandler(this.FIND_INPUT_Bowin_Click);
            // 
            // FIND_INPUT_Sattahip
            // 
            this.FIND_INPUT_Sattahip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FIND_INPUT_Sattahip.AutoSize = true;
            this.FIND_INPUT_Sattahip.Location = new System.Drawing.Point(723, 10);
            this.FIND_INPUT_Sattahip.Name = "FIND_INPUT_Sattahip";
            this.FIND_INPUT_Sattahip.Size = new System.Drawing.Size(58, 20);
            this.FIND_INPUT_Sattahip.TabIndex = 5;
            this.FIND_INPUT_Sattahip.Text = "สัตหีบ";
            this.FIND_INPUT_Sattahip.UseVisualStyleBackColor = true;
            this.FIND_INPUT_Sattahip.Click += new System.EventHandler(this.FIND_INPUT_Sattahip_Click);
            // 
            // FIND_INPUT_Pattaya
            // 
            this.FIND_INPUT_Pattaya.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FIND_INPUT_Pattaya.AutoSize = true;
            this.FIND_INPUT_Pattaya.Location = new System.Drawing.Point(633, 10);
            this.FIND_INPUT_Pattaya.Name = "FIND_INPUT_Pattaya";
            this.FIND_INPUT_Pattaya.Size = new System.Drawing.Size(58, 20);
            this.FIND_INPUT_Pattaya.TabIndex = 4;
            this.FIND_INPUT_Pattaya.Text = "พัทยา";
            this.FIND_INPUT_Pattaya.UseVisualStyleBackColor = true;
            this.FIND_INPUT_Pattaya.Click += new System.EventHandler(this.FIND_INPUT_Pattaya_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ใส่คำค้น ";
            // 
            // FIND_INPUT_FindWord
            // 
            this.FIND_INPUT_FindWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FIND_INPUT_FindWord.Location = new System.Drawing.Point(183, 8);
            this.FIND_INPUT_FindWord.Name = "FIND_INPUT_FindWord";
            this.FIND_INPUT_FindWord.Size = new System.Drawing.Size(354, 23);
            this.FIND_INPUT_FindWord.TabIndex = 2;
            this.FIND_INPUT_FindWord.TextChanged += new System.EventHandler(this.FIND_INPUT_FindWord_TextChanged);
            // 
            // FIND_INPUT_All
            // 
            this.FIND_INPUT_All.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FIND_INPUT_All.AutoSize = true;
            this.FIND_INPUT_All.Checked = true;
            this.FIND_INPUT_All.Location = new System.Drawing.Point(543, 10);
            this.FIND_INPUT_All.Name = "FIND_INPUT_All";
            this.FIND_INPUT_All.Size = new System.Drawing.Size(65, 20);
            this.FIND_INPUT_All.TabIndex = 3;
            this.FIND_INPUT_All.TabStop = true;
            this.FIND_INPUT_All.Text = "ทั้งหมด";
            this.FIND_INPUT_All.UseVisualStyleBackColor = true;
            this.FIND_INPUT_All.Click += new System.EventHandler(this.FIND_INPUT_All_Click);
            // 
            // FIND_OUTPUT_ListView
            // 
            this.FIND_OUTPUT_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Passport,
            this._HisID,
            this._Th_Title,
            this._Th_Name,
            this._Th_Lastname,
            this._School});
            this.FIND_OUTPUT_ListView.FullRowSelect = true;
            this.FIND_OUTPUT_ListView.GridLines = true;
            this.FIND_OUTPUT_ListView.Location = new System.Drawing.Point(12, 71);
            this.FIND_OUTPUT_ListView.MultiSelect = false;
            this.FIND_OUTPUT_ListView.Name = "FIND_OUTPUT_ListView";
            this.FIND_OUTPUT_ListView.Size = new System.Drawing.Size(900, 379);
            this.FIND_OUTPUT_ListView.TabIndex = 1;
            this.FIND_OUTPUT_ListView.UseCompatibleStateImageBehavior = false;
            this.FIND_OUTPUT_ListView.View = System.Windows.Forms.View.Details;
            // 
            // _Passport
            // 
            this._Passport.Text = "Passport";
            this._Passport.Width = 100;
            // 
            // _HisID
            // 
            this._HisID.Text = "รหัสครู";
            // 
            // _Th_Title
            // 
            this._Th_Title.Text = "คำนำหน้า";
            this._Th_Title.Width = 76;
            // 
            // _Th_Name
            // 
            this._Th_Name.Text = "ชื่อ";
            this._Th_Name.Width = 199;
            // 
            // _Th_Lastname
            // 
            this._Th_Lastname.Text = "นามสกุล";
            this._Th_Lastname.Width = 216;
            // 
            // _School
            // 
            this._School.Text = "โรงเรียน";
            this._School.Width = 201;
            // 
            // FIND_BTN_Send
            // 
            this.FIND_BTN_Send.Location = new System.Drawing.Point(423, 456);
            this.FIND_BTN_Send.Name = "FIND_BTN_Send";
            this.FIND_BTN_Send.Size = new System.Drawing.Size(75, 23);
            this.FIND_BTN_Send.TabIndex = 2;
            this.FIND_BTN_Send.Text = "Send ->";
            this.FIND_BTN_Send.UseVisualStyleBackColor = true;
            this.FIND_BTN_Send.Click += new System.EventHandler(this.FIND_BTN_Send_Click);
            // 
            // FORM_FIND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 489);
            this.Controls.Add(this.FIND_BTN_Send);
            this.Controls.Add(this.FIND_OUTPUT_ListView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_FIND";
            this.ShowInTaskbar = false;
            this.Text = "Find";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton FIND_INPUT_Bowin;
        private System.Windows.Forms.RadioButton FIND_INPUT_Sattahip;
        private System.Windows.Forms.RadioButton FIND_INPUT_Pattaya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIND_INPUT_FindWord;
        private System.Windows.Forms.RadioButton FIND_INPUT_All;
        private System.Windows.Forms.ListView FIND_OUTPUT_ListView;
        private System.Windows.Forms.ColumnHeader _Passport;
        private System.Windows.Forms.ColumnHeader _HisID;
        private System.Windows.Forms.ColumnHeader _Th_Title;
        private System.Windows.Forms.ColumnHeader _Th_Name;
        private System.Windows.Forms.ColumnHeader _Th_Lastname;
        private System.Windows.Forms.ColumnHeader _School;
        private System.Windows.Forms.Button FIND_BTN_Send;
    }
}