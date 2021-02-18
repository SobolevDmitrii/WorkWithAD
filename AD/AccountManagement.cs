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
using System.Windows.Forms;

namespace AD
{
    class AccountManagement
    {
        #region Переменные
        public static string sDomainDefault;//куда подключаемся по умолчанию
        public static string sDomain ;//куда подключаемся
        public static string sDefaultRootOU ;//где ищем по умолчанию
        public static string sServiceUser;//пользователь от кого делаем
        public static string sServicePassword ;
        private static bool enabl = true;
        #endregion

        /// <summary>
        /// Установка нового пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sNewPassword">Новый пароль</param>
        /// <param name="sMessage">Описание ошибки (если возникла)</param>
        public static void SetUserPassword(string sUserName, string sNewPassword, out string sMessage)
        {
            try
            {
                searchMetods.GetUser(sUserName).SetPassword(sNewPassword);
                sMessage = string.Empty;
            }
            catch (Exception ex)
            {
                sMessage = ex.Message;
            }
        }

        /// <summary>
        /// Установка свойств пользователя
        /// </summary>
        /// <param name="prop">Устанавливаемые параметры</param>
        /// <param name="sMessage">Описание ошибки (если возникла)</param>
        public static bool SetUserProperty(UserPrincipal oUserPrincipal, UserProperty prop, out string sMessage)
        {
            if (oUserPrincipal != null)
            {
                try
                {

                    if (prop.displayname != null)
                        if (prop.displayname != "") oUserPrincipal.DisplayName = prop.displayname; else oUserPrincipal.DisplayName = null;

                    if (prop.sn != null)
                        if (prop.sn != "") oUserPrincipal.Surname = prop.sn; else oUserPrincipal.Surname = null;

                    if (prop.givenname != null)
                        if (prop.givenname != "") oUserPrincipal.GivenName = prop.givenname; else oUserPrincipal.GivenName = null;

                    if (prop.description != null)
                        if (prop.description != "") { prop.description = prop.description.Length >= 65 ? prop.description.Substring(0, 64) : prop.description; oUserPrincipal.Description = prop.description; } else oUserPrincipal.Description = null;
                   
                    if (prop.mail != null)
                        if (prop.mail != "") oUserPrincipal.EmailAddress = prop.mail; else oUserPrincipal.EmailAddress = null;

                    if (prop.telephoneNumber != null)
                        if (prop.telephoneNumber != "") oUserPrincipal.VoiceTelephoneNumber = prop.telephoneNumber; else oUserPrincipal.VoiceTelephoneNumber = null;

                    if (prop.scriptPath != null)
                        if (prop.scriptPath != "") oUserPrincipal.ScriptPath = prop.scriptPath; else oUserPrincipal.ScriptPath = null;

                    if (prop.physicaldeliveryofficename != null)
                        if (prop.physicaldeliveryofficename != "") oUserPrincipal.SetProperty("physicaldeliveryofficename", prop.physicaldeliveryofficename); else oUserPrincipal.SetProperty("physicaldeliveryofficename", null);

                    if (prop.title != null)
                        if (prop.title != "") { prop.title = prop.title.Length >= 65 ? prop.title.Substring(0, 64) : prop.title; oUserPrincipal.SetProperty("title", prop.title); } else oUserPrincipal.SetProperty("title", null);

                    if (prop.department != null)
                        if (prop.department != "") { prop.department = prop.department.Length >= 65 ? prop.department.Substring(0, 64) : prop.department; oUserPrincipal.SetProperty("department", prop.department); } else oUserPrincipal.SetProperty("department", null);

                    if (prop.company != null)
                        if (prop.company != "") { prop.company = prop.company.Length >= 65 ? prop.company.Substring(0, 64) : prop.company; oUserPrincipal.SetProperty("company", prop.company); } else oUserPrincipal.SetProperty("company", null);

                    if (prop.manager != null)
                        if (prop.manager != "") oUserPrincipal.SetProperty("manager", prop.manager); else oUserPrincipal.SetProperty("manager", null);

                    if (prop.homeDrive != null)
                        if (prop.homeDrive != "") oUserPrincipal.HomeDrive = prop.homeDrive; else oUserPrincipal.HomeDrive = null;

                    if (prop.homeDirectory != null)
                        if (prop.homeDirectory != "") oUserPrincipal.HomeDirectory = prop.homeDirectory; else oUserPrincipal.HomeDirectory = null;

                    if (prop.userworkstations != null)
                        if (prop.userworkstations != "") oUserPrincipal.SetProperty("userworkstations", prop.userworkstations); else oUserPrincipal.SetProperty("userworkstations", null);

                    oUserPrincipal.Save();

                }
                catch (Exception e)
                {
                    sMessage = e.Message; return false;
                }

                sMessage = string.Empty; return true;
            }
            else { sMessage = string.Empty; return false; }
        }


