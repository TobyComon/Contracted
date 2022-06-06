using System;
using System.Collections.Generic;
using Contracted.Models;
using Contracted.Services;
using Microsoft.AspNetCore.Mvc;

namespace Contracted.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : Controller
    {
        private readonly CompaniesService _cs;
        private readonly CompanyContractorsService _ccs;

        public CompaniesController(CompaniesService cs, CompanyContractorsService ccs)
        {
            _cs = cs;
            _ccs = ccs;
        }

        [HttpGet]
        public ActionResult<List<Company>> Get()
        {
            try
            {
                List<Company> companies = _cs.Get();
                return Ok(companies);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Company> Get(int id)
        {
            try
            {
                Company company = _cs.Get(id);
                return Ok(company);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // [HttpGet("{id}/contractors")]
        // public ActionResult<List<CompanyContractor>> GetContractors(int id)
        // {
        //     try
        //     {
        //         List<CompanyContractor> contractors = _ccs.Get(id);
        //         return Ok(contractors);
        //     }
        //     catch (Exception e)
        //     {
        //         return BadRequest(e.Message);
        //     }
        // }
    }
}