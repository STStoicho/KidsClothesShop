namespace KidsClothesShop
{
    partial class Form1
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txb_Size = new System.Windows.Forms.TextBox();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(39, 388);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(114, 50);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(213, 388);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(114, 50);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(382, 388);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(114, 50);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Id.Location = new System.Drawing.Point(56, 15);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(27, 20);
            this.lbl_Id.TabIndex = 3;
            this.lbl_Id.Text = "Id:";
            // 
            // txb_Id
            // 
            this.txb_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Id.Location = new System.Drawing.Point(89, 12);
            this.txb_Id.Multiline = true;
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(173, 36);
            this.txb_Id.TabIndex = 4;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Name.Location = new System.Drawing.Point(89, 63);
            this.txb_Name.Multiline = true;
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(173, 36);
            this.txb_Name.TabIndex = 6;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Name.Location = new System.Drawing.Point(28, 66);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name:";
            // 
            // txb_Price
            // 
            this.txb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Price.Location = new System.Drawing.Point(89, 116);
            this.txb_Price.Multiline = true;
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(173, 36);
            this.txb_Price.TabIndex = 8;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Price.Location = new System.Drawing.Point(35, 119);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(48, 20);
            this.lbl_Price.TabIndex = 7;
            this.lbl_Price.Text = "Price:";
            // 
            // txb_Size
            // 
            this.txb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Size.Location = new System.Drawing.Point(89, 168);
            this.txb_Size.Multiline = true;
            this.txb_Size.Name = "txb_Size";
            this.txb_Size.Size = new System.Drawing.Size(173, 36);
            this.txb_Size.TabIndex = 10;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Size.Location = new System.Drawing.Point(39, 171);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(44, 20);
            this.lbl_Size.TabIndex = 9;
            this.lbl_Size.Text = "Size:";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Gender.Location = new System.Drawing.Point(16, 222);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(67, 20);
            this.lbl_Gender.TabIndex = 11;
            this.lbl_Gender.Text = "Gender:";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Boy",
            "Girl"});
            this.cmb_Gender.Location = new System.Drawing.Point(89, 224);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(173, 28);
            this.cmb_Gender.TabIndex = 12;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Type.Location = new System.Drawing.Point(35, 270);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(47, 20);
            this.lbl_Type.TabIndex = 13;
            this.lbl_Type.Text = "Type:";
            // 
            // cmb_Type
            // 
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(88, 270);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(173, 28);
            this.cmb_Type.TabIndex = 14;
            // 
            // txb_Description
            // 
            this.txb_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Description.Location = new System.Drawing.Point(89, 313);
            this.txb_Description.Multiline = true;
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(292, 58);
            this.txb_Description.TabIndex = 16;
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Description.Location = new System.Drawing.Point(0, 316);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(93, 20);
            this.lbl_Description.TabIndex = 15;
            this.lbl_Description.Text = "Description:";
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(548, 388);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(114, 50);
            this.btn_Find.TabIndex = 17;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectAll.Location = new System.Drawing.Point(712, 388);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(114, 50);
            this.btn_SelectAll.TabIndex = 18;
            this.btn_SelectAll.Text = "Select All";
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // listbox
            // 
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Location = new System.Drawing.Point(281, 15);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(566, 292);
            this.listbox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.txb_Size);
            this.Controls.Add(this.lbl_Size);
            this.Controls.Add(this.txb_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txb_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txb_Size;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.ListBox listbox;
    }
}