using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace przegladaniePlikow
{
    class Program
    {

        [STAThread] //pozwolenie na jednowatkowy apartament
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class MyExtensions
    {
        public static string DosAttributes(this FileSystemInfo info)
        {
            FileAttributes attribs = info.Attributes;
            return ((attribs & FileAttributes.ReadOnly) > 0 ? "r" : "-") +
                ((attribs & FileAttributes.Archive) > 0 ? "a" : "-") +
                ((attribs & FileAttributes.Hidden) > 0 ? "h" : "-") +
                ((attribs & FileAttributes.System) > 0 ? "s" : "-");
        }
    }

}
