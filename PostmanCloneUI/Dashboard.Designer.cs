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
            FormHeader = new Label();
            apiLabel = new Label();
            apitext = new TextBox();
            callAPI = new Button();
            resultstext = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FormHeader
            // 
            FormHeader.AutoSize = true;
            FormHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormHeader.Location = new Point(43, 43);
            FormHeader.Name = "FormHeader";
            FormHeader.Size = new Size(254, 47);
            FormHeader.TabIndex = 0;
            FormHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(43, 145);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(60, 32);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API: ";
            // 
            // apitext
            // 
            apitext.BorderStyle = BorderStyle.FixedSingle;
            apitext.Location = new Point(110, 138);
            apitext.Name = "apitext";
            apitext.Size = new Size(753, 39);
            apitext.TabIndex = 2;
            // 
            // callAPI
            // 
            callAPI.BackColor = Color.DimGray;
            callAPI.ForeColor = SystemColors.ButtonHighlight;
            callAPI.Location = new Point(903, 138);
            callAPI.Name = "callAPI";
            callAPI.Size = new Size(139, 39);
            callAPI.TabIndex = 3;
            callAPI.Text = "Go";
            callAPI.UseVisualStyleBackColor = false;
            callAPI.Click += callAPI_Click;
            // 
            // resultstext
            // 
            resultstext.BackColor = SystemColors.ButtonHighlight;
            resultstext.Location = new Point(43, 277);
            resultstext.Multiline = true;
            resultstext.Name = "resultstext";
            resultstext.ReadOnly = true;
            resultstext.ScrollBars = ScrollBars.Both;
            resultstext.Size = new Size(999, 217);
            resultstext.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 607);
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
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(43, 233);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(88, 32);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1122, 642);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultstext);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormHeader;
        private Label apiLabel;
        private TextBox apitext;
        private Button callAPI;
        private TextBox resultstext;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
