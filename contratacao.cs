using System;

public class Class1
{
    public class Contratacao
    {
        public int ID_Contratacao { get; set; }
        public int ID_Empresa { get; set; }
        public int ID_Time { get; set; }
        public DateTime Data_Contratacao { get; set; }
        // Outras informações sobre a contratação
        public Empresa Empresa { get; set; }
        public Time Time { get; set; }
    }
}
