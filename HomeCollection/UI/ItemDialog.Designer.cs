namespace HomeCollection.UI
{
    partial class ItemDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.originalPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.originalPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.webPanel = new System.Windows.Forms.Panel();
            this.transferButton = new System.Windows.Forms.Button();
            this.searchResultListView = new System.Windows.Forms.ListView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.webPropertyGrid = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.originalPanel.SuspendLayout();
            this.webPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.originalPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.webPanel);
            this.splitContainer.Size = new System.Drawing.Size(1034, 558);
            this.splitContainer.SplitterDistance = 344;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 1;
            // 
            // originalPanel
            // 
            this.originalPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.originalPanel.Controls.Add(this.cancelButton);
            this.originalPanel.Controls.Add(this.originalPropertyGrid);
            this.originalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalPanel.Location = new System.Drawing.Point(0, 0);
            this.originalPanel.Name = "originalPanel";
            this.originalPanel.Size = new System.Drawing.Size(344, 558);
            this.originalPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(0, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(1, 1);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // originalPropertyGrid
            // 
            this.originalPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalPropertyGrid.CategoryForeColor = System.Drawing.Color.White;
            this.originalPropertyGrid.CommandsBorderColor = System.Drawing.Color.RoyalBlue;
            this.originalPropertyGrid.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.originalPropertyGrid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPropertyGrid.HelpBackColor = System.Drawing.Color.CornflowerBlue;
            this.originalPropertyGrid.HelpBorderColor = System.Drawing.Color.CornflowerBlue;
            this.originalPropertyGrid.HelpVisible = false;
            this.originalPropertyGrid.LineColor = System.Drawing.Color.RoyalBlue;
            this.originalPropertyGrid.Location = new System.Drawing.Point(12, 12);
            this.originalPropertyGrid.Name = "originalPropertyGrid";
            this.originalPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.originalPropertyGrid.SelectedItemWithFocusBackColor = System.Drawing.Color.OrangeRed;
            this.originalPropertyGrid.Size = new System.Drawing.Size(316, 473);
            this.originalPropertyGrid.TabIndex = 0;
            this.originalPropertyGrid.ToolbarVisible = false;
            this.originalPropertyGrid.ViewBackColor = System.Drawing.Color.RoyalBlue;
            this.originalPropertyGrid.ViewBorderColor = System.Drawing.Color.RoyalBlue;
            this.originalPropertyGrid.ViewForeColor = System.Drawing.Color.White;
            // 
            // webPanel
            // 
            this.webPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.webPanel.Controls.Add(this.transferButton);
            this.webPanel.Controls.Add(this.searchResultListView);
            this.webPanel.Controls.Add(this.searchTextBox);
            this.webPanel.Controls.Add(this.webPropertyGrid);
            this.webPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webPanel.Location = new System.Drawing.Point(0, 0);
            this.webPanel.Name = "webPanel";
            this.webPanel.Size = new System.Drawing.Size(689, 558);
            this.webPanel.TabIndex = 0;
            this.webPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnPanelDoubleClicked);
            // 
            // transferButton
            // 
            this.transferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.transferButton.BackColor = System.Drawing.Color.OrangeRed;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferButton.ForeColor = System.Drawing.Color.White;
            this.transferButton.Location = new System.Drawing.Point(359, 491);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(316, 55);
            this.transferButton.TabIndex = 1;
            this.transferButton.Text = "Übernehmen";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.OnTransferButtonClicked);
            // 
            // searchResultListView
            // 
            this.searchResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchResultListView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchResultListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResultListView.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultListView.ForeColor = System.Drawing.Color.White;
            this.searchResultListView.Location = new System.Drawing.Point(28, 41);
            this.searchResultListView.MultiSelect = false;
            this.searchResultListView.Name = "searchResultListView";
            this.searchResultListView.Size = new System.Drawing.Size(310, 505);
            this.searchResultListView.TabIndex = 6;
            this.searchResultListView.UseCompatibleStateImageBehavior = false;
            this.searchResultListView.View = System.Windows.Forms.View.List;
            this.searchResultListView.DoubleClick += new System.EventHandler(this.OnWebResultDoubleClicked);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(28, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(310, 23);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.OnBoardgameSearch);
            // 
            // webPropertyGrid
            // 
            this.webPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webPropertyGrid.CategoryForeColor = System.Drawing.Color.White;
            this.webPropertyGrid.CommandsBackColor = System.Drawing.Color.CornflowerBlue;
            this.webPropertyGrid.CommandsBorderColor = System.Drawing.Color.CornflowerBlue;
            this.webPropertyGrid.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.webPropertyGrid.Enabled = false;
            this.webPropertyGrid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webPropertyGrid.HelpBackColor = System.Drawing.Color.RoyalBlue;
            this.webPropertyGrid.HelpBorderColor = System.Drawing.Color.RoyalBlue;
            this.webPropertyGrid.HelpVisible = false;
            this.webPropertyGrid.LineColor = System.Drawing.Color.CornflowerBlue;
            this.webPropertyGrid.Location = new System.Drawing.Point(359, 12);
            this.webPropertyGrid.Name = "webPropertyGrid";
            this.webPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.webPropertyGrid.SelectedItemWithFocusBackColor = System.Drawing.Color.OrangeRed;
            this.webPropertyGrid.Size = new System.Drawing.Size(316, 473);
            this.webPropertyGrid.TabIndex = 1;
            this.webPropertyGrid.ToolbarVisible = false;
            this.webPropertyGrid.ViewBackColor = System.Drawing.Color.CornflowerBlue;
            this.webPropertyGrid.ViewBorderColor = System.Drawing.Color.CornflowerBlue;
            this.webPropertyGrid.ViewForeColor = System.Drawing.Color.White;
            // 
            // BoardgameDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1034, 558);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoardgameDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BoardgameDialog";
            this.Load += new System.EventHandler(this.OnLoad);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.originalPanel.ResumeLayout(false);
            this.webPanel.ResumeLayout(false);
            this.webPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel webPanel;
        private System.Windows.Forms.Panel originalPanel;
        private System.Windows.Forms.PropertyGrid originalPropertyGrid;
        private System.Windows.Forms.PropertyGrid webPropertyGrid;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListView searchResultListView;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Button cancelButton;
    }
}