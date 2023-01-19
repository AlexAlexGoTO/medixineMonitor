﻿using MedixineMonitor.Application.Common.Interfaces;
using MedixineMonitor.Application.Observations.Queries;
using MedixineMonitor.Presentation.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace MedixineMonitor.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class AlertsController : ApiControllerBase
{
    private readonly IAlertService alertService;

    public AlertsController(
        IAlertService alertService)
    {
        this.alertService = alertService;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await alertService.GetAlerts();

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        await alertService.RemoveAlert(id);

        return Ok();
    }
}
