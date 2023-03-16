using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository.vH.Interface;
using PRN211_ShoesStore.Service.vH.Interface;
using System.Collections.Generic;

namespace PRN211_ShoesStore.Service.vH
{
    public class ShoesService2 : vH.Interface.IShoesService
    {
        private readonly IShoesRepository _shoesRepository;
        public ShoesService2(IShoesRepository ShoesRepository)
        {
            this._shoesRepository = ShoesRepository;
        }
        public void AddShoes(Shoes shoes) => this._shoesRepository.Add(shoes);
        public Shoes GetShoesByShoesId(int id) => this._shoesRepository.GetFirstOrDefault(item => item.id == id);
        public void UpdateShoes(Shoes shoes)
        {
            Shoes shoesCopy = new()
            {
                id = shoes.id,
                name = shoes.name,
                shoesDetails = shoes.shoesDetails,
                launchDate = shoes.launchDate,
                price = shoes.price,
                status = shoes.status,
                image = shoes.image,
                CategoryShoes = shoes.CategoryShoes,
                ShoesColors = shoes.ShoesColors
            };

            _shoesRepository.RemoveCategoriesFromShoes(shoes);
            _shoesRepository.RemoveColorsFromShoes(shoes);
            this._shoesRepository.Update(shoesCopy);
        }

        public void RemoveShoes(Shoes shoes) => this._shoesRepository.Remove(shoes);

        public Shoes GetShoesByName(string shoesName) => this._shoesRepository.GetFirstOrDefault(item => item.name.Equals(shoesName));

        public IEnumerable<Shoes> GetAllShoes() => (List<Shoes>)this._shoesRepository.GetAll();
    }
}
