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
using System.Collections;

namespace AD
{
    class searchMetods
    {
       /* public static string sDomainDefault;//куда подключаемся по умолчанию
        public static string sDomain;//куда подключаемся
        public static string sDefaultRootOU;//где ищем по умолчанию
        public static string sServiceUser;//пользователь от кого делаем
        public static string sServicePassword;
        private static bool enabl = true;*/
        /// <summary>
        /// Возвращаем объект домена
        /// </summary>
        /// <param name="Dn">домен</param>
        public static Domain GetDomain(string dn = null)
        {
            try
            {
                if (dn == null) return Domain.GetDomain(new DirectoryContext(DirectoryContextType.Domain));
                return Domain.GetDomain(new DirectoryContext(DirectoryContextType.Domain, dn));
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Возвращаем список контроллеров домена
        /// </summary>
        /// <param name="Dn">домен</param>
        public static ArrayList GetListOfDomainControllersByDirectorySearcher(string sDefaultRootOU)
        {
            ArrayList alDcs = new ArrayList();

            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Domain);
                DirectoryEntry domainEntry = new DirectoryEntry("LDAP://" + context.ConnectedServer + "/OU=Domain Controllers," + sDefaultRootOU);
                DirectorySearcher searcher = new DirectorySearcher(domainEntry);
                searcher.PageSize = 100;
                searcher.SizeLimit = 5000;

                searcher.Filter = "(&(objectCategory=computer)(objectClass=computer)(userAccountControl:1.2.840.113556.1.4.803:=8192))";

                //  searcher.PropertiesToLoad.AddRange(new string[] { "name", "operatingsystem" });

                SearchResultCollection fnd = searcher.FindAll();

                foreach (SearchResult result in fnd)
                {
                    alDcs.Add(result.Properties["name"][0].ToString());

                }
            }
            catch (Exception ex)
            {
                return null;
            }

            alDcs.Sort();

            return alDcs;
        }

        /// <summary>
        /// Возвращаем список контроллеров домена
        /// </summary>
        /// <param name="ip_get">разрешать ИП адрес, по умолчанию да</param>
        public static ArrayList GetListOfDomainControllersByDirectorySearcherFull(string sDefaultRootOU, bool ip_get = true)
        {
            ArrayList alDcs = new ArrayList();
            string[] Dlist;

            try
            {
                PrincipalContext context = new PrincipalContext(ContextType.Domain);
                DirectoryEntry domainEntry = new DirectoryEntry("LDAP://" + context.ConnectedServer + "/OU=Domain Controllers," + sDefaultRootOU);
                DirectorySearcher searcher = new DirectorySearcher(domainEntry);

                searcher.PageSize = 100;
                searcher.SizeLimit = 5000;

                searcher.Filter = "(&(objectCategory=computer)(objectClass=computer)(userAccountControl:1.2.840.113556.1.4.803:=8192))";

                SearchResultCollection fnd = searcher.FindAll();

                foreach (SearchResult result in fnd)
                {
                    Dlist = new string[3];

                    Dlist[0] = result.Properties["dNSHostName"][0].ToString();
                    Dlist[1] = result.Properties["operatingSystem"][0].ToString();
                    Dlist[2] = "";

                    if (ip_get)
                    {
                        try
                        {

                            IPAddress[] ips = Dns.GetHostAddresses(Dlist[0]);

                            foreach (IPAddress ip in ips)
                            {

                                Dlist[2] += ip.ToString() + ";";
                            }

                        }
                        catch
                        {
                            Dlist[2] = "no IP";
                        }
                    }

                    alDcs.Add(Dlist);

                }
            }
            catch (Exception ex)
            {
                return null;
            }

            try
            {
                alDcs.Sort();
            }
            catch
            {

            }

            return alDcs;
        }

        /// <summary>
        /// Получить указанного пользователя Active Directory
        /// </summary>
        /// <param name="sUserName">Имя пользователя для извлечения</param>
        /// <returns>Объект UserPrincipal</returns>
        public static UserPrincipal GetUser(string sUserName)
        {
            PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
            UserPrincipal result = null;
            sUserName = sUserName.Trim();

            if (sUserName != null && sUserName != "")
            {
                try
                {
                    result = UserPrincipal.FindByIdentity(oPrincipalContext, sUserName);
                    //UserPrincipal.
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
            PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
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

            PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
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
        /// Возвращает DirectoryEntry пользователя по DistinguishedName
        /// </summary>
        /// <param name="sUserPrincipal"> DistinguishedName пользователя</param>
        /// <returns>Возвращает DirectoryEntry пользователя</returns>
        public static DirectoryEntry LDAPGetUser(string UserPath, string sDomain, string sServiceUser, string sServicePassword)
        {
            DirectoryEntry user = new DirectoryEntry("LDAP://" + sDomain + "/" + UserPath, sServiceUser, sServicePassword);

            return user;
        }



        /// <summary>
        /// Получить группу Active Directory
        /// </summary>
        /// <param name="sGroupName">Группа для получения</param>
        /// <returns>Возвращает объект GroupPrincipal</returns>
        public static GroupPrincipal GetGroup(string sGroupName)
        {
            if (sGroupName != "")
            {
                PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
                return GroupPrincipal.FindByIdentity(oPrincipalContext, sGroupName);
            }
            return null;
        }


    }
}
