using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Fake.Model.Invitations.Seller;

namespace DAL.Fake.Model.Invitations.Core.Buyer
{
    public class BuyerInvitations
    {
        public List<global::Model.Invitations> Seller1Invitation;
        public List<global::Model.Invitations> Buyer1Invitation;

        public BuyerInvitations()
        {
            InitializeSellerList();
            InitializeBuyerList();
        }


        #region Seller 1

        private void InitializeSellerList()
        {
            Seller1Invitation = new SellerInvitations().Seller1Invitation;
        }
        #endregion


        #region Buyer 1

        private void InitializeBuyerList()
        {
            Buyer1Invitation = GetBuyerIncomingInvitations();
        }

        public List<global::Model.Invitations> GetBuyerIncomingInvitations()
        {
           return (from c in Seller1Invitation where c.BuyerId == 1 select c).ToList() ;
        }

        #endregion


        ~BuyerInvitations()
        {
            Seller1Invitation = null;
            Buyer1Invitation = null;
        }
    }
}
