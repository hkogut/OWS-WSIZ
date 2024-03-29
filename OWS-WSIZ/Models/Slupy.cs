﻿
namespace OWS_WSIZ.Models
{
    /// <summary>
    /// Klasa Slupy to model tabeli Slupy z bazy danych
    /// </summary>
    public class Slupy
    {
        ///<value>propercja Id</value> 
        public int Id { get; set; }
        ///<value>propercja TypSlupa</value> 
        public string TypSlupa { get; set; }
        ///<value>propercja WytrzymaloscW1</value> 
        public float WytrzymaloscW1 { get; set; }
        ///<value>propercja WytrzymaloscW2</value> 
        public float WytrzymaloscW2 { get; set; }
    }
}
