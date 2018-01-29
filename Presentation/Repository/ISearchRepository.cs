using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Presentation.Repository
{
    public interface ISearchRepository
    {
        bool Search(SearchViewModel model);
    }
}