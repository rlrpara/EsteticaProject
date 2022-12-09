namespace Estetica.Service.ViewModel.Entities
{
    public class ErrorResponseViewModel
    {
        public string TraceId { get; private set; }
        public List<ErrorDetailViewModel> Errors { get; private set; }

        public ErrorResponseViewModel()
        {
            TraceId = Guid.NewGuid().ToString();
            Errors = new List<ErrorDetailViewModel>();
        }
        public ErrorResponseViewModel(string logreg, string message)
        {
            TraceId = Guid.NewGuid().ToString();
            Errors = new List<ErrorDetailViewModel>();
            AddError(logreg, message);
        }
        public void AddError(string logreg, string message) => Errors.Add(new ErrorDetailViewModel(logreg, message));
    }

    public class ErrorDetailViewModel
    {
        public string LogRef { get; private set; }
        public string Message { get; private set; }
        public ErrorDetailViewModel(string logref, string message)
        {
            LogRef = logref;
            Message = message;
        }
    }
}
