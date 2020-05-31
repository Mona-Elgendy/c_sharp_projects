using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadApp
{
    public partial class NotePadForm : Form
    {
        #region Fields
        private bool isFileAlreadySaved;
        private bool isFileDirty;
        private string currentOpenFileName;
        private FontDialog fontDialog = new FontDialog();

        #endregion;


        public NotePadForm()
        {
            InitializeComponent();
        }

        
       

        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Right Reserved for the Author","About Notepad App",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFileMenu();
        }

        private void NewFileMenu()
        {
            if (isFileDirty)
            {
                DialogResult result = MessageBox.Show("Do you want Save Changes ?", "File Save", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFileMenu();

                        break;
                    case DialogResult.No:

                        break;
                }
            }

            ClearScreen();

            isFileAlreadySaved = false;
            currentOpenFileName = "";
            EnablrDisableUndoRedoProcess(false);
            MessageToolStripStatusLabel.Text = "New Document is Created";
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileMenu();
        }

        private void OpenFileMenu()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);


                this.Text = Path.GetFileName(openFileDialog.FileName) + " - NotePad Application";


                isFileAlreadySaved = true;
                isFileDirty = false;
                currentOpenFileName = openFileDialog.FileName;

                EnablrDisableUndoRedoProcess(false);
                MessageToolStripStatusLabel.Text = "File Is Opened";
            }
        }

        private void EnablrDisableUndoRedoProcess(bool enable)
        {
            undoToolStripMenuItem.Enabled = enable;
            redoToolStripMenuItem.Enabled = enable;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFileMenue();
        }

        private void SaveAsFileMenue()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    MainRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);

                if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                    MainRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);

                this.Text = Path.GetFileName(saveFileDialog.FileName) + " - NotePad Application";


                isFileAlreadySaved = true;
                isFileDirty = false;
                currentOpenFileName = saveFileDialog.FileName;

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileMenu();
        }

        private void SaveFileMenu()
        {
            if (isFileAlreadySaved)
            {
                if (Path.GetExtension(currentOpenFileName) == ".txt")
                    MainRichTextBox.SaveFile(currentOpenFileName, RichTextBoxStreamType.PlainText);

                if (Path.GetExtension(currentOpenFileName) == ".rtf")
                    MainRichTextBox.SaveFile(currentOpenFileName, RichTextBoxStreamType.RichText);
                isFileDirty = false;
            }
            else
            {
                if (isFileDirty)
                {
                    SaveAsFileMenue();
                }
                else
                {
                    ClearScreen();
                }
            }
        }

        private void ClearScreen()
        {
            MainRichTextBox.Clear();
            this.Text = "Untitled - Notepad Application";
            isFileDirty = false;
        }

        private void NotePadForm_Load(object sender, EventArgs e)
        {
        isFileAlreadySaved =false;
        isFileDirty =false;
        currentOpenFileName="";
        if (Control.IsKeyLocked(Keys.CapsLock))
        {
            CapsToolStripStatusLabel.Text = "CAPS ON";
        }
        else
        {
            CapsToolStripStatusLabel.Text = "CAPS OFF";
            }
    }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            isFileDirty = true;
            undoToolStripMenuItem.Enabled = true;
            toolStripButton10.Enabled = true;
            undoToolStripMenuItem1.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoEditMenu();
        }

        private void UndoEditMenu()
        {
            MainRichTextBox.Undo();
            redoToolStripMenuItem.Enabled = true;
            
            undoToolStripMenuItem.Enabled = false;
            toolStripButton11.Enabled = true;
            toolStripButton10.Enabled = false;

            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Enabled = true;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedoEditmenu();
        }

        private void RedoEditmenu()
        {
            MainRichTextBox.Redo();
            redoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = true;
            toolStripButton11.Enabled = false;
            toolStripButton10.Enabled = true;

            undoToolStripMenuItem1.Enabled = true;
            redoToolStripMenuItem1.Enabled = false;
        }

        private void strikthroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Strikeout);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText = DateTime.Now.ToString();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Italic);
        }

        private void FormatText(FontStyle fontStyle)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, fontStyle);
        }

        private void underLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Underline);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Regular);
        }

        private void formatFontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.Apply += new System.EventHandler(fontDialog_Apply);
            
            

            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MainRichTextBox.SelectionLength >0)
                { 
                MainRichTextBox.SelectionFont = fontDialog.Font;
                MainRichTextBox.SelectionColor = fontDialog.Color;

                }

            }
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            if (MainRichTextBox.SelectionLength > 0)
            {
                MainRichTextBox.SelectionFont = fontDialog.Font;
                MainRichTextBox.SelectionColor = fontDialog.Color;

            }
        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (MainRichTextBox.SelectionLength > 0)
                {
                    MainRichTextBox.SelectionColor = colorDialog.Color;
                    

                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewFileMenu();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileMenu();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileMenu();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveAsFileMenue();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            UndoEditMenu();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            RedoEditmenu();
        }

        private void MainRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                CapsToolStripStatusLabel.Text = "CAPS ON";
            }
            else
            {
                CapsToolStripStatusLabel.Text = "CAPS OFF";
            }
        }

        private void stricktroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Regular);
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Bold);
        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Italic);
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormatText(FontStyle.Underline);
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UndoEditMenu();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RedoEditmenu();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MainRichTextBox.Cut();
            CutEditText();
        }

        private void CutEditText()
        {
            if (MainRichTextBox.SelectionLength > 0)
            {
                Clipboard.SetText(MainRichTextBox.SelectedText);
                MainRichTextBox.SelectedText = "";
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainRichTextBox.Copy();
            CopyEdittext();
        }

        private void CopyEdittext()
        {
            if (MainRichTextBox.SelectionLength > 0)
                Clipboard.SetText(MainRichTextBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainRichTextBox.Paste();
            PasteEditText();
        }

        private void PasteEditText()
        {
            if (Clipboard.ContainsText())
            {
                MainRichTextBox.SelectedText = Clipboard.GetText();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            PasteEditText();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PasteEditText();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CutEditText();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CopyEdittext();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            CutEditText();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CopyEdittext();
        }
    }
}
