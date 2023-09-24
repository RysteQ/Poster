namespace Poster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBoxMethodSelection = new ComboBox();
            TextBoxUrl = new TextBox();
            ButtonSendRequest = new Button();
            TabControlRequestParameters = new TabControl();
            TabPageParameters = new TabPage();
            PanelParameters = new Panel();
            CheckBoxIsParameterEnabled = new CheckBox();
            TextBoxParameterValue = new TextBox();
            ButtonDeleteParameter = new Button();
            TextBoxParameterKey = new TextBox();
            LabelValue = new Label();
            LabelKey = new Label();
            TabPageAuthentication = new TabPage();
            TabControlResults = new TabControl();
            TabPageRawResults = new TabPage();
            RichTextBoxRaw = new RichTextBox();
            TabPageJSONResults = new TabPage();
            RichTextBoxJSON = new RichTextBox();
            TabPagHTMLResults = new TabPage();
            WebViewHTMLResponse = new Microsoft.Web.WebView2.WinForms.WebView2();
            ListBoxResponseHistory = new ListBox();
            TabControlRequestParameters.SuspendLayout();
            TabPageParameters.SuspendLayout();
            PanelParameters.SuspendLayout();
            TabControlResults.SuspendLayout();
            TabPageRawResults.SuspendLayout();
            TabPageJSONResults.SuspendLayout();
            TabPagHTMLResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebViewHTMLResponse).BeginInit();
            SuspendLayout();
            // 
            // ComboBoxMethodSelection
            // 
            ComboBoxMethodSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxMethodSelection.FormattingEnabled = true;
            ComboBoxMethodSelection.Items.AddRange(new object[] { "HTTP", "POST", "GET", "PUT", "PATCH", "DELETE" });
            ComboBoxMethodSelection.Location = new Point(12, 12);
            ComboBoxMethodSelection.Name = "ComboBoxMethodSelection";
            ComboBoxMethodSelection.Size = new Size(69, 23);
            ComboBoxMethodSelection.TabIndex = 0;
            // 
            // TextBoxUrl
            // 
            TextBoxUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxUrl.Location = new Point(87, 12);
            TextBoxUrl.Name = "TextBoxUrl";
            TextBoxUrl.Size = new Size(918, 23);
            TextBoxUrl.TabIndex = 1;
            // 
            // ButtonSendRequest
            // 
            ButtonSendRequest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSendRequest.Location = new Point(1011, 11);
            ButtonSendRequest.Name = "ButtonSendRequest";
            ButtonSendRequest.Size = new Size(69, 24);
            ButtonSendRequest.TabIndex = 2;
            ButtonSendRequest.Text = "Send";
            ButtonSendRequest.UseVisualStyleBackColor = true;
            // 
            // TabControlRequestParameters
            // 
            TabControlRequestParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TabControlRequestParameters.Controls.Add(TabPageParameters);
            TabControlRequestParameters.Controls.Add(TabPageAuthentication);
            TabControlRequestParameters.Location = new Point(282, 41);
            TabControlRequestParameters.Name = "TabControlRequestParameters";
            TabControlRequestParameters.SelectedIndex = 0;
            TabControlRequestParameters.Size = new Size(798, 200);
            TabControlRequestParameters.TabIndex = 3;
            // 
            // TabPageParameters
            // 
            TabPageParameters.Controls.Add(PanelParameters);
            TabPageParameters.Controls.Add(LabelValue);
            TabPageParameters.Controls.Add(LabelKey);
            TabPageParameters.Location = new Point(4, 24);
            TabPageParameters.Name = "TabPageParameters";
            TabPageParameters.Padding = new Padding(3);
            TabPageParameters.Size = new Size(790, 172);
            TabPageParameters.TabIndex = 0;
            TabPageParameters.Text = "Parameters";
            TabPageParameters.UseVisualStyleBackColor = true;
            // 
            // PanelParameters
            // 
            PanelParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelParameters.AutoScroll = true;
            PanelParameters.Controls.Add(CheckBoxIsParameterEnabled);
            PanelParameters.Controls.Add(TextBoxParameterValue);
            PanelParameters.Controls.Add(ButtonDeleteParameter);
            PanelParameters.Controls.Add(TextBoxParameterKey);
            PanelParameters.Location = new Point(3, 23);
            PanelParameters.Name = "PanelParameters";
            PanelParameters.Size = new Size(787, 149);
            PanelParameters.TabIndex = 9;
            // 
            // CheckBoxIsParameterEnabled
            // 
            CheckBoxIsParameterEnabled.AutoSize = true;
            CheckBoxIsParameterEnabled.Location = new Point(3, 7);
            CheckBoxIsParameterEnabled.Name = "CheckBoxIsParameterEnabled";
            CheckBoxIsParameterEnabled.Size = new Size(15, 14);
            CheckBoxIsParameterEnabled.TabIndex = 5;
            CheckBoxIsParameterEnabled.UseVisualStyleBackColor = true;
            // 
            // TextBoxParameterValue
            // 
            TextBoxParameterValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBoxParameterValue.Enabled = false;
            TextBoxParameterValue.Location = new Point(218, 3);
            TextBoxParameterValue.Name = "TextBoxParameterValue";
            TextBoxParameterValue.Size = new Size(525, 23);
            TextBoxParameterValue.TabIndex = 7;
            // 
            // ButtonDeleteParameter
            // 
            ButtonDeleteParameter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonDeleteParameter.Location = new Point(749, 2);
            ButtonDeleteParameter.Name = "ButtonDeleteParameter";
            ButtonDeleteParameter.Size = new Size(32, 24);
            ButtonDeleteParameter.TabIndex = 8;
            ButtonDeleteParameter.UseVisualStyleBackColor = true;
            // 
            // TextBoxParameterKey
            // 
            TextBoxParameterKey.Location = new Point(24, 3);
            TextBoxParameterKey.Name = "TextBoxParameterKey";
            TextBoxParameterKey.Size = new Size(188, 23);
            TextBoxParameterKey.TabIndex = 6;
            TextBoxParameterKey.TextChanged += OnTextBoxParameterKeyChanged;
            // 
            // LabelValue
            // 
            LabelValue.Anchor = AnchorStyles.None;
            LabelValue.AutoSize = true;
            LabelValue.Location = new Point(467, 5);
            LabelValue.Name = "LabelValue";
            LabelValue.Size = new Size(35, 15);
            LabelValue.TabIndex = 4;
            LabelValue.Text = "Value";
            // 
            // LabelKey
            // 
            LabelKey.Anchor = AnchorStyles.None;
            LabelKey.AutoSize = true;
            LabelKey.Location = new Point(107, 5);
            LabelKey.Name = "LabelKey";
            LabelKey.Size = new Size(26, 15);
            LabelKey.TabIndex = 3;
            LabelKey.Text = "Key";
            // 
            // TabPageAuthentication
            // 
            TabPageAuthentication.Location = new Point(4, 24);
            TabPageAuthentication.Name = "TabPageAuthentication";
            TabPageAuthentication.Padding = new Padding(3);
            TabPageAuthentication.Size = new Size(790, 172);
            TabPageAuthentication.TabIndex = 1;
            TabPageAuthentication.Text = "Authentication";
            TabPageAuthentication.UseVisualStyleBackColor = true;
            // 
            // TabControlResults
            // 
            TabControlResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControlResults.Controls.Add(TabPageRawResults);
            TabControlResults.Controls.Add(TabPageJSONResults);
            TabControlResults.Controls.Add(TabPagHTMLResults);
            TabControlResults.Location = new Point(282, 247);
            TabControlResults.Name = "TabControlResults";
            TabControlResults.SelectedIndex = 0;
            TabControlResults.Size = new Size(794, 191);
            TabControlResults.TabIndex = 4;
            // 
            // TabPageRawResults
            // 
            TabPageRawResults.Controls.Add(RichTextBoxRaw);
            TabPageRawResults.Location = new Point(4, 24);
            TabPageRawResults.Name = "TabPageRawResults";
            TabPageRawResults.Padding = new Padding(3);
            TabPageRawResults.Size = new Size(786, 163);
            TabPageRawResults.TabIndex = 0;
            TabPageRawResults.Text = "Raw";
            TabPageRawResults.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxRaw
            // 
            RichTextBoxRaw.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBoxRaw.Location = new Point(-1, 0);
            RichTextBoxRaw.Name = "RichTextBoxRaw";
            RichTextBoxRaw.Size = new Size(784, 163);
            RichTextBoxRaw.TabIndex = 0;
            RichTextBoxRaw.Text = "";
            // 
            // TabPageJSONResults
            // 
            TabPageJSONResults.Controls.Add(RichTextBoxJSON);
            TabPageJSONResults.Location = new Point(4, 24);
            TabPageJSONResults.Name = "TabPageJSONResults";
            TabPageJSONResults.Padding = new Padding(3);
            TabPageJSONResults.Size = new Size(786, 163);
            TabPageJSONResults.TabIndex = 1;
            TabPageJSONResults.Text = "JSON";
            TabPageJSONResults.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxJSON
            // 
            RichTextBoxJSON.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RichTextBoxJSON.Location = new Point(-1, 0);
            RichTextBoxJSON.Name = "RichTextBoxJSON";
            RichTextBoxJSON.Size = new Size(787, 160);
            RichTextBoxJSON.TabIndex = 0;
            RichTextBoxJSON.Text = "";
            // 
            // TabPagHTMLResults
            // 
            TabPagHTMLResults.Controls.Add(WebViewHTMLResponse);
            TabPagHTMLResults.Location = new Point(4, 24);
            TabPagHTMLResults.Name = "TabPagHTMLResults";
            TabPagHTMLResults.Size = new Size(786, 163);
            TabPagHTMLResults.TabIndex = 2;
            TabPagHTMLResults.Text = "HTML";
            TabPagHTMLResults.UseVisualStyleBackColor = true;
            // 
            // WebViewHTMLResponse
            // 
            WebViewHTMLResponse.AllowExternalDrop = true;
            WebViewHTMLResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WebViewHTMLResponse.CreationProperties = null;
            WebViewHTMLResponse.DefaultBackgroundColor = Color.White;
            WebViewHTMLResponse.Location = new Point(-1, 0);
            WebViewHTMLResponse.Name = "WebViewHTMLResponse";
            WebViewHTMLResponse.Size = new Size(787, 163);
            WebViewHTMLResponse.TabIndex = 0;
            WebViewHTMLResponse.ZoomFactor = 1D;
            // 
            // ListBoxResponseHistory
            // 
            ListBoxResponseHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ListBoxResponseHistory.FormattingEnabled = true;
            ListBoxResponseHistory.ItemHeight = 15;
            ListBoxResponseHistory.Location = new Point(12, 41);
            ListBoxResponseHistory.Name = "ListBoxResponseHistory";
            ListBoxResponseHistory.Size = new Size(264, 394);
            ListBoxResponseHistory.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 450);
            Controls.Add(ListBoxResponseHistory);
            Controls.Add(TabControlResults);
            Controls.Add(TabControlRequestParameters);
            Controls.Add(ButtonSendRequest);
            Controls.Add(TextBoxUrl);
            Controls.Add(ComboBoxMethodSelection);
            MinimumSize = new Size(1108, 489);
            Name = "Form1";
            Text = "Poster";
            Resize += OnFormResized;
            TabControlRequestParameters.ResumeLayout(false);
            TabPageParameters.ResumeLayout(false);
            TabPageParameters.PerformLayout();
            PanelParameters.ResumeLayout(false);
            PanelParameters.PerformLayout();
            TabControlResults.ResumeLayout(false);
            TabPageRawResults.ResumeLayout(false);
            TabPageJSONResults.ResumeLayout(false);
            TabPagHTMLResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)WebViewHTMLResponse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxMethodSelection;
        private TextBox TextBoxUrl;
        private Button ButtonSendRequest;
        private TabControl TabControlRequestParameters;
        private TabPage TabPageParameters;
        private TabPage TabPageAuthentication;
        private TabControl TabControlResults;
        private TabPage TabPageRawResults;
        private TabPage TabPageJSONResults;
        private Label LabelValue;
        private Label LabelKey;
        private TextBox TextBoxParameterKey;
        private TextBox TextBoxParameterValue;
        private CheckBox CheckBoxIsParameterEnabled;
        private Button ButtonDeleteParameter;
        private Panel PanelParameters;
        private TabPage TabPagHTMLResults;
        private RichTextBox RichTextBoxRaw;
        private RichTextBox RichTextBoxJSON;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebViewHTMLResponse;
        private ListBox ListBoxResponseHistory;
    }
}