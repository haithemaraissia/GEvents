using System;
using System.Linq;
using DAL.Data.UnitofWork;
using DAL.Fake.Model.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Base;

namespace Test.Core.FeedBacks
{
    [TestClass]
    public class FeedBack
    {

        #region Global

        private UnitofWork _uow;

        #endregion

        #region Init and Simple

        [TestInitialize]
        public void Initialize()
        {
            _uow = new Uow().AllRepo();
        }

        #endregion

        [TestMethod]
        public void FeedBackRateStatistics()
        {
            var feedbackgroups = _uow.FeedBackRepository.All.GroupBy(x => new { x.SectionId })
                .Select(g => new FeedbackStatistics
                {
                    Average = Math.Round(g.Average(p => p.RateId), 2),
                    SectionId = g.Key.SectionId,
                    Percentage = Math.Round((g.Average(p => p.RateId) * 100) / (int)RateCode.Values.VeryGood, 2),
                    SectionName = GetSectionNameBySectionId(g.Key.SectionId),
                    NumberOfRaters = g.Count()
                });

            Assert.AreEqual(3, feedbackgroups.Count());
            var eventSection = feedbackgroups.FirstOrDefault(x => x.SectionId == (int)EventRateSection.Values.Events);
            if (eventSection != null)
            {
                Assert.AreEqual(3.67, eventSection.Average);
                Assert.AreEqual(73.33, eventSection.Percentage);
                Assert.AreEqual(1, eventSection.NumberOfRaters);
            }
        }

        #region Util
        private string GetSectionNameBySectionId(int sectionId)
        {
            var eventRateSection = _uow.EventRateSectionRepository.FindBy(x => x.SectionId == sectionId).FirstOrDefault();
            if (eventRateSection != null)
                return eventRateSection.SectionValue.ToString();
            return "section Name";
        }
        #endregion

    }
}
