
namespace ManaDigital
{
    partial class SearchEditUserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEditUserControl1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpperLayoutpanel2 = new System.Windows.Forms.Panel();
            this.docUserControl11 = new ManaDigital.UserControls.DocUserControl1();
            this.LeftLayoutpanel1 = new System.Windows.Forms.Panel();
            this.Searchlabel1 = new System.Windows.Forms.Label();
            this.SearchbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SearchlistBox1 = new System.Windows.Forms.ListBox();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.royadbDataSet = new ManaDigital.royadbDataSet();
            this.CVSaverbutton1 = new System.Windows.Forms.Button();
            this.ChooseFilebutton1 = new System.Windows.Forms.Button();
            this.parametercomboBox1 = new System.Windows.Forms.ComboBox();
            this.AgenumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AddressbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PhonebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RelationbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NamebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CVUploadlabel7 = new System.Windows.Forms.Label();
            this.Agelabel5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Phonelabel3 = new System.Windows.Forms.Label();
            this.Addresslabel4 = new System.Windows.Forms.Label();
            this.Relationlabel2 = new System.Windows.Forms.Label();
            this.Namelabel1 = new System.Windows.Forms.Label();
            this.SaveEditbutton2 = new System.Windows.Forms.Button();
            this.peopleTableAdapter = new ManaDigital.royadbDataSetTableAdapters.peopleTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CVbutton1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.UpperLayoutpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.royadbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(635, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 509);
            this.panel1.TabIndex = 8;
            // 
            // UpperLayoutpanel2
            // 
            this.UpperLayoutpanel2.Controls.Add(this.docUserControl11);
            this.UpperLayoutpanel2.Controls.Add(this.panel1);
            this.UpperLayoutpanel2.Controls.Add(this.LeftLayoutpanel1);
            this.UpperLayoutpanel2.Location = new System.Drawing.Point(4, 2);
            this.UpperLayoutpanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpperLayoutpanel2.Name = "UpperLayoutpanel2";
            this.UpperLayoutpanel2.Size = new System.Drawing.Size(676, 41);
            this.UpperLayoutpanel2.TabIndex = 8;
            // 
            // docUserControl11
            // 
            this.docUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.docUserControl11.Location = new System.Drawing.Point(-4, -2);
            this.docUserControl11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.docUserControl11.Name = "docUserControl11";
            this.docUserControl11.Size = new System.Drawing.Size(682, 511);
            this.docUserControl11.TabIndex = 33;
            this.docUserControl11.Load += new System.EventHandler(this.docUserControl11_Load);
            // 
            // LeftLayoutpanel1
            // 
            this.LeftLayoutpanel1.Location = new System.Drawing.Point(680, 0);
            this.LeftLayoutpanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftLayoutpanel1.Name = "LeftLayoutpanel1";
            this.LeftLayoutpanel1.Size = new System.Drawing.Size(38, 557);
            this.LeftLayoutpanel1.TabIndex = 6;
            // 
            // Searchlabel1
            // 
            this.Searchlabel1.AutoSize = true;
            this.Searchlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel1.ForeColor = System.Drawing.Color.Silver;
            this.Searchlabel1.Location = new System.Drawing.Point(601, 46);
            this.Searchlabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Searchlabel1.Name = "Searchlabel1";
            this.Searchlabel1.Size = new System.Drawing.Size(41, 17);
            this.Searchlabel1.TabIndex = 9;
            this.Searchlabel1.Text = "جستجو";
            // 
            // SearchbunifuMaterialTextbox1
            // 
            this.SearchbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.HintText = "";
            this.SearchbunifuMaterialTextbox1.isPassword = false;
            this.SearchbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.LineThickness = 3;
            this.SearchbunifuMaterialTextbox1.Location = new System.Drawing.Point(472, 66);
            this.SearchbunifuMaterialTextbox1.MaxLength = 32767;
            this.SearchbunifuMaterialTextbox1.Name = "SearchbunifuMaterialTextbox1";
            this.SearchbunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchbunifuMaterialTextbox1.Size = new System.Drawing.Size(147, 27);
            this.SearchbunifuMaterialTextbox1.TabIndex = 10;
            this.SearchbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchbunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.SearchbunifuMaterialTextbox1_OnValueChanged);
            // 
            // SearchlistBox1
            // 
            this.SearchlistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SearchlistBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchlistBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peopleBindingSource, "Id", true));
            this.SearchlistBox1.DataSource = this.peopleBindingSource;
            this.SearchlistBox1.DisplayMember = "fullName";
            this.SearchlistBox1.ForeColor = System.Drawing.Color.Silver;
            this.SearchlistBox1.FormattingEnabled = true;
            this.SearchlistBox1.Location = new System.Drawing.Point(472, 172);
            this.SearchlistBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchlistBox1.Name = "SearchlistBox1";
            this.SearchlistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchlistBox1.Size = new System.Drawing.Size(148, 184);
            this.SearchlistBox1.TabIndex = 11;
            this.SearchlistBox1.ValueMember = "Id";
            this.SearchlistBox1.Click += new System.EventHandler(this.SearchlistBox1_Click);
            this.SearchlistBox1.SelectedIndexChanged += new System.EventHandler(this.SearchlistBox1_SelectedIndexChanged);
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
            // CVSaverbutton1
            // 
            this.CVSaverbutton1.FlatAppearance.BorderSize = 0;
            this.CVSaverbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVSaverbutton1.ForeColor = System.Drawing.Color.Silver;
            this.CVSaverbutton1.Location = new System.Drawing.Point(182, 453);
            this.CVSaverbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CVSaverbutton1.Name = "CVSaverbutton1";
            this.CVSaverbutton1.Size = new System.Drawing.Size(91, 25);
            this.CVSaverbutton1.TabIndex = 30;
            this.CVSaverbutton1.Text = "ذخیره";
            this.CVSaverbutton1.UseVisualStyleBackColor = true;
            // 
            // ChooseFilebutton1
            // 
            this.ChooseFilebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFilebutton1.ForeColor = System.Drawing.Color.Silver;
            this.ChooseFilebutton1.Location = new System.Drawing.Point(182, 417);
            this.ChooseFilebutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseFilebutton1.Name = "ChooseFilebutton1";
            this.ChooseFilebutton1.Size = new System.Drawing.Size(91, 25);
            this.ChooseFilebutton1.TabIndex = 29;
            this.ChooseFilebutton1.Text = "انتخاب فایل";
            this.ChooseFilebutton1.UseCompatibleTextRendering = true;
            this.ChooseFilebutton1.UseVisualStyleBackColor = true;
            this.ChooseFilebutton1.Click += new System.EventHandler(this.ChooseFilebutton1_Click);
            // 
            // parametercomboBox1
            // 
            this.parametercomboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.parametercomboBox1.ForeColor = System.Drawing.Color.Silver;
            this.parametercomboBox1.FormattingEnabled = true;
            this.parametercomboBox1.Location = new System.Drawing.Point(182, 370);
            this.parametercomboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parametercomboBox1.Name = "parametercomboBox1";
            this.parametercomboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parametercomboBox1.Size = new System.Drawing.Size(92, 21);
            this.parametercomboBox1.TabIndex = 28;
            this.parametercomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AgenumericUpDown1
            // 
            this.AgenumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.AgenumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgenumericUpDown1.ForeColor = System.Drawing.Color.Silver;
            this.AgenumericUpDown1.Location = new System.Drawing.Point(182, 313);
            this.AgenumericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgenumericUpDown1.Name = "AgenumericUpDown1";
            this.AgenumericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgenumericUpDown1.Size = new System.Drawing.Size(91, 16);
            this.AgenumericUpDown1.TabIndex = 27;
            // 
            // AddressbunifuMaterialTextbox1
            // 
            this.AddressbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddressbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddressbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AddressbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AddressbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.HintText = "";
            this.AddressbunifuMaterialTextbox1.isPassword = false;
            this.AddressbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.AddressbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.LineThickness = 3;
            this.AddressbunifuMaterialTextbox1.Location = new System.Drawing.Point(118, 251);
            this.AddressbunifuMaterialTextbox1.MaxLength = 32767;
            this.AddressbunifuMaterialTextbox1.Name = "AddressbunifuMaterialTextbox1";
            this.AddressbunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddressbunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 27);
            this.AddressbunifuMaterialTextbox1.TabIndex = 26;
            this.AddressbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhonebunifuMaterialTextbox1
            // 
            this.PhonebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhonebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhonebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhonebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhonebunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PhonebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.HintText = "";
            this.PhonebunifuMaterialTextbox1.isPassword = false;
            this.PhonebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.PhonebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.LineThickness = 3;
            this.PhonebunifuMaterialTextbox1.Location = new System.Drawing.Point(118, 189);
            this.PhonebunifuMaterialTextbox1.MaxLength = 32767;
            this.PhonebunifuMaterialTextbox1.Name = "PhonebunifuMaterialTextbox1";
            this.PhonebunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PhonebunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 27);
            this.PhonebunifuMaterialTextbox1.TabIndex = 25;
            this.PhonebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RelationbunifuMaterialTextbox1
            // 
            this.RelationbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RelationbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RelationbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RelationbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RelationbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RelationbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.HintText = "";
            this.RelationbunifuMaterialTextbox1.isPassword = false;
            this.RelationbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.RelationbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.LineThickness = 3;
            this.RelationbunifuMaterialTextbox1.Location = new System.Drawing.Point(118, 128);
            this.RelationbunifuMaterialTextbox1.MaxLength = 32767;
            this.RelationbunifuMaterialTextbox1.Name = "RelationbunifuMaterialTextbox1";
            this.RelationbunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RelationbunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 27);
            this.RelationbunifuMaterialTextbox1.TabIndex = 24;
            this.RelationbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NamebunifuMaterialTextbox1
            // 
            this.NamebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NamebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NamebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NamebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamebunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NamebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.HintText = "";
            this.NamebunifuMaterialTextbox1.isPassword = false;
            this.NamebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.NamebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.LineThickness = 3;
            this.NamebunifuMaterialTextbox1.Location = new System.Drawing.Point(118, 66);
            this.NamebunifuMaterialTextbox1.MaxLength = 32767;
            this.NamebunifuMaterialTextbox1.Name = "NamebunifuMaterialTextbox1";
            this.NamebunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NamebunifuMaterialTextbox1.Size = new System.Drawing.Size(154, 27);
            this.NamebunifuMaterialTextbox1.TabIndex = 23;
            this.NamebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CVUploadlabel7
            // 
            this.CVUploadlabel7.AutoSize = true;
            this.CVUploadlabel7.ForeColor = System.Drawing.Color.Silver;
            this.CVUploadlabel7.Location = new System.Drawing.Point(250, 401);
            this.CVUploadlabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CVUploadlabel7.Name = "CVUploadlabel7";
            this.CVUploadlabel7.Size = new System.Drawing.Size(58, 13);
            this.CVUploadlabel7.TabIndex = 22;
            this.CVUploadlabel7.Text = "آپلود رزومه";
            // 
            // Agelabel5
            // 
            this.Agelabel5.AutoSize = true;
            this.Agelabel5.ForeColor = System.Drawing.Color.Silver;
            this.Agelabel5.Location = new System.Drawing.Point(277, 296);
            this.Agelabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Agelabel5.Name = "Agelabel5";
            this.Agelabel5.Size = new System.Drawing.Size(23, 13);
            this.Agelabel5.TabIndex = 21;
            this.Agelabel5.Text = "سن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(271, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "گروه";
            // 
            // Phonelabel3
            // 
            this.Phonelabel3.AutoSize = true;
            this.Phonelabel3.ForeColor = System.Drawing.Color.Silver;
            this.Phonelabel3.Location = new System.Drawing.Point(251, 172);
            this.Phonelabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phonelabel3.Name = "Phonelabel3";
            this.Phonelabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Phonelabel3.Size = new System.Drawing.Size(61, 13);
            this.Phonelabel3.TabIndex = 19;
            this.Phonelabel3.Text = "شماره تلفن ";
            // 
            // Addresslabel4
            // 
            this.Addresslabel4.AutoSize = true;
            this.Addresslabel4.ForeColor = System.Drawing.Color.Silver;
            this.Addresslabel4.Location = new System.Drawing.Point(270, 219);
            this.Addresslabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Addresslabel4.Name = "Addresslabel4";
            this.Addresslabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Addresslabel4.Size = new System.Drawing.Size(30, 13);
            this.Addresslabel4.TabIndex = 18;
            this.Addresslabel4.Text = "آدرس";
            // 
            // Relationlabel2
            // 
            this.Relationlabel2.AutoSize = true;
            this.Relationlabel2.ForeColor = System.Drawing.Color.Silver;
            this.Relationlabel2.Location = new System.Drawing.Point(249, 110);
            this.Relationlabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Relationlabel2.Name = "Relationlabel2";
            this.Relationlabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Relationlabel2.Size = new System.Drawing.Size(65, 13);
            this.Relationlabel2.TabIndex = 17;
            this.Relationlabel2.Text = "عنوان شغلی";
            this.Relationlabel2.Click += new System.EventHandler(this.Relationlabel2_Click);
            // 
            // Namelabel1
            // 
            this.Namelabel1.AutoSize = true;
            this.Namelabel1.ForeColor = System.Drawing.Color.Silver;
            this.Namelabel1.Location = new System.Drawing.Point(229, 49);
            this.Namelabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Namelabel1.Name = "Namelabel1";
            this.Namelabel1.Size = new System.Drawing.Size(94, 13);
            this.Namelabel1.TabIndex = 16;
            this.Namelabel1.Text = "نام و نام خانوادگی";
            // 
            // SaveEditbutton2
            // 
            this.SaveEditbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveEditbutton2.BackgroundImage")));
            this.SaveEditbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveEditbutton2.FlatAppearance.BorderSize = 0;
            this.SaveEditbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditbutton2.Location = new System.Drawing.Point(14, 474);
            this.SaveEditbutton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveEditbutton2.Name = "SaveEditbutton2";
            this.SaveEditbutton2.Size = new System.Drawing.Size(63, 25);
            this.SaveEditbutton2.TabIndex = 31;
            this.SaveEditbutton2.UseVisualStyleBackColor = true;
            this.SaveEditbutton2.Click += new System.EventHandler(this.SaveEditbutton2_Click);
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // CVbutton1
            // 
            this.CVbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CVbutton1.FlatAppearance.BorderSize = 0;
            this.CVbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVbutton1.ForeColor = System.Drawing.Color.Silver;
            this.CVbutton1.Location = new System.Drawing.Point(29, 370);
            this.CVbutton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CVbutton1.Name = "CVbutton1";
            this.CVbutton1.Size = new System.Drawing.Size(56, 31);
            this.CVbutton1.TabIndex = 32;
            this.CVbutton1.Text = "رزومه";
            this.CVbutton1.UseVisualStyleBackColor = true;
            this.CVbutton1.Click += new System.EventHandler(this.CVbutton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // SearchEditUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.CVbutton1);
            this.Controls.Add(this.SaveEditbutton2);
            this.Controls.Add(this.CVSaverbutton1);
            this.Controls.Add(this.ChooseFilebutton1);
            this.Controls.Add(this.parametercomboBox1);
            this.Controls.Add(this.AgenumericUpDown1);
            this.Controls.Add(this.AddressbunifuMaterialTextbox1);
            this.Controls.Add(this.PhonebunifuMaterialTextbox1);
            this.Controls.Add(this.RelationbunifuMaterialTextbox1);
            this.Controls.Add(this.NamebunifuMaterialTextbox1);
            this.Controls.Add(this.CVUploadlabel7);
            this.Controls.Add(this.Agelabel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Phonelabel3);
            this.Controls.Add(this.Addresslabel4);
            this.Controls.Add(this.Relationlabel2);
            this.Controls.Add(this.Namelabel1);
            this.Controls.Add(this.Searchlabel1);
            this.Controls.Add(this.SearchbunifuMaterialTextbox1);
            this.Controls.Add(this.SearchlistBox1);
            this.Controls.Add(this.UpperLayoutpanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchEditUserControl1";
            this.Size = new System.Drawing.Size(682, 511);
            this.Load += new System.EventHandler(this.SearchEditUserControl1_Load);
            this.UpperLayoutpanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.royadbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel UpperLayoutpanel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchbunifuMaterialTextbox1;
        private System.Windows.Forms.Label Searchlabel1;
        private System.Windows.Forms.Panel LeftLayoutpanel1;
        private System.Windows.Forms.ListBox SearchlistBox1;
        private System.Windows.Forms.Button CVSaverbutton1;
        private System.Windows.Forms.Button ChooseFilebutton1;
        private System.Windows.Forms.ComboBox parametercomboBox1;
        private System.Windows.Forms.NumericUpDown AgenumericUpDown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AddressbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhonebunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RelationbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NamebunifuMaterialTextbox1;
        private System.Windows.Forms.Label CVUploadlabel7;
        private System.Windows.Forms.Label Agelabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Phonelabel3;
        private System.Windows.Forms.Label Addresslabel4;
        private System.Windows.Forms.Label Relationlabel2;
        private System.Windows.Forms.Label Namelabel1;
        private System.Windows.Forms.Button SaveEditbutton2;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private royadbDataSet royadbDataSet;
        private royadbDataSetTableAdapters.peopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button CVbutton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private UserControls.DocUserControl1 docUserControl11;
    }
}
