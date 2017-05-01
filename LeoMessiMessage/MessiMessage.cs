using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeoMessiMessage
{
    public class MessiMessage
    {
        public static string Result;

        public enum MessiBoxButton
        {
            Ok,
            Cancel,
            YesNo
        }
        public static string ShowMessage(string Message, string _Caption, MessiBoxButton selectBtn)
        {
            FRM_ShowMessage frm = new FRM_ShowMessage();
            frm.label1.Text = Message;
            frm.Text = _Caption;
            
            if(selectBtn==MessiBoxButton.Ok)
            {
                frm.btn2.Visible = true;
                frm.btn2.Text = "Ok";
            }
            else if(selectBtn==MessiBoxButton.Cancel)
            {
                frm.btn2.Visible = true;
                frm.btn2.Text = "Cancel";
            }
            else if(selectBtn==MessiBoxButton.YesNo)
            {
                frm.btn1.Visible = true;
                frm.btn3.Visible = true;
                frm.btn3.Text = "Yes";
                frm.btn1.Text = "No";
            }
            frm.ShowDialog();
            return Result;
        }
    }
}
