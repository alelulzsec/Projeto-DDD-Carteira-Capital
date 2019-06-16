namespace Carteira.Infra.Contexts
{
    public class DbContext
    {
        private string v;

        public DbContext(string v)
        {
            this.v = v;
        }
    }
}