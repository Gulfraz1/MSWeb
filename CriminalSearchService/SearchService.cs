using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CriminalSearchService.Messages;
using CriminalSearchService.ParamValidation;
using CriminalSearchService.Search;
using DataObjects;
using Infrastructure.AppEmail;

namespace CriminalSearchService
{
    public class SearchService : ISearchService
    {
        static readonly IDaoFactory Factory = DaoFactories.GetFactory();
        private readonly ICriminalDao _criminalDao;
        private SearchFilter searchFilter;
        private IEmailService _emailService;
        public SearchService() : this(Factory.CriminalDao,new AppEmailService())
        {

        }
        public SearchService(ICriminalDao criminalDao, IEmailService emailService)
        {
            _criminalDao = criminalDao;
            _emailService = emailService;
        }
        public SearchResponse Search(SearchRequest request)
        {
            searchFilter = request.Filter;
            List<string> errors;
            if (ValidationHelper.ValidateParams(request.Filter, out errors) == false)
            {
                return new SearchResponse
                {
                    Errors = errors,
                    Success = false
                };
            }
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += DoSearch;
            backgroundWorker.RunWorkerAsync();
            return new SearchResponse
            {
                Success = true
            };
        }
        private void DoSearch(object sender, DoWorkEventArgs e)
        {
            new SearchEngine().Search(searchFilter,_criminalDao, _emailService);
        }
    }
}
