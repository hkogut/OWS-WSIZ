using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace OWS_WSIZ.Models
{
    /// <summary>
    ///  Klasa odpowiedzialna za pobieranie danych z bazy
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Pobiera dane z tabeli ObliczoneSlupy
        /// </summary>
        /// <returns></returns>
        public List<ObliczoneSlupy> ZaladujTabele()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = connection.Query<ObliczoneSlupy>(
                $"select * from ObliczoneSlupy").ToList();
                return output;
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli Slupy
        /// </summary>
        /// <returns></returns>
        public List<Slupy> ZaladujSlupy()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = connection.Query<Slupy>(
                $"select * from Slupy").ToList();
                return output;
            }
        }
        /// <summary>
        /// Pobiera dane z tabeli ObcLatarnia
        /// </summary>
        /// <param name="SelectedWiatr"></param>
        /// <returns></returns>
        public List<ObcLatarnia> ZaladujLatarnia(string SelectedWiatr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = connection.Query<ObcLatarnia>(
                $"select * from ObcLatarnia where StrefaWiatrowa = '{SelectedWiatr}'").ToList();
                return output;
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli NaciagPodstawowy
        /// </summary>
        /// <returns></returns>
        public List<NaciagPodstawowy> ZaladujNaciagPodstawowy()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = connection.Query<NaciagPodstawowy>(
                $"select * from NaciagPodstawowy ").ToList();
                return output;
            }
        }

        /// <summary>
        /// Pobiera dane z tabeli ObcKablaWiatremWpPrzelot
        /// </summary>
        /// <param name="SelectedWiatr"></param>
        /// <returns></returns>
        public List<ObcKablaWiatremWpPrzelot> ZaladujKabelGlownyPrzelot(string SelectedWiatr)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = connection.Query<ObcKablaWiatremWpPrzelot>(
                $"select * from ObcKablaWiatremWpPrzelot where StrefaWiatrowa = '{SelectedWiatr}'").ToList();
                return output;
            }
        }


    }
}
