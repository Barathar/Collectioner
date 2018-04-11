namespace HomeCollection.UI
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardgamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videogamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupListView = new System.Windows.Forms.ListView();
            this.itemListView = new System.Windows.Forms.ListView();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.viewToggletoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.collectionsMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(927, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileMenuItem.Text = "Datei";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveToolStripMenuItem.Text = "Speichern";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnMenuSaveClicked);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Enabled = false;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Beenden";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnMenuExitClicked);
            // 
            // collectionsMenuItem
            // 
            this.collectionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boardgamesToolStripMenuItem,
            this.videogamesToolStripMenuItem,
            this.cDsToolStripMenuItem,
            this.dVDsToolStripMenuItem,
            this.booksToolStripMenuItem});
            this.collectionsMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.collectionsMenuItem.Name = "collectionsMenuItem";
            this.collectionsMenuItem.Size = new System.Drawing.Size(90, 20);
            this.collectionsMenuItem.Text = "Sammlungen";
            // 
            // boardgamesToolStripMenuItem
            // 
            this.boardgamesToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.boardgamesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.boardgamesToolStripMenuItem.Name = "boardgamesToolStripMenuItem";
            this.boardgamesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.boardgamesToolStripMenuItem.Text = "Brettspiele";
            this.boardgamesToolStripMenuItem.Click += new System.EventHandler(this.OnMenuBoardgamesClicked);
            // 
            // videogamesToolStripMenuItem
            // 
            this.videogamesToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.videogamesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.videogamesToolStripMenuItem.Name = "videogamesToolStripMenuItem";
            this.videogamesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.videogamesToolStripMenuItem.Text = "Videospiele";
            this.videogamesToolStripMenuItem.Click += new System.EventHandler(this.OnMenuVideogamesClicked);
            // 
            // cDsToolStripMenuItem
            // 
            this.cDsToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.cDsToolStripMenuItem.Name = "cDsToolStripMenuItem";
            this.cDsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cDsToolStripMenuItem.Text = "CDs";
            // 
            // dVDsToolStripMenuItem
            // 
            this.dVDsToolStripMenuItem.BackColor = System.Drawing.Color.MediumPurple;
            this.dVDsToolStripMenuItem.Name = "dVDsToolStripMenuItem";
            this.dVDsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dVDsToolStripMenuItem.Text = "DVDs";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.BackColor = System.Drawing.Color.DeepPink;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.booksToolStripMenuItem.Text = "Bücher";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 66);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupListView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.itemListView);
            this.splitContainer.Size = new System.Drawing.Size(927, 510);
            this.splitContainer.SplitterDistance = 165;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // groupListView
            // 
            this.groupListView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupListView.Location = new System.Drawing.Point(0, 0);
            this.groupListView.Name = "groupListView";
            this.groupListView.Size = new System.Drawing.Size(165, 510);
            this.groupListView.TabIndex = 0;
            this.groupListView.UseCompatibleStateImageBehavior = false;
            // 
            // itemListView
            // 
            this.itemListView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.itemListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListView.ForeColor = System.Drawing.Color.White;
            this.itemListView.Location = new System.Drawing.Point(0, 0);
            this.itemListView.Margin = new System.Windows.Forms.Padding(0);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(761, 510);
            this.itemListView.TabIndex = 0;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.List;
            this.itemListView.DoubleClick += new System.EventHandler(this.OnItemDoubleClicked);
            this.itemListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.addToolStripButton,
            this.viewToggletoolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainToolStrip.Size = new System.Drawing.Size(927, 25);
            this.mainToolStrip.TabIndex = 3;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.BackColor = System.Drawing.Color.OrangeRed;
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.saveToolStripButton.Text = "Speichern";
            this.saveToolStripButton.Click += new System.EventHandler(this.OnButtonSaveClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.BackColor = System.Drawing.Color.OrangeRed;
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(73, 22);
            this.addToolStripButton.Text = "Hinzufügen";
            this.addToolStripButton.ToolTipText = "Hinzufügen";
            this.addToolStripButton.Click += new System.EventHandler(this.OnButtonAddClicked);
            // 
            // viewToggletoolStripButton
            // 
            this.viewToggletoolStripButton.BackColor = System.Drawing.Color.OrangeRed;
            this.viewToggletoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewToggletoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("viewToggletoolStripButton.Image")));
            this.viewToggletoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewToggletoolStripButton.Name = "viewToggletoolStripButton";
            this.viewToggletoolStripButton.Size = new System.Drawing.Size(91, 22);
            this.viewToggletoolStripButton.Text = "Ansicht ändern";
            this.viewToggletoolStripButton.Click += new System.EventHandler(this.OnToggleViewButtonClicked);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(927, 577);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "mainform";
            this.Text = "Sammlung";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem collectionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boardgamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videogamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton viewToggletoolStripButton;
    }
}

