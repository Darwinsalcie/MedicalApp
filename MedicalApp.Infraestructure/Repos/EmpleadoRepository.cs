

using Mapster;
using MedicalApp.Aplication.Contracts;
using MedicalApp.Aplication.DTOs.Request.Empleado;
using MedicalApp.Aplication.DTOs.Response;
using MedicalApp.Aplication.DTOs.Response.Empleado;
using MedicalApp.Domain.Entities.EmpleadoFolder;
using MedicalApp.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MedicalApp.Infraestructure.Repos
{
    public class EmpleadoRepository(AppDbContext context) : IEmpleado
    {
        private async Task<Empleado> FindEmpleadoByNameAsync(string name)
        => await context.Empleados.FirstOrDefaultAsync(e => e.Nombre.ToLower() == name.ToLower());

        private async Task<Empleado> FindEmpleadoByIdASync(int id)
        => await context.Empleados.Include(s=>s.Nombre)
            .Include(s => s.Direccion)
            .Include(s => s.Telefono)
            .Include(s => s.Poblacion)
            .Include(s => s.Provincia)
            .Include(s => s.CodigoPostal)
            .Include(s => s.NIF)
            .Include(s => s.Cedula)
            .FirstOrDefaultAsync(e => e.Id == id);

        private async Task SaveChangesAsync() => context.SaveChangesAsync();
        private static GeneralResponse NullResponse(string message) => new(false, message);
        private static GeneralResponse AlreadyExistResponse(string message) => new(false, message);
        private static GeneralResponse OperationSuccessResponse(string message) => new(true, message);

        public async Task<GeneralResponse> AddEmpleado(CreateEmpleadoRequestDTO model)
        {
            if (await FindEmpleadoByNameAsync(model.Nombre) is not null)
                return AlreadyExistResponse("Empleado ya existe");

            context.Empleados.Add(model.Adapt(new Empleado()));

            await SaveChangesAsync();
            return OperationSuccessResponse("Empleado creado");
        }

        public async Task<GeneralResponse> DeleteEmpleado(int id)
        {
            if(FindEmpleadoByIdASync(id) is null)
                return NullResponse("Empleado no encontrado");

            context.Empleados.Remove(await FindEmpleadoByIdASync(id));

            await SaveChangesAsync();
            return OperationSuccessResponse("Empleado eliminado");
        }

        public async Task<GetEmpleadoResponseDTO> GetEmpleadoById(int id)
        => (await FindEmpleadoByIdASync(id)).Adapt(new GetEmpleadoResponseDTO());

        public async Task<IEnumerable<GetEmpleadoResponseDTO>> GetEmpleados()
  
            =>(await context.Empleados
                .Include(e => e.Nombre)
                .Include(e => e.Cedula)
                .Include(e => e.CodigoPostal)
                .Include(e => e.Direccion)
                .Include(e => e.NIF)
                .Include(e => e.Poblacion)
                .Include(e => e.Provincia)
                .ToListAsync()).Adapt<List<GetEmpleadoResponseDTO>>();

            //return data.Select(emp => new GetEmpleadoResponseDTO
            //{
            //    Id = emp.Id,
            //    Nombre = emp.Nombre,
            //    Direccion = emp.Direccion,
            //    Telefono = emp.Telefono,
            //    Poblacion = emp.Poblacion,
            //    Provincia = emp.Provincia,
            //    CodigoPostal = emp.CodigoPostal,
            //    NIF = emp.NIF,
            //    Cedula = emp.Cedula,
            //    // Clave foránea al rol
            //    //Implementar con una propiedad de navegación
            //    Role = new GetRoleResponseDTO()
            //    {
            //        Id = emp.Role.Id,
            //        Name = emp.Role.Name
            //    }
            //}

            //)


        public async Task<GeneralResponse> UpdateEmpleado(UpdateEmpleadoRequestDTO model)
        {
            if(await FindEmpleadoByIdASync(model.Id) is null)
                return NullResponse("Empleado no encontrado");

            context.Entry(await FindEmpleadoByIdASync(model.Id)).State = EntityState.Detached;
            context.Empleados.Update(model.Adapt(new Empleado()));

            await SaveChangesAsync();
            return OperationSuccessResponse("Empleado actualizado");
        }
    }
}
