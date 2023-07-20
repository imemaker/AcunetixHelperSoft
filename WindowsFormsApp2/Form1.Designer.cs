using System;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Google_CSE_Scraper_TabPage = new System.Windows.Forms.TabPage();
            this.Google_CSE_Scraper_Dorking_Example_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Query_Description_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Delete_Selected_Results_Button = new System.Windows.Forms.Button();
            this.Google_CSE_Scraper_Clear_Results_Button = new System.Windows.Forms.Button();
            this.Google_CSE_Scraper_Clear_Keywords_Button = new System.Windows.Forms.Button();
            this.Google_CSE_Scraper_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Google_CSE_Scraper_Settings_Reminder_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Google_CSE_Scraper_Settings_Language_ComboBox = new System.Windows.Forms.ComboBox();
            this.Google_CSE_Scraper_Settings_Country_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper__Settings_Country_ComboBox = new System.Windows.Forms.ComboBox();
            this.Google_CSE_Scraper_Settings_Language_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Export_To_Subfinder_Button = new System.Windows.Forms.Button();
            this.Google_CSE_Scraper_Start_CSE_Search_Button = new System.Windows.Forms.Button();
            this.Google_CSE_Scraper_Results_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Google_CSE_Scraper_Results_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Keywords_Label = new System.Windows.Forms.Label();
            this.Google_CSE_Scraper_Keywords_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Subfinder_TabPage = new System.Windows.Forms.TabPage();
            this.Subfinder_Module_Domains_Processed_Label = new System.Windows.Forms.Label();
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button = new System.Windows.Forms.Button();
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button = new System.Windows.Forms.Button();
            this.Subfinder_Module_Delete_Selected_Subdomains_Button = new System.Windows.Forms.Button();
            this.Subfinder_Module_Clear_Subdomains_Button = new System.Windows.Forms.Button();
            this.Subfinder_Module_Clear_Subfinder_Domains_Button = new System.Windows.Forms.Button();
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button = new System.Windows.Forms.Button();
            this.Subfinder_Module_Threads_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Subfinder_Module_Threads_Amount_Label = new System.Windows.Forms.Label();
            this.Subfinder_Module_Domain_Results_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Subfinder_Module_Results_Label = new System.Windows.Forms.Label();
            this.Subfinder_Module_Domains_Label = new System.Windows.Forms.Label();
            this.Subfinder_Module_Domains_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Httpx_Module_TabPage = new System.Windows.Forms.TabPage();
            this.Httpx_Export_To_Acunetix_Importer_Button = new System.Windows.Forms.Button();
            this.Httpx_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox = new System.Windows.Forms.CheckBox();
            this.Httpx_Settings_Add_Title_Detection_CheckBox = new System.Windows.Forms.CheckBox();
            this.Httpx_Settings_Threads_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Httpx_Settings_Threads_Label = new System.Windows.Forms.Label();
            this.Httpx_Delete_Selected_Websites_Button = new System.Windows.Forms.Button();
            this.Httpx_Export_To_Local_Database_Button = new System.Windows.Forms.Button();
            this.Httpx_Clear_Checked_Websites_Button = new System.Windows.Forms.Button();
            this.Httpx_Clear_Unchecked_Websites_Button = new System.Windows.Forms.Button();
            this.Httpx_Stop_And_Delete_Websites_Button = new System.Windows.Forms.Button();
            this.Httpx_Start_Online_Check_Button = new System.Windows.Forms.Button();
            this.Httpx_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Httpx_Checked_Websites_Label = new System.Windows.Forms.Label();
            this.Httpx_Unchecked_Websites_Label = new System.Windows.Forms.Label();
            this.Httpx_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Local_Database_TabPage = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.blacklist_website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blacklist_date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.website_subdomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website_domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website_tld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website_statuscode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website_date_added = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acunetix_Importer_TabPage = new System.Windows.Forms.TabPage();
            this.button24 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Advanced_Acunetix_Operations_TabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.Settings_TabPage = new System.Windows.Forms.TabPage();
            this.label51 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.Settings_Httpx_Location_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Settings_Subfinder_Location_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.About_TabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Google_CSE_Scraper_TabPage.SuspendLayout();
            this.Google_CSE_Scraper_Settings_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown)).BeginInit();
            this.Subfinder_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subfinder_Module_Threads_NumericUpDown)).BeginInit();
            this.Httpx_Module_TabPage.SuspendLayout();
            this.Httpx_Settings_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Httpx_Settings_Threads_NumericUpDown)).BeginInit();
            this.Local_Database_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Acunetix_Importer_TabPage.SuspendLayout();
            this.Advanced_Acunetix_Operations_TabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Settings_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Google_CSE_Scraper_TabPage);
            this.tabControl1.Controls.Add(this.Subfinder_TabPage);
            this.tabControl1.Controls.Add(this.Httpx_Module_TabPage);
            this.tabControl1.Controls.Add(this.Local_Database_TabPage);
            this.tabControl1.Controls.Add(this.Acunetix_Importer_TabPage);
            this.tabControl1.Controls.Add(this.Advanced_Acunetix_Operations_TabPage);
            this.tabControl1.Controls.Add(this.Settings_TabPage);
            this.tabControl1.Controls.Add(this.About_TabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 612);
            this.tabControl1.TabIndex = 2;
            // 
            // Google_CSE_Scraper_TabPage
            // 
            this.Google_CSE_Scraper_TabPage.BackColor = System.Drawing.Color.Transparent;
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Dorking_Example_Label);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Query_Description_Label);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Delete_Selected_Results_Button);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Clear_Results_Button);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Clear_Keywords_Button);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Settings_GroupBox);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Export_To_Subfinder_Button);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Start_CSE_Search_Button);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Results_CheckedListBox);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Results_Label);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Keywords_Label);
            this.Google_CSE_Scraper_TabPage.Controls.Add(this.Google_CSE_Scraper_Keywords_RichTextBox);
            this.Google_CSE_Scraper_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Google_CSE_Scraper_TabPage.Name = "Google_CSE_Scraper_TabPage";
            this.Google_CSE_Scraper_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Google_CSE_Scraper_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Google_CSE_Scraper_TabPage.TabIndex = 0;
            this.Google_CSE_Scraper_TabPage.Text = "Google CSE Scraper";
            this.Google_CSE_Scraper_TabPage.UseVisualStyleBackColor = true;
            // 
            // Google_CSE_Scraper_Dorking_Example_Label
            // 
            this.Google_CSE_Scraper_Dorking_Example_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Google_CSE_Scraper_Dorking_Example_Label.Location = new System.Drawing.Point(544, 291);
            this.Google_CSE_Scraper_Dorking_Example_Label.Name = "Google_CSE_Scraper_Dorking_Example_Label";
            this.Google_CSE_Scraper_Dorking_Example_Label.Size = new System.Drawing.Size(254, 279);
            this.Google_CSE_Scraper_Dorking_Example_Label.TabIndex = 28;
            this.Google_CSE_Scraper_Dorking_Example_Label.Text = resources.GetString("Google_CSE_Scraper_Dorking_Example_Label.Text");
            // 
            // Google_CSE_Scraper_Query_Description_Label
            // 
            this.Google_CSE_Scraper_Query_Description_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Google_CSE_Scraper_Query_Description_Label.Location = new System.Drawing.Point(272, 291);
            this.Google_CSE_Scraper_Query_Description_Label.Name = "Google_CSE_Scraper_Query_Description_Label";
            this.Google_CSE_Scraper_Query_Description_Label.Size = new System.Drawing.Size(236, 279);
            this.Google_CSE_Scraper_Query_Description_Label.TabIndex = 27;
            this.Google_CSE_Scraper_Query_Description_Label.Text = resources.GetString("Google_CSE_Scraper_Query_Description_Label.Text");
            // 
            // Google_CSE_Scraper_Delete_Selected_Results_Button
            // 
            this.Google_CSE_Scraper_Delete_Selected_Results_Button.Location = new System.Drawing.Point(545, 48);
            this.Google_CSE_Scraper_Delete_Selected_Results_Button.Name = "Google_CSE_Scraper_Delete_Selected_Results_Button";
            this.Google_CSE_Scraper_Delete_Selected_Results_Button.Size = new System.Drawing.Size(253, 23);
            this.Google_CSE_Scraper_Delete_Selected_Results_Button.TabIndex = 26;
            this.Google_CSE_Scraper_Delete_Selected_Results_Button.Text = "Delete Selected Results";
            this.Google_CSE_Scraper_Delete_Selected_Results_Button.UseVisualStyleBackColor = true;
            // 
            // Google_CSE_Scraper_Clear_Results_Button
            // 
            this.Google_CSE_Scraper_Clear_Results_Button.AutoSize = true;
            this.Google_CSE_Scraper_Clear_Results_Button.Location = new System.Drawing.Point(545, 77);
            this.Google_CSE_Scraper_Clear_Results_Button.Name = "Google_CSE_Scraper_Clear_Results_Button";
            this.Google_CSE_Scraper_Clear_Results_Button.Size = new System.Drawing.Size(253, 23);
            this.Google_CSE_Scraper_Clear_Results_Button.TabIndex = 13;
            this.Google_CSE_Scraper_Clear_Results_Button.Text = "Clear Results";
            this.Google_CSE_Scraper_Clear_Results_Button.UseVisualStyleBackColor = true;
            this.Google_CSE_Scraper_Clear_Results_Button.Click += new System.EventHandler(this.Google_cse_scraper_clear_results_button_Click);
            // 
            // Google_CSE_Scraper_Clear_Keywords_Button
            // 
            this.Google_CSE_Scraper_Clear_Keywords_Button.AutoSize = true;
            this.Google_CSE_Scraper_Clear_Keywords_Button.Location = new System.Drawing.Point(275, 210);
            this.Google_CSE_Scraper_Clear_Keywords_Button.Name = "Google_CSE_Scraper_Clear_Keywords_Button";
            this.Google_CSE_Scraper_Clear_Keywords_Button.Size = new System.Drawing.Size(264, 23);
            this.Google_CSE_Scraper_Clear_Keywords_Button.TabIndex = 12;
            this.Google_CSE_Scraper_Clear_Keywords_Button.Text = "Clear Keywords";
            this.Google_CSE_Scraper_Clear_Keywords_Button.UseVisualStyleBackColor = true;
            this.Google_CSE_Scraper_Clear_Keywords_Button.Click += new System.EventHandler(this.Clear_keywords_button_Click);
            // 
            // Google_CSE_Scraper_Settings_GroupBox
            // 
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper_Settings_Reminder_Label);
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label);
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown);
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper_Settings_Language_ComboBox);
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper_Settings_Country_Label);
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper__Settings_Country_ComboBox);
            this.Google_CSE_Scraper_Settings_GroupBox.Controls.Add(this.Google_CSE_Scraper_Settings_Language_Label);
            this.Google_CSE_Scraper_Settings_GroupBox.Location = new System.Drawing.Point(275, 19);
            this.Google_CSE_Scraper_Settings_GroupBox.Name = "Google_CSE_Scraper_Settings_GroupBox";
            this.Google_CSE_Scraper_Settings_GroupBox.Size = new System.Drawing.Size(264, 156);
            this.Google_CSE_Scraper_Settings_GroupBox.TabIndex = 25;
            this.Google_CSE_Scraper_Settings_GroupBox.TabStop = false;
            this.Google_CSE_Scraper_Settings_GroupBox.Text = "Scraper Settings";
            // 
            // Google_CSE_Scraper_Settings_Reminder_Label
            // 
            this.Google_CSE_Scraper_Settings_Reminder_Label.AutoSize = true;
            this.Google_CSE_Scraper_Settings_Reminder_Label.Location = new System.Drawing.Point(6, 131);
            this.Google_CSE_Scraper_Settings_Reminder_Label.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.Google_CSE_Scraper_Settings_Reminder_Label.Name = "Google_CSE_Scraper_Settings_Reminder_Label";
            this.Google_CSE_Scraper_Settings_Reminder_Label.Size = new System.Drawing.Size(195, 13);
            this.Google_CSE_Scraper_Settings_Reminder_Label.TabIndex = 23;
            this.Google_CSE_Scraper_Settings_Reminder_Label.Text = "Do not forget to set Apikey and CSE ID.";
            // 
            // Google_CSE_Scraper_Settings_Results_Per_Keyword_Label
            // 
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.AutoSize = true;
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Location = new System.Drawing.Point(6, 34);
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Name = "Google_CSE_Scraper_Settings_Results_Per_Keyword_Label";
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Size = new System.Drawing.Size(107, 13);
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.TabIndex = 16;
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Text = "Results per Keyword:";
            // 
            // Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown
            // 
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Location = new System.Drawing.Point(119, 32);
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Name = "Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown";
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.TabIndex = 17;
            this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Google_CSE_Scraper_Settings_Language_ComboBox
            // 
            this.Google_CSE_Scraper_Settings_Language_ComboBox.FormattingEnabled = true;
            this.Google_CSE_Scraper_Settings_Language_ComboBox.Location = new System.Drawing.Point(119, 95);
            this.Google_CSE_Scraper_Settings_Language_ComboBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Google_CSE_Scraper_Settings_Language_ComboBox.Name = "Google_CSE_Scraper_Settings_Language_ComboBox";
            this.Google_CSE_Scraper_Settings_Language_ComboBox.Size = new System.Drawing.Size(139, 21);
            this.Google_CSE_Scraper_Settings_Language_ComboBox.TabIndex = 21;
            // 
            // Google_CSE_Scraper_Settings_Country_Label
            // 
            this.Google_CSE_Scraper_Settings_Country_Label.AutoSize = true;
            this.Google_CSE_Scraper_Settings_Country_Label.Location = new System.Drawing.Point(6, 66);
            this.Google_CSE_Scraper_Settings_Country_Label.Name = "Google_CSE_Scraper_Settings_Country_Label";
            this.Google_CSE_Scraper_Settings_Country_Label.Size = new System.Drawing.Size(46, 13);
            this.Google_CSE_Scraper_Settings_Country_Label.TabIndex = 20;
            this.Google_CSE_Scraper_Settings_Country_Label.Text = "Country:";
            // 
            // Google_CSE_Scraper__Settings_Country_ComboBox
            // 
            this.Google_CSE_Scraper__Settings_Country_ComboBox.FormattingEnabled = true;
            this.Google_CSE_Scraper__Settings_Country_ComboBox.Location = new System.Drawing.Point(119, 63);
            this.Google_CSE_Scraper__Settings_Country_ComboBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Google_CSE_Scraper__Settings_Country_ComboBox.Name = "Google_CSE_Scraper__Settings_Country_ComboBox";
            this.Google_CSE_Scraper__Settings_Country_ComboBox.Size = new System.Drawing.Size(139, 21);
            this.Google_CSE_Scraper__Settings_Country_ComboBox.TabIndex = 22;
            // 
            // Google_CSE_Scraper_Settings_Language_Label
            // 
            this.Google_CSE_Scraper_Settings_Language_Label.AutoSize = true;
            this.Google_CSE_Scraper_Settings_Language_Label.Location = new System.Drawing.Point(6, 98);
            this.Google_CSE_Scraper_Settings_Language_Label.Name = "Google_CSE_Scraper_Settings_Language_Label";
            this.Google_CSE_Scraper_Settings_Language_Label.Size = new System.Drawing.Size(58, 13);
            this.Google_CSE_Scraper_Settings_Language_Label.TabIndex = 19;
            this.Google_CSE_Scraper_Settings_Language_Label.Text = "Language:";
            // 
            // Google_CSE_Scraper_Export_To_Subfinder_Button
            // 
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.AutoSize = true;
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.Location = new System.Drawing.Point(545, 19);
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.Name = "Google_CSE_Scraper_Export_To_Subfinder_Button";
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.Size = new System.Drawing.Size(253, 23);
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.TabIndex = 11;
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.Text = "Export to Subfinder";
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.UseVisualStyleBackColor = true;
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.Click += new System.EventHandler(this.Export_to_subfinder_button_Click);
            // 
            // Google_CSE_Scraper_Start_CSE_Search_Button
            // 
            this.Google_CSE_Scraper_Start_CSE_Search_Button.Location = new System.Drawing.Point(275, 181);
            this.Google_CSE_Scraper_Start_CSE_Search_Button.Name = "Google_CSE_Scraper_Start_CSE_Search_Button";
            this.Google_CSE_Scraper_Start_CSE_Search_Button.Size = new System.Drawing.Size(264, 23);
            this.Google_CSE_Scraper_Start_CSE_Search_Button.TabIndex = 10;
            this.Google_CSE_Scraper_Start_CSE_Search_Button.Text = "Start CSE Search";
            this.Google_CSE_Scraper_Start_CSE_Search_Button.UseVisualStyleBackColor = true;
            this.Google_CSE_Scraper_Start_CSE_Search_Button.Click += new System.EventHandler(this.Start_cse_search_button_Click);
            // 
            // Google_CSE_Scraper_Results_CheckedListBox
            // 
            this.Google_CSE_Scraper_Results_CheckedListBox.FormattingEnabled = true;
            this.Google_CSE_Scraper_Results_CheckedListBox.Location = new System.Drawing.Point(811, 19);
            this.Google_CSE_Scraper_Results_CheckedListBox.Name = "Google_CSE_Scraper_Results_CheckedListBox";
            this.Google_CSE_Scraper_Results_CheckedListBox.Size = new System.Drawing.Size(257, 559);
            this.Google_CSE_Scraper_Results_CheckedListBox.TabIndex = 24;
            // 
            // Google_CSE_Scraper_Results_Label
            // 
            this.Google_CSE_Scraper_Results_Label.AutoSize = true;
            this.Google_CSE_Scraper_Results_Label.Location = new System.Drawing.Point(811, 3);
            this.Google_CSE_Scraper_Results_Label.Name = "Google_CSE_Scraper_Results_Label";
            this.Google_CSE_Scraper_Results_Label.Size = new System.Drawing.Size(45, 13);
            this.Google_CSE_Scraper_Results_Label.TabIndex = 9;
            this.Google_CSE_Scraper_Results_Label.Text = "Results:";
            // 
            // Google_CSE_Scraper_Keywords_Label
            // 
            this.Google_CSE_Scraper_Keywords_Label.AutoSize = true;
            this.Google_CSE_Scraper_Keywords_Label.Location = new System.Drawing.Point(8, 3);
            this.Google_CSE_Scraper_Keywords_Label.Name = "Google_CSE_Scraper_Keywords_Label";
            this.Google_CSE_Scraper_Keywords_Label.Size = new System.Drawing.Size(56, 13);
            this.Google_CSE_Scraper_Keywords_Label.TabIndex = 8;
            this.Google_CSE_Scraper_Keywords_Label.Text = "Keywords:";
            // 
            // Google_CSE_Scraper_Keywords_RichTextBox
            // 
            this.Google_CSE_Scraper_Keywords_RichTextBox.Location = new System.Drawing.Point(8, 19);
            this.Google_CSE_Scraper_Keywords_RichTextBox.Name = "Google_CSE_Scraper_Keywords_RichTextBox";
            this.Google_CSE_Scraper_Keywords_RichTextBox.Size = new System.Drawing.Size(254, 559);
            this.Google_CSE_Scraper_Keywords_RichTextBox.TabIndex = 2;
            this.Google_CSE_Scraper_Keywords_RichTextBox.Text = "";
            // 
            // Subfinder_TabPage
            // 
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Domains_Processed_Label);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Delete_Selected_Subdomains_Button);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Clear_Subdomains_Button);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Clear_Subfinder_Domains_Button);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Start_Subfinder_Enumeration_Button);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Threads_NumericUpDown);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Threads_Amount_Label);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Domain_Results_CheckedListBox);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Results_Label);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Domains_Label);
            this.Subfinder_TabPage.Controls.Add(this.Subfinder_Module_Domains_RichTextBox);
            this.Subfinder_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Subfinder_TabPage.Name = "Subfinder_TabPage";
            this.Subfinder_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Subfinder_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Subfinder_TabPage.TabIndex = 1;
            this.Subfinder_TabPage.Text = "Subfinder Module";
            this.Subfinder_TabPage.UseVisualStyleBackColor = true;
            // 
            // Subfinder_Module_Domains_Processed_Label
            // 
            this.Subfinder_Module_Domains_Processed_Label.AutoSize = true;
            this.Subfinder_Module_Domains_Processed_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subfinder_Module_Domains_Processed_Label.Location = new System.Drawing.Point(273, 155);
            this.Subfinder_Module_Domains_Processed_Label.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.Subfinder_Module_Domains_Processed_Label.Name = "Subfinder_Module_Domains_Processed_Label";
            this.Subfinder_Module_Domains_Processed_Label.Size = new System.Drawing.Size(201, 24);
            this.Subfinder_Module_Domains_Processed_Label.TabIndex = 37;
            this.Subfinder_Module_Domains_Processed_Label.Text = "Domains processed:";
            // 
            // Subfinder_Module_Delete_gov_mil_arpa_Domains_Button
            // 
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.Location = new System.Drawing.Point(278, 104);
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.Name = "Subfinder_Module_Delete_gov_mil_arpa_Domains_Button";
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.Size = new System.Drawing.Size(254, 23);
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.TabIndex = 36;
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.Text = "Delete .gov .mil .arpa Domains";
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.UseVisualStyleBackColor = true;
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.Click += new System.EventHandler(this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button_Click);
            // 
            // Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button
            // 
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.Location = new System.Drawing.Point(544, 104);
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.Name = "Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button";
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.Size = new System.Drawing.Size(254, 23);
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.TabIndex = 35;
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.Text = "Export Subdomains to Httpx Module";
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.UseVisualStyleBackColor = true;
            this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button.Click += new System.EventHandler(this.Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button_Click);
            // 
            // Subfinder_Module_Delete_Selected_Subdomains_Button
            // 
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.Location = new System.Drawing.Point(545, 75);
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.Name = "Subfinder_Module_Delete_Selected_Subdomains_Button";
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.Size = new System.Drawing.Size(254, 23);
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.TabIndex = 34;
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.Text = "Delete Selected Subdomains";
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.UseVisualStyleBackColor = true;
            this.Subfinder_Module_Delete_Selected_Subdomains_Button.Click += new System.EventHandler(this.Subfinder_Module_Delete_Selected_Subdomains_Button_Click);
            // 
            // Subfinder_Module_Clear_Subdomains_Button
            // 
            this.Subfinder_Module_Clear_Subdomains_Button.Location = new System.Drawing.Point(545, 46);
            this.Subfinder_Module_Clear_Subdomains_Button.Name = "Subfinder_Module_Clear_Subdomains_Button";
            this.Subfinder_Module_Clear_Subdomains_Button.Size = new System.Drawing.Size(254, 23);
            this.Subfinder_Module_Clear_Subdomains_Button.TabIndex = 33;
            this.Subfinder_Module_Clear_Subdomains_Button.Text = "Clear Subdomains";
            this.Subfinder_Module_Clear_Subdomains_Button.UseVisualStyleBackColor = true;
            this.Subfinder_Module_Clear_Subdomains_Button.Click += new System.EventHandler(this.Subfinder_Module_Clear_Subdomains_Button_Click);
            // 
            // Subfinder_Module_Clear_Subfinder_Domains_Button
            // 
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.Location = new System.Drawing.Point(278, 75);
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.Name = "Subfinder_Module_Clear_Subfinder_Domains_Button";
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.Size = new System.Drawing.Size(254, 23);
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.TabIndex = 32;
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.Text = "Clear Domains";
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.UseVisualStyleBackColor = true;
            // 
            // Subfinder_Module_Start_Subfinder_Enumeration_Button
            // 
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.Location = new System.Drawing.Point(278, 46);
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.Name = "Subfinder_Module_Start_Subfinder_Enumeration_Button";
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.Size = new System.Drawing.Size(254, 23);
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.TabIndex = 31;
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.Text = "Start Subdomain Enumeration";
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.UseVisualStyleBackColor = true;
            this.Subfinder_Module_Start_Subfinder_Enumeration_Button.Click += new System.EventHandler(this.Start_Subfinder_Enumeration_Button_Click);
            // 
            // Subfinder_Module_Threads_NumericUpDown
            // 
            this.Subfinder_Module_Threads_NumericUpDown.Location = new System.Drawing.Point(424, 20);
            this.Subfinder_Module_Threads_NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Subfinder_Module_Threads_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Subfinder_Module_Threads_NumericUpDown.Name = "Subfinder_Module_Threads_NumericUpDown";
            this.Subfinder_Module_Threads_NumericUpDown.Size = new System.Drawing.Size(108, 20);
            this.Subfinder_Module_Threads_NumericUpDown.TabIndex = 17;
            this.Subfinder_Module_Threads_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Subfinder_Module_Threads_Amount_Label
            // 
            this.Subfinder_Module_Threads_Amount_Label.AutoSize = true;
            this.Subfinder_Module_Threads_Amount_Label.Location = new System.Drawing.Point(275, 22);
            this.Subfinder_Module_Threads_Amount_Label.Name = "Subfinder_Module_Threads_Amount_Label";
            this.Subfinder_Module_Threads_Amount_Label.Size = new System.Drawing.Size(150, 13);
            this.Subfinder_Module_Threads_Amount_Label.TabIndex = 16;
            this.Subfinder_Module_Threads_Amount_Label.Text = "How many Subfinder\'s to start:";
            // 
            // Subfinder_Module_Domain_Results_CheckedListBox
            // 
            this.Subfinder_Module_Domain_Results_CheckedListBox.FormattingEnabled = true;
            this.Subfinder_Module_Domain_Results_CheckedListBox.Location = new System.Drawing.Point(811, 22);
            this.Subfinder_Module_Domain_Results_CheckedListBox.Name = "Subfinder_Module_Domain_Results_CheckedListBox";
            this.Subfinder_Module_Domain_Results_CheckedListBox.Size = new System.Drawing.Size(257, 559);
            this.Subfinder_Module_Domain_Results_CheckedListBox.TabIndex = 30;
            // 
            // Subfinder_Module_Results_Label
            // 
            this.Subfinder_Module_Results_Label.AutoSize = true;
            this.Subfinder_Module_Results_Label.Location = new System.Drawing.Point(811, 6);
            this.Subfinder_Module_Results_Label.Name = "Subfinder_Module_Results_Label";
            this.Subfinder_Module_Results_Label.Size = new System.Drawing.Size(68, 13);
            this.Subfinder_Module_Results_Label.TabIndex = 27;
            this.Subfinder_Module_Results_Label.Text = "Subdomains:";
            // 
            // Subfinder_Module_Domains_Label
            // 
            this.Subfinder_Module_Domains_Label.AutoSize = true;
            this.Subfinder_Module_Domains_Label.Location = new System.Drawing.Point(8, 6);
            this.Subfinder_Module_Domains_Label.Name = "Subfinder_Module_Domains_Label";
            this.Subfinder_Module_Domains_Label.Size = new System.Drawing.Size(51, 13);
            this.Subfinder_Module_Domains_Label.TabIndex = 26;
            this.Subfinder_Module_Domains_Label.Text = "Domains:";
            // 
            // Subfinder_Module_Domains_RichTextBox
            // 
            this.Subfinder_Module_Domains_RichTextBox.Location = new System.Drawing.Point(8, 22);
            this.Subfinder_Module_Domains_RichTextBox.Name = "Subfinder_Module_Domains_RichTextBox";
            this.Subfinder_Module_Domains_RichTextBox.Size = new System.Drawing.Size(254, 559);
            this.Subfinder_Module_Domains_RichTextBox.TabIndex = 25;
            this.Subfinder_Module_Domains_RichTextBox.Text = "";
            // 
            // Httpx_Module_TabPage
            // 
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Export_To_Acunetix_Importer_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Settings_GroupBox);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Delete_Selected_Websites_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Export_To_Local_Database_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Clear_Checked_Websites_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Clear_Unchecked_Websites_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Stop_And_Delete_Websites_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Start_Online_Check_Button);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_CheckedListBox);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Checked_Websites_Label);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_Unchecked_Websites_Label);
            this.Httpx_Module_TabPage.Controls.Add(this.Httpx_RichTextBox);
            this.Httpx_Module_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Httpx_Module_TabPage.Name = "Httpx_Module_TabPage";
            this.Httpx_Module_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Httpx_Module_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Httpx_Module_TabPage.TabIndex = 2;
            this.Httpx_Module_TabPage.Text = "Httpx Module";
            this.Httpx_Module_TabPage.UseVisualStyleBackColor = true;
            // 
            // Httpx_Export_To_Acunetix_Importer_Button
            // 
            this.Httpx_Export_To_Acunetix_Importer_Button.Location = new System.Drawing.Point(545, 80);
            this.Httpx_Export_To_Acunetix_Importer_Button.Name = "Httpx_Export_To_Acunetix_Importer_Button";
            this.Httpx_Export_To_Acunetix_Importer_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Export_To_Acunetix_Importer_Button.TabIndex = 44;
            this.Httpx_Export_To_Acunetix_Importer_Button.Text = "Export to Acunetix Importer";
            this.Httpx_Export_To_Acunetix_Importer_Button.UseVisualStyleBackColor = true;
            // 
            // Httpx_Settings_GroupBox
            // 
            this.Httpx_Settings_GroupBox.Controls.Add(this.Httpx_Settings_Add_Status_Code_Detection_CheckBox);
            this.Httpx_Settings_GroupBox.Controls.Add(this.Httpx_Settings_Add_Title_Detection_CheckBox);
            this.Httpx_Settings_GroupBox.Controls.Add(this.Httpx_Settings_Threads_NumericUpDown);
            this.Httpx_Settings_GroupBox.Controls.Add(this.Httpx_Settings_Threads_Label);
            this.Httpx_Settings_GroupBox.Location = new System.Drawing.Point(276, 110);
            this.Httpx_Settings_GroupBox.Name = "Httpx_Settings_GroupBox";
            this.Httpx_Settings_GroupBox.Size = new System.Drawing.Size(253, 102);
            this.Httpx_Settings_GroupBox.TabIndex = 43;
            this.Httpx_Settings_GroupBox.TabStop = false;
            this.Httpx_Settings_GroupBox.Text = "Httpx Settings";
            // 
            // Httpx_Settings_Add_Status_Code_Detection_CheckBox
            // 
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.AutoSize = true;
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.Location = new System.Drawing.Point(9, 42);
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.Name = "Httpx_Settings_Add_Status_Code_Detection_CheckBox";
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.Size = new System.Drawing.Size(155, 17);
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.TabIndex = 5;
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.Text = "Add Status-Code Detection";
            this.Httpx_Settings_Add_Status_Code_Detection_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Httpx_Settings_Add_Title_Detection_CheckBox
            // 
            this.Httpx_Settings_Add_Title_Detection_CheckBox.AutoSize = true;
            this.Httpx_Settings_Add_Title_Detection_CheckBox.Location = new System.Drawing.Point(9, 19);
            this.Httpx_Settings_Add_Title_Detection_CheckBox.Name = "Httpx_Settings_Add_Title_Detection_CheckBox";
            this.Httpx_Settings_Add_Title_Detection_CheckBox.Size = new System.Drawing.Size(117, 17);
            this.Httpx_Settings_Add_Title_Detection_CheckBox.TabIndex = 4;
            this.Httpx_Settings_Add_Title_Detection_CheckBox.Text = "Add Title Detection";
            this.Httpx_Settings_Add_Title_Detection_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Httpx_Settings_Threads_NumericUpDown
            // 
            this.Httpx_Settings_Threads_NumericUpDown.Location = new System.Drawing.Point(127, 65);
            this.Httpx_Settings_Threads_NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Httpx_Settings_Threads_NumericUpDown.Name = "Httpx_Settings_Threads_NumericUpDown";
            this.Httpx_Settings_Threads_NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.Httpx_Settings_Threads_NumericUpDown.TabIndex = 3;
            this.Httpx_Settings_Threads_NumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Httpx_Settings_Threads_Label
            // 
            this.Httpx_Settings_Threads_Label.AutoSize = true;
            this.Httpx_Settings_Threads_Label.Location = new System.Drawing.Point(6, 67);
            this.Httpx_Settings_Threads_Label.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Httpx_Settings_Threads_Label.Name = "Httpx_Settings_Threads_Label";
            this.Httpx_Settings_Threads_Label.Size = new System.Drawing.Size(77, 13);
            this.Httpx_Settings_Threads_Label.TabIndex = 2;
            this.Httpx_Settings_Threads_Label.Text = "Httpx Threads:";
            // 
            // Httpx_Delete_Selected_Websites_Button
            // 
            this.Httpx_Delete_Selected_Websites_Button.Location = new System.Drawing.Point(545, 177);
            this.Httpx_Delete_Selected_Websites_Button.Name = "Httpx_Delete_Selected_Websites_Button";
            this.Httpx_Delete_Selected_Websites_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Delete_Selected_Websites_Button.TabIndex = 42;
            this.Httpx_Delete_Selected_Websites_Button.Text = "Delete Selected Websites";
            this.Httpx_Delete_Selected_Websites_Button.UseVisualStyleBackColor = true;
            // 
            // Httpx_Export_To_Local_Database_Button
            // 
            this.Httpx_Export_To_Local_Database_Button.Location = new System.Drawing.Point(545, 51);
            this.Httpx_Export_To_Local_Database_Button.Name = "Httpx_Export_To_Local_Database_Button";
            this.Httpx_Export_To_Local_Database_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Export_To_Local_Database_Button.TabIndex = 41;
            this.Httpx_Export_To_Local_Database_Button.Text = "Export to Local Database";
            this.Httpx_Export_To_Local_Database_Button.UseVisualStyleBackColor = true;
            // 
            // Httpx_Clear_Checked_Websites_Button
            // 
            this.Httpx_Clear_Checked_Websites_Button.Location = new System.Drawing.Point(545, 22);
            this.Httpx_Clear_Checked_Websites_Button.Name = "Httpx_Clear_Checked_Websites_Button";
            this.Httpx_Clear_Checked_Websites_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Clear_Checked_Websites_Button.TabIndex = 40;
            this.Httpx_Clear_Checked_Websites_Button.Text = "Clear Checked Websites";
            this.Httpx_Clear_Checked_Websites_Button.UseVisualStyleBackColor = true;
            // 
            // Httpx_Clear_Unchecked_Websites_Button
            // 
            this.Httpx_Clear_Unchecked_Websites_Button.Location = new System.Drawing.Point(275, 80);
            this.Httpx_Clear_Unchecked_Websites_Button.Name = "Httpx_Clear_Unchecked_Websites_Button";
            this.Httpx_Clear_Unchecked_Websites_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Clear_Unchecked_Websites_Button.TabIndex = 39;
            this.Httpx_Clear_Unchecked_Websites_Button.Text = "Clear Unchecked Websites";
            this.Httpx_Clear_Unchecked_Websites_Button.UseVisualStyleBackColor = true;
            // 
            // Httpx_Stop_And_Delete_Websites_Button
            // 
            this.Httpx_Stop_And_Delete_Websites_Button.Location = new System.Drawing.Point(275, 51);
            this.Httpx_Stop_And_Delete_Websites_Button.Name = "Httpx_Stop_And_Delete_Websites_Button";
            this.Httpx_Stop_And_Delete_Websites_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Stop_And_Delete_Websites_Button.TabIndex = 38;
            this.Httpx_Stop_And_Delete_Websites_Button.Text = "Stop and Delete processed Websites";
            this.Httpx_Stop_And_Delete_Websites_Button.UseVisualStyleBackColor = true;
            // 
            // Httpx_Start_Online_Check_Button
            // 
            this.Httpx_Start_Online_Check_Button.Location = new System.Drawing.Point(275, 22);
            this.Httpx_Start_Online_Check_Button.Name = "Httpx_Start_Online_Check_Button";
            this.Httpx_Start_Online_Check_Button.Size = new System.Drawing.Size(254, 23);
            this.Httpx_Start_Online_Check_Button.TabIndex = 37;
            this.Httpx_Start_Online_Check_Button.Text = "Start Online Check";
            this.Httpx_Start_Online_Check_Button.UseVisualStyleBackColor = true;
            this.Httpx_Start_Online_Check_Button.Click += new System.EventHandler(this.Httpx_Start_Online_Check_Button_Click);
            // 
            // Httpx_CheckedListBox
            // 
            this.Httpx_CheckedListBox.FormattingEnabled = true;
            this.Httpx_CheckedListBox.Location = new System.Drawing.Point(811, 22);
            this.Httpx_CheckedListBox.Name = "Httpx_CheckedListBox";
            this.Httpx_CheckedListBox.Size = new System.Drawing.Size(257, 559);
            this.Httpx_CheckedListBox.TabIndex = 36;
            // 
            // Httpx_Checked_Websites_Label
            // 
            this.Httpx_Checked_Websites_Label.AutoSize = true;
            this.Httpx_Checked_Websites_Label.Location = new System.Drawing.Point(811, 6);
            this.Httpx_Checked_Websites_Label.Name = "Httpx_Checked_Websites_Label";
            this.Httpx_Checked_Websites_Label.Size = new System.Drawing.Size(100, 13);
            this.Httpx_Checked_Websites_Label.TabIndex = 33;
            this.Httpx_Checked_Websites_Label.Text = "Checked Websites:";
            // 
            // Httpx_Unchecked_Websites_Label
            // 
            this.Httpx_Unchecked_Websites_Label.AutoSize = true;
            this.Httpx_Unchecked_Websites_Label.Location = new System.Drawing.Point(8, 6);
            this.Httpx_Unchecked_Websites_Label.Name = "Httpx_Unchecked_Websites_Label";
            this.Httpx_Unchecked_Websites_Label.Size = new System.Drawing.Size(113, 13);
            this.Httpx_Unchecked_Websites_Label.TabIndex = 32;
            this.Httpx_Unchecked_Websites_Label.Text = "Unchecked Websites:";
            // 
            // Httpx_RichTextBox
            // 
            this.Httpx_RichTextBox.Location = new System.Drawing.Point(8, 22);
            this.Httpx_RichTextBox.Name = "Httpx_RichTextBox";
            this.Httpx_RichTextBox.Size = new System.Drawing.Size(254, 559);
            this.Httpx_RichTextBox.TabIndex = 31;
            this.Httpx_RichTextBox.Text = "";
            // 
            // Local_Database_TabPage
            // 
            this.Local_Database_TabPage.Controls.Add(this.label43);
            this.Local_Database_TabPage.Controls.Add(this.button22);
            this.Local_Database_TabPage.Controls.Add(this.button21);
            this.Local_Database_TabPage.Controls.Add(this.button20);
            this.Local_Database_TabPage.Controls.Add(this.button19);
            this.Local_Database_TabPage.Controls.Add(this.button18);
            this.Local_Database_TabPage.Controls.Add(this.button17);
            this.Local_Database_TabPage.Controls.Add(this.button16);
            this.Local_Database_TabPage.Controls.Add(this.button15);
            this.Local_Database_TabPage.Controls.Add(this.button14);
            this.Local_Database_TabPage.Controls.Add(this.button13);
            this.Local_Database_TabPage.Controls.Add(this.dataGridView2);
            this.Local_Database_TabPage.Controls.Add(this.dataGridView1);
            this.Local_Database_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Local_Database_TabPage.Name = "Local_Database_TabPage";
            this.Local_Database_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Local_Database_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Local_Database_TabPage.TabIndex = 3;
            this.Local_Database_TabPage.Text = "Local Database";
            this.Local_Database_TabPage.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(821, 113);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(76, 24);
            this.label43.TabIndex = 24;
            this.label43.Text = "Blacklist";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(278, 122);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(254, 23);
            this.button22.TabIndex = 23;
            this.button22.Text = "Export Selected Domains to Subfinder Module";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(278, 93);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(254, 23);
            this.button21.TabIndex = 22;
            this.button21.Text = "Export All Domains to Subfinder Module";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(278, 211);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(254, 23);
            this.button20.TabIndex = 21;
            this.button20.Text = "Export Selected Websites to Blacklist";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(278, 35);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(254, 23);
            this.button19.TabIndex = 20;
            this.button19.Text = "Export Selected Websites to Httpx Module";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(278, 6);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(254, 23);
            this.button18.TabIndex = 19;
            this.button18.Text = "Export All Websites to Httpx Module";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(8, 64);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(254, 23);
            this.button17.TabIndex = 18;
            this.button17.Text = "Remove Selected Websites from Database";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(8, 35);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(254, 23);
            this.button16.TabIndex = 17;
            this.button16.Text = "Export Selected Websites to Acunetix Importer";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(8, 6);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(254, 23);
            this.button15.TabIndex = 16;
            this.button15.Text = "Export All Websites to Acunetix Importer";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(737, 555);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 23);
            this.button14.TabIndex = 15;
            this.button14.Text = "Clear Blacklist";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(545, 555);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(89, 23);
            this.button13.TabIndex = 14;
            this.button13.Text = "Clear Database";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blacklist_website,
            this.blacklist_date_added});
            this.dataGridView2.Location = new System.Drawing.Point(825, 140);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(243, 438);
            this.dataGridView2.TabIndex = 13;
            // 
            // blacklist_website
            // 
            this.blacklist_website.HeaderText = "Website";
            this.blacklist_website.Name = "blacklist_website";
            this.blacklist_website.ReadOnly = true;
            // 
            // blacklist_date_added
            // 
            this.blacklist_date_added.HeaderText = "Date Added";
            this.blacklist_date_added.Name = "blacklist_date_added";
            this.blacklist_date_added.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.website_subdomain,
            this.website_domain,
            this.website_tld,
            this.website_statuscode,
            this.website_title,
            this.website_date_added});
            this.dataGridView1.Location = new System.Drawing.Point(8, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 338);
            this.dataGridView1.TabIndex = 12;
            // 
            // website_subdomain
            // 
            this.website_subdomain.HeaderText = "Subdomain";
            this.website_subdomain.Name = "website_subdomain";
            this.website_subdomain.ReadOnly = true;
            // 
            // website_domain
            // 
            this.website_domain.HeaderText = "Domain";
            this.website_domain.Name = "website_domain";
            this.website_domain.ReadOnly = true;
            // 
            // website_tld
            // 
            this.website_tld.HeaderText = "TLD";
            this.website_tld.Name = "website_tld";
            this.website_tld.ReadOnly = true;
            // 
            // website_statuscode
            // 
            this.website_statuscode.HeaderText = "Statuscode";
            this.website_statuscode.Name = "website_statuscode";
            this.website_statuscode.ReadOnly = true;
            // 
            // website_title
            // 
            this.website_title.HeaderText = "Title";
            this.website_title.Name = "website_title";
            this.website_title.ReadOnly = true;
            // 
            // website_date_added
            // 
            this.website_date_added.HeaderText = "Date Added";
            this.website_date_added.Name = "website_date_added";
            this.website_date_added.ReadOnly = true;
            // 
            // Acunetix_Importer_TabPage
            // 
            this.Acunetix_Importer_TabPage.Controls.Add(this.button24);
            this.Acunetix_Importer_TabPage.Controls.Add(this.comboBox1);
            this.Acunetix_Importer_TabPage.Controls.Add(this.button23);
            this.Acunetix_Importer_TabPage.Controls.Add(this.label10);
            this.Acunetix_Importer_TabPage.Controls.Add(this.richTextBox2);
            this.Acunetix_Importer_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Acunetix_Importer_TabPage.Name = "Acunetix_Importer_TabPage";
            this.Acunetix_Importer_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Acunetix_Importer_TabPage.TabIndex = 4;
            this.Acunetix_Importer_TabPage.Text = "Acunetix Importer";
            this.Acunetix_Importer_TabPage.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(276, 49);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(256, 23);
            this.button24.TabIndex = 20;
            this.button24.Text = "Clear Targets";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(546, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(276, 19);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(256, 23);
            this.button23.TabIndex = 18;
            this.button23.Text = "Add to Acunetix and Start Selected Scan";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Targets:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(8, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(254, 559);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // Advanced_Acunetix_Operations_TabPage
            // 
            this.Advanced_Acunetix_Operations_TabPage.Controls.Add(this.groupBox3);
            this.Advanced_Acunetix_Operations_TabPage.Controls.Add(this.button28);
            this.Advanced_Acunetix_Operations_TabPage.Controls.Add(this.button25);
            this.Advanced_Acunetix_Operations_TabPage.Controls.Add(this.button26);
            this.Advanced_Acunetix_Operations_TabPage.Controls.Add(this.button27);
            this.Advanced_Acunetix_Operations_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Advanced_Acunetix_Operations_TabPage.Name = "Advanced_Acunetix_Operations_TabPage";
            this.Advanced_Acunetix_Operations_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Advanced_Acunetix_Operations_TabPage.TabIndex = 5;
            this.Advanced_Acunetix_Operations_TabPage.Text = "Advanced Acunetix Operations";
            this.Advanced_Acunetix_Operations_TabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 248);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Targets:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Running Scans:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 24);
            this.label14.TabIndex = 25;
            this.label14.Text = "Unscanned Targets Left:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 148);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "Queued Scans:";
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(8, 35);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(254, 23);
            this.button28.TabIndex = 26;
            this.button28.Text = "Delete All Queued Scans";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(8, 64);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(254, 23);
            this.button25.TabIndex = 21;
            this.button25.Text = "Delete All Finished Targets with 0 Vulnerabilities";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(8, 93);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(254, 23);
            this.button26.TabIndex = 20;
            this.button26.Text = "Delete All Targets in Acunetix";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(8, 6);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(254, 23);
            this.button27.TabIndex = 19;
            this.button27.Text = "Delete All Running Scans";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // Settings_TabPage
            // 
            this.Settings_TabPage.Controls.Add(this.label51);
            this.Settings_TabPage.Controls.Add(this.numericUpDown2);
            this.Settings_TabPage.Controls.Add(this.maskedTextBox6);
            this.Settings_TabPage.Controls.Add(this.maskedTextBox5);
            this.Settings_TabPage.Controls.Add(this.Settings_Httpx_Location_MaskedTextBox);
            this.Settings_TabPage.Controls.Add(this.Settings_Subfinder_Location_MaskedTextBox);
            this.Settings_TabPage.Controls.Add(this.maskedTextBox2);
            this.Settings_TabPage.Controls.Add(this.maskedTextBox1);
            this.Settings_TabPage.Controls.Add(this.label50);
            this.Settings_TabPage.Controls.Add(this.label49);
            this.Settings_TabPage.Controls.Add(this.label48);
            this.Settings_TabPage.Controls.Add(this.label47);
            this.Settings_TabPage.Controls.Add(this.label46);
            this.Settings_TabPage.Controls.Add(this.label45);
            this.Settings_TabPage.Controls.Add(this.label44);
            this.Settings_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Settings_TabPage.Name = "Settings_TabPage";
            this.Settings_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.Settings_TabPage.TabIndex = 7;
            this.Settings_TabPage.Text = "Settings";
            this.Settings_TabPage.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(268, 151);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(49, 13);
            this.label51.TabIndex = 32;
            this.label51.Text = "Seconds";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(143, 149);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 31;
            this.numericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(143, 122);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(389, 20);
            this.maskedTextBox6.TabIndex = 30;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(143, 99);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(389, 20);
            this.maskedTextBox5.TabIndex = 29;
            // 
            // Settings_Httpx_Location_MaskedTextBox
            // 
            this.Settings_Httpx_Location_MaskedTextBox.Location = new System.Drawing.Point(143, 76);
            this.Settings_Httpx_Location_MaskedTextBox.Name = "Settings_Httpx_Location_MaskedTextBox";
            this.Settings_Httpx_Location_MaskedTextBox.Size = new System.Drawing.Size(389, 20);
            this.Settings_Httpx_Location_MaskedTextBox.TabIndex = 28;
            this.Settings_Httpx_Location_MaskedTextBox.Text = "C:\\Users\\0000\\go\\bin\\httpx.exe";
            // 
            // Settings_Subfinder_Location_MaskedTextBox
            // 
            this.Settings_Subfinder_Location_MaskedTextBox.Location = new System.Drawing.Point(143, 53);
            this.Settings_Subfinder_Location_MaskedTextBox.Name = "Settings_Subfinder_Location_MaskedTextBox";
            this.Settings_Subfinder_Location_MaskedTextBox.Size = new System.Drawing.Size(389, 20);
            this.Settings_Subfinder_Location_MaskedTextBox.TabIndex = 27;
            this.Settings_Subfinder_Location_MaskedTextBox.Text = "C:\\Users\\0000\\go\\bin\\subfinder.exe";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(143, 30);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(389, 20);
            this.maskedTextBox2.TabIndex = 26;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 7);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(389, 20);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 151);
            this.label50.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(128, 13);
            this.label50.TabIndex = 24;
            this.label50.Text = "Statistics Update Interval:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(8, 125);
            this.label49.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(93, 13);
            this.label49.TabIndex = 23;
            this.label49.Text = "Blacklist Location:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 102);
            this.label48.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(129, 13);
            this.label48.TabIndex = 22;
            this.label48.Text = "Local Database Location:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 79);
            this.label47.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(79, 13);
            this.label47.TabIndex = 21;
            this.label47.Text = "Httpx Location:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 56);
            this.label46.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(99, 13);
            this.label46.TabIndex = 20;
            this.label46.Text = "Subfinder Location:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(8, 33);
            this.label45.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(82, 13);
            this.label45.TabIndex = 19;
            this.label45.Text = "Google CSE ID:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(8, 10);
            this.label44.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(103, 13);
            this.label44.TabIndex = 18;
            this.label44.Text = "Google CSE Apikey:";
            // 
            // About_TabPage
            // 
            this.About_TabPage.Location = new System.Drawing.Point(4, 22);
            this.About_TabPage.Name = "About_TabPage";
            this.About_TabPage.Size = new System.Drawing.Size(1076, 586);
            this.About_TabPage.TabIndex = 8;
            this.About_TabPage.Text = "About";
            this.About_TabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 612);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 651);
            this.MinimumSize = new System.Drawing.Size(1100, 651);
            this.Name = "Form1";
            this.Text = "AcunetixHelperSoft";
            this.tabControl1.ResumeLayout(false);
            this.Google_CSE_Scraper_TabPage.ResumeLayout(false);
            this.Google_CSE_Scraper_TabPage.PerformLayout();
            this.Google_CSE_Scraper_Settings_GroupBox.ResumeLayout(false);
            this.Google_CSE_Scraper_Settings_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown)).EndInit();
            this.Subfinder_TabPage.ResumeLayout(false);
            this.Subfinder_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Subfinder_Module_Threads_NumericUpDown)).EndInit();
            this.Httpx_Module_TabPage.ResumeLayout(false);
            this.Httpx_Module_TabPage.PerformLayout();
            this.Httpx_Settings_GroupBox.ResumeLayout(false);
            this.Httpx_Settings_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Httpx_Settings_Threads_NumericUpDown)).EndInit();
            this.Local_Database_TabPage.ResumeLayout(false);
            this.Local_Database_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Acunetix_Importer_TabPage.ResumeLayout(false);
            this.Acunetix_Importer_TabPage.PerformLayout();
            this.Advanced_Acunetix_Operations_TabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Settings_TabPage.ResumeLayout(false);
            this.Settings_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Google_CSE_Scraper_TabPage;
        private System.Windows.Forms.TabPage Subfinder_TabPage;
        private System.Windows.Forms.TabPage Httpx_Module_TabPage;
        private System.Windows.Forms.TabPage Local_Database_TabPage;
        private System.Windows.Forms.TabPage Acunetix_Importer_TabPage;
        private System.Windows.Forms.TabPage Advanced_Acunetix_Operations_TabPage;
        private System.Windows.Forms.TabPage Settings_TabPage;
        private System.Windows.Forms.TabPage About_TabPage;
        private System.Windows.Forms.RichTextBox Google_CSE_Scraper_Keywords_RichTextBox;
        private System.Windows.Forms.Label Google_CSE_Scraper_Results_Label;
        private System.Windows.Forms.Label Google_CSE_Scraper_Keywords_Label;
        private System.Windows.Forms.Button Google_CSE_Scraper_Clear_Results_Button;
        private System.Windows.Forms.Button Google_CSE_Scraper_Clear_Keywords_Button;
        private System.Windows.Forms.Button Google_CSE_Scraper_Export_To_Subfinder_Button;
        private System.Windows.Forms.Button Google_CSE_Scraper_Start_CSE_Search_Button;
        private System.Windows.Forms.NumericUpDown Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Results_Per_Keyword_Label;
        private System.Windows.Forms.ComboBox Google_CSE_Scraper__Settings_Country_ComboBox;
        private System.Windows.Forms.ComboBox Google_CSE_Scraper_Settings_Language_ComboBox;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Country_Label;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Language_Label;
        private System.Windows.Forms.CheckedListBox Google_CSE_Scraper_Results_CheckedListBox;
        private System.Windows.Forms.GroupBox Google_CSE_Scraper_Settings_GroupBox;
        private System.Windows.Forms.Button Google_CSE_Scraper_Delete_Selected_Results_Button;
        private System.Windows.Forms.Label Google_CSE_Scraper_Query_Description_Label;
        private System.Windows.Forms.Label Google_CSE_Scraper_Dorking_Example_Label;
        private System.Windows.Forms.CheckedListBox Subfinder_Module_Domain_Results_CheckedListBox;
        private System.Windows.Forms.Label Subfinder_Module_Results_Label;
        private System.Windows.Forms.Label Subfinder_Module_Domains_Label;
        private System.Windows.Forms.RichTextBox Subfinder_Module_Domains_RichTextBox;
        private System.Windows.Forms.NumericUpDown Subfinder_Module_Threads_NumericUpDown;
        private System.Windows.Forms.Label Subfinder_Module_Threads_Amount_Label;
        private System.Windows.Forms.Button Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button;
        private System.Windows.Forms.Button Subfinder_Module_Delete_Selected_Subdomains_Button;
        private System.Windows.Forms.Button Subfinder_Module_Clear_Subdomains_Button;
        private System.Windows.Forms.Button Subfinder_Module_Clear_Subfinder_Domains_Button;
        private System.Windows.Forms.Button Subfinder_Module_Start_Subfinder_Enumeration_Button;
        private System.Windows.Forms.Label Subfinder_Module_Domains_Processed_Label;
        private System.Windows.Forms.Button Subfinder_Module_Delete_gov_mil_arpa_Domains_Button;
        private System.Windows.Forms.CheckedListBox Httpx_CheckedListBox;
        private System.Windows.Forms.Label Httpx_Checked_Websites_Label;
        private System.Windows.Forms.Label Httpx_Unchecked_Websites_Label;
        private System.Windows.Forms.RichTextBox Httpx_RichTextBox;
        private System.Windows.Forms.Button Httpx_Start_Online_Check_Button;
        private System.Windows.Forms.Button Httpx_Stop_And_Delete_Websites_Button;
        private System.Windows.Forms.Button Httpx_Clear_Checked_Websites_Button;
        private System.Windows.Forms.Button Httpx_Clear_Unchecked_Websites_Button;
        private System.Windows.Forms.Button Httpx_Delete_Selected_Websites_Button;
        private System.Windows.Forms.Button Httpx_Export_To_Local_Database_Button;
        private System.Windows.Forms.GroupBox Httpx_Settings_GroupBox;
        private System.Windows.Forms.Label Httpx_Settings_Threads_Label;
        private System.Windows.Forms.NumericUpDown Httpx_Settings_Threads_NumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn blacklist_website;
        private System.Windows.Forms.DataGridViewTextBoxColumn blacklist_date_added;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridViewTextBoxColumn website_subdomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn website_domain;
        private System.Windows.Forms.DataGridViewTextBoxColumn website_tld;
        private System.Windows.Forms.DataGridViewTextBoxColumn website_statuscode;
        private System.Windows.Forms.DataGridViewTextBoxColumn website_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn website_date_added;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button Httpx_Export_To_Acunetix_Importer_Button;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox Settings_Httpx_Location_MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox Settings_Subfinder_Location_MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Reminder_Label;
        private System.Windows.Forms.CheckBox Httpx_Settings_Add_Status_Code_Detection_CheckBox;
        private System.Windows.Forms.CheckBox Httpx_Settings_Add_Title_Detection_CheckBox;
    }
}

