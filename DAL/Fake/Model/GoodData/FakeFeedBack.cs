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
                ThirdFeedBack(),
                FourthFeedBack(),
                FifthFeedBack()
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
                FeedBackId = 2,
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
                FeedBackId = 3,
                FeebBack = "The stuff was very helpful",
                RateId = (int)Util.RateCode.Values.Netural,
                SectionId = (int)Util.EventRateSection.Values.Location
            };
            return thirdFeedBack;
        }

        public FeedBacks FourthFeedBack()
        {
            var feedBack = new FeedBacks
            {
                FeedBackId = 4,
                FeebBack = "The Event was good",
                RateId = (int)Util.RateCode.Values.Good,
                SectionId = (int)Util.EventRateSection.Values.Events
            };
            return feedBack;
        }

        public FeedBacks FifthFeedBack()
        {
            var feedBack = new FeedBacks
            {
                FeedBackId = 5,
                FeebBack = "The Event was bad",
                RateId = (int)Util.RateCode.Values.Bad,
                SectionId = (int)Util.EventRateSection.Values.Events
            };
            return feedBack;
        }
        ~FakeFeedBacks()
        {
            MyFeedBacks = null;
        }
    }
}
