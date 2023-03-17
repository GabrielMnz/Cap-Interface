using System;
using System.Collections.Generic;
using Interface.Entities;

namespace Interface.Services {
    internal interface IServicePayment {

        double Tax (double amount);
        double Calculation(double amount, int months);

    }
}
