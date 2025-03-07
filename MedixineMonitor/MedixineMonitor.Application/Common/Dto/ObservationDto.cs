﻿using MedixineMonitor.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedixineMonitor.Application.Common.Dto;

public class ObservationDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public HealthMetrics Type { get; set; }
    public double Value { get; set; }
    public int PatientId { get; set; }
    public string? Description { get; set; }
}

