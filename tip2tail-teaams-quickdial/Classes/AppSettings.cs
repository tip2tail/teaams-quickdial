using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tip2tail_teaams_quickdial.JSON;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace tip2tail_teaams_quickdial.Classes
{
    internal static class AppSettings
    {
        public static Settings Current;

        private static Settings _default;
        private static Settings _user;

        public static void Init()
        {
            // Load default settings
            var path = Path.Combine(Program.AppPath, "DefaultSettings.json");
            if (!File.Exists(path))
            {
                throw new Exception("The default settings file was not found - fatal error");
            }
            _default = Settings.FromJson(File.ReadAllText(path));

            // Load the user saved settings
            path = Path.Combine(Program.AppPath, "UserSettings.json");
            if (File.Exists(path))
            {
                // There are user overrides so load these for use
                _user = Settings.FromJson(File.ReadAllText(path));
            }
            else
            {
                _user = _default;
            }

            // Combine the two
            Current = _default;
            CopyValues(Current, _user);
        }

        public static void ResetToLastSaved()
        {
            Current = null;
            _default = null;
            _user = null;
            Init();
        }

        public static void Save()
        {
            var json = Current.ToJson();
            var path = Path.Combine(Program.AppPath, "UserSettings.json");
            File.WriteAllText(path, json);
        }

        public static string GetJson()
        {
            return Current.ToJson();
        }

        public static bool SetJson(string json)
        {
            try
            {
                // Load default settings
                var path = Path.Combine(Program.AppPath, "DefaultSettings.json");
                if (!File.Exists(path))
                {
                    throw new Exception("The default settings file was not found - fatal error");
                }
                var _default = Settings.FromJson(File.ReadAllText(path));

                // Load the imported settings
                var _imported = Settings.FromJson(json);

                // Combine the two
                var fullImported = _default;
                CopyValues(fullImported, _imported);

                // Got here?  All good!
                Current = fullImported;
                return true;
            }
            catch (Exception ex)
            {
                Dialogs.Error("The JSON settings file that was imported is invalid.  No settings have been changed.");
                // MiscHelpers.Log("SETTINGS-IMPORT", ex.Message);
            }
            return false;
        }

        public static void CopyValues<T>(T target, T source)
        {
            Type t = typeof(T);
            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            foreach (var prop in properties)
            {
                var value = prop.GetValue(source, null);
                if (value != null)
                {
                    prop.SetValue(target, value, null);
                }
            }
        }
    }
}
