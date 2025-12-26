using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LİBRARYPROJECT.deising
{
    public class Tool
    {
        public void ButonAyarla(System.Windows.Forms.Button btn)
        {
            btn.ForeColor = Renkler.Yazi;
            btn.Cursor = Cursors.Hand;    
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0; 


        }
        public void KutuAyarla(TextBox t)
        {
            
            t.ForeColor = Renkler.Yazi;
            t.BorderStyle = BorderStyle.FixedSingle; 
            t.Font = new Font("Segoe UI", 12F, FontStyle.Regular);

        }
        public void ListboxAyarla(ListBox Li)
        {
            Li.ForeColor = Renkler.Yazi;
            Li.BackColor = Renkler.Koyu2;
            Li.BorderStyle = BorderStyle.None;
        }
        public void Labelayarla(Label l)
        {
            l.ForeColor = Renkler.Yazi;
        }
        //scrollbarların dark moda uymsaını sağlayan class
        public class Araclar
        {
            
            [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
            private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

            
            public void PanelScrollbarKarart(Control panel)
            {
                
                try
                {
                    SetWindowTheme(panel.Handle, "DarkMode_Explorer", null);
                }
                catch { }
            }
        }
}
}
