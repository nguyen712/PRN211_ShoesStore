using PRN211_ShoesStore.Models.Entity;
using System.Collections.Generic;

namespace PRN211_ShoesStore.Service
{
    public interface IShoesService
    {
        IEnumerable<Shoes> GetShoes();
        Shoes GetShoesById(int shoesId);
        IEnumerable<Shoes> GetShoesByName(string shoesname);
        public bool UpdateShoes(Shoes shoes);
    }
}
