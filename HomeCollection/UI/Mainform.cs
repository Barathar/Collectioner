using HomeCollection.Data;
using HomeCollection.Http;
using HomeCollection.Interfaces;
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
    public enum CollectionMode
    {
        Boardgame,
        Videogame,
        CD,
        DVD,
        Book
    }

    public partial class mainform : Form
    {
        // TODO implement Autosave

        private CollectionMode mode;
        private IDatabase database;
        private ImageList imageList = new ImageList();
        private bool modified = false;

        public mainform()
        {
            InitializeComponent();
            UpdateAppearance();

            mode = CollectionMode.Boardgame;
            InitializeDatabase();
            ToggleView();
        }

        private void OnDatabaseChanged(object sender, EventArgs e)
        {
            UpdateListViews();
            modified = true;
        }

        private void OnMenuSaveClicked(object sender, EventArgs e)
        {
            SaveDatabase();
        }
        private void OnMenuExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnMenuBoardgamesClicked(object sender, EventArgs e)
        {
            if (HandleSaveChanges() == DialogResult.OK)
                SelectBoardgameMode();
        }
        private void OnMenuVideogamesClicked(object sender, EventArgs e)
        {
            if (HandleSaveChanges() == DialogResult.OK)
                SelectVideogameMode();
        }

        private void OnButtonSaveClicked(object sender, EventArgs e)
        {
            SaveDatabase();
        }
        private void OnButtonAddClicked(object sender, EventArgs e)
        {
            HandleAddItem();
        }
        private void OnToggleViewButtonClicked(object sender, EventArgs e)
        {
            ToggleView();
        }
        private void OnItemDoubleClicked(object sender, EventArgs e)
        {
            HandleModifyItem();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                HandleDeleteItem();
        }

        private void InitializeDatabase()
        {
            switch (mode)
            {
                case CollectionMode.Boardgame:
                    database = new BoardgameDatabase();
                    break;
                case CollectionMode.Videogame:
                    database = new VideogameDatabase();
                    break;
                case CollectionMode.CD:
                    break;
                case CollectionMode.DVD:
                    break;
                case CollectionMode.Book:
                    break;
                default:
                    break;
            }

            database.DatabaseChanged += OnDatabaseChanged;
            LoadDatabase();
        }
        private void LoadDatabase()
        {
            database.LoadDatabase();
            modified = false;
        }
        private void SaveDatabase()
        {
            database.SaveDatabase();
            modified = false;
        }
        private void ToggleView()
        {
            if (itemListView.View == View.LargeIcon)
                ChangeToListView();
            else
                ChangeToTileView();
        }
        private void ChangeToListView()
        {
            itemListView.SmallImageList = imageList;
            itemListView.View = View.List;
            imageList.ImageSize = new Size(20, 20);
            UpdateListViews();
        }
        private void ChangeToTileView()
        {
            itemListView.LargeImageList = imageList;
            itemListView.View = View.LargeIcon;
            imageList.ImageSize = new Size(150, 150);
            UpdateListViews();
        }
        private void SelectBoardgameMode()
        {
            mode = CollectionMode.Boardgame;

            StyleManager.ChangeColorTheme(mode);
            UpdateAppearance();            
            InitializeDatabase();
            UpdateListViews();
        }
        private void SelectVideogameMode()
        {
            mode = CollectionMode.Videogame;

            StyleManager.ChangeColorTheme(mode);
            UpdateAppearance();            
            InitializeDatabase();
            UpdateListViews();
        }
        private void HandleAddItem()
        {
            ItemDialog dialog = new ItemDialog();
            dialog.Item = CreateItem();
            dialog.ShowDialog();

            database.Add(dialog.Item);
        }
        private void HandleModifyItem()
        {
            if (itemListView.SelectedItems.Count <= 0)
                return;

            ItemDialog dialog = new ItemDialog();
            dialog.Item = itemListView.SelectedItems[0].Tag;
            dialog.ShowDialog();

            database.Modify(dialog.Item);
        }
        private void HandleDeleteItem()
        {
            if (itemListView.SelectedItems.Count > 0)
                database.Delete(itemListView.SelectedItems[0].Tag);
        }
        private DialogResult HandleSaveChanges()
        {
            if (!modified)
                return DialogResult.OK;

            ConfirmDialog dialog = new ConfirmDialog();
            switch (dialog.ShowDialog())
            {
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                case DialogResult.Yes:
                    SaveDatabase();
                    return DialogResult.OK;
                case DialogResult.No:
                    return DialogResult.OK;
                default:
                    return DialogResult.Cancel;
            }
        }
        private object CreateItem()
        {
            switch (mode)
            {
                case CollectionMode.Boardgame:
                    return new Boardgame();
                case CollectionMode.Videogame:
                    return new Videogame();
                //case CollectionMode.CD:
                //    break;
                //case CollectionMode.DVD:
                //    break;
                //case CollectionMode.Book:
                //    break;
                default:
                    return null;
            }
        }

        private void UpdateListViews()
        {
            UpdateItemListView();
            UpdateGroupListView();
        }
        private void UpdateItemListView()
        {
            itemListView.Clear();

            foreach (IListViewPresentation current in database.GetEntries())
            {
                ListViewItem item = new ListViewItem();
                item.Tag = current;
                item.Text = current.DisplayText;

                if (current.DisplayImage != null)
                {
                    imageList.Images.Add(current.ItemReference.ToString(), current.DisplayImage);
                    item.ImageKey = current.ItemReference.ToString();
                }

                itemListView.Items.Add(item);
            }
        }
        private void UpdateGroupListView()
        {

        }
        private void UpdateAppearance()
        {
            BackColor = StyleManager.MainBack;
            ForeColor = StyleManager.MainFore;
            mainMenuStrip.BackColor = StyleManager.MainBack;
            mainMenuStrip.ForeColor = StyleManager.MainFore;
            mainMenuStrip.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 0.9f, FontStyle.Regular);
            fileMenuItem.BackColor = StyleManager.MainBack;
            fileMenuItem.ForeColor = StyleManager.MainFore;
            collectionsMenuItem.BackColor = StyleManager.MainBack;
            collectionsMenuItem.ForeColor = StyleManager.MainFore;
            mainToolStrip.BackColor = StyleManager.MainBack;
            mainToolStrip.ForeColor = StyleManager.MainFore;
            saveToolStripButton.BackColor = StyleManager.HighlightBack;
            saveToolStripButton.ForeColor = StyleManager.HighlightFore;
            saveToolStripButton.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 0.9f, FontStyle.Regular);
            addToolStripButton.BackColor = StyleManager.HighlightBack;
            addToolStripButton.ForeColor = StyleManager.HighlightFore;
            addToolStripButton.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 0.9f, FontStyle.Regular);
            viewToggletoolStripButton.BackColor = StyleManager.HighlightBack;
            viewToggletoolStripButton.ForeColor = StyleManager.HighlightFore;
            viewToggletoolStripButton.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 0.9f, FontStyle.Regular);
            itemListView.BackColor = StyleManager.MainBack;
            itemListView.ForeColor = StyleManager.MainFore;
            itemListView.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 0.9f, FontStyle.Regular);
            groupListView.BackColor = StyleManager.MainBack;
            groupListView.ForeColor = StyleManager.MainFore;
            itemListView.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 0.9f, FontStyle.Regular);
        }
    }
}
