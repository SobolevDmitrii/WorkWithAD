using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    /// Структура данных пользователя
    /// 
    public struct UserProperty
    {
        public string sn;
        public string givenname;
        public string cn;
        public string displayname;
        public string description;
        public string physicaldeliveryofficename;
        public string title;
        public string department;
        public string company;
        public string manager;
        public string scriptPath;
        public string telephoneNumber;
        public string mail;
        public string name;
        public string homeDrive;
        public string homeDirectory;
        public string userworkstations;
    }


    public struct UserPropertyExtend
    {
        public string samaccountname;
        public string cn;
        public string sn;
        public string givenname;
        public string displayname;
        public string description;
        public string physicaldeliveryofficename;
        public string title;
        public string department;
        public string company;
        public string manager;
        public string manager_distinguishedname;
        public string scriptPath;
        public string telephonenumber;
        public string mail;
        public string name;
        public string distinguishedname;
        public bool userdisable;
        public bool usrpassworddenied;//Установлен параметр "Запрет смены пароля"
        public bool passwordneverexpires;
        public string coment;
        public string userworkstations;
        public bool usrexpires; //Истек срок действия УЗ
        public long tic_usrexpires; //Значение истечения срока действия
        public long loginnever; //Время последнего логина "Никогда"
    }

    public struct GroupProperty
    {
        public string samaccountname;
        public string description;
        public string name;
        public string cn;
        public string distinguishedname;
        public int grouptype;
        public string coment;
        public string managedby;
    }

    public enum LdapFilter { UsersSAN, UsersCN, Computers, Groups, OU, UsersName };

}
