namespace SistemaConta.Presentation.Configuration
{
    //classe para confifuração do automapper
    public class AutoMapperConfiguration
    {
        public static void Add(WebApplicationBuilder builder)
        {
              builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
