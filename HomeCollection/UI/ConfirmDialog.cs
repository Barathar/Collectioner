using HomeCollection.Utility;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeCollection.UI
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog()
        {
            InitializeComponent();

            saveButton.FlatAppearance.BorderSize = 0;
            discardButton.FlatAppearance.BorderSize = 0;
            cancelbutton.FlatAppearance.BorderSize = 0;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            UpdateAppearance();
        }

        private void UpdateAppearance()
        {
            BackColor = StyleManager.AlternatingBack;
            infoLabel.ForeColor = StyleManager.AlternatingFore;     
            infoLabel.Font = new Font(StyleManager.Font.FontFamily, StyleManager.Font.Size * 1.6f, StyleManager.Font.Style);

            saveButton.Font = StyleManager.Font;
            saveButton.BackColor = StyleManager.HighlightBack;
            saveButton.ForeColor = StyleManager.HighlightFore;
            discardButton.Font = StyleManager.Font;
            discardButton.BackColor = StyleManager.HighlightBack;
            discardButton.ForeColor = StyleManager.HighlightFore;
            cancelbutton.Font = StyleManager.Font;
            cancelbutton.BackColor = StyleManager.HighlightBack;
            cancelbutton.ForeColor = StyleManager.HighlightFore;            
        }
    }
}
