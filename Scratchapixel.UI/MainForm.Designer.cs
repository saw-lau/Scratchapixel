namespace Scratchapixel.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            _selectionPanel = new Panel();
            _uriLinkLabel = new LinkLabel();
            _notesTextBox = new TextBox();
            _descriptionTextBox = new TextBox();
            _lessonsPanel = new FlowLayoutPanel();
            _nameLabel = new Label();
            _outputPanel = new Panel();
            _selectionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _selectionPanel
            // 
            _selectionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            _selectionPanel.BorderStyle = BorderStyle.FixedSingle;
            _selectionPanel.Controls.Add(_uriLinkLabel);
            _selectionPanel.Controls.Add(_notesTextBox);
            _selectionPanel.Controls.Add(_descriptionTextBox);
            _selectionPanel.Controls.Add(_lessonsPanel);
            _selectionPanel.Controls.Add(_nameLabel);
            _selectionPanel.Location = new Point(12, 12);
            _selectionPanel.Name = "_selectionPanel";
            _selectionPanel.Size = new Size(200, 426);
            _selectionPanel.TabIndex = 0;
            // 
            // _uriLinkLabel
            // 
            _uriLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _uriLinkLabel.AutoEllipsis = true;
            _uriLinkLabel.Location = new Point(3, 401);
            _uriLinkLabel.Name = "_uriLinkLabel";
            _uriLinkLabel.Size = new Size(192, 23);
            _uriLinkLabel.TabIndex = 3;
            _uriLinkLabel.LinkClicked += UriLinkLabel_LinkClicked;
            // 
            // _notesTextBox
            // 
            _notesTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _notesTextBox.BorderStyle = BorderStyle.None;
            _notesTextBox.Location = new Point(3, 271);
            _notesTextBox.Multiline = true;
            _notesTextBox.Name = "_notesTextBox";
            _notesTextBox.ReadOnly = true;
            _notesTextBox.Size = new Size(192, 127);
            _notesTextBox.TabIndex = 2;
            _notesTextBox.Text = "Notes.";
            // 
            // _descriptionTextBox
            // 
            _descriptionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _descriptionTextBox.BorderStyle = BorderStyle.None;
            _descriptionTextBox.Location = new Point(3, 127);
            _descriptionTextBox.Multiline = true;
            _descriptionTextBox.Name = "_descriptionTextBox";
            _descriptionTextBox.ReadOnly = true;
            _descriptionTextBox.Size = new Size(192, 138);
            _descriptionTextBox.TabIndex = 1;
            _descriptionTextBox.Text = "Lesson Description";
            // 
            // _lessonsPanel
            // 
            _lessonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _lessonsPanel.Location = new Point(3, 3);
            _lessonsPanel.Name = "_lessonsPanel";
            _lessonsPanel.Size = new Size(192, 97);
            _lessonsPanel.TabIndex = 0;
            // 
            // _nameLabel
            // 
            _nameLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _nameLabel.Location = new Point(3, 103);
            _nameLabel.Name = "_nameLabel";
            _nameLabel.Size = new Size(192, 21);
            _nameLabel.TabIndex = 0;
            _nameLabel.Text = "Lesson Name";
            _nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // _outputPanel
            // 
            _outputPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _outputPanel.BorderStyle = BorderStyle.FixedSingle;
            _outputPanel.Location = new Point(218, 12);
            _outputPanel.Name = "_outputPanel";
            _outputPanel.Size = new Size(570, 426);
            _outputPanel.TabIndex = 1;
            _outputPanel.Paint += OutputPanel_Paint;
            _outputPanel.Resize += OutputPanel_Resize;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_outputPanel);
            Controls.Add(_selectionPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Scratchapixel 4.0";
            Load += MainForm_Load;
            _selectionPanel.ResumeLayout(false);
            _selectionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel _selectionPanel;
        private Panel _outputPanel;
        private FlowLayoutPanel _lessonsPanel;
        private Label _nameLabel;
        private TextBox _descriptionTextBox;
        private TextBox _notesTextBox;
        private LinkLabel _uriLinkLabel;
    }
}
