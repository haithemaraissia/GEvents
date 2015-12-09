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
                FeebBack ="The room were too small",
                RateId  =  (int)Util.RateCode.Values.Good,
                SectionId = (int)Util.EventRateSection.Values.Organization
            };
            return firstFeedBack;
        }

        public FeedBacks SecondFeedBack()
        {
            var secondFeedBack = new FeedBacks
            {
                FeedBackId = 1,
                FeebBack = "The Event was great",
                RateId  =  (int)Util.RateCode.Values.VeryGood,
                SectionId = (int)Util.EventRateSection.Values.Events
            };
            return secondFeedBack;
        }

        public FeedBacks ThirdFeedBack()
        {
            var thirdFeedBack = new FeedBacks
            {
                FeedBackId = 1,
                FeebBack = "The stuff was very helpful",
                RateId = (int)Util.RateCode.Values.Netural,
                SectionId = (int)Util.EventRateSection.Values.Location
            };
            return thirdFeedBack;
        }
        ~FakeFeedBacks()
        {
            MyFeedBacks = null;
        }
    }
}
