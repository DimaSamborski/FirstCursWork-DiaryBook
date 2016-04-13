namespace AtP_Curs
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.GAdd = new System.Windows.Forms.Button();
            this.txtAddGroup = new System.Windows.Forms.TextBox();
            this.cmbAddFacults = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbViewGroup = new System.Windows.Forms.ComboBox();
            this.cmbViewFacults = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRedactingCount = new System.Windows.Forms.TextBox();
            this.cmbRedactingGroup = new System.Windows.Forms.ComboBox();
            this.cmbRedactingFacults = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmdDeleteGroup = new System.Windows.Forms.ComboBox();
            this.cmbDeleteFacukltets = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddCount);
            this.groupBox1.Controls.Add(this.GAdd);
            this.groupBox1.Controls.Add(this.txtAddGroup);
            this.groupBox1.Controls.Add(this.cmbAddFacults);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // txtAddCount
            // 
            this.txtAddCount.Location = new System.Drawing.Point(7, 82);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(100, 20);
            this.txtAddCount.TabIndex = 3;
            // 
            // GAdd
            // 
            this.GAdd.Location = new System.Drawing.Point(138, 82);
            this.GAdd.Name = "GAdd";
            this.GAdd.Size = new System.Drawing.Size(97, 28);
            this.GAdd.TabIndex = 2;
            this.GAdd.Text = "Add Group";
            this.GAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Location = new System.Drawing.Point(135, 41);
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.Size = new System.Drawing.Size(100, 20);
            this.txtAddGroup.TabIndex = 1;
            // 
            // cmbAddFacults
            // 
            this.cmbAddFacults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddFacults.FormattingEnabled = true;
            this.cmbAddFacults.Location = new System.Drawing.Point(7, 41);
            this.cmbAddFacults.Name = "cmbAddFacults";
            this.cmbAddFacults.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFacults.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BSearch);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.cmbViewGroup);
            this.groupBox2.Controls.Add(this.cmbViewFacults);
            this.groupBox2.Location = new System.Drawing.Point(326, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // BSearch
            // 
            this.BSearch.Location = new System.Drawing.Point(302, 17);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(75, 23);
            this.BSearch.TabIndex = 4;
            this.BSearch.Text = "Search";
            this.BSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbViewGroup
            // 
            this.cmbViewGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewGroup.FormattingEnabled = true;
            this.cmbViewGroup.Location = new System.Drawing.Point(154, 20);
            this.cmbViewGroup.Name = "cmbViewGroup";
            this.cmbViewGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbViewGroup.TabIndex = 1;
            // 
            // cmbViewFacults
            // 
            this.cmbViewFacults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewFacults.FormattingEnabled = true;
            this.cmbViewFacults.Location = new System.Drawing.Point(7, 20);
            this.cmbViewFacults.Name = "cmbViewFacults";
            this.cmbViewFacults.Size = new System.Drawing.Size(121, 21);
            this.cmbViewFacults.TabIndex = 0;
            this.cmbViewFacults.SelectedIndexChanged += new System.EventHandler(this.cmbViewFacults_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtRedactingCount);
            this.groupBox3.Controls.Add(this.cmbRedactingGroup);
            this.groupBox3.Controls.Add(this.cmbRedactingFacults);
            this.groupBox3.Location = new System.Drawing.Point(6, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Redacting";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rgroup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtRedactingCount
            // 
            this.txtRedactingCount.Location = new System.Drawing.Point(7, 77);
            this.txtRedactingCount.Name = "txtRedactingCount";
            this.txtRedactingCount.Size = new System.Drawing.Size(100, 20);
            this.txtRedactingCount.TabIndex = 2;
            // 
            // cmbRedactingGroup
            // 
            this.cmbRedactingGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedactingGroup.FormattingEnabled = true;
            this.cmbRedactingGroup.Location = new System.Drawing.Point(135, 37);
            this.cmbRedactingGroup.Name = "cmbRedactingGroup";
            this.cmbRedactingGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbRedactingGroup.TabIndex = 1;
            // 
            // cmbRedactingFacults
            // 
            this.cmbRedactingFacults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedactingFacults.FormattingEnabled = true;
            this.cmbRedactingFacults.Location = new System.Drawing.Point(7, 38);
            this.cmbRedactingFacults.Name = "cmbRedactingFacults";
            this.cmbRedactingFacults.Size = new System.Drawing.Size(121, 21);
            this.cmbRedactingFacults.TabIndex = 0;
            this.cmbRedactingFacults.SelectedIndexChanged += new System.EventHandler(this.cmbRedactingFacults_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.cmdDeleteGroup);
            this.groupBox4.Controls.Add(this.cmbDeleteFacukltets);
            this.groupBox4.Location = new System.Drawing.Point(6, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 148);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(7, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteGroup
            // 
            this.cmdDeleteGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdDeleteGroup.FormattingEnabled = true;
            this.cmdDeleteGroup.Location = new System.Drawing.Point(147, 19);
            this.cmdDeleteGroup.Name = "cmdDeleteGroup";
            this.cmdDeleteGroup.Size = new System.Drawing.Size(121, 21);
            this.cmdDeleteGroup.TabIndex = 2;
            // 
            // cmbDeleteFacukltets
            // 
            this.cmbDeleteFacukltets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeleteFacukltets.FormattingEnabled = true;
            this.cmbDeleteFacukltets.Location = new System.Drawing.Point(7, 19);
            this.cmbDeleteFacukltets.Name = "cmbDeleteFacukltets";
            this.cmbDeleteFacukltets.Size = new System.Drawing.Size(121, 21);
            this.cmbDeleteFacukltets.TabIndex = 1;
            this.cmbDeleteFacukltets.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteFacukltets_SelectedIndexChanged);
            // 
            // btnAddUser
            // 
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddUser.Location = new System.Drawing.Point(326, 362);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(91, 39);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 425);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "VNTU Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.Button GAdd;
        private System.Windows.Forms.TextBox txtAddGroup;
        private System.Windows.Forms.ComboBox cmbAddFacults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRedactingCount;
        private System.Windows.Forms.ComboBox cmbRedactingGroup;
        private System.Windows.Forms.ComboBox cmbRedactingFacults;
        private System.Windows.Forms.ComboBox cmbViewGroup;
        private System.Windows.Forms.ComboBox cmbViewFacults;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmdDeleteGroup;
        private System.Windows.Forms.ComboBox cmbDeleteFacukltets;
    }
}