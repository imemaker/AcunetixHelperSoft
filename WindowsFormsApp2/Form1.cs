using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        // Dictionaries to store country and language codes
        private Dictionary<string, string> countryCodes = new Dictionary<string, string>();
        private Dictionary<string, string> languageCodes = new Dictionary<string, string>();

        // Counter to store the total number of results
        private int totalResults = 0;
        private int processedDomainsCount = 0;

        public Form1()
        {
            InitializeComponent();

            // Attach the event handlers
            this.Google_CSE_Scraper_Keywords_RichTextBox.TextChanged += new System.EventHandler(this.Keywords_richTextBox_TextChanged);
            this.Google_CSE_Scraper_Export_To_Subfinder_Button.Click += new System.EventHandler(this.Export_to_subfinder_button_Click);
            this.Google_CSE_Scraper_Clear_Results_Button.Click += new System.EventHandler(this.Google_cse_scraper_clear_results_button_Click);
            this.Subfinder_Module_Clear_Subfinder_Domains_Button.Click += new System.EventHandler(this.Subfinder_Module_Clear_Subfinder_Domains_Button_Click);
            this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button.Click += new System.EventHandler(this.Subfinder_Module_Delete_gov_mil_arpa_Domains_Button_Click);

            // Initialize country codes
            countryCodes.Add("Belgium", "countryBE");
            countryCodes.Add("Canada", "countryCA");
            countryCodes.Add("China", "countryCN");
            countryCodes.Add("Denmark", "countryDK");
            countryCodes.Add("European Union", "countryEU");
            countryCodes.Add("France", "countryFR");
            countryCodes.Add("Germany", "countryDE");
            countryCodes.Add("India", "countryIN");
            countryCodes.Add("Italy", "countryIT");
            countryCodes.Add("Netherlands", "countryNL");
            countryCodes.Add("Poland", "countryPL");
            countryCodes.Add("Russia", "countryRU");
            countryCodes.Add("Spain", "countryES");
            countryCodes.Add("Switzerland", "countryCH");
            countryCodes.Add("Turkey", "countryTR");
            countryCodes.Add("Ukraine", "countryUA");
            countryCodes.Add("United Kingdom", "countryUK");
            countryCodes.Add("United States", "countryUS");

            // Initialize language codes
            languageCodes.Add("Arabic", "lang_ar");
            languageCodes.Add("Bulgarian", "lang_bg");
            languageCodes.Add("Catalan", "lang_ca");
            languageCodes.Add("Chinese (Simplified)", "lang_zh-CN");
            languageCodes.Add("Chinese (Traditional)", "lang_zh-TW");
            languageCodes.Add("Croatian", "lang_hr");
            languageCodes.Add("Czech", "lang_cs");
            languageCodes.Add("Danish", "lang_da");
            languageCodes.Add("Dutch", "lang_nl");
            languageCodes.Add("English", "lang_en");
            languageCodes.Add("Estonian", "lang_et");
            languageCodes.Add("Finnish", "lang_fi");
            languageCodes.Add("French", "lang_fr");
            languageCodes.Add("German", "lang_de");
            languageCodes.Add("Greek", "lang_el");
            languageCodes.Add("Hebrew", "lang_iw");
            languageCodes.Add("Hungarian", "lang_hu");
            languageCodes.Add("Icelandic", "lang_is");
            languageCodes.Add("Indonesian", "lang_id");
            languageCodes.Add("Italian", "lang_it");
            languageCodes.Add("Japanese", "lang_ja");
            languageCodes.Add("Korean", "lang_ko");
            languageCodes.Add("Latvian", "lang_lv");
            languageCodes.Add("Lithuanian", "lang_lt");
            languageCodes.Add("Norwegian", "lang_no");
            languageCodes.Add("Polish", "lang_pl");
            languageCodes.Add("Portuguese", "lang_pt");
            languageCodes.Add("Romanian", "lang_ro");
            languageCodes.Add("Russian", "lang_ru");
            languageCodes.Add("Serbian", "lang_sr");
            languageCodes.Add("Slovak", "lang_sk");
            languageCodes.Add("Slovenian", "lang_sl");
            languageCodes.Add("Spanish", "lang_es");
            languageCodes.Add("Swedish", "lang_sv");
            languageCodes.Add("Turkish", "lang_tr");

            // Fill ComboBoxes with country and language names
            foreach (var country in countryCodes.Keys)
            {
                Google_CSE_Scraper__Settings_Country_ComboBox.Items.Add(country);
            }
            foreach (var language in languageCodes.Keys)
            {
                Google_CSE_Scraper_Settings_Language_ComboBox.Items.Add(language);
            }
            // Set default values
            Google_CSE_Scraper__Settings_Country_ComboBox.SelectedItem = "United States";
            Google_CSE_Scraper_Settings_Language_ComboBox.SelectedItem = "English";
        }


        private async void Start_cse_search_button_Click(object sender, EventArgs e)
        {
            var keywords = Google_CSE_Scraper_Keywords_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            // Clear the checkedListBox and reset the totalResults counter before the loop
            Google_CSE_Scraper_Results_CheckedListBox.Items.Clear();
            totalResults = 0;

            foreach (var keyword in keywords)
            {
                await RunCseSearch(keyword);
                await Task.Delay(1000); // Wait for 1 second
            }
        }

        private async Task RunCseSearch(string keyword)
        {
            var resultsPerKeyword = (int)Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Value;
            var country = countryCodes[Google_CSE_Scraper__Settings_Country_ComboBox.SelectedItem.ToString()];
            var language = languageCodes[Google_CSE_Scraper_Settings_Language_ComboBox.SelectedItem.ToString()];

            var apiKey = maskedTextBox1.Text;
            var cseId = maskedTextBox2.Text;

            string query = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={cseId}&q={keyword}&num={resultsPerKeyword}&cr={country}&lr={language}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    JObject googleSearch = JObject.Parse(content);
                    JArray items = (JArray)googleSearch["items"];

                    if (items != null)
                    {
                        foreach (var item in items)
                        {
                            string link = (string)item["link"];
                            Uri uri = new Uri(link);
                            Google_CSE_Scraper_Results_CheckedListBox.Items.Add(uri.Host);
                            totalResults++; // Increment the counter for each result
                        }
                    }
                }
                else if (response.StatusCode == (System.Net.HttpStatusCode)429)
                {
                    MessageBox.Show("Too Many Requests! You are being rate limited. Try slowing down your requests.");
                }
                else

                {
                    MessageBox.Show("Error!!1\nSomething is wrong.\nCheck your Settings, Dumbass!\nStatuscode of Response says: " + response.StatusCode.ToString());
                }
            }

            // Update the label at the end of the method
            Google_CSE_Scraper_Results_Label.Text = $"Total results: {totalResults}";
        }

        private void Clear_keywords_button_Click(object sender, EventArgs e)
        {
            Google_CSE_Scraper_Keywords_RichTextBox.Clear();
        }

        private void Keywords_richTextBox_TextChanged(object sender, EventArgs e)
        {
            var keywords = Google_CSE_Scraper_Keywords_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Google_CSE_Scraper_Keywords_Label.Text = "Keywords: " + keywords.Length;
            Google_CSE_Scraper_Keywords_Label.Refresh(); // Force the label to update its display
        }

        private void Export_to_subfinder_button_Click(object sender, EventArgs e)
        {
            // Clear the richTextBox
            Subfinder_Module_Domains_RichTextBox.Clear();

            // Add each item from the checkedListBox to the richTextBox
            foreach (var item in Google_CSE_Scraper_Results_CheckedListBox.Items)
            {
                Subfinder_Module_Domains_RichTextBox.AppendText(item.ToString() + "\n");
            }
        }

        private void Google_cse_scraper_clear_results_button_Click(object sender, EventArgs e)
        {
            // Clear the checkedListBox and reset the totalResults counter
            Google_CSE_Scraper_Results_CheckedListBox.Items.Clear();
            totalResults = 0;

            // Update the label to show that there are no results
            Google_CSE_Scraper_Results_Label.Text = "Total results: 0";
        }

        private async void Start_Subfinder_Enumeration_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Enabled = false;
            var threads = (int)Subfinder_Module_Threads_NumericUpDown.Value;
            var subfinderLocation = Settings_Subfinder_Location_MaskedTextBox.Text;
            var domains = Subfinder_Module_Domains_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var totalCount = domains.Length;
            List<Task> runningTasks = new List<Task>();
            processedDomainsCount = 0;

            // Added the line here
            UpdateDomainCount();

            for (int i = 0; i < domains.Length; i++)
            {
                if (runningTasks.Count >= threads)
                {
                    var completedTask = await Task.WhenAny(runningTasks);
                    runningTasks.Remove(completedTask);
                }

                var subfinderTask = RunSubfinder(subfinderLocation, domains[i], totalCount);
                runningTasks.Add(subfinderTask);
            }

            await Task.WhenAll(runningTasks);
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Enabled = true;
        }

        private async Task RunSubfinder(string subfinderLocation, string domain, int totalCount)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = subfinderLocation,
                    Arguments = $"-d {domain} -silent",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                var process = new Process { StartInfo = startInfo };
                process.Start();

                // Create a StreamReader for the output
                using (var reader = process.StandardOutput)
                {
                    // Read line by line
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            Subfinder_Module_Domain_Results_CheckedListBox.Items.Add(line);
                            UpdateSubdomainsCount();
                        });
                    }
                }

                // Wait for the process to exit
                await Task.Run(() => process.WaitForExit());

                // Update the processedDomainsCount and the label
                this.Invoke((MethodInvoker)delegate
                {
                    // Use Interlocked.Increment to safely increment the counter
                    Interlocked.Increment(ref processedDomainsCount);
                    Subfinder_Module_Domains_Processed_Label.Text = $"Domains processed: {processedDomainsCount}/{totalCount}";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while running the subfinder process: {ex.Message}");
            }
        }


        private void Subfinder_Module_Clear_Subfinder_Domains_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Domains_RichTextBox.Clear();
            UpdateDomainCount();
        }

        private void Subfinder_Module_Delete_gov_mil_arpa_Domains_Button_Click(object sender, EventArgs e)
        {
            var lines = Subfinder_Module_Domains_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var filteredLines = lines.Where(line => !line.EndsWith(".gov") && !line.EndsWith(".mil") && !line.EndsWith(".arpa"));
            Subfinder_Module_Domains_RichTextBox.Text = string.Join("\n", filteredLines);
            UpdateDomainCount();
        }
        private void UpdateDomainCount()
        {
            var domainCount = Subfinder_Module_Domains_RichTextBox.Lines.Length;
            Subfinder_Module_Domains_Label.Text = $"Domains: {domainCount}";
        }

        private void UpdateSubdomainsCount()
        {
            int subdomainsCount = Subfinder_Module_Domain_Results_CheckedListBox.Items.Count;
            Subfinder_Module_Results_Label.Text = $"Subdomains: {subdomainsCount}";
        }

        private void Subfinder_Module_Clear_Subdomains_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Domain_Results_CheckedListBox.Items.Clear();
            UpdateSubdomainsCount();
        }

        private void Subfinder_Module_Delete_Selected_Subdomains_Button_Click(object sender, EventArgs e)
        {
            for (int i = Subfinder_Module_Domain_Results_CheckedListBox.CheckedItems.Count - 1; i >= 0; i--)
            {
                Subfinder_Module_Domain_Results_CheckedListBox.Items.Remove(Subfinder_Module_Domain_Results_CheckedListBox.CheckedItems[i]);
            }
            UpdateSubdomainsCount();
        }

        private void Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button_Click(object sender, EventArgs e)
        {
            foreach (var item in Subfinder_Module_Domain_Results_CheckedListBox.Items)
            {
                Httpx_RichTextBox.AppendText(item.ToString() + "\n");
            }
            UpdateSubdomainsCount();
        }

        public class HttpxResult
        {
            public string Url { get; set; }
            public int StatusCode { get; set; }
            public string Title { get; set; }
        }

        private Dictionary<string, HttpxResult> websiteData = new Dictionary<string, HttpxResult>();

        private async void Httpx_Start_Online_Check_Button_Click(object sender, EventArgs e)
        {
            Httpx_Start_Online_Check_Button.Enabled = false;
            var threads = (int)Httpx_Settings_Threads_NumericUpDown.Value;
            var websites = Httpx_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<Task> runningTasks = new List<Task>();

            for (int i = 0; i < websites.Length; i++)
            {
                if (runningTasks.Count >= threads)
                {
                    var completedTask = await Task.WhenAny(runningTasks);
                    runningTasks.Remove(completedTask);
                }

                var httpxTask = RunHttpx(websites[i]);
                runningTasks.Add(httpxTask);
            }

            await Task.WhenAll(runningTasks);
            Httpx_Start_Online_Check_Button.Enabled = true;
        }

        private async Task RunHttpx(string website)
        {
            string httpxLocation = Settings_Httpx_Location_MaskedTextBox.Text;

            ProcessStartInfo startInfo = new ProcessStartInfo(httpxLocation)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            // Construct the arguments based on the checked items in Httpx_Settings_CheckedListBox
            string arguments = website + " -silent";
            if (Httpx_Settings_Add_Status_Code_Detection_CheckBox.Checked) arguments += " -status-code";
            if (Httpx_Settings_Add_Title_Detection_CheckBox.Checked) arguments += " -title";

            startInfo.Arguments = arguments;

            // Create a new process and then start it
            using (Process process = new Process() { StartInfo = startInfo, EnableRaisingEvents = true })
            {
                process.Start();

                using (StreamReader reader = process.StandardOutput)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = await reader.ReadLineAsync();

                        // Parse the output line to get the status code and title
                        var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        // Extract URL, status code, and title
                        string url = parts[0];
                        int statusCode = 0;
                        string title = "";

                        if (Httpx_Settings_Add_Status_Code_Detection_CheckBox.Checked && parts.Length > 1)
                        {
                            statusCode = int.Parse(parts[1].Trim(new char[] { '[', ']' }));
                        }

                        if (Httpx_Settings_Add_Title_Detection_CheckBox.Checked && parts.Length > 2)
                        {
                            title = parts[2].Trim(new char[] { '[', ']' });
                        }

                        // Create a HttpxResult object
                        var httpxResult = new HttpxResult
                        {
                            Url = url,
                            StatusCode = statusCode,
                            Title = title
                        };

                        // Save the HttpxResult in the dictionary for later use
                        websiteData[url] = httpxResult;

                        // Add the website URL to the checked list box in the UI thread
                        this.BeginInvoke(new Action(() =>
                        {
                            Httpx_CheckedListBox.Items.Add(url);
                        }));
                    }
                }
            }
        }
    }//
}