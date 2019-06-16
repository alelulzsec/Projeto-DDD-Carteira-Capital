using System;

namespace Carteira.Api.Controllers
{
    internal class HttpPutAttribute : Attribute
    {
        private string v;

        public HttpPutAttribute(string v)
        {
            this.v = v;
        }
    }
}