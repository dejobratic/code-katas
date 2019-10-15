using Kata.Models;

namespace Kata.UseCases
{
    public interface IKata
    {
        IKataResponse Execute(IKataRequest request);
    }
}
