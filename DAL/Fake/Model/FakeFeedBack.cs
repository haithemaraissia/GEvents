using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeFeedBacks
    {
        public List<FeedBacks> MyFeedBacks;

        public FakeFeedBacks()
        {
            InitializeUserTypeList();
        }

        public void InitializeUserTypeList()
        {
            MyFeedBacks = new List<FeedBacks> {
                FirstUserType(), 
                SecondUserType(),
            };
        }

        public FeedBacks FirstUserType()
        {

            var firstUserType = new FeedBacks
            {
                TypeId = 1,
                TypeValue = Util.FeedBacks.Values.Seller.ToString()
            };
            return firstUserType;
        }

        public FeedBacks SecondUserType()
        {
            var secondUserType = new FeedBacks
            {
                TypeId = 2,
                TypeValue = Util.FeedBacks.Values.Buyer.ToString()
            };
            return secondUserType;
        }

        public FeedBacks ThirdUserType()
        {
            var thirdUserType = new FeedBacks
            {
                TypeId = 3,
                TypeValue = Util.FeedBacks.Values.Admin.ToString()
            };
            return thirdUserType;
        }
        ~FakeFeedBacks()
        {
            MyFeedBacks = null;
        }
    }
}
