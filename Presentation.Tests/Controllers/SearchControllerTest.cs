using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Presentation.Controllers;
using Presentation.Models;
using Presentation.Repository;
using Presentation.SearchService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Presentation.Tests.Controllers
{
    // testClass for SearchController.
    // note: the pattern in each TestMethod is: AAA (Arrange, Act, Assert).
    [TestClass]
    public class SearchControllerTest
    {
        // the mock service
        Mock<ISearchRepository> mockService;
        SearchController CreateSearchService()
        {
            return new SearchController(mockService.Object);
        }

        [TestMethod]
        public void SubmitSearch_True_IfServiceReturnsTrue()
        {
            mockService = new Mock<ISearchRepository>();
            mockService.Setup(foo => foo.Search(It.IsAny<SearchViewModel>())).Returns(
                true);

            // Arrange
            var repo = CreateSearchService();
            // Act
            var result = repo.Search(new SearchViewModel
            {

            });
            var viewResult = result as ViewResult;
            // Assert
            Assert.IsTrue(viewResult != null && viewResult.ViewName == "Success");
        }

        [TestMethod]
        public void SubmitSearch_False_IfServiceReturnsFalse()
        {
            mockService = new Mock<ISearchRepository>();
            mockService.Setup(foo => foo.Search(It.IsAny<SearchViewModel>())).Returns(
                false);

            // Arrange
            var repo = CreateSearchService();
            // Act
            var result = repo.Search(new SearchViewModel
            {

            });
            var viewResult = result as ViewResult;
            // Assert
            Assert.IsTrue(viewResult != null && viewResult.ViewName == "Failure");
        }
    }
}