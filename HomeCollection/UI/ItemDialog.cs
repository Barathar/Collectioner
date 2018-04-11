using HomeCollection.Data;
using HomeCollection.Events;
using HomeCollection.Http;
using HomeCollection.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCollection.UI
{
    public partial class ItemDialog : Form
    {
        private bool enlarged = false;
        private Timer typingTimer;
        private BoardgameGeekApi api = new BoardgameGeekApi();
        private object searchedItem;
        private object item;

        public object Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                UpdateControls();
            }
        }

        public ItemDialog()
        {
            InitializeComponent();
            RegisterEvents();
            ResizeDialog();
            UpdateControls();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            UpdateAppearance();
        }

        private void OnPanelDoubleClicked(object sender, MouseEventArgs e)
        {
            ResizeDialog();
        }
        private void OnTransferButtonClicked(object sender, EventArgs e)
        {
            if (searchedItem != null)
                item = searchedItem;

            UpdateControls();
        }

        private void OnBoardgameSearchompleted(object sender, BoardgameEventArgs e)
        {
            searchedItem = e.Boardgame;
            searchResultListView.Visible = true;
            UpdateControls();
        }
        private void OnBoardgamesSearchCompleted(object sender, BoardgameSearchEventArgs e)
        {
            searchResultListView.Items.Clear();
            foreach (var game in e.Result)
            {
                ListViewItem item = new ListViewItem(game.Name);
                item.Tag = game;
                searchResultListView.Items.Add(item);
            }

            searchTextBox.Enabled = true;
        }
        private void OnBoardgameSearch(object sender, EventArgs e)
        {
            if (typingTimer == null)
            {
                typingTimer = new Timer();
                typingTimer.Interval = 1000;
                typingTimer.Tick += new EventHandler(OnTypingTimerTimeout);
            }
            typingTimer.Stop();
            typingTimer.Tag = (sender as TextBox).Text;
            typingTimer.Start();
        }
        private void OnTypingTimerTimeout(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;
            if (timer == null)
                return;

            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                searchTextBox.Enabled = false;
                api.RequestBoardgameSearch(searchTextBox.Text);
            }

            timer.Stop();
        }
        private void OnWebResultDoubleClicked(object sender, EventArgs e)
        {
            int selection = searchResultListView.SelectedIndices[0];
            BoardgameGeekApiResult game = searchResultListView.Items[selection].Tag as BoardgameGeekApiResult;

            api.RequestBoardgame(game.Id);
            searchResultListView.Visible = false;
        }

        private void RegisterEvents()
        {
            api.RequestBoardgameCompleted += OnBoardgameSearchompleted;
            api.RequestBoardgameSearchCompleted += OnBoardgamesSearchCompleted;
        }

        private void UpdateControls()
        {
            originalPropertyGrid.SelectedObject = item;
            webPropertyGrid.SelectedObject = searchedItem;

            transferButton.Visible = searchedItem != null;
        }
        private void ResizeDialog()
        {
            splitContainer.SplitterDistance = enlarged ? (int)(Size.Width * 0.3) : Size.Width - 10;
            enlarged = !enlarged;
        }        
        private void UpdateAppearance()
        {
            BackColor = StyleManager.MainBack;

            originalPanel.BackColor = StyleManager.AlternatingBack;
            originalPropertyGrid.Font = StyleManager.Font;
            originalPropertyGrid.BackColor = StyleManager.AlternatingBack;
            originalPropertyGrid.LineColor = StyleManager.AlternatingBack;
            originalPropertyGrid.ViewBackColor = StyleManager.AlternatingBack;
            originalPropertyGrid.ViewForeColor = StyleManager.AlternatingFore;
            originalPropertyGrid.ViewBorderColor = StyleManager.AlternatingBack;
            originalPropertyGrid.SelectedItemWithFocusBackColor = StyleManager.HighlightBack;
            originalPropertyGrid.SelectedItemWithFocusForeColor = StyleManager.HighlightFore;
            originalPropertyGrid.HelpBackColor = StyleManager.MainBack;
            originalPropertyGrid.HelpBorderColor = StyleManager.MainBack;
            originalPropertyGrid.CommandsBackColor = StyleManager.AlternatingBack;
            originalPropertyGrid.CommandsBorderColor = StyleManager.AlternatingBack;
            originalPropertyGrid.CategoryForeColor = StyleManager.AlternatingFore;

            webPanel.BackColor = StyleManager.MainBack;
            webPropertyGrid.Font = StyleManager.Font;
            webPropertyGrid.BackColor = StyleManager.MainBack;
            webPropertyGrid.LineColor = StyleManager.MainBack;
            webPropertyGrid.ViewBackColor = StyleManager.MainBack;
            webPropertyGrid.ViewForeColor = StyleManager.MainFore;
            webPropertyGrid.ViewBorderColor = StyleManager.MainBack;
            webPropertyGrid.SelectedItemWithFocusBackColor = StyleManager.HighlightBack;
            webPropertyGrid.SelectedItemWithFocusForeColor = StyleManager.HighlightFore;
            webPropertyGrid.HelpBackColor = StyleManager.AlternatingBack;
            webPropertyGrid.HelpBorderColor = StyleManager.AlternatingBack;
            webPropertyGrid.CommandsBackColor = StyleManager.MainBack;
            webPropertyGrid.CommandsBorderColor = StyleManager.MainBack;
            webPropertyGrid.CategoryForeColor = StyleManager.MainFore;

            searchResultListView.BackColor = StyleManager.MainBack;
            searchResultListView.Font = StyleManager.Font;

            cancelButton.FlatAppearance.BorderSize = 0;            

            searchTextBox.BackColor = StyleManager.AlternatingBack;
            searchTextBox.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 1.5f, StyleManager.Font.Style);

            transferButton.FlatAppearance.BorderSize = 0;
            transferButton.BackColor = StyleManager.HighlightBack;
            transferButton.ForeColor = StyleManager.HighlightFore;
            transferButton.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 1.3f, StyleManager.Font.Style);
        }
    }
}
