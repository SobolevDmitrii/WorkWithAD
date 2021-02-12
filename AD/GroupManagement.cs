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
    class GroupManagement
    {
        /// <summary>
        /// Создание новой группы Active Directory
        /// </summary>
        /// <param name="sOU">OU, где будет создана новая группа</param>
        /// <param name="sGroupName">Имя группы</param>
        /// <param name="sDescription">Описание группы</param>
        /// <param name="oGroupScope">Область группы</param>
        /// <param name="bSecurityGroup">True - группа безопасности, false - группа рассылки</param>
        /// <returns>Возвращает объект GroupPrincipal</returns>
        public static GroupPrincipal CreateNewGroup(string sOU, string sGroupName, string sDescription, GroupScope oGroupScope, bool bSecurityGroup)
        {
            PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext(sOU);

            GroupPrincipal oGroupPrincipal = new GroupPrincipal(oPrincipalContext, sGroupName)
            {
                Description = sDescription,
                GroupScope = oGroupScope,
                IsSecurityGroup = bSecurityGroup
            };

            oGroupPrincipal.Save();

            return oGroupPrincipal;
        }

        /// <summary>
        /// Добавляет пользователя в указанную группу
        /// </summary>
        /// <param name="sUserName">Имя добавляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>В случае успеха возвращает true</returns>
        public static bool AddUserToGroup(string sUserName, string sGroupName, out string err)
        {
            UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName);
            if (oUserPrincipal != null)
            {
                return AddUserToGroup(oUserPrincipal, sGroupName, out err);
            }
            else { err = "Пользователь не найден!"; return false; }
        }

        /// <summary>
        /// Добавляет пользователя в указанную группу
        /// </summary>
        /// <param name="sUserName">UserPrincipal добавляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>В случае успеха возвращает true</returns>
        public static bool AddUserToGroup(UserPrincipal oUserPrincipal, string sGroupName, out string err)
        {
            try
            {

                using (GroupPrincipal oGroupPrincipal = searchMetods.GetGroup(sGroupName))
                {
                    if (oUserPrincipal != null && oGroupPrincipal != null)
                    {
                        if (! IsUserGroupMember(oUserPrincipal.Name, sGroupName))
                        {
                            oGroupPrincipal.Members.Add(oUserPrincipal);
                            oGroupPrincipal.Save();
                        }
                        else { err = sGroupName + " уже состоит в этой группе!"; }
                    }
                }
                err = string.Empty;
                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }


        /// <summary>
        /// Добавляет пользователя в указанную группу
        /// </summary>
        /// <param name="sUserName">UserPrincipal добавляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>В случае успеха возвращает true</returns>
        public static bool LDAPAddUserToGroup(string sUserName, string sGroupName, out string err)
        {

            SearchResult user = HelperMetods.LDAPFindOne("", sUserName, LdapFilter.UsersSAN);
            SearchResult group = HelperMetods.LDAPFindOne("", sGroupName, LdapFilter.Groups);

            try
            {
                DirectoryEntry de_group = group.GetDirectoryEntry();

                string userDN = user.Properties["distinguishedName"][0].ToString();
                string gpDN = de_group.Properties["distinguishedName"][0].ToString();

                //  if (!de_group.Properties["member"].Contains(userDN))
                if (!user.Properties["memberOf"].Contains(gpDN))
                {
                    de_group.Properties["member"].Add(userDN);
                    de_group.CommitChanges();

                    err = string.Empty;
                    return true;
                }
                else
                {
                    err = "Уже состоит в данной группе";
                    return false;

                }
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }

        /// <summary>
        /// Удаляет пользователя из указанной группы
        /// </summary>
        /// <param name="sUserName">UserPrincipal добавляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>В случае успеха возвращает true</returns>
        public static bool LDAPRemoveUserFromGroup(string sUserName, string sGroupName, out string err)
        {

            SearchResult user = HelperMetods.LDAPFindOne("", sUserName, LdapFilter.UsersSAN);
            SearchResult group = HelperMetods.LDAPFindOne("", sGroupName, LdapFilter.Groups);

            try
            {
                DirectoryEntry de_group = group.GetDirectoryEntry();

                string userDN = user.Properties["distinguishedName"][0].ToString();
                string gpDN = de_group.Properties["distinguishedName"][0].ToString();


                // if (de_group.Properties["member"].Contains(userDN))
                if (user.Properties["memberOf"].Contains(gpDN))
                {
                    de_group.Properties["member"].Remove(userDN);
                    de_group.CommitChanges();

                    err = string.Empty;
                    return true;
                }
                else
                {
                    err = "Не состоит в данной группе";
                    return false;

                }
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }
        }


        /// <summary>
        /// Удаляет пользователя из указанной группы
        /// </summary>
        /// <param name="sUserName">Имя удаляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>Возвращает true в случае успеха</returns>
        public static bool RemoveUserFromGroup(string sUserName, string sGroupName)
        {
            try
            {
                using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
                using (GroupPrincipal oGroupPrincipal = searchMetods.GetGroup(sGroupName))
                {
                    if (oUserPrincipal != null && oGroupPrincipal != null)
                    {
                        if (IsUserGroupMember(sUserName, sGroupName))
                        {
                            oGroupPrincipal.Members.Remove(oUserPrincipal);
                            oGroupPrincipal.Save();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Удаляет пользователя из указанной группы
        /// </summary>
        /// <param name="sUserName">Имя удаляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>Возвращает true в случае успеха</returns>
        public static bool LDAPRemoveUserFromGroup(string sUserName, string sGroupName)
        {

            SearchResult user = HelperMetods.LDAPFindOne("", sUserName, LdapFilter.UsersSAN);
            SearchResult group = HelperMetods.LDAPFindOne("", sGroupName, LdapFilter.Groups);

            try
            {
                string userDN = user.Properties["distinguishedName"][0].ToString();
                DirectoryEntry de_group = group.GetDirectoryEntry();

                de_group.Properties["member"].Remove(userDN);
                de_group.CommitChanges();


                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        /// <summary>
        /// Проверка на вхождение пользователя в группу
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>Возвращает true, если пользователь входит в группу</returns>
        public static bool IsUserGroupMember(string sUserName, string sGroupName)
        {
            bool bResult = false;

            using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
            using (GroupPrincipal oGroupPrincipal = searchMetods.GetGroup(sGroupName))
            {
                if (oUserPrincipal != null && oGroupPrincipal != null)
                {
                    bResult = oGroupPrincipal.Members.Contains(oUserPrincipal);
                }
            }

            return bResult;
        }

        /// <summary>
        /// Возвращает список групп, в которых состоит пользователь
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает List со всеми группами пользователя</returns>
        /// 
        public static List<string> GetUserGroups(string sUserName)
        {
            UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName);
            return GetUserGroups(oUserPrincipal);
        }

        /// <summary>
        /// Возвращает список групп, в которых состоит пользователь
        /// </summary>
        /// <param name="sUserPrincipal"> UserPrincipal пользователя</param>
        /// <returns>Возвращает List со всеми группами пользователя</returns>
        public static List<string> GetUserGroups(UserPrincipal sUserPrincipal)
        {
            List<string> myItems = new List<string>();
            PrincipalContext oPrincipalContext =HelperMetods.GetPrincipalContext();
            if (sUserPrincipal != null)
            {
                try
                {

                    using (PrincipalSearchResult<Principal> oPrincipalSearchResult = sUserPrincipal.GetGroups(oPrincipalContext))
                    {

                        foreach (Principal oResult in oPrincipalSearchResult)
                        {
                            myItems.Add(oResult.Name);
                        }
                    }

                }

                catch { return null; }
            }
            else return null;

            return myItems;
        }

        /// <summary>
        /// Возвращает список групп, в которых состоит пользователь
        /// </summary>
        /// <param name="sUserPrincipal"> UserPrincipal пользователя</param>
        /// <returns>Возвращает List со всеми группами пользователя</returns>
        public static List<string> LDAPGetUserGroups(string sUserName)
        {
            List<string> myItems = new List<string>();

            SearchResult objSearch = LDAPFindOne("", sUserName, LdapFilter.UsersSAN);

            if (objSearch != null)
            {
                var gp = objSearch.Properties["memberOf"];


                if (gp.Count > 0)
                {

                    foreach (string r in gp)
                    {
                        string gp_name = r.Substring(3, r.IndexOf(",") - 3);
                        myItems.Add(gp_name);

                    }

                }


            }
            else return null;

            return myItems;
        }

        /// <summary>
        /// Возвращает список авторизационных групп пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает List<string> содержащий авторизационные группы пользователя</returns>
        public static List<string> GetUserAuthorizationGroups(string sUserName)
        {
            List<string> myItems = new List<string>();
            PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
            UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName);

            using (PrincipalSearchResult<Principal> oPrincipalSearchResult = oUserPrincipal.GetAuthorizationGroups())
            {
                foreach (Principal oResult in oPrincipalSearchResult)
                {
                    myItems.Add(oResult.Name);
                }
            }

            return myItems;
        }


        /// <summary>
        /// Возвращает список авторизационных групп пользователя
        /// </summary>
        /// <param name="sUserPrincipal"> UserPrincipal пользователя</param>
        /// <returns>Возвращает List содержащий авторизационные группы пользователя</returns>
        public static List<string> GetUserAuthorizationGroups(UserPrincipal sUserPrincipal)
        {
            List<string> myItems = new List<string>();

            try
            {
                using (PrincipalSearchResult<Principal> oPrincipalSearchResult = sUserPrincipal.GetAuthorizationGroups())
                {

                    foreach (Principal oResult in oPrincipalSearchResult)
                    {
                        myItems.Add(oResult.Name);
                    }

                }

            }
            catch { return null; }

            return myItems;
        }

    }
}
