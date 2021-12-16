using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Types;
using Wifi.PlaylistEditor.UI.Properties;
//using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.UI
{
    public partial class Form1 : Form
    {
        private IPlaylist _playlist;
        private INewPlaylistCreator _newPlaylistCreator;
        private IPlaylistItemFactory _itemFactory;
        private IRepositoryFactory _repositoyFactory;
        

        //Fields
        private int borderSize = 2;
        ////private RepositoryFactory _repositoryFactory;
        //private PlaylistItemFactory itemFactory;
        //private RepositoryFactory repositoryFactory;


        //Constructor
        public Form1(IPlaylistItemFactory itemFactory, IRepositoryFactory _repositoryFactory, INewPlaylistCreator newPlaylistCreator)
        {
            InitializeComponent();

            //Start the Program with the Left Menu in Collapst Version
            CollapsMenu();
            this.Padding = new System.Windows.Forms.Padding(borderSize);
            _newPlaylistCreator = new frmNewPlaylist();
            _itemFactory = itemFactory;


            //this.BackColor = Color.FromArgb(220, 193, 176);
        }

        //public Form1(PlaylistItemFactory itemFactory, RepositoryFactory repositoryFactory)
        //{
        //    this.itemFactory = itemFactory;
        //    this.repositoryFactory = repositoryFactory;
        //}

        //Import the user32.dll from the System folder
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Make the Top Menu, work like the Program Title Bar. So the Program could be moved with Left click and holding on the Top Menu
        private void panel_TopMenue_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
        //protected override void WndProc(ref Message m)
        //{
        //    //Definition: https://docs.microsoft.com/en-us/windows/win32/winmsg/wm-nccalcsize
        //    const int WM_NCCALCSIZE = 0x0083;
        //    if ((m.Msg == WM_NCCALCSIZE) && (m.WParam.ToInt32() == 1))
        //    {
        //        return;
        //    }
        //    base.WndProc(ref m);
        //}

        //Reposition the Padding if the Window is Maximizied
        private void Form1_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 7, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;

            }
        }

        //Minimize the Windows
        private void btn_MinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Maximize the Windows
        private void btn_MaximizeApp_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState -= FormWindowState.Maximized;
            }
            
        }

        //Close the Application
        private void btn_CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MenuBurger_Click(object sender, EventArgs e)
        {
            CollapsMenu();
        }

        //Minimize and Maximize the left Control Panel
        private void CollapsMenu()
        {
            if (this.panel_ControlLeft.Width > 101)
            {
                panel_ControlLeft.Width = 100;
                pictureBox_Logo.Visible = false;
                btn_MenuBurger.Dock = DockStyle.Top;
                foreach (Button menuButton in panel_ControlLeft.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panel_ControlLeft.Width = 180;
                pictureBox_Logo.Visible = true;
                btn_MenuBurger.Dock = DockStyle.None;
                foreach (Button menuButton in panel_ControlLeft.Controls.OfType<Button>())
                {
                    menuButton.Text = "    " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(10, 0, 0, 0);

                }
            }
        }

        //Override system default Window Methods
        //Based on: https://rjcodeadvance.com/final-modern-ui-aero-snap-window-resizing-sliding-menu-c-winforms/
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112; 
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                var formSize = this.ClientSize;
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            if (_newPlaylistCreator.OpenDialog() != DialogResult.OK)
            {
                return;
            }

            _playlist = new Playlist(_newPlaylistCreator.Title,
                _newPlaylistCreator.Author,
                _newPlaylistCreator.CreateAt);

            UpdateView();
            //frmNewPlaylist frmNewPlaylist = new frmNewPlaylist();
            //frmNewPlaylist.ShowDialog();
        }

        private void UpdateView()
        {
            lbl_RightPlaylistName.Text = $"Name: {_playlist.Name}";
            lbl_RightPlaylistDuration.Text = $"Duration: {_playlist.Duration}";
            lbl_RightPlaylistAuthor.Text = $"Author: {_playlist.Author}";
            lbl_RightPlaylistCreateDate.Text = $"Create Date: {_playlist.CreateDate}";
            UpdateListViewItems();
        }

        private void UpdateListViewItems()
        {
            int index = 0;

            lv_Center_AllItems.Items.Clear();
            imageList1.Images.Clear();
            lv_Center_AllItems.LargeImageList = imageList1;

            foreach (var playlist_Item in _playlist.Items)
            {
                var listViewItem = new ListViewItem(playlist_Item.Title);
                if (playlist_Item.Thumbnail != null)
                {
                    imageList1.Images.Add(playlist_Item.Thumbnail);
                }
                else
                {
                    imageList1.Images.Add(Resources.No_image);
                }
                //imageList1.Images.Add(playlist_Item.Thumbnail);
                
                listViewItem.ImageIndex = index;
                listViewItem.Tag = playlist_Item;
                
                lv_Center_AllItems.Items.Add(listViewItem);
                index++;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearView();
            //EnablePlaylistControls(false);
        }

        private void EnablePlaylistControls(bool isEnabled)
        {
            lv_Center_AllItems.Enabled = isEnabled;
            menuItemItems.Enabled = isEnabled;
            menuItemSave.Enabled = isEnabled;
        }

        private void ClearView()
        {
            lbl_RightPlaylistName.Text = string.Empty;
            lbl_RightPlaylistDuration.Text = string.Empty;
            lbl_RightPlaylistAuthor.Text = string.Empty;
            lbl_RightPlaylistCreateDate.Text = string.Empty;
        }
        private void panel_SongDetails_Paint(object sender, PaintEventArgs e)
        {            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemAdd_Click(object sender, EventArgs e)
        {
            ConfigureFileDialog(openFileDialog1, "Bitte Item auswählen:", true,
                _itemFactory.AvailableTypes);
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            foreach (var file in openFileDialog1.FileNames)
            {
                var newItem = _itemFactory.Create(file);
                if (newItem != null)
                {
                    _playlist.Add(newItem);
                    EnablePlaylistControls(true);
                }
            }

            UpdateView();
        }

        private void ConfigureFileDialog(FileDialog fileDialog, string dialogTitle, 
            bool enableMultiSelection, IEnumerable<IFileIdentifier> availableTypes)
        {
            fileDialog.Title = dialogTitle;
            if (fileDialog is OpenFileDialog openFileDialog)
            {
                openFileDialog.Multiselect = enableMultiSelection;
            }

            var filterString = string.Empty;
            availableTypes.ToList().ForEach(x => filterString += $"{x.Description}|*{x.Extension}|");
            filterString = filterString.Remove(filterString.Length - 1, 1);

            fileDialog.Filter = filterString;
        }

        //private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        //{

        //}

        private void menuItemRemove_Click(object sender, EventArgs e)
        {
            if (lv_Center_AllItems.SelectedItems == null || lv_Center_AllItems.SelectedItems.Count == 0)
            {
                return;
            }

            foreach (ListViewItem selectedItem in lv_Center_AllItems.SelectedItems)
            {
                var playlistItem = selectedItem.Tag as IPlaylistItem;

                if (playlistItem != null)
                {
                    _playlist.Remove(playlistItem);
                }
            }

            UpdateView();
        }

        private void menuItemClearAll_Click(object sender, EventArgs e)
        {
            _playlist.Clear();
            UpdateView();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            ConfigureFileDialog(openFileDialog1, "Playlist auswählen", false,
                _repositoyFactory.AvailableTypes);

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            //F12 => Geht zur definition und mit strg + - kommt man wieder zurück
            IRepository repository = _repositoyFactory.Create(saveFileDialog1.FileName);
            if (repository != null)
            {
                repository.Save(_playlist, saveFileDialog1.FileName);
            }
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            ConfigureFileDialog(openFileDialog1, "Playlist auswählen", false,
                _repositoyFactory.AvailableTypes);

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var repository = _repositoyFactory.Create(openFileDialog1.FileName);
            if (repository == null)
            {
                //Nicht unterstütztes Dateiformat!!!!
                return;
            }

            _playlist = repository.Load(openFileDialog1.FileName);
            EnablePlaylistControls(true);
            UpdateView();

        }
    }
}