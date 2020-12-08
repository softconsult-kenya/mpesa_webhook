using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using smcaptureLib.Globals.KendoSupport;


namespace smcaptureLib.Globals
{
    public enum GetReferenceNumberTypes
    {
        MaxGet = 0,
        CountGet = 1,
    }


    public static class FormHelper
    {
        //ROOT PREFIX FOR FILE
        public static string GetNameofInetfolder()
        {
            var globalFolderName = "/yara";
            return globalFolderName;
        }
        
        public static int freq = 10;

        public static bool numbersonly(string nat_id)
        {
            var regex = new Regex("[0-9]");
            var match = regex.Match(nat_id);
            return match.Success;
        }

        public static bool phonenumberonly(string phone1)
        {
            var regex = new Regex("^[0]");
            var match = regex.Match(phone1);
            return match.Success;
        }

        public static bool HasCapitals(string text)
        {
            foreach (char c in text)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }
        public static bool HasSmall(string text)
        {
            foreach (char c in text)
            {
                if (char.IsLower(c)) return true;
            }
            return false;
        }


        public static bool ValidateEmail(string email)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match(email);
            return match.Success;
        }




        public static object ValidationFailed()
        {
            throw new NotImplementedException();

        }


  


       


        public static long ConvertDateTimeToEpoch(DateTime time)
        {
            var epoch = new DateTime(1970, 1, 1);
            return Convert.ToInt64(time.Subtract(epoch).TotalMilliseconds);

        }

        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);

        }
    }

    public class CompanyModule
    {
        public int companymoduleid { get; set; }
    }


    public class CompanyBranches
    {
        public int branch_id { get; set; }
        public string branch_name { get; set; }
        public int account_id { get; set; }
    }


    public class connectionstringObj
    {
        public string username { get; set; }
        public string password { get; set; }
        public string database { get; set; }
        public string server { get; set; }

    }


}