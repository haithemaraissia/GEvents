using System;
using System.Collections.Generic;
using Model;

namespace DAL.Fake.Model
{
    public class FakeInvitationSchedules
    {
        public List<InvitationSchedules> MyInvitationSchedules;

        public FakeInvitationSchedules()
        {
            InitializeInvitationScheduleList();
        }

        public void InitializeInvitationScheduleList()
        {
            MyInvitationSchedules = new List<InvitationSchedules> {
                FirstInvitationSchedule(), 
                SecondInvitationSchedule(),
                ThirdInvitationSchedule()
            };
        }

        public InvitationSchedules FirstInvitationSchedule()
        {
            var firstInvitationSchedule = new InvitationSchedules
            {
                InvitationScheduleId = 1,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Now.Date
            };
            return firstInvitationSchedule;
        }

        public InvitationSchedules SecondInvitationSchedule()
        {
            var secondInvitationSchedule = new InvitationSchedules
            {
                InvitationScheduleId = 2,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Now.Date
            };
            return secondInvitationSchedule;
        }

        public InvitationSchedules ThirdInvitationSchedule()
        {
            var thirdInvitationSchedule = new InvitationSchedules
            {
                InvitationScheduleId = 3,
                BuyerId = 1,
                SellerId = 1,
                BoothId = 1,
                Date = DateTime.Now.Date
            };
            return thirdInvitationSchedule;
        }
        ~FakeInvitationSchedules()
        {
            MyInvitationSchedules = null;
        }
    }
}
