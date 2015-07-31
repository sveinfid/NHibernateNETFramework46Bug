using NServiceBus.Saga;

namespace NHibernateNETFramework46Bug
{
    public class MySaga : Saga<MySagaDataSubClassOne>
    {
        protected override void ConfigureHowToFindSaga(SagaPropertyMapper<MySagaDataSubClassOne> mapper)
        {
            
        }
    }
}