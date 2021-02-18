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
        private static bool enabl = true;
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


        /*
                #region Вспомогательные методы


                /// <summary>
                /// Получить указанного пользователя Active Directory
                /// </summary>
                /// <param name="sUserName">Имя пользователя для извлечения</param>
                /// <returns>Объект UserPrincipal</returns>
                public static UserPrincipal GetUser(string sUserName)
                {
                    PrincipalContext oPrincipalContext = GetPrincipalContext();
                    UserPrincipal result = null;
                    sUserName = sUserName.Trim();

                    if (sUserName != null && sUserName != "")
                    {
                        try
                        {
                            result = UserPrincipal.FindByIdentity(oPrincipalContext, sUserName);

                        }
                        catch (Exception er)
                        {

                            return null;
                        }

                        return result;

                    }
                    else { return null; }

                }


                /// <summary>
                /// Получить указанного пользователя Active Directory
                /// </summary>
                /// <param name="sUserName">Имя пользователя для извлечения</param>
                /// <returns>Объект UserPrincipal</returns>
                public static UserPrincipal GetUser(string sUserName, out string user_err)
                {
                    PrincipalContext oPrincipalContext = GetPrincipalContext();
                    UserPrincipal result = null;
                    sUserName = sUserName.Trim();

                    if (sUserName != null && sUserName != "")
                    {
                        try
                        {
                            result = UserPrincipal.FindByIdentity(oPrincipalContext, sUserName);

                        }
                        catch (Exception er)
                        {
                            user_err = er.Message;
                            return null;
                        }
                        user_err = "ok";
                        return result;

                    }
                    else
                    {

                        user_err = "Пустой логин";
                        return null;

                    }

                }

                /// <summary>
                /// Получить указанного пользователя Active Directory
                /// </summary>
                /// <param name="sUserName">Имя пользователя для извлечения</param>
                /// <param name="err">Возвращает ошибку</param>
                /// <returns>Объект UserPrincipal</returns>
                public static UserPrincipal GetUserCN(string sUserName, out string err)
                {

                    PrincipalContext oPrincipalContext = GetPrincipalContext();
                    err = null;

                    if (sUserName != null && sUserName != "")
                    {
                        try
                        {
                            return UserPrincipal.FindByIdentity(oPrincipalContext, IdentityType.Name, sUserName);

                        }
                        catch (Exception e)
                        {
                            err = e.Message;
                            return null;
                        }

                    }
                    else return null;

                }

                /// <summary>
                /// Попытка получить базовый основной контекст
                /// </summary>
                /// <returns>Возвращает объект PrincipalContext</returns>
                public static PrincipalContext TryGetPrincipalContext(out string sMessage)
                {
                    PrincipalContext result;
                    try
                    {
                        result = new PrincipalContext(ContextType.Domain, sDomain, sServiceUser, sServicePassword);
                        sMessage = string.Empty;
                        return result;

                    }
                    catch (Exception ex)
                    {
                        sMessage = ex.Message;

                        return null;
                    }


                }

                /// <summary>
                /// Попытка получить базовый основной контекст
                /// </summary>
                /// <param name="sUserName">Имя пользователя</param>
                /// <param name="sPassword">Пароль</param>
                /// <returns>Возвращает объект PrincipalContext</returns>

                public static PrincipalContext TryGetPrincipalContext(string sUserName, string sPassword, out string sMessage)
                {
                    PrincipalContext result;
                    try
                    {
                        result = new PrincipalContext(ContextType.Domain, sDomain, sUserName, sPassword);
                        sMessage = string.Empty;
                        return result;

                    }
                    catch (Exception ex)
                    {
                        sMessage = ex.Message;

                        return null;
                    }


                }


                /// <summary>
                /// Получить основной контекст указанного OU
                /// </summary>
                /// <param name="sOU">OU для которого нужно получить основной контекст</param>
                /// <returns>Возвращает объект PrincipalContext</returns>
                public static PrincipalContext GetPrincipalContext(string sOU = "")
                {
                    if (string.IsNullOrEmpty(sOU)) return new PrincipalContext(ContextType.Domain, sDomain, sServiceUser, sServicePassword);
                    else
                        return new PrincipalContext(ContextType.Domain, sDomain, sOU, sServiceUser, sServicePassword);
                }


                /// <summary>
                /// Возвращает найденный обьект из АД согласно фильтру
                /// </summary>
                /// <param name="ou">Место поиска</param>
                /// <param name="Filter">Параметры фильтра</param>
                /// <returns>Возвращает SearchResult</returns>
                public static SearchResult LDAPFindOne(string ou, string Filter, string user = null, string password = null)
                {

                    if (enabl) return null;

                    if (ou == "")
                    {
                        ou = sDefaultRootOU;
                    }

                    var domainPath = @"LDAP://" + sDomain + "/" + ou;
                    DirectoryEntry directoryEntry;

                    if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
                    {
                        directoryEntry = new DirectoryEntry(domainPath, sServiceUser, sServicePassword);
                    }
                    else
                    {
                        directoryEntry = new DirectoryEntry(domainPath, user, password);
                    }

                    var dirSearcher = new DirectorySearcher(directoryEntry);
                    dirSearcher.SearchScope = SearchScope.Subtree;
                    dirSearcher.PageSize = 100;
                    dirSearcher.SizeLimit = 5000;
                    dirSearcher.Filter = Filter;

                    try
                    {

                        return dirSearcher.FindOne();
                    }
                    catch (Exception erousr)
                    {
                        return null;
                    }

                }

                /// <summary>
                /// Возвращает найденный обьект из АД согласно выбора
                /// </summary>
                /// <param name="ou">Место поиска</param>
                /// <param name="obj">имя объекта</param>
                /// <param name="ldf">LdapFilter:  выбор обьекта</param>
                /// <returns>Возвращает SearchResult</returns>
                public static SearchResult LDAPFindOne(string ou, string obj, LdapFilter ldf, string user = null, string password = null)
                {
                    string filter = "";


                    switch (ldf)
                    {
                        case LdapFilter.Computers: filter = "(&(objectCategory=computer)(name=" + obj + "))"; break;
                        case LdapFilter.OU: filter = "(objectCategory=organizationalUnit)"; break;//----------!!!!!!!!
                        case LdapFilter.UsersSAN: filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + obj + "))"; break;
                        case LdapFilter.UsersCN: filter = "(&(objectCategory=person)(objectClass=user)(CN=" + obj + "))"; break;
                        case LdapFilter.Groups: filter = "(&(objectCategory=group)(name=" + obj + ")) "; break;
                    }

                    return LDAPFindOne(ou, filter, user, password);
                }
                #endregion
        */
    }
}
