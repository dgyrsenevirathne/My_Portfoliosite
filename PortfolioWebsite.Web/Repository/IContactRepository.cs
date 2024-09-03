using PortfolioWebsite.Web.Models;
using System.Threading.Tasks;

namespace PortfolioWebsite.Web.Repository
{
    public interface IContactRepository
    {
        Task InsertContactMessageAsync(ContactMessage contactMessage);
    }
}
