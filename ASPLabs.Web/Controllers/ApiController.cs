using System;
using Microsoft.AspNetCore.Mvc;
using ASPLabs.Web.Models;
using System.Collections.Generic;

namespace ExchangeThings.Controllers
{
    [ApiController]
    [Route("api/company")]
    public class ApiController : ControllerBase
    {
        public IActionResult Post(CompanyModel company)
        {
            try
            {
                CompanyAddedViewModel response = new CompanyAddedViewModel
                {
                    NumberOfCharsInName = company.Name.Length,
                    NumberOfCharsInDescription = company.Description.Length,
                    IsHidden = !company.IsVisible
                };

                return Ok(response);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}