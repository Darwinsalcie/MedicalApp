using MedicalApp.Domain.BaseEntity;
namespace MedicalApp.Domain.Entities.EmpleadoFolder
{
    public class Empleado : Trabajador
    {
        public RolEmpleado Rol { get; set; }
    }

}
