﻿using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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


        /// <summary>
        /// Metoda zapisuje do bazy informację o obliczonym słupie
        /// </summary>
        /// <param name="NrSlupa"></param>
        /// <param name="Wynik"></param>
        /// <param name="Pu"></param>
        /// <param name="Pud"></param>
        public void ZapiszSlupa(string NrSlupa, string Wynik, float Pu, float Pud, string TypSlupa)
        {

            SqlConnection con = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["BazaOWS"].ConnectionString
            };
            con.Open();
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Insert into ObliczoneSlupy(NrSlupa, Wynik, Pu, Pud, TypSlupa) values (@NrSlupa, @Wynik, @Pu, @Pud, @TypSlupa)",
                Connection = con
            };
            cmd.Parameters.AddWithValue("@NrSlupa", NrSlupa);
            cmd.Parameters.AddWithValue("@Wynik", Wynik);
            cmd.Parameters.AddWithValue("@Pu", Pu);
            cmd.Parameters.AddWithValue("@Pud", Pud);
            cmd.Parameters.AddWithValue("@TypSlupa", TypSlupa);
            cmd.Connection = con;
            int a = cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Pobiera dane z tabeli SlupyNarozne
        /// </summary>
        /// <returns></returns>
        public List<Slupy> ZaladujSlupyNarozne()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BazaOWS")))
            {
                var output = connection.Query<Slupy>(
                    $"select * from SlupyNarozne").ToList();
                return output;
            }
        }
    }
}