        /// <summary>
        /// Включить учетную запись пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        public static void EnableUserAccount(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
            {
                oUserPrincipal.Enabled = true;
                oUserPrincipal.Save();
            }
        }

        /// <summary>
        /// Отключить учетную запись пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        public static void DisableUserAccount(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
            {
                oUserPrincipal.Enabled = false;
                oUserPrincipal.Save();

                string userToBeMoved = sUserName; // the username (login name) of a user who exists in AD
                string sourceLdapPath = @"LDAP://" + sDomain + "/" + sDefaultRootOU;
                DirectoryEntry sourceLdapConnection = new DirectoryEntry(sourceLdapPath, sServiceUser, sServicePassword);
                DirectorySearcher search = new DirectorySearcher(sourceLdapConnection)
                {
                    SearchScope = SearchScope.Subtree,
                    Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + userToBeMoved + "))" 
                };

                //search.PropertiesToLoad.Add("distinguishedname");
                if (search != null)
                {
                    SearchResult result = search.FindOne();

                    using (DirectoryEntry userEntry = result.GetDirectoryEntry())
                    {
                        if (userEntry != null)
                        {
                            string targetLdapPath = @"LDAP://" + sDomain + "/UsersOff";
                            using (DirectoryEntry targetLdapConnection = new DirectoryEntry(targetLdapPath, sServiceUser, sServicePassword))
                            {
                                // this is the line at which it breaks
                                userEntry.MoveTo(targetLdapConnection);
                            }
                        }
                    }
                }
                /* DirectoryEntry mySearchRoot = new DirectoryEntry(@"LDAP://" + sDomain + "/" + sDefaultRootOU);
                 DirectorySearcher myDirectorySearcher = new DirectorySearcher(mySearchRoot);

                 SearchResult mySearchResult = myDirectorySearcher.FindOne();

                 if (mySearchResult != null)
                 {
                     DirectoryEntry directoryEntry = mySearchResult.GetDirectoryEntry();
                     DirectoryEntry newLocation = new DirectoryEntry(@"LDAP://" + sDomain + "/UsersOff",sServiceUser,sServicePassword);

                     directoryEntry.MoveTo(newLocation);
                     directoryEntry.CommitChanges();

                 }*/
            }
        }

        /// <summary>
        /// Установить признак истечения срока действия пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя с "истекающим" сроком действия</param>
        public static void ExpireUserPassword(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
            {
                oUserPrincipal.ExpirePasswordNow();
                oUserPrincipal.Save();

                
            }
        }

        /// <summary>
        /// Разблокировка заблокированного пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя для снятия lock'а</param>
        public static void UnlockUserAccount(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
            {
                oUserPrincipal.UnlockAccount();
                oUserPrincipal.Save();
            }
        }

    

        /// <summary>
        /// Создание нового пользователя Active Directory
        /// </summary>
        /// <param name="sOU">OU создания нового пользователя</param>
        /// <param name="sUserName">логин пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <param name="sGivenName">Имя</param>
        /// <param name="sSurName">Фамилия</param>
        /// <returns>Возвращает объект UserPrincipal</returns>

        public static UserPrincipal CreateNewUser(string sOU, string sUserName, string sPassword, UserProperty userProp, UserFlags flag, out string ErrMessage, string sDomainDefault)
        {
            if (sUserName != "")
            {
                
                if (WorkWithAD.LDAPIsUserExisiting(sUserName)) { ErrMessage = sUserName + "- Пользователь существует"; return null; }
                
                else
                {
                   
                    PrincipalContext oPrincipalContext = HelperMetods.GetPrincipalContext();
                    if (oPrincipalContext != null)
                    {
                        
                        try
                        {
                           
                            UserPrincipal oUserPrincipal = new UserPrincipal(oPrincipalContext, sUserName, sPassword, true)
                            {
                                Name = userProp.name,
                                UserPrincipalName = sUserName + "@" + sDomainDefault,
                                Surname = userProp.sn,
                                DisplayName = userProp.displayname,
                                Enabled = flag.enable,
                                PasswordNeverExpires = flag.PasswordNeverExpires,
                                UserCannotChangePassword = flag.UserCannotChangePassword,
                                PasswordNotRequired = false
                                
                            };
                            SetUserProperty(oUserPrincipal, userProp,out ErrMessage);
                            if (flag.ExpirePassword) oUserPrincipal.ExpirePasswordNow();

                            oUserPrincipal.Save();

                            ErrMessage = string.Empty;
                            return oUserPrincipal;

                        }
                        catch (Exception e)
                        {
                            
                            ErrMessage = e.Message;
                            return null;

                        }

                    }
                    else { ErrMessage = "Ошибка получения OU"; return null; }

                    /*         }
                             else
                             {
                                 ErrMessage = "ошибка fullname"; return null;
                             }*/

                } 
            }
            else { ErrMessage = "логин == пусто"; return null; }
        }

        /// <summary>
        /// Переименование пользователя Active Directory
        /// </summary>
        /// <param name="sUserName">логин пользователя</param>
        /// <param name="sFullName">новое имя пользователя</param>
        /// <returns>Возвращает Истина если все хорошо</returns>
        public static bool RenameUser(string sUserName, string sName,string sSecondName,string sFullName, UserProperty userProperty, out string err)
        {
            try
            {
                var user = UserPrincipal.FindByIdentity(HelperMetods.GetPrincipalContext(), sUserName);
                if (user != null && sFullName != null && sName != null && sSecondName != null)
                {
                    var dirEntry = (DirectoryEntry)user.GetUnderlyingObject();
                    dirEntry.Rename("CN=" + sFullName);
                    dirEntry.CommitChanges();
                    dirEntry.Close();
                }
                else { err = "Ошибка в передаваемых параметрах!"; return false; }

                err = null;
                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }

        }

        /// <summary>
        /// Переименование пользователя Active Directory
        /// </summary>
        /// <param name="sUserName">логин пользователя</param>
        /// <param name="sFullName">новое имя пользователя</param>
        /// <returns>Возвращает Истина если все хорошо</returns>
        public static bool LDAPRenameUser(string sUserName, string sFullName, out string err , string sServiceUser, string sServicePassword)
        {
            try
            {
                SearchResult user = HelperMetods.LDAPFindOne("", sUserName, LdapFilter.UsersSAN);
                //var user = UserPrincipal.FindByIdentity(GetPrincipalContext(), sUserName);
                if (user != null && sFullName != null)
                {
                    using (DirectoryEntry dirEntry = new DirectoryEntry(user.Path, sServiceUser, sServicePassword))
                    {
                        if (dirEntry != null)
                        {
                            dirEntry.Rename("CN=" + sFullName);
                            dirEntry.CommitChanges();
                        }
                        else { err = null; return false; }
                    }

                }
                else { err = "Ошибка в передаваемых параметрах!"; return false; }

                err = null;
                return true;
            }
            catch (Exception e)
            {
                err = e.Message;
                return false;
            }

        }

        /// <summary>
        /// Удаление пользователя Active Directory
        /// </summary>
        /// <param name="sUserName">Имя пользователя для удаления</param>
        /// <returns>Возвращает true, если удаление прошло успешно</returns>
        public static bool DeleteUser(string sUserName)
        {
            try
            {
                using (UserPrincipal oUserPrincipal = searchMetods.GetUser(sUserName))
                {
                    oUserPrincipal.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
