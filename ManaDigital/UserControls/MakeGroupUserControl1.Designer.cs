
namespace ManaDigital
{
    partial class MakeGroupUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeGroupUserControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpperLayoutpanel2 = new System.Windows.Forms.Panel();
            this.LeftLayoutpanel1 = new System.Windows.Forms.Panel();
            this.NewGroupTextlabel1 = new System.Windows.Forms.Label();
            this.GroupNamelabel2 = new System.Windows.Forms.Label();
            this.GroupNamebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Memberslabel1 = new System.Windows.Forms.Label();
            this.NewGroupMemberlistBox1 = new System.Windows.Forms.ListBox();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.royadbDataSet = new ManaDigital.royadbDataSet();
            this.MemberslistBox1 = new System.Windows.Forms.ListBox();
            this.peopleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GroupListbutton1 = new System.Windows.Forms.Button();
            this.SubmitGroupbutton2 = new System.Windows.Forms.Button();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new ManaDigital.royadbDataSetTableAdapters.groupsTableAdapter();
            this.peopleTableAdapter = new ManaDigital.royadbDataSetTableAdapters.peopleTableAdapter();
            this.UpperLayoutpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.royadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(847, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 626);
            this.panel1.TabIndex = 8;
            // 
            // UpperLayoutpanel2
            // 
            this.UpperLayoutpanel2.Controls.Add(this.panel1);
            this.UpperLayoutpanel2.Controls.Add(this.LeftLayoutpanel1);
            this.UpperLayoutpanel2.Location = new System.Drawing.Point(9, 3);
            this.UpperLayoutpanel2.Name = "UpperLayoutpanel2";
            this.UpperLayoutpanel2.Size = new System.Drawing.Size(901, 51);
            this.UpperLayoutpanel2.TabIndex = 9;
            // 
            // LeftLayoutpanel1
            // 
            this.LeftLayoutpanel1.Location = new System.Drawing.Point(907, 0);
            this.LeftLayoutpanel1.Name = "LeftLayoutpanel1";
            this.LeftLayoutpanel1.Size = new System.Drawing.Size(51, 686);
            this.LeftLayoutpanel1.TabIndex = 6;
            // 
            // NewGroupTextlabel1
            // 
            this.NewGroupTextlabel1.AutoSize = true;
            this.NewGroupTextlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGroupTextlabel1.ForeColor = System.Drawing.Color.Silver;
            this.NewGroupTextlabel1.Location = new System.Drawing.Point(752, 71);
            this.NewGroupTextlabel1.Name = "NewGroupTextlabel1";
            this.NewGroupTextlabel1.Size = new System.Drawing.Size(103, 20);
            this.NewGroupTextlabel1.TabIndex = 15;
            this.NewGroupTextlabel1.Text = ":ایجاد گروه جدید";
            this.NewGroupTextlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GroupNamelabel2
            // 
            this.GroupNamelabel2.AutoSize = true;
            this.GroupNamelabel2.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamelabel2.Location = new System.Drawing.Point(804, 121);
            this.GroupNamelabel2.Name = "GroupNamelabel2";
            this.GroupNamelabel2.Size = new System.Drawing.Size(46, 17);
            this.GroupNamelabel2.TabIndex = 11;
            this.GroupNamelabel2.Text = "نام گروه";
            // 
            // GroupNamebunifuMaterialTextbox1
            // 
            this.GroupNamebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.GroupNamebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.GroupNamebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.GroupNamebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GroupNamebunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GroupNamebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.HintText = "";
            this.GroupNamebunifuMaterialTextbox1.isPassword = false;
            this.GroupNamebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.GroupNamebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.LineThickness = 3;
            this.GroupNamebunifuMaterialTextbox1.Location = new System.Drawing.Point(672, 142);
            this.GroupNamebunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupNamebunifuMaterialTextbox1.MaxLength = 32767;
            this.GroupNamebunifuMaterialTextbox1.Name = "GroupNamebunifuMaterialTextbox1";
            this.GroupNamebunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupNamebunifuMaterialTextbox1.Size = new System.Drawing.Size(196, 33);
            this.GroupNamebunifuMaterialTextbox1.TabIndex = 16;
            this.GroupNamebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GroupNamebunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.GroupNamebunifuMaterialTextbox1_OnValueChanged);
            // 
            // Memberslabel1
            // 
            this.Memberslabel1.AutoSize = true;
            this.Memberslabel1.ForeColor = System.Drawing.Color.Silver;
            this.Memberslabel1.Location = new System.Drawing.Point(316, 121);
            this.Memberslabel1.Name = "Memberslabel1";
            this.Memberslabel1.Size = new System.Drawing.Size(44, 17);
            this.Memberslabel1.TabIndex = 17;
            this.Memberslabel1.Text = "کاربران";
            // 
            // NewGroupMemberlistBox1
            // 
            this.NewGroupMemberlistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.NewGroupMemberlistBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewGroupMemberlistBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peopleBindingSource, "Id", true));
            this.NewGroupMemberlistBox1.DataSource = this.peopleBindingSource;
            this.NewGroupMemberlistBox1.DisplayMember = "fullName";
            this.NewGroupMemberlistBox1.ForeColor = System.Drawing.Color.Silver;
            this.NewGroupMemberlistBox1.FormattingEnabled = true;
            this.NewGroupMemberlistBox1.ItemHeight = 16;
            this.NewGroupMemberlistBox1.Location = new System.Drawing.Point(672, 262);
            this.NewGroupMemberlistBox1.Name = "NewGroupMemberlistBox1";
            this.NewGroupMemberlistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewGroupMemberlistBox1.Size = new System.Drawing.Size(196, 226);
            this.NewGroupMemberlistBox1.TabIndex = 18;
            this.NewGroupMemberlistBox1.ValueMember = "Id";
            this.NewGroupMemberlistBox1.Click += new System.EventHandler(this.NewGroupMemberlistBox1_Click);
            this.NewGroupMemberlistBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "people";
            this.peopleBindingSource.DataSource = this.royadbDataSet;
            // 
            // royadbDataSet
            // 
            this.royadbDataSet.DataSetName = "royadbDataSet";
            this.royadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MemberslistBox1
            // 
            this.MemberslistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MemberslistBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemberslistBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peopleBindingSource2, "Id", true));
            this.MemberslistBox1.DataSource = this.peopleBindingSource1;
            this.MemberslistBox1.DisplayMember = "fullName";
            this.MemberslistBox1.ForeColor = System.Drawing.Color.Silver;
            this.MemberslistBox1.FormattingEnabled = true;
            this.MemberslistBox1.ItemHeight = 16;
            this.MemberslistBox1.Location = new System.Drawing.Point(196, 166);
            this.MemberslistBox1.Name = "MemberslistBox1";
            this.MemberslistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MemberslistBox1.Size = new System.Drawing.Size(196, 322);
            this.MemberslistBox1.TabIndex = 19;
            this.MemberslistBox1.ValueMember = "Id";
            this.MemberslistBox1.Click += new System.EventHandler(this.MemberslistBox1_Click);
            this.MemberslistBox1.SelectedIndexChanged += new System.EventHandler(this.MemberslistBox1_SelectedIndexChanged);
            // 
            // peopleBindingSource2
            // 
            this.peopleBindingSource2.DataMember = "people";
            this.peopleBindingSource2.DataSource = this.royadbDataSet;
            // 
            // peopleBindingSource1
            // 
            this.peopleBindingSource1.DataMember = "people";
            this.peopleBindingSource1.DataSource = this.royadbDataSet;
            // 
            // GroupListbutton1
            // 
            this.GroupListbutton1.FlatAppearance.BorderSize = 0;
            this.GroupListbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupListbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupListbutton1.ForeColor = System.Drawing.Color.Silver;
            this.GroupListbutton1.Location = new System.Drawing.Point(30, 573);
            this.GroupListbutton1.Name = "GroupListbutton1";
            this.GroupListbutton1.Size = new System.Drawing.Size(115, 32);
            this.GroupListbutton1.TabIndex = 20;
            this.GroupListbutton1.Text = "لیست گروه ها";
            this.GroupListbutton1.UseVisualStyleBackColor = true;
            this.GroupListbutton1.Click += new System.EventHandler(this.GroupListbutton1_Click);
            // 
            // SubmitGroupbutton2
            // 
            this.SubmitGroupbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitGroupbutton2.BackgroundImage")));
            this.SubmitGroupbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubmitGroupbutton2.FlatAppearance.BorderSize = 0;
            this.SubmitGroupbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitGroupbutton2.Location = new System.Drawing.Point(732, 555);
            this.SubmitGroupbutton2.Name = "SubmitGroupbutton2";
            this.SubmitGroupbutton2.Size = new System.Drawing.Size(84, 31);
            this.SubmitGroupbutton2.TabIndex = 32;
            this.SubmitGroupbutton2.UseVisualStyleBackColor = true;
            this.SubmitGroupbutton2.Click += new System.EventHandler(this.SubmitGroupbutton2_Click);
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
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // MakeGroupUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.SubmitGroupbutton2);
            this.Controls.Add(this.GroupListbutton1);
            this.Controls.Add(this.MemberslistBox1);
            this.Controls.Add(this.NewGroupMemberlistBox1);
            this.Controls.Add(this.Memberslabel1);
            this.Controls.Add(this.GroupNamebunifuMaterialTextbox1);
            this.Controls.Add(this.GroupNamelabel2);
            this.Controls.Add(this.NewGroupTextlabel1);
            this.Controls.Add(this.UpperLayoutpanel2);
            this.Name = "MakeGroupUserControl1";
            this.Size = new System.Drawing.Size(910, 629);
            this.Load += new System.EventHandler(this.MakeGroupUserControl1_Load);
            this.UpperLayoutpanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.royadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel UpperLayoutpanel2;
        private System.Windows.Forms.Panel LeftLayoutpanel1;
        private System.Windows.Forms.Label NewGroupTextlabel1;
        private System.Windows.Forms.Label GroupNamelabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox GroupNamebunifuMaterialTextbox1;
        private System.Windows.Forms.Label Memberslabel1;
        private System.Windows.Forms.ListBox NewGroupMemberlistBox1;
        private System.Windows.Forms.ListBox MemberslistBox1;
        private System.Windows.Forms.Button GroupListbutton1;
        private System.Windows.Forms.Button SubmitGroupbutton2;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private royadbDataSet royadbDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource2;
        private System.Windows.Forms.BindingSource peopleBindingSource1;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private royadbDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private royadbDataSetTableAdapters.peopleTableAdapter peopleTableAdapter;
    }
}
