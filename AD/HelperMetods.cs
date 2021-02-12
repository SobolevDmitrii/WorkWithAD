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

namespace AD
{
    class HelperMetods
    {

        #region Переменные
        public static string sDomainDefault;//куда подключаемся по умолчанию
        public static string sDomain ;//куда подключаемся
        public static string sDefaultRootOU ;//где ищем по умолчанию
        public static string sServiceUser;//пользователь от кого делаем
        public static string sServicePassword ;
        private static bool enabl;
        #endregion


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

        /// <summary>
        /// Получает DirectoryEntry деректории OU
        /// </summary>
        /// <param name="ou"> путь к OU</param>
        /// <returns>Возвращает DirectoryEntry деректории OU</returns>
        public static DirectoryEntry GetOU(string ou)
        {
            try
            {
                DirectoryEntry dr = new DirectoryEntry("LDAP://" + sDomain + "/" + ou, sServiceUser, sServicePassword);
                dr.RefreshCache();
                return dr;
            }
            catch
            {
                return null;
            }
                        
        }


    }
}
