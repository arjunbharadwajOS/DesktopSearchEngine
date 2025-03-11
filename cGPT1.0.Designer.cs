namespace cGPT
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtChatSearchBox = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            txtSearchResults = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            helpButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtChatSearchBox
            // 
            txtChatSearchBox.Location = new Point(305, 87);
            txtChatSearchBox.Multiline = true;
            txtChatSearchBox.Name = "txtChatSearchBox";
            txtChatSearchBox.Size = new Size(458, 88);
            txtChatSearchBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            label1.Location = new Point(203, 156);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 1;
            label1.Text = "Chat Message";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(769, 144);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(73, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search >>";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(txtSearchResults);
            panel1.Location = new Point(12, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 504);
            panel1.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(396, 192);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(252, 24);
            progressBar1.TabIndex = 7;
            progressBar1.Visible = false;
            // 
            // txtSearchResults
            // 
            txtSearchResults.Location = new Point(7, 10);
            txtSearchResults.Name = "txtSearchResults";
            txtSearchResults.ReadOnly = true;
            txtSearchResults.Size = new Size(1016, 479);
            txtSearchResults.TabIndex = 0;
            txtSearchResults.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            label2.Location = new Point(19, 182);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Results";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(408, 38);
            label3.Name = "label3";
            label3.Size = new Size(275, 32);
            label3.TabIndex = 6;
            label3.Text = "Desktop Search Engine";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.RosyBrown;
            imageList1.Images.SetKeyName(0, "1009849-200.png");
            // 
            // helpButton
            // 
            helpButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            helpButton.Location = new Point(1021, 2);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(44, 39);
            helpButton.TabIndex = 7;
            helpButton.Text = "?";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 720);
            Controls.Add(helpButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtChatSearchBox);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "cGPT 1.0";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtChatSearchBox;
        private Label label1;
        private Button btnSearch;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private RichTextBox txtSearchResults;
        private ImageList imageList1;
        private Button helpButton;
    }
}