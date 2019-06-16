using System;

namespace Carteira.Api.Controllers
{
    internal class HttpDeleteAttribute : Attribute
    {
        private string v;

        public HttpDeleteAttribute(string v)
        {
            this.v = v;
        }
    }
}