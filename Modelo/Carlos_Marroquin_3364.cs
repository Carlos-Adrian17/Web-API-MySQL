using System.ComponentModel.DataAnnotations;

public class Carlos_Marroquin_3364
{
    [Key]
    public int IdCurso { get; set; }

    public string NombreCurso { get; set; }
    public int Semestre { get; set; }
    public int Anio { get; set; }
    public string Estado { get; set; }
    public string Descripcion { get; set; }
}
