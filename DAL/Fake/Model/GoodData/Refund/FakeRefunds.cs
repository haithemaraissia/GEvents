﻿using System;
using System.Collections.Generic;

namespace DAL.Fake.Model.GoodData.Refund
{
    public class FakeRefunds
    {
        public List<global::Model.Refund> MyRefunds;

        public FakeRefunds()
        {
            InitializeRefundList();
        }

        public void InitializeRefundList()
        {
            MyRefunds = new List<global::Model.Refund> {
                FirstRefund(), 
                SecondRefund(),
                ThirdRefund()
            };
        }

        public global::Model.Refund FirstRefund()
        {
            var firstRefund = new global::Model.Refund
            {
                RefundId =  1,
                OrderDetailId = 5,
                RefundTypeId = 1,
                DisputeDate = DateTime.Today.Date,
                RefundAmount = (decimal) 8.50,
                StatusId = 1,
                ReasonId = 1,
                Evidence = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Refund\NeverDelivered.jpg",
                Description = "This item was never delivered"
            };
            return firstRefund;
        }

        public global::Model.Refund SecondRefund()
        {
            var secondRefund = new global::Model.Refund
            {
                RefundId = 2,
                OrderDetailId = 2,
                RefundTypeId = 2,
                DisputeDate = DateTime.Today.Date,
                RefundAmount = (decimal)7.50,
                StatusId = 1,
                ReasonId = 2,
                Evidence = "",
                Description = "This item was not good"
            };
            return secondRefund;
        }

        public global::Model.Refund ThirdRefund()
        {
            var thirdRefund = new global::Model.Refund
            {
                RefundId = 1,
                OrderDetailId = 5,
                RefundTypeId = 1,
                DisputeDate = DateTime.Today.Date,
                RefundAmount = (decimal)4.50,
                StatusId = 1,
                ReasonId = 1,
                Evidence = @"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\trunk\Test\Images\Refund\BadFood.jpg",
                Description = "look at the picture and you will understand"
            };
            return thirdRefund;
        }

        ~FakeRefunds()
        {
            MyRefunds = null;
        }
    }
}
