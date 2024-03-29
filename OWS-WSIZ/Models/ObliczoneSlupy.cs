﻿
namespace OWS_WSIZ.Models
{
    /// <summary>
    /// Klasa ObliczoneSlupy to model tabeli ObliczoneSlupy z bazy danych
    /// </summary>
    public class ObliczoneSlupy
    {
        ///<value>propercja Id</value> 
        public int Id { get; set; }
        ///<value>propercja NrSlupa</value> 
        public string NrSlupa { get; set; }
        ///<value>propercja Wynik</value> 
        public string Wynik { get; set; }
        ///<value>propercja Pu</value> 
        public float Pu { get; set; }
        ///<value>propercja Pud</value> 
        public float Pud { get; set; }
        ///<value>propercja TypSłupa</value> 
        public string TypSlupa { get; set; }

    }
}
