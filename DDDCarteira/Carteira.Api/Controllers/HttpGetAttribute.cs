using System;

namespace Carteira.Api.Controllers
{
    internal class HttpGetAttribute : Attribute
    {
        private string v;

        public HttpGetAttribute(string v)
        {
            this.v = v;
        }
    }
}