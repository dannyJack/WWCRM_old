using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritersWeb.Func
{
    public class BaseFunction
    {
        public static class Tag
        {
            public static class Key
            {
                public static string SyncForm { get { return "sync_form"; } }
                public static string FormName { get { return "form_name"; } }
                public static string IsPopUpForm { get { return "is_popupform"; } }
                public static string BreadcrumbLabel { get { return "breadcrumb_label"; } }
                public static string BreadcrumbIcon { get { return "breadcrumb_icon"; } }
                public static string FuncBeforeShow { get { return "func_before_show"; } }
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
        }
    }
}
