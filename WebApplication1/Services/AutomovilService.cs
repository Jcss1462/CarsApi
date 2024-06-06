using WebApplication1.Models;
namespace WebApplication1.Services;

public class AutomovilService : IAutomovilService
{
    CarrosContext context;

    public AutomovilService(CarrosContext dbcontext)
    {
        context = dbcontext;
    }
    
    public IEnumerable<Automovil> Get()
    {
        return context.Auromoviles;
    }

    public async Task Save(Automovil automovil)
    {
        context.Add(automovil);
        await context.SaveChangesAsync();
    }

}

public interface IAutomovilService
{
    IEnumerable<Automovil> Get();
    Task Save(Automovil automovil);


}