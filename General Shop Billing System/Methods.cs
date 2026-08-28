using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace General_Shop_Billing_System
{
    internal class Methods
    {
        public bool VerifyName(string name)
        {
            name = name.ToLower();
            bool check = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (!((name[i] >= 'a' && name[i] <= 'z') || name[i] == ' '))
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        public string FormatName(string name)
        {
            name = name.Trim();

            name = name.ToLower();
            for (int i = 0, j = 1; j < name.Length; i++, j++)
            {
                if (name[i] == ' ' && name[j] == ' ')
                {
                    name = name.Remove(j, 1);
                    j = i;
                    i--;
                }
            }

            string c = name[0].ToString().ToUpper();
            name = name.Remove(0, 1);
            name = c + name;

            string fname = "";

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                {
                    fname += name[i].ToString();
                }
                else
                {
                    fname += " ";
                    fname += name[i + 1].ToString().ToUpper();
                    i++;
                }
            }
            return fname;
        }
        public bool VerifyPhoneNumber(string phoneNumber)
        {
            bool check = true;
            if (phoneNumber.Length != 11) 
            {
                check = false;
                return check;
            }
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!(phoneNumber[i] >= '0' && phoneNumber[i] <= '9'))
                {
                    check = false;
                    break;
                }
            }

            return check;
        }

        public bool IsValidEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email) && email.EndsWith("@gmail.com"))
            {
                return true;
            }
            return false;
        }

        public void ResetAnchors (Control container)
        {
            foreach (Control c in container.Controls)
            {
                c.Anchor = AnchorStyles.None;
                if (c.HasChildren)
                {
                    ResetAnchors(c);
                }
            }
        }
        //public void Exit(FormClosingEventArgs e)
        //{
        //    DialogResult dialogue = MessageBox.Show("Do you really want to exit this application: ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //    if (dialogue == DialogResult.Yes)
        //    {
        //        e.Cancel = false;
        //        //Application.Exit();
        //    }

        //    else if (dialogue == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //    Environment.Exit(0);

        //}

        //public void Exit(FormClosingEventArgs e)
        //{
        //    DialogResult dialogue = MessageBox.Show(
        //        "Do you really want to exit this application?",
        //        "Confirm",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Warning
        //    );

        //    if (dialogue == DialogResult.Yes)
        //    {
        //        e.Cancel = false;  // Form বন্ধ হবে
        //        Application.Exit(); // সব forms বন্ধ করবে
        //    }
        //    else
        //    {
        //        e.Cancel = true;   // Form close cancelled
        //    }

        //public void Exit(FormClosingEventArgs e, bool isMainForm = false)
        //{
        //    if (isMainForm)
        //    {
        //        // Main form closing → show confirmation
        //        DialogResult dialogue = MessageBox.Show(
        //            "Do you really want to exit this application?",
        //            "Confirm Exit",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Warning
        //        );

        //        if (dialogue == DialogResult.Yes)
        //        {
        //            e.Cancel = false;  // allow form to close
        //            Application.Exit(); // safely close all forms
        //        }
        //        else
        //        {
        //            e.Cancel = true;   // cancel closing
        //        }
        //    }
        //    else
        //    {
        //        // Secondary forms → just close normally
        //        e.Cancel = false;
        //    }
        //}

        private static bool isExiting = false;

        public void Exit(FormClosingEventArgs e)
        {
            if (!isExiting)
            {
                DialogResult dialogue = MessageBox.Show(
                    "Do you really want to exit this application?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogue == DialogResult.Yes)
                {
                    isExiting = true;   // set flag
                    e.Cancel = false;   // allow closing
                    Application.Exit(); // close all forms
                }
                else
                {
                    e.Cancel = true;    // cancel close
                }
            }
            else
            {
                // Already exiting, just allow form to close
                e.Cancel = false;
            }
        }


        public bool IsAgeAtLeast18(DateTime dateOfBirth)
        {
        DateTime today = DateTime.Today;
        int age = today.Year - dateOfBirth.Year;

        // যদি এই বছরে এখনো জন্মদিন না হয়ে থাকে
            if (today < dateOfBirth.AddYears(age))
            {
                age--;
            }

            return age >= 18;
        }


    }
}
