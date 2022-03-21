using Microsoft.EntityFrameworkCore;
using PortfolioAPI.IServices;
using PortfolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioAPI.Services
{
    public class InvestorsService:IInvestorsService
    {
        APIDbContext dbContext;
        public InvestorsService(APIDbContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Investors> GetInvestor()
        {
            var investor = dbContext.Portfolio.ToList();
            return investor;
        }
        public Investors AddInvestor(Investors portfolio)
        {
            if (portfolio != null)
            {
                dbContext.Portfolio.Add(portfolio);
                dbContext.SaveChanges();
                return portfolio;
            }
            return null;
        }
        public Investors UpdateInvestor(Investors portfolio)
        {
            dbContext.Entry(portfolio).State = EntityState.Modified;
            dbContext.SaveChanges();
            return portfolio;
        }

        public Investors DeleteInvestor(int id)
        {
            var portfolio = dbContext.Portfolio.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(portfolio).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return portfolio;
        }

        public Investors GetInvestorById(int id)
        {
            var portfolio = dbContext.Portfolio.FirstOrDefault(x => x.Id == id);
            return portfolio;
        }
    }
}
