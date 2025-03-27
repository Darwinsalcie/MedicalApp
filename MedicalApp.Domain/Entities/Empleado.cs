
using MedicalApp.Domain.BaseEntity;
namespace MedicalApp.Domain.Entities
{
    public class Empleado : Trabajador
    {
        public RolEmpleado Rol { get; set; }
    }

    public enum RolEmpleado
    {
        ATS,
        ATSZona,
        AuxiliarEnfermeria,
        Celador,
        Administrativo
    }

}
