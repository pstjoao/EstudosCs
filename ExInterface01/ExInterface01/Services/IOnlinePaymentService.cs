using System;

namespace ExInterface01.Services {
    internal interface IOnlinePaymentService {

        double PaymentFee(double amount);
        double Interest(double amoun, int months);
    }
}
