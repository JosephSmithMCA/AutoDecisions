namespace AutoDecisions {
    internal class Program {
        static void Main(string[] args) {
            double payRate     = 0;
            double hoursWorked = 0;

            payRate = InputDouble("Please enter the employees payrate :");
            hoursWorked = InputDouble("Please enter the employees hours");
            CalculatePay(payRate,hoursWorked);
        }//end main
        static void CalculatePay(double rate, double hours) {
            //declare
            double grossPay    = 0;
            double overtimePay = 0;

            //make selection
            if (hours > 40) {
                grossPay = 40 * rate;
                overtimePay = (rate * 1.5) * (hours - 40);
                Console.WriteLine($"The employees grosspay is {grossPay + overtimePay:C}");

            } else {
                grossPay = 40 * rate;
                Console.WriteLine($"The employees grosspay is {grossPay:C}");
            }//end if
            
        }//end function
        #region HELPER FUNCTIONS

        static string Input(string message) {
            Console.WriteLine(message);
            return Console.ReadLine();
        }//end function
        static decimal InputDecimal(string message) {
            string value = Input(message);
            return decimal.Parse(value);
        }//end function
        static double InputDouble(string message) {
            string value = Input(message);
            return double.Parse(value);
        }//end function
        static int InputInt(string message) {
            string value = Input(message);
            return int.Parse(value);
        }//end function
        #endregion
    }//end class
}//end namespace