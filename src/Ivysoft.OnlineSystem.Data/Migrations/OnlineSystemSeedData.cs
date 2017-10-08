namespace Ivysoft.OnlineSystem.Data.Migrations
{
    using System.Threading.Tasks;

    public class OnlineSystemSeedData
    {
        private const string AdministratorUserName = "nayden.kirov@gmail.com";
        private const string AdministratorPassword = "123456";

        private readonly OnlineSystemDbContext context;

        public OnlineSystemSeedData(OnlineSystemDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task SeedData()
        {
            //if (!context.Roles.Any())
            //{
            //    var roleName = "Administrator";
            //    var roleManager = new RoleManager<ApplicationRole>()
            //    await roleManager.CreateAsync(new IdentityRole(roleName));
            //    //var roleStore = new RoleStore<ApplicationRole>(context);
            //    //var roleManager = new RoleManager<ApplicationRole>(roleStore);
            //    //var role = new ApplicationRole { Name = roleName };
            //    roleManager.CreateAsync(role);

            //    var userStore = new UserStore<User>(context);
            //    var userManager = new UserManager<User>(userStore);
            //    var user = new User
            //    {
            //        UserName = AdministratorUserName,
            //        Email = AdministratorUserName,
            //        EmailConfirmed = true,
            //        CreatedOn = DateTime.Now
            //    };

            //    userManager.Create(user, AdministratorPassword);
            //    userManager.AddToRole(user.Id, roleName);
            //}
        }

        //protected override void Seed(OnlineSystemDbContext context)
        //{
        //    this.SeedUsers(context);

        //}
        //private void SeedUsers(OnlineSystemDbContext context)
        //{
        //    if (!context.Roles.Any())
        //    {
        //        var roleName = "Administrator";
        //        var roleStore = new RoleStore<ApplicationRole>(context);
        //        var roleManager = new RoleManager<ApplicationRole>(roleStore);
        //        var role = new ApplicationRole { Name = roleName };
        //        roleManager.Create(role);

        //        var userStore = new UserStore<User>(context);
        //        var userManager = new UserManager<User>(userStore);
        //        var user = new User
        //        {
        //            UserName = AdministratorUserName,
        //            Email = AdministratorUserName,
        //            EmailConfirmed = true,
        //            CreatedOn = DateTime.Now
        //        };

        //        userManager.Create(user, AdministratorPassword);
        //        userManager.AddToRole(user.Id, roleName);
        //    }
        //}
    }
}
