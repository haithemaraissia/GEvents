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
                ThirdCompany(),
                FourthCompany(),
                FifthCompany(),
                SixthCompany()
            };
        }

        public Companies FirstCompany()
        {

            var firstCompanies = new Companies
            {
                CompanyId = 1,
                Name = "Lamnies Production"
            };
            return firstCompanies;
        }

        public Companies SecondCompany()
        {
            var secondCompanies = new Companies
            {
                CompanyId = 2,
                Name = "R & R"
            };
            return secondCompanies;
        }

        public Companies ThirdCompany()
        {
            var thirdCompanies = new Companies
            {
                CompanyId = 3,
                Name = "First Production"
            };
            return thirdCompanies;
        }

        public Companies FourthCompany()
        {
            var fourthCompanies = new Companies
            {
                CompanyId = 4,
                Name = "Chain Command"
            };
            return fourthCompanies;
        }

        public Companies FifthCompany()
        {
            var fifthCompanies = new Companies
            {
                CompanyId = 5,
                Name = "Elite Manufacturing"
            };
            return fifthCompanies;
        }

        public Companies SixthCompany()
        {
            var sixthCompanies = new Companies
            {
                CompanyId = 6,
                Name = "Export Production"
            };
            return sixthCompanies;
        }
        ~FakeCompanies()
        {
            MyCompanies = null;
        }
    }
}
