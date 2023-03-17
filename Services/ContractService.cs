using System;
using System.Collections.Generic;
using Interface.Entities;

namespace Interface.Services {
    internal class ContractService {

        private IServicePayment _ServicePayment;

        public ContractService(IServicePayment _servicePayment) {
            _ServicePayment = _servicePayment;
        }

        public void ProcessContract (Contract contract, int months) {
            double normalQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) { 
                DateOnly date = contract.Date.AddMonths(i);
                double upQuota = normalQuota + _ServicePayment.Calculation(normalQuota, i);
                double fullQuota = normalQuota + _ServicePayment.Tax(upQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
