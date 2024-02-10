namespace Equipos3.Modelos
{
    public class Equipo
    {
        public int CodigoEvento { get; set; }
        public required string Propietario { get; set; }
        public required string CTE { get; set; }
        public required string Subestacion { get; set; }
        public required string Elemento { get; set; }
        public required string TipoDeEquipo { get; set; }
        public required string NombreEquipo { get; set; }
        public required DateTime Fecha { get; set; }
        public required string PL1 { get; set; }
        public required string PL2 { get; set; }
        public required string Rdf { get; set; }
        public required string SOE { get; set; }
        public string? Opciones { get; set; }
    }
}
