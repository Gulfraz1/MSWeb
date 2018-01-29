using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataObjects.Linq2sql
{
    // Data access object for Member
    // ** DAO Pattern
    public class CriminalDao : ICriminalDao
    {
        public List<BusinessObjects.Criminal> SearchCriminals(SearchFilter searchFilter)
        {
            using (var context = DataObjects.Linq2Sql.DataContextFactory.CreateContext())
            {
                var noOfRec = searchFilter.NoOfResults == 0 ? 10 : searchFilter.NoOfResults;
                var filteredData = context.Criminals.Where(x => x.Sex == searchFilter.Sex &&
                                                (x.Age >= searchFilter.AgeMin && x.Age <= searchFilter.AgeMax) &&
                                                (x.Height >= searchFilter.HeightMin && x.Height <= searchFilter.HeightMax) &&
                                                (x.Weight >= searchFilter.WeightMin && x.Weight <= searchFilter.WeightMax) &&
                                                (x.FirstName == searchFilter.FirstName || x.LastName == searchFilter.LastName) &&
                                                x.Nationality == searchFilter.Nationality);

                    return filteredData.Take(noOfRec).Select(CriminalDataMapper).ToList();
            }
        }

        private static readonly Func<DataObjects.Linq2sql.Criminal, BusinessObjects.Criminal> CriminalDataMapper = (x) =>
        {
            if (x == null)
            {
                return default(BusinessObjects.Criminal);
            }
            return new BusinessObjects.Criminal
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Sex = x.Sex,
                Weight = x.Weight,
                Height = x.Height,
                Nationality = x.Nationality
            };
        };
    }
}
