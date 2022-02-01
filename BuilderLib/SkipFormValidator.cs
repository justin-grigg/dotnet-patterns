using System;
namespace BuilderLib
{
    public class SkipFormValidator : IFormValidator
    {
        public SkipFormValidator()
        {
        }

        public void Validate(Form form)
        {
            Console.WriteLine("### skipping form validation ###");
        }
    }
}
