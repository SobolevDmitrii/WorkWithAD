using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.AccountManagement;

namespace AD
{
    public static class AccountManagementExtensions
    {
        /// <summary>
        /// Получить свойства
        /// </summary>
        /// <param name="property">Имя свойства</param>
        /// <returns>Возвращает значение свойства</returns>
        public static String GetProperty (this Principal principal, String property)
        {
            DirectoryEntry directoryEntry = principal.GetUnderlyingObject() as DirectoryEntry;
            if (directoryEntry.Properties.Contains(property))
                return directoryEntry.Properties[property].Value.ToString();
            else
                return String.Empty;
        }

        /// <summary>
        /// Задать свойства
        /// </summary>
        /// <param name="property">Имя свойства</param>
        /// <param name="value">Присваеваемое значение</param>
        public static void SetProperty(this Principal principal, String property, String value)
        {
            DirectoryEntry directoryEntry = principal.GetUnderlyingObject() as DirectoryEntry;
            directoryEntry.Properties[property].Value = value;
        }
    }
}
