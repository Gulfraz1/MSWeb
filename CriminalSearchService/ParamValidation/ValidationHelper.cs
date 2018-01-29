using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CriminalSearchService.Messages;

namespace CriminalSearchService.ParamValidation
{
    public class ValidationHelper
    {
        public static bool ValidateParams(SearchFilter filter, out List<string> errors)
        {
            errors = new List<string>();
            var result = true;

            if (string.IsNullOrEmpty(filter.FirstName))
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}", filter.FirstName));
            }
            if (string.IsNullOrEmpty(filter.LastName))
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}", filter.LastName));
            }
            if (!ValidateEmail(filter.Email))
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.Email));
            }
            if (filter.AgeMin <1)
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.AgeMin));
            }
            if (filter.AgeMax < 1 || filter.AgeMax< filter.AgeMin)
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.AgeMax));
            }
            if (filter.HeightMin < 1)
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.HeightMin));
            }
            if (filter.HeightMax < 1 || filter.HeightMax < filter.HeightMin)
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.HeightMax));
            }
            if (filter.WeightMin < 1)
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.WeightMin));
            }
            if (filter.WeightMax < 1 || filter.WeightMax < filter.WeightMin)
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}",filter.WeightMax));
            }
            if (string.IsNullOrEmpty(filter.Nationality))
            {
                result = false;
                errors.Add(string.Format("Invalid input for {0}", filter.Nationality));
            }
            return result;
        }
        private static bool ValidateEmail(string email)
        {
                const string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, pattern);
        }
    }
}
