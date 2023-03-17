using System;
using System.Collections.Generic;

namespace Interface.Entities {
    class Contract {
        public int Number { get; set; }
        public DateOnly Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateOnly date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment) {
            Installments.Add(installment);
        }

    }
}
