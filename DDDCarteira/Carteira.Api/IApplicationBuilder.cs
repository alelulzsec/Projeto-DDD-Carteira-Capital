using System;
using System.Threading.Tasks;

namespace Carteira.Api
{
    public interface IApplicationBuilder
    {
        void UseDeveloperExceptionPage();
        void Run(Func<object, Task> p);
    }
}