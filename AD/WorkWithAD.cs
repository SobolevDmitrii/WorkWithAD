using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Security.Principal;
using ActiveDs;
using System.Windows.Forms;

namespace AD
{
    class WorkWithAD
    {
        #region Переменные
        public static string sDomainDefault;//куда подключаемся по умолчанию
        public static string sDomain ;//куда подключаемся
        public static string sDefaultRootOU ;//где ищем по умолчанию
        public static string sServiceUser;//пользователь от кого делаем
        public static string sServicePassword;
        //private static bool enabl = true;
        #endregion

        #region Методы проверки
        /// <summary>
        /// Проверка имени пользователя и пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <returns>Возвращает true, если имя и пароль верны</returns>
        public static bool OldValidateCredentials (string sUserName, string sPassword)
        {
            return HelperMetods.GetPrincipalContext().ValidateCredentials(sUserName, sPassword);
        }


        /// <summary>
        /// Проверка имени пользователя и пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <returns>Возвращает true, если имя и пароль верны</returns>
        public static bool LDAPValidateCredentials (string sUserName, string sPassword)
        {
            var pc = HelperMetods.LDAPFindOne("", sUserName, LdapFilter.UsersSAN, sUserName, sPassword);
            if (pc == null) return false;
            else return true;
        }

        /// <summary>
        /// Проверка имени пользователя и пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <returns>Возвращает true, если имя и пароль верны</returns>
        public static bool LDAPValidateCredentials()
        {
           
            var pc = HelperMetods.LDAPFindOne("", sServiceUser, LdapFilter.UsersSAN);

            if (pc == null) return false;
            else { return true; }
        }

        //------------------------------------------------------------------------
        /// <summary>
        /// Проверка сервера
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <returns>Возвращает true, если имя и пароль верны и сервер хороший</returns>
        public static bool OldValidateController(string sUserName, string sPassword)
        {
            string err;
            PrincipalContext pc = HelperMetods.TryGetPrincipalContext(out err);
            if (pc == null) return false;
            else { return pc.ValidateCredentials(sUserName, sPassword); }

        }

        /// <summary>
        /// Проверка сервера
        /// </summary>
        /// <returns>Возвращает true, если имя и пароль верны и сервер хороший</returns>
        public static bool OldValidateController()
        {
            string err;
            PrincipalContext pc = HelperMetods.TryGetPrincipalContext(out err);
            if (pc == null) return false;
            else { return pc.ValidateCredentials(sServiceUser, sServicePassword); }

        }

        /// <summary>
        /// Проверка сервера
        /// </summary>
        /// <returns>Возвращает true, есои сервер вернул данные</returns>
        public static bool ValidateController()
        {
          
            return LDAPValidateCredentials();

        }

        /// <summary>
        /// Проверка флага на истекший пароль пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если срок действия пароля истек</returns>
        public static bool IsChangePasswordAtNextLogonSet(string sUserName)
        {

            var user = searchMetods.GetUser(sUserName);

            if (user.LastPasswordSet == null) return true;

            else return false;
        }


        /// <summary>
        /// Проверка флага на истекший пароль пользователя
        /// </summary>
        /// <param name="user">UserPrincipal пользователя</param>
        /// <returns>Возвращает true, если срок действия пароля истек</returns>
        public static bool IsChangePasswordAtNextLogonSet(UserPrincipal user)
        {
            if (user.LastPasswordSet == null) return true;

            else return false;
        }

        /// <summary>
        /// Проверка существования пользователя в AD
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если пользователь существует</returns>
        public static bool IsUserExisiting (string sUserName)
        {
            return searchMetods.GetUser(sUserName) == null ? false : true;
        }

        /// <summary>
        /// Проверка существования пользователя в AD
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если пользователь существует</returns>
        public static bool LDAPIsUserExisiting(string sUserName)
        {
            bool found = false;
            if ( HelperMetods.LDAPFindOne("",sUserName, LdapFilter.UsersSAN)!=null)
            {
                found = true;
            }
            return found;
        }

        /// <summary>
        /// Проверка существования пользователя в AD по DN
        /// </summary>
        /// <param name="DN">DN пользователя</param>
        /// <returns>Возвращает true, если пользователь существует</returns>
        public static bool IsUserDNExisiting(string dn, out string err)
        {
            PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
            UserPrincipal result = null;
            err = null;
            //Перемудрено с вложением и перехватом ошибок//
            if (dn != null && dn != "")
            {
                try
                {
                    result = searchMetods.GetUser(dn);
                }
                catch (Exception e)
                {
                    err = e.Message;
                    return false;
                }

            }

            return result == null ? false : true;

        }


        /*  /// <summary>
          /// Проверка существования пользователя по полному имени и аккаунту
          /// </summary>
          /// <param name="sUserName">Имя пользователя</param>
          /// <param name="sUserName">Полное имя</param>
          /// <returns>Возвращает true, если пользователь существует</returns>
          public static bool IsUserExisiting(string sUserName, string fullname)
          {
              return GetUser(sUserName, fullname) == null ? false : true;
          }*/

        /// <summary>
        /// Проверяет блокировку пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если учетная запись заблокирована</returns>
        public static bool IsAccountLocked(string sUserName)
        {
            return searchMetods.GetUser(sUserName).IsAccountLockedOut();
        }

        #endregion
        public static bool CreateNewOU(string newOU)
        {
            DirectoryEntry newDirectory = new DirectoryEntry(@"LDAP://" + Properties.Settings.Default.Domain);
            newDirectory.RefreshCache();

            //string newOU = "OU=UsersOff1";
            string newDescription = "AD OU";

            try
            {
                DirectoryEntry objOU = newDirectory.Children.Add("OU =" + newOU, "OrganizationalUnit");
                objOU.Properties["description"].Add(newDescription);
                objOU.CommitChanges();
                return true;
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
                return false;

            }
        }
    }
}
