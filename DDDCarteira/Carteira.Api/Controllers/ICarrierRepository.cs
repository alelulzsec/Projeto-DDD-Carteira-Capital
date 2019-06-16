using System.Collections.Generic;

namespace Carteira.Api.Controllers
{
    internal interface ICarrierRepository
    {
        void Save(Carrier carrier);
        IEnumerable<Carrier> GetCarriers();
    }
}