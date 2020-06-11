﻿using System.Configuration;

namespace OWS_WSIZ.Models
{
    /// <summary>
    /// Klasa posiadająca jedną propercję przechowującą connectionStringa
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Przechowuje ConnectionStrings
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
