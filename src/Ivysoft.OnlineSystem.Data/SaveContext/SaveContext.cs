namespace Ivysoft.OnlineSystem.Data.SaveContext
{
    public class SaveContext : ISaveContext
    {
        private readonly OnlineSystemDbContext context;

        public SaveContext(OnlineSystemDbContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }
    }
}
