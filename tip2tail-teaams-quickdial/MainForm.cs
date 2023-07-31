using Microsoft.WindowsAPICodePack.Taskbar;
using System.Reflection;
using System.Windows.Forms;
using tip2tail_teaams_quickdial.Classes;
using tip2tail_teaams_quickdial.JSON;

namespace tip2tail_teaams_quickdial
{
    public partial class MainForm : Form
    {
        private bool isEdit;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void CreateJumpList()
        {
            string cmdPath = Program.AppExe;

            // Create a new Jump List
            JumpList jumpList = JumpList.CreateJumpList();
            JumpListCustomCategory qdCategory = new JumpListCustomCategory("Quick Dial");

            // var maxCount = Math.Min(AppSettings.Current.Contacts.Count - 1, 4);
            var maxCount = AppSettings.Current.Contacts.Count - 1;
            List<IJumpListItem> items = new List<IJumpListItem>();
            for (int i = 0; i <= maxCount; i++)
            {
                items.Add(new JumpListLink(cmdPath, AppSettings.Current.Contacts[i].Name) { Arguments = $"--make-call {AppSettings.Current.Contacts[i].Mail}" });
            }

            qdCategory.AddJumpListItems(items.ToArray());
            jumpList.ClearAllUserTasks();
            jumpList.AddCustomCategories(qdCategory);
            jumpList.Refresh();
        }

        private void PopulateFields()
        {
            lstNames.Items.Clear();
            foreach (var contact in AppSettings.Current.Contacts)
            {
                lstNames.Items.Add(contact);
            }
            lstNames.SelectedIndex = -1;
            SetButtons();
        }

        private void SetButtons(bool editMode = false)
        {
            btnAdd.Enabled = !editMode;
            btnEdit.Enabled = !editMode;
            btnDelete.Enabled = !editMode;
            gbDetails.Enabled = editMode;
            lstNames.Enabled = !editMode;
            txtName.Clear();
            txtMail.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetButtons(true);
            txtName.Focus();
            isEdit = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex >= 0)
            {
                if (Dialogs.Question($"Delete \"{(lstNames.Items[lstNames.SelectedIndex] as Contact).Name}\"?"))
                {
                    AppSettings.Current.Contacts.Remove((lstNames.Items[lstNames.SelectedIndex] as Contact));
                    AppSettings.Save();
                    PopulateFields();
                    CreateJumpList();
                }
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            CreateJumpList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var contact = new Contact();
            if (isEdit)
            {
                contact = (lstNames.Items[lstNames.SelectedIndex] as Contact);
            }
            contact.Name = txtName.Text;
            contact.Mail = txtMail.Text;
            if (!isEdit)
            {
                contact.Id = Guid.NewGuid();
                AppSettings.Current.Contacts.Add(contact);
            }
            SetButtons();
            SetOrder();
            AppSettings.Save();
            PopulateFields();
            CreateJumpList();
        }

        private void SetOrder()
        {
            AppSettings.Current.Order.Clear();
            for (int i = 0; i < lstNames.Items.Count; i++)
            {
                AppSettings.Current.Order.Add((lstNames.Items[i] as Contact).Id);
            }
            AppSettings.Current.Contacts = AppSettings.Current.Contacts.OrderBy(
                item => AppSettings.Current.Order.IndexOf(item.Id)
            ).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetButtons(true);
            var selected = (lstNames.Items[lstNames.SelectedIndex] as Contact);
            txtName.Text = selected.Name;
            txtMail.Text = selected.Mail;
            txtName.Focus();
            isEdit = true;
        }

        private void lstNames_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstNames.SelectedItem == null)
            {
                return;
            }
            lstNames.DoDragDrop(lstNames.SelectedItem, DragDropEffects.Move);
        }

        private void lstNames_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstNames_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstNames.PointToClient(new Point(e.X, e.Y));
            int index = lstNames.IndexFromPoint(point);
            if (index < 0)
            {
                index = lstNames.Items.Count - 1;
            }
            object data = e.Data.GetData(typeof(Contact));
            lstNames.Items.Remove(data);
            lstNames.Items.Insert(index, data);
            SetOrder();
            AppSettings.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (WindowState != FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Minimized;
                    e.Cancel = true;
                }
            }
        }

        private void lstNames_Click(object sender, EventArgs e)
        {
            SetButtons();
        }
    }
}