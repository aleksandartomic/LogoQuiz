using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LogoQuiz.Services
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetLogosAsync(bool forceRefresh = false);

        Task<T> GetLogoAsync(string id);

    }
}
