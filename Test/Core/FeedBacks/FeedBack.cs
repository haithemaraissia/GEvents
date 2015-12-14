using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
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

        public void RatePercentage()
        {
            //Get Rate Percentage per caregroies
            var feedbacks = _uow.FeedBackRepository.All.GroupBy(x => x.SectionId);
            foreach (var feedback in feedbacks)
            {
                var total = 0;
                total = _uow.FeedBackRepository.FindBy(x => x.RateId == feedback.Key).Count();
            }

            //Get number of people that submit feedback
             var raters = _uow.FeedBackRepository.All.GroupBy(x => x.SectionId).Count();
        }

        //Get those rate and test them.

    }
}
