namespace tip2tail_teaams_quickdial.Classes
{
    public class Dialogs
    {

        /// <summary>
        /// Error Message Dialog
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        public static void Error(string message, string? title = null)
        {
            if (string.IsNullOrEmpty(title))
            {
                title = $"ERROR";
            }
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Information Message Dialog
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        public static void Info(string message, string title = null)
        {
            if (string.IsNullOrEmpty(title))
            {
                title = "INFO";
            }
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Question Dialog
        /// </summary>
        /// <param name="question"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static bool Question(string question, string title = null)
        {
            if (string.IsNullOrEmpty(title))
            {
                title = "CONFIRM";
            }
            return MessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static bool Open(string ext, out string fileName)
        {
            fileName = string.Empty;
            var openDialog = new OpenFileDialog();
            openDialog.Filter = $"File (*.{ext})|*.{ext}";
            openDialog.Multiselect = false;
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
                return true;
            }
            return false;
        }

        public static bool Save(string ext, out string fileName)
        {
            fileName = string.Empty;
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = $"File (*.{ext})|*.{ext}";
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveDialog.FileName;
                return true;
            }
            return false;
        }
    }
}
