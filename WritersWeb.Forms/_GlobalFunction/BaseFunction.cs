using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritersWeb.Func
{
    public class BFunc
    {
        public static class Tag
        {
            public static class Key
            {
                public static string SyncForm { get { return "sync_form"; } }
                public static string IsPopUpForm { get { return "is_popupform"; } }
                public static string IsButtonFormClose { get { return "is_btn_frm_close"; } }
                public static string IsFormLoaded { get { return "is_frm_loaded"; } }
                public static string IsFormReloadOnClick { get { return "is_frm_reload_onclick"; } }
                public static string BreadcrumbLabel { get { return "breadcrumb_label"; } }
                public static string BreadcrumbIcon { get { return "breadcrumb_icon"; } }
                public static string FuncBeforeShow { get { return "func_before_show"; } }
                public static string FuncOnClose { get { return "func_on_close"; } }
                public static string ParentForm { get { return "parent_form"; } }
                public static string FormType { get { return "form_type"; } }
                public static string LastForm { get { return "last_form"; } }
            }
            public static void Set(System.Windows.Forms.Control c, string key, object val)
            {
                Dictionary<string, object> d;
                if (c.Tag is Dictionary<string, object>)
                {
                    d = (Dictionary<string, object>)c.Tag;
                    if (d.ContainsKey(key)) d[key] = val;
                    else d.Add(key, val);
                }
                else
                {
                    d = new Dictionary<string, object>();
                    d.Add(key, val);
                }
                c.Tag = d;
            }
            public static object Get(System.Windows.Forms.Control c, string key)
            {
                Dictionary<string, object> d;
                if (c.Tag is Dictionary<string, object>)
                {
                    d = (Dictionary<string, object>)c.Tag;
                    if (!d.ContainsKey(key)) d.Add(key, null);
                }
                else
                {
                    d = new Dictionary<string, object>();
                    d.Add(key, null);
                }
                return d[key];
            }

            public static bool Is(System.Windows.Forms.Control c, string key, object val)
            {
                var t = Tag.Get(c, key);
                if (val == null && t == null) return true;
                else if (t != null)
                {
                    //if val is null then considered as boolean true
                    if (val is bool && t is bool)
                        return (bool)val == (bool)t;
                    else if (val is string && t is string)
                        return (string)val == (string)t;
                    else if (val is int && t is int)
                        return (int)val == (int)t;
                    else if (val is double && t is double)
                        return (double)val == (double)t;
                    return val == t;
                }
                return false;
            }

        }
    }
}
