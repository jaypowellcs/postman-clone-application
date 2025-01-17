namespace PostmanCloneUI
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            FormHeader = new Label();
            apiLabel = new Label();
            apitext = new TextBox();
            callAPI = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            httpVerbSelection = new ComboBox();
            httpVerbLabel = new Label();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodytext = new TextBox();
            outputTab = new TabPage();
            resultstext = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            outputTab.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            FormHeader.AutoSize = true;
            FormHeader.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormHeader.Location = new Point(43, 38);
            FormHeader.Name = "FormHeader";
            FormHeader.Size = new Size(344, 65);
            FormHeader.TabIndex = 0;
            FormHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(43, 233);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(60, 32);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API: ";
            // 
            // apitext
            // 
            apitext.BorderStyle = BorderStyle.FixedSingle;
            apitext.Location = new Point(109, 226);
            apitext.Name = "apitext";
            apitext.Size = new Size(753, 39);
            apitext.TabIndex = 2;
            // 
            // callAPI
            // 
            callAPI.BackColor = Color.DimGray;
            callAPI.ForeColor = SystemColors.ButtonHighlight;
            callAPI.Location = new Point(903, 225);
            callAPI.Name = "callAPI";
            callAPI.Size = new Size(139, 39);
            callAPI.TabIndex = 3;
            callAPI.Text = "Go";
            callAPI.UseVisualStyleBackColor = false;
            callAPI.Click += callAPI_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 748);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1122, 35);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(69, 30);
            systemStatus.Text = "Ready";
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PATCH", "DELETE" });
            httpVerbSelection.Location = new Point(211, 143);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(115, 40);
            httpVerbSelection.TabIndex = 7;
            // 
            // httpVerbLabel
            // 
            httpVerbLabel.AutoSize = true;
            httpVerbLabel.Location = new Point(43, 151);
            httpVerbLabel.Name = "httpVerbLabel";
            httpVerbLabel.Size = new Size(162, 32);
            httpVerbLabel.TabIndex = 8;
            httpVerbLabel.Text = "Request Type:";
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(outputTab);
            callData.Location = new Point(43, 300);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(999, 416);
            callData.TabIndex = 9;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodytext);
            bodyTab.Location = new Point(4, 41);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(991, 371);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // bodytext
            // 
            bodytext.BackColor = SystemColors.ButtonHighlight;
            bodytext.Dock = DockStyle.Fill;
            bodytext.Location = new Point(3, 3);
            bodytext.Multiline = true;
            bodytext.Name = "bodytext";
            bodytext.ScrollBars = ScrollBars.Both;
            bodytext.Size = new Size(985, 365);
            bodytext.TabIndex = 6;
            // 
            // outputTab
            // 
            outputTab.Controls.Add(resultstext);
            outputTab.Location = new Point(4, 41);
            outputTab.Name = "outputTab";
            outputTab.Padding = new Padding(3);
            outputTab.Size = new Size(991, 371);
            outputTab.TabIndex = 1;
            outputTab.Text = "Results";
            outputTab.UseVisualStyleBackColor = true;
            // 
            // resultstext
            // 
            resultstext.Dock = DockStyle.Fill;
            resultstext.Location = new Point(3, 3);
            resultstext.Multiline = true;
            resultstext.Name = "resultstext";
            resultstext.ReadOnly = true;
            resultstext.ScrollBars = ScrollBars.Both;
            resultstext.Size = new Size(985, 365);
            resultstext.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1122, 783);
            Controls.Add(callData);
            Controls.Add(httpVerbLabel);
            Controls.Add(httpVerbSelection);
            Controls.Add(statusStrip);
            Controls.Add(callAPI);
            Controls.Add(apitext);
            Controls.Add(apiLabel);
            Controls.Add(FormHeader);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Dashboard";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            outputTab.ResumeLayout(false);
            outputTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormHeader;
        private Label apiLabel;
        private TextBox apitext;
        private Button callAPI;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox httpVerbSelection;
        private Label httpVerbLabel;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage outputTab;
        private TextBox bodytext;
        private TextBox resultstext;
        private ContextMenuStrip contextMenuStrip1;
    }
}
