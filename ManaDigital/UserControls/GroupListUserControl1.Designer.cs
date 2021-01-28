
namespace ManaDigital
{
    partial class GroupListUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupListUserControl1));
            this.Groupslabel1 = new System.Windows.Forms.Label();
            this.GroupMemberslabel2 = new System.Windows.Forms.Label();
            this.UpperLayoutpanel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftLayoutpanel1 = new System.Windows.Forms.Panel();
            this.GroupslistBox1 = new System.Windows.Forms.ListBox();
            this.GroupMemberslistBox2 = new System.Windows.Forms.ListBox();
            this.FlashLogopanel2 = new System.Windows.Forms.Panel();
            this.ExitGroupListbutton1 = new System.Windows.Forms.Button();
            this.royadbDataSet = new ManaDigital.royadbDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new ManaDigital.royadbDataSetTableAdapters.peopleTableAdapter();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new ManaDigital.royadbDataSetTableAdapters.groupsTableAdapter();
            this.UpperLayoutpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.royadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Groupslabel1
            // 
            this.Groupslabel1.AutoSize = true;
            this.Groupslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupslabel1.Location = new System.Drawing.Point(781, 128);
            this.Groupslabel1.Name = "Groupslabel1";
            this.Groupslabel1.Size = new System.Drawing.Size(44, 17);
            this.Groupslabel1.TabIndex = 0;
            this.Groupslabel1.Text = "گروه ها";
            // 
            // GroupMemberslabel2
            // 
            this.GroupMemberslabel2.AutoSize = true;
            this.GroupMemberslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMemberslabel2.Location = new System.Drawing.Point(284, 128);
            this.GroupMemberslabel2.Name = "GroupMemberslabel2";
            this.GroupMemberslabel2.Size = new System.Drawing.Size(71, 17);
            this.GroupMemberslabel2.TabIndex = 1;
            this.GroupMemberslabel2.Text = "اعضاء گروه ";
            // 
            // UpperLayoutpanel2
            // 
            this.UpperLayoutpanel2.Controls.Add(this.panel1);
            this.UpperLayoutpanel2.Controls.Add(this.LeftLayoutpanel1);
            this.UpperLayoutpanel2.Location = new System.Drawing.Point(9, 3);
            this.UpperLayoutpanel2.Name = "UpperLayoutpanel2";
            this.UpperLayoutpanel2.Size = new System.Drawing.Size(901, 51);
            this.UpperLayoutpanel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(847, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 626);
            this.panel1.TabIndex = 8;
            // 
            // LeftLayoutpanel1
            // 
            this.LeftLayoutpanel1.Location = new System.Drawing.Point(907, 0);
            this.LeftLayoutpanel1.Name = "LeftLayoutpanel1";
            this.LeftLayoutpanel1.Size = new System.Drawing.Size(51, 686);
            this.LeftLayoutpanel1.TabIndex = 6;
            // 
            // GroupslistBox1
            // 
            this.GroupslistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GroupslistBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "Id", true));
            this.GroupslistBox1.DataSource = this.groupsBindingSource;
            this.GroupslistBox1.DisplayMember = "groupName";
            this.GroupslistBox1.ForeColor = System.Drawing.Color.Silver;
            this.GroupslistBox1.FormattingEnabled = true;
            this.GroupslistBox1.ItemHeight = 16;
            this.GroupslistBox1.Location = new System.Drawing.Point(629, 179);
            this.GroupslistBox1.Name = "GroupslistBox1";
            this.GroupslistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupslistBox1.Size = new System.Drawing.Size(196, 292);
            this.GroupslistBox1.TabIndex = 11;
            this.GroupslistBox1.ValueMember = "Id";
            this.GroupslistBox1.Click += new System.EventHandler(this.GroupslistBox1_Click);
            // 
            // GroupMemberslistBox2
            // 
            this.GroupMemberslistBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GroupMemberslistBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peopleBindingSource, "Id", true));
            this.GroupMemberslistBox2.DataSource = this.peopleBindingSource;
            this.GroupMemberslistBox2.DisplayMember = "fullName";
            this.GroupMemberslistBox2.ForeColor = System.Drawing.Color.Silver;
            this.GroupMemberslistBox2.FormattingEnabled = true;
            this.GroupMemberslistBox2.ItemHeight = 16;
            this.GroupMemberslistBox2.Location = new System.Drawing.Point(159, 179);
            this.GroupMemberslistBox2.Name = "GroupMemberslistBox2";
            this.GroupMemberslistBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupMemberslistBox2.Size = new System.Drawing.Size(196, 292);
            this.GroupMemberslistBox2.TabIndex = 12;
            this.GroupMemberslistBox2.ValueMember = "Id";
            // 
            // FlashLogopanel2
            // 
            this.FlashLogopanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlashLogopanel2.BackgroundImage")));
            this.FlashLogopanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlashLogopanel2.Location = new System.Drawing.Point(361, 179);
            this.FlashLogopanel2.Name = "FlashLogopanel2";
            this.FlashLogopanel2.Size = new System.Drawing.Size(262, 292);
            this.FlashLogopanel2.TabIndex = 13;
            // 
            // ExitGroupListbutton1
            // 
            this.ExitGroupListbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitGroupListbutton1.BackgroundImage")));
            this.ExitGroupListbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitGroupListbutton1.FlatAppearance.BorderSize = 0;
            this.ExitGroupListbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGroupListbutton1.Location = new System.Drawing.Point(9, 586);
            this.ExitGroupListbutton1.Name = "ExitGroupListbutton1";
            this.ExitGroupListbutton1.Size = new System.Drawing.Size(29, 29);
            this.ExitGroupListbutton1.TabIndex = 14;
            this.ExitGroupListbutton1.UseVisualStyleBackColor = true;
            this.ExitGroupListbutton1.Click += new System.EventHandler(this.ExitGroupListbutton1_Click);
            // 
            // royadbDataSet
            // 
            this.royadbDataSet.DataSetName = "royadbDataSet";
            this.royadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "people";
            this.peopleBindingSource.DataSource = this.royadbDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.royadbDataSet;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // GroupListUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.ExitGroupListbutton1);
            this.Controls.Add(this.FlashLogopanel2);
            this.Controls.Add(this.GroupMemberslistBox2);
            this.Controls.Add(this.GroupslistBox1);
            this.Controls.Add(this.UpperLayoutpanel2);
            this.Controls.Add(this.GroupMemberslabel2);
            this.Controls.Add(this.Groupslabel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "GroupListUserControl1";
            this.Size = new System.Drawing.Size(910, 629);
            this.Load += new System.EventHandler(this.GroupListUserControl1_Load);
            this.UpperLayoutpanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.royadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Groupslabel1;
        private System.Windows.Forms.Label GroupMemberslabel2;
        private System.Windows.Forms.Panel UpperLayoutpanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftLayoutpanel1;
        private System.Windows.Forms.ListBox GroupslistBox1;
        private System.Windows.Forms.ListBox GroupMemberslistBox2;
        private System.Windows.Forms.Panel FlashLogopanel2;
        private System.Windows.Forms.Button ExitGroupListbutton1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private royadbDataSet royadbDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private royadbDataSetTableAdapters.peopleTableAdapter peopleTableAdapter;
        private royadbDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
    }
}
