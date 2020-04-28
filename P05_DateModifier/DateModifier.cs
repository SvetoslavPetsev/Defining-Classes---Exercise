namespace DefiningClasses
{
    using System;
    public class DateModifier
    {
        private int dayes;
        private DateTime endDate;
        private DateTime startDate;

        public DateModifier()
        {
            this.endDate = new DateTime();
            this.startDate = new DateTime();
        }
        public DateModifier(DateTime start, DateTime end)
        {
            this.startDate = start;
            this.endDate = end;
        }
        public int GetDayes()
        {
            return dayes = (this.endDate - this.startDate).Days;
        }
    }
}
