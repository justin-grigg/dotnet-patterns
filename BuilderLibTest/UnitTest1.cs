using System;
using Xunit;
using BuilderLib;

namespace BuilderLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestFormSubmitterBuilder()
        {
            FormSubmitterBuilder builder = new FormSubmitterBuilder();
            /*
            builder.SkipValidation();
            builder.WithReceipt();
            */

            IFormSubmitter formSubmitter = builder
                .SkipValidation()
                //.WithReceipt()
                .Build();

            Form form = new Form();
            formSubmitter.Submit(form);
        }
    }
}
