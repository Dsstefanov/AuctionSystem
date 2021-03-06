﻿namespace AuctionSystem.Controllers.Contracts
{
    using Models;
    using System.Collections.Generic;

    public interface IPaymentController
    {
        void AddPayment(Payment payment, int userId);

        Payment GetPayment(int paymentId);
        
        bool DeletePayment(int paymentId);

        bool UpdatePayment(Payment payment);
        
        IList<Payment> GetPaymentsByUser(User user);
    }
}