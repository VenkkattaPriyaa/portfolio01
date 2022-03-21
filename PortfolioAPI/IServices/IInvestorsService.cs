using PortfolioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioAPI.IServices
{
    public interface IInvestorsService
    {
        IEnumerable<Investors> GetInvestor();
        Investors GetInvestorById(int id);

        Investors UpdateInvestor(Investors portfolio);
        Investors AddInvestor(Investors portfolio);
        
        Investors DeleteInvestor(int id);
    }
}
