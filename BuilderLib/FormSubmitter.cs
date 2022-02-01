namespace BuilderLib
{
    public class FormSubmitter : IFormSubmitter
    {
        private IFormValidator _validator;

        public FormSubmitter(IFormValidator validator)
        {
            _validator = validator;
        }

        public void Submit(Form form)
        {
            _validator.Validate(form);

            global::System.Console.WriteLine("Submitting form...");
            global::System.Threading.Thread.Sleep(500);
            global::System.Console.WriteLine("Successsfully submitted form...");
        }
    }
}