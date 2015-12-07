using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeFeedBacks
    {
        public List<FeedBacks> MyFeedBacks;

        public FakeFeedBacks()
        {
            InitializeFeedBackList();
        }

        public void InitializeFeedBackList()
        {
            MyFeedBacks = new List<FeedBacks> {
                FirstFeedBack(), 
                SecondFeedBack(),
                ThirdFeedBack()
            };
        }

        public FeedBacks FirstFeedBack()
        {
            var firstFeedBack = new FeedBacks
            {
                FeedBackId  = 1,
                FeebBack ="",
                RateId  = 1,
                SectionId   = 1
            };
            return firstFeedBack;
        }

        public FeedBacks SecondFeedBack()
        {
            var secondFeedBack = new FeedBacks
            {
                FeedBackId = 1,
                FeebBack = "",
                RateId = 1,
                SectionId = 1
            };
            return secondFeedBack;
        }

        public FeedBacks ThirdFeedBack()
        {
            var thirdFeedBack = new FeedBacks
            {
                FeedBackId = 1,
                FeebBack = "",
                RateId = 1,
                SectionId = 1
            };
            return thirdFeedBack;
        }
        ~FakeFeedBacks()
        {
            MyFeedBacks = null;
        }
    }
}
