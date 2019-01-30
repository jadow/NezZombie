using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;

using NezZombie.Scenes;

namespace NezZombie
{
    public class Game1 : Core
    {
        public Game1() : base(640 * 2, 480 * 2)
        {
            IsMouseVisible = true;
            Window.AllowUserResizing = true;
            IsFixedTimeStep = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

            //Graphics.instance.batcher.shouldRoundDestinations = false;

            Scene.setDefaultDesignResolution(640, 480, Scene.SceneResolutionPolicy.ShowAllPixelPerfect);
            scene = new MasterScene();
        }
    }
}
