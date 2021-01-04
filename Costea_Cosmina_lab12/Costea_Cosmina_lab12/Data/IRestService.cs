using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Costea_Cosmina_lab12.Models;

namespace Costea_Cosmina_lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
