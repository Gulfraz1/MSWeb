using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriminalSearchService.Messages;
using CriminalSearchService.Reporting;
using DataObjects;
using Infrastructure.AppEmail;

namespace CriminalSearchService.Search
{
    public class SearchEngine
    {
        public void Search(SearchFilter searchFilter, ICriminalDao criminalDao, IEmailService emailService)
        {
            var result = criminalDao.SearchCriminals(CriminalSearchFilter(searchFilter));
            if (result != null)
            {
                var reports = new ReportingEngine().CreateReports(result);
                if (reports == null || reports.Count < 1)
                {
                    return;
                }
                var reports10 = from index in Enumerable.Range(0, reports.Count)
                              group reports[index] by index / 10;
                foreach (var report in reports10)
                {
                    emailService.Send(searchFilter.Email, report.ToList());
                }
            }
        }

        static readonly Func<SearchFilter, BusinessObjects.SearchFilter> CriminalSearchFilter = (x) =>
        {
            if (x == null)
            {
                return default(BusinessObjects.SearchFilter);
            }
            return new BusinessObjects.SearchFilter
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                AgeMin = x.AgeMin,
                AgeMax = x.AgeMax,
                Sex = x.Sex,
                HeightMin = x.HeightMin,
                HeightMax = x.HeightMax,
                WeightMin = x.WeightMin,
                WeightMax = x.WeightMax,
                Nationality = x.Nationality,
                Email = x.Email,
                NoOfResults = x.NoOfResults
            };
        };
    }
}
