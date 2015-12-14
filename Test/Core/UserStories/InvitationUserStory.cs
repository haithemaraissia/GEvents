using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Data.UnitofWork;
using Model;
using Test.Base;
using Test.Helper;

namespace Test.Core.UserStories
{
    public class InvitationUserStory
    {
        private UnitofWork _uow;
        private BuyerHelper _firstBuyer;
        private BuyerHelper _secondBuyer;
        private SellerHelper _firstSeller;
        private SellerHelper _secondSeller;

        public InvitationUserStory()
        {

            _uow = new Uow().AllRepo();

            var firstBuyer = _uow.BuyerRepository.All.First();
            _firstBuyer = new BuyerHelper(_uow, firstBuyer);
            var secondBuyer = _uow.BuyerRepository.All.Skip(1).First();
            _secondBuyer = new BuyerHelper(_uow, secondBuyer);

            var firstSeller = _uow.SellerRepository.All.First();
            _firstSeller = new SellerHelper(_uow, firstSeller);
            var secondSeller = _uow.SellerRepository.All.Skip(1).First();
            _secondSeller = new SellerHelper(_uow, secondSeller);

        }

        public void FirstStory()
        {
            var buyerInvitation = _firstBuyer.GetInvitationCount();
            var sellerInvitation = _firstSeller.GetInvitationCount();

           FirstBuyerAcceptInvitation();

            GetFirstBuyerSchedule();
            GetFirstSellerSchedule();
           FirstBuyerRefuseSecondInvitation();
           GetFirstBuyerSchedule();
           GetFirstSellerSchedule();
            FirstBuyerClearRefusedSecondInvitation();

            //Refused one
            FirstBuyerThirdInvitation();
            GetFirstBuyerSchedule();
            GetFirstSellerSchedule();

            //Another Seller
           SecondBuyerAcceptInvitation();
           GetFirstBuyerSchedule();
           GetSecondSellerSchedule();
        }

        public void FirstBuyerAcceptInvitation()
        {
            var NewFirstInvitationId = _firstSeller.CreateInvitation(_firstBuyer.Buyer.BuyerId, 1, DateTime.Today.AddDays(100));
            // buyerInvitation = _firstBuyer.GetInvitationCount();
            //sellerInvitation = _firstSeller.GetInvitationCount();

            var newInvitation = _uow.InvitationsRepository.FindBy(x => x.BuyerId == _firstBuyer.Buyer.BuyerId).Last();

            _firstBuyer.AcceptInvitation(NewFirstInvitationId);
        }

        public void FirstBuyerRefuseSecondInvitation()
        {
            int NewFirstInvitationId;
            var NewSecondInvitationId = _firstSeller.CreateInvitation(_firstBuyer.Buyer.BuyerId, 1, DateTime.Today.AddDays(100));
            // buyerInvitation = _firstBuyer.GetInvitationCount();
            //sellerInvitation = _firstSeller.GetInvitationCount();

            var newSecondInvitation = _uow.InvitationsRepository.FindBy(x => x.BuyerId == _firstBuyer.Buyer.BuyerId).Last();

            _firstBuyer.RefuseInvitation(NewFirstInvitationId);
        }

        public void FirstBuyerClearRefusedSecondInvitation()
        { }
    }
}
