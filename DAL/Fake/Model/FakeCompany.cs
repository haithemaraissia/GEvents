using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeCompanies
    {
        public List<Companies> MyCompanies;

        public FakeCompanies()
        {
            InitializeCompaniesList();
        }

        public void InitializeCompaniesList()
        {
            MyCompanies = new List<Companies> {
                FirstCompany(), 
                SecondCompany(),
                ThirdCompany()
            };
        }

        public Companies FirstCompany()
        {

            var firstCompanies = new Companies
            {
                CompanyId = 1,
                Name = ""
            };
            return firstCompanies;
        }

        public Companies SecondCompany()
        {
            var secondCompanies = new Companies
            {
                CompanyId = 2,
                Name = ""
            };
            return secondCompanies;
        }

        public Companies ThirdCompany()
        {
            var thirdCompanies = new Companies
            {
                CompanyId = 3,
                Name = ""
            };
            return thirdCompanies;
        }
        ~FakeCompanies()
        {
            MyCompanies = null;
        }
    }
}
