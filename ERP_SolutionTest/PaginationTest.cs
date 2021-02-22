using ERP_Solution.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP_SolutionTest
{
    [TestClass]
    public class PaginationTest
    {
        [TestMethod]
        public void PaginationEmployeeProperties()
        {
            PaginationEmployee pagination = PaginationCrud();

            Assert.AreEqual(600, pagination.Total);
            Assert.AreEqual(10, pagination.Page);
            Assert.AreEqual(30, pagination.Pages);
            Assert.AreEqual(20, pagination.Limit);
        }

        public PaginationEmployee PaginationCrud()
        {
            PaginationEmployee pagination = new PaginationEmployee();
            pagination.Total = 600;
            pagination.Page = 10;
            pagination.Pages = 30;
            pagination.Limit = 20;

            return pagination;
        }
    }
}
