using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClassLibrary
{
    public interface IHeroBuilder
    {
        public IHeroBuilder SetName(string name);
        public IHeroBuilder SetHeight(int height);
        public IHeroBuilder SetBuild(string build);
        public IHeroBuilder SetHairColor(string hairColor);
        public IHeroBuilder SetEyeColor(string eyeColor);
        public IHeroBuilder SetOutfit(string outfit);
        public IHeroBuilder AddInventoryItem(string item);
        public Hero GetHero();
    }
}
