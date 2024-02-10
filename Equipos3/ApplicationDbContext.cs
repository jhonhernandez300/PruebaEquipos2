using Microsoft.EntityFrameworkCore;
using Equipos3.Modelos;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Equipos3
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Equipo> Equipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>().HasKey(m => m.CodigoEvento);

            modelBuilder.Entity<Equipo>()
           .HasData(
                new Equipo
                {
                    CodigoEvento = 3,
                    Fecha = new DateTime(2024, 1, 1),
                    Propietario = "Emtelco",
                    CTE = "CTE Oriente",
                    Subestacion = "Guajira 230 KV",
                    Elemento = "BL Guajira 230 Soacha 2",
                    TipoDeEquipo = "Relé de presentación",
                    NombreEquipo = "BL Guajirá 230 KV Sogamoso 1 SEL321",
                    PL1 = "Sí",
                    PL2 = "No",
                    Rdf = "Activo",
                    SOE = "Sí",
                    Opciones = "Activo"
                }
           );

            modelBuilder.Entity<Equipo>()
          .HasData(
               new Equipo
               {
                   CodigoEvento = 2,
                   Fecha = new DateTime(2024, 2, 1),
                   Propietario = "5 Five",
                   CTE = "CTE Occidente",
                   Subestacion = "Amazonas 230 KV",
                   Elemento = "BL Amazonas 230 rio 2",
                   TipoDeEquipo = "Relé de presentación",
                   NombreEquipo = "BL Amazonas 230 KV rio 1 SEL321",
                   PL1 = "Sí",
                   PL2 = "Sí",
                   Rdf = "Activo",
                   SOE = "NO",
                   Opciones = "Activo"
               }
          );

            base.OnModelCreating(modelBuilder);
        }
    }
}
