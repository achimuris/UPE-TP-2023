using Datos;
using Entidades;

namespace LogicaNegocio
{
    public class Materia
    {
        UniversidadEjemploContext context = new UniversidadEjemploContext();
        public List<Entidades.Materium> ListaDeMaterias ()
        {
            
            return context.Materia.ToList();
        }

        public Entidades.Materium GetMateriaPorId(int id)
        {

            return context.Materia.Where(x => x.IdMateria == id).FirstOrDefault();
        }

        public void AgregarEntidad()
        { 
        
            Materium objetoNuevo = new Materium();
            objetoNuevo.IdCarrera = 1;
            objetoNuevo.ProfesorTitular = "Ing. Chimuris";
            objetoNuevo.Descripcion = "SW y Los Nuevos Escenarios";
            objetoNuevo.Anio = 1;

            context.Materia.Add(objetoNuevo);

            context.SaveChanges();

        }

    }
}