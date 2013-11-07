using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Tests.Logic.Arguments
{
    [Binding]
    public class Transformations
    {
        [StepArgumentTransformation]
        public RegistrationInfo CreateRegistrationInfo(Table table)
        {
            return table.CreateInstance<RegistrationInfo>();
        }

        [StepArgumentTransformation]
        public IEnumerable<RegistrationInfo> CreateRegistrationInfoList(Table table)
        {
            return table.CreateSet<RegistrationInfo>();
        }
    }
}