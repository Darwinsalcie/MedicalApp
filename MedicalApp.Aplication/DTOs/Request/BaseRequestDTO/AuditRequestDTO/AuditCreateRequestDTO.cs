﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalApp.Aplication.DTOs.Request.BaseRequestDTO.AuditRequestDTO
{
    public abstract class AuditCreateRequestDTO : TrabajadorRequestDTO
    {
        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
