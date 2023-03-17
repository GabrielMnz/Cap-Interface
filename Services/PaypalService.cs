using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services {
    internal class PaypalService : IServicePayment {
        private const double Js = 0.02;
        private const double TaxPercentage = 0.01;

        private IServicePayment _ServicePayment;

        public double Calculation (double amount, int mounths) {
            return amount * TaxPercentage * mounths;
        }

        public double Tax(double amount) {
            return amount * Js;
        }
    }
}
