using System;

namespace BuilderLib
{
    internal class ReceiptFormSubmitter : IFormSubmitter
    {
        private IFormSubmitter _formSubmitter;

        public ReceiptFormSubmitter(IFormSubmitter formSubmitter)
        {
            _formSubmitter = formSubmitter;
        }

        public void Submit(Form form)
        {
            _formSubmitter.Submit(form);

            Console.WriteLine("### now send receipt... ###");
        }
    }
}