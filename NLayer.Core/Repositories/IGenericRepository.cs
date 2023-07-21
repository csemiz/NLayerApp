using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id); //Id ye göre T entity'siyle data dön
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        //productRepository.Where(x=>x.id>5).OrderBy.ToListAsync();
        IQueryable<T> Where(Expression<Func<T,bool>> expression);// where metodundan geriye IQueryable dönüyor
        Task<bool> AnyAsync(Expression<Func<T,bool>> expression);
        Task AddAsync (T entity);//update ve delete metotlarının async kısmı yok ef core da cuz uzun bir islem degil
        Task AddRangeAsync (IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
