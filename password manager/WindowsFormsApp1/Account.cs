using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Account_item  : IEquatable<Account_item>
    {
        public string link, user, password;
        
        public Account_item(string link, string user, string password)
        {
            this.link = link;
            this.user = user;
            this.password = password;
        }

        public bool Equals(Account_item other)  
        {
            return link == other.link && user == other.user && password == other.password;
        }
    }
    class Account
    {
        
        List<Account_item> Account_info = new List<Account_item>();
        Dictionary<string, List<Account_item>> Same_password = new Dictionary<string, List<Account_item>>();
        

        private string ItemToString(Account_item item)
        {
            return "Link: " + item.link + "\nUser: " + item.user + "\nPassword: " + item.password + "\n================================\n";
        }
        public bool CheckSameAccount(string link,string user)
        {
            foreach(Account_item item in Account_info)
            {
                if (item.link == link && item.user == user) return true;
            }
            return false;
        }
        public string FindSamePassword()
        {
            string result = "";
            foreach(var item in Same_password)
            {
                if (item.Value.Count() == 1) continue;

                foreach(Account_item item2 in item.Value)
                {
                    result += ItemToString(item2);
                }
            }
            return result;
        }
        public bool Del(string link, string user, string password)
        {

            Account_item target = new Account_item(link, user, password);
            if (Account_info.Contains(target))
            {
                Account_info.Remove(target);
                Same_password[password].Remove(target);
                return true;
            }
            return false;
        }
        public bool Add(string link,string user,string password)
        {
            if (CheckSameAccount(link, user)) return false;

            Account_item ins = new Account_item(link, user, password);
            Account_info.Add(ins);

            if (Same_password.ContainsKey(password))
            {
                Same_password[password].Add(ins);
            }
            else
            {
                List<Account_item> ins_lis = new List<Account_item>();
                ins_lis.Add(ins);
                Same_password.Add(password, ins_lis);
            }
            return true;
        }

        public string Search(string Target) 
        {
            string result = "";
            if (Target == "")
            {
                foreach (Account_item item in Account_info)
                {
                    result += ItemToString(item);
                }
            }
            else
            {
                foreach (Account_item item in Account_info)
                {
                    if (item.link.Contains(Target))
                    {
                        result += ItemToString(item);
                    }
                }
            }
            return result;
        }
        
    }
}
