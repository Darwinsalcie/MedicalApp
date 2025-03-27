using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Response
{
    public record LoginResponse (bool Flag = false, string Message = null!, string Toke= null!, string RefreshToken = null!);

}
