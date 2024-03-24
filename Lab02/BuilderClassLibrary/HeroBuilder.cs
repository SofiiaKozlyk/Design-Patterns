using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public class HeroBuilder : IHeroBuilder
    {
        private Hero _hero = new Hero();
        private void _reset()
        {
            this._hero = new Hero();
        }
        public IHeroBuilder SetName(string name)
        {
            _hero.Name = name;
            return this;
        }
        public IHeroBuilder SetHeight(int height)
        {
            _hero.Height = height;
            return this;
        }
        public IHeroBuilder SetBuild(string build)
        {
            _hero.Build = build;
            return this;
        }
        public IHeroBuilder SetHairColor(string hairColor)
        {
            _hero.HairColor = hairColor;
            return this;
        }
        public IHeroBuilder SetEyeColor(string eyeColor)
        {
            _hero.EyeColor = eyeColor;
            return this;
        }
        public IHeroBuilder SetOutfit(string outfit)
        {
            _hero.Outfit = outfit;
            return this;
        }
        public IHeroBuilder AddInventoryItem(string item)
        {
            _hero.Inventory.Add(item);
            return this;
        }
        public Hero GetHero()
        {
            Hero hero = this._hero;
            this._reset();
            return hero;
        }
    }
}
