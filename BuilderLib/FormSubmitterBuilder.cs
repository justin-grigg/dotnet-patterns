using System;
namespace BuilderLib
{
    public class FormSubmitterBuilder
    {
        private bool _withReceipt;
        private bool _skipValidation;

        public FormSubmitterBuilder WithReceipt()
        {
            _withReceipt = true;
            return this;
        }

        public FormSubmitterBuilder SkipValidation()
        {
            _skipValidation = true;
            return this;
        }

        public IFormSubmitter Build()
        {
            IFormValidator formValidator = BuildFormValidator();

            IFormSubmitter formSubmitter = new FormSubmitter(formValidator);

            if(_withReceipt)
            {
                formSubmitter = new ReceiptFormSubmitter(formSubmitter);
            }

            return formSubmitter;
        }

        private IFormValidator BuildFormValidator()
        {
            if(_skipValidation)
            {
                return new SkipFormValidator();
            }

            return new FormValidator();
        }
    }
}
