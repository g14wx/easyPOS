namespace Domain.Primitives;

public interface IunitOfWork
{
    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
}