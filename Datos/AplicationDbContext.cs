using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Datos
{
    public class AplicationDbContext(DbContextOptions<AplicationDbContext> options) : DbContext(options)
    {

        //Agregar Los modelos aquí
        public DbSet<Contacto> Contacto { get; set; }
    }
}
