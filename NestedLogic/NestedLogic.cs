using System;

namespace NestedLogic {
    public class NestedLogic {
        public NestedLogic(DateTime returned, DateTime due) {
            this.ret= returned;
            this.due = due;
        }
        public int GetPayment() {
            var sameYear = ret.Year == due.Year;
            var sameMonth = ret.Year == due.Year;
            var sameDay = ret.Year == due.Year;


            var returnedBeforeDueDate = (ret.Year > due.Year) ? false :
                (ret.Year < due.Year) ? true :
                (ret.Month > due.Month) ? false :
                (ret.Day > due.Day) ? false : true;
            var returnedOnDueDate = (ret.Day == due.Day) &&
                (ret.Month == due.Month) &&
                (ret.Year == due.Year);
            var expiredThisMonth = (ret.Day > due.Day) &&
                (ret.Month == due.Month) &&
                (ret.Year == due.Year);
            var expiredThisYear = (ret.Month > due.Month) &&
                (ret.Year == due.Year);
            var expiredNextYear = ret.Year > due.Year;
            if (returnedBeforeDueDate) return 0;
            if (returnedOnDueDate) return 0;
            if (expiredThisMonth) return 15 * (ret.Day - due.Day);
            if (expiredThisYear) return 500 * (ret.Month - due.Month);
            if (expiredNextYear) return 10000;
            throw new ApplicationException();
        }
        private DateTime ret { get; }
        private DateTime due { get; }
    }
}
