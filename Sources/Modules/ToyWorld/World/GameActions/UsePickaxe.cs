using World.Atlas;
using World.GameActors;

namespace World.GameActions
{
    public class UsePickaxe : GameAction
    {
        public float Damage { get; set; }

        public UsePickaxe(GameActor sender) : base(sender) { }

        public override void Resolve(GameActorPosition target, IAtlas atlas)
        {
            throw new System.NotImplementedException();
        }
    }
}