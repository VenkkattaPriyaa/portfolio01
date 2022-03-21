using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.IServices;
using PortfolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private readonly IInvestorsService investorService;
        public PortfolioController(IInvestorsService investor)
        {
            investorService = investor;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("/api​/Portfolio​/GetInvestor")]
        public IEnumerable<Investors> GetInvestor()
        {
            return investorService.GetInvestor();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Portfolio/Addinvestor")]
        public Investors AddInvestor(Investors portfolio)
        {
            return investorService.AddInvestor(portfolio);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Portfolio/EditInvestor")]
        public Investors EditEmployee(Investors portfolio)
        {
            return investorService.UpdateInvestor(portfolio);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Portfolio/DeleteInvestor")]
        public Investors DeleteInvestor(int id)
        {
            return investorService.DeleteInvestor(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Portfolio/GetInvestorId")]
        public Investors GetInvestorId(int id)
        {
            return investorService.GetInvestorById(id);
        }
    }
}
