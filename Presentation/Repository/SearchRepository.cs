using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Presentation.Models;
using Presentation.SearchService;

namespace Presentation.Repository
{
    public class SearchRepository : ISearchRepository
    {

        public bool Search(SearchViewModel model)
        {
            var response = new SearchResponse();
            SearchServiceClient client = new SearchServiceClient();
            response = client.Search(new SearchRequest()
            {
                Filter = new SearchFilter
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    AgeMin = model.AgeTo,
                    AgeMax = model.AgeFrom,
                    Sex = model.Sex,
                    HeightMin = model.HeightTo,
                    HeightMax = model.HeightFrom,
                    WeightMin = model.WeightTo,
                    WeightMax = model.WeightFrom,
                    Nationality = model.Nationality,
                    Email = model.Email,
                    NoOfResults = 30
                }
            });
            return response.Success;
        }
    }
}