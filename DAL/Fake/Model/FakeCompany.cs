using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeCompanies
    {
        public List<Companies> MyCompanies;

        public FakeCompanies()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyCompanies = new List<Companies> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public Companies FirstUserType()
        {

            var firstUserType = new Companies
            {
                CompanyId = 1,
                Name = ""
            };
            return firstUserType;
        }

        public Companies SecondUserType()
        {
            var secondUserType = new Companies
            {
                CompanyId = 2,
                Name = ""
            };
            return secondUserType;
        }

        public Companies ThirdUserType()
        {
            var thirdUserType = new Companies
            {
                CompanyId = 3,
                Name = ""
            };
            return thirdUserType;
        }
        ~FakeCompanies()
        {
            MyCompanies = null;
        }
    }
}
