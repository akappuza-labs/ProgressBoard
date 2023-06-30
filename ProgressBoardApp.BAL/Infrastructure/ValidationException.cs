namespace ProgressBoardApp.BAL.Infrastructure
{

    public class ValidationException : Exception
    {

        public string ValidationProperty { get; set; }
        
        public ValidationException(string message, string validationProperty) : base(message)
        {
            ValidationProperty = validationProperty;
        }
    }
}
