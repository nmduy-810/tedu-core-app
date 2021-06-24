using System.Data.Common;
using System.Linq.Expressions;

namespace TeduCoreApp.Infrastructure.SharedKernel
{
    //<T> : generic type
    public abstract class DomainEntity<T>
    {
        //Id: Once entity have Id
        public T Id { get; set; }

        /// <summary>
        /// True if domain entity has identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}