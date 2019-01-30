using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using NezZombie.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NezZombie.Scenes
{
    class MasterScene: Scene
    {
        public override void initialize()
        {
            clearColor = Color.LightGray;
            addRenderer(new DefaultRenderer());

            // var mapLoaderEntity = createEntity("map-loader");
            var playerEntity = createEntity("player");

            // mapLoaderEntity.addComponent(new MapLoader(playerEntity));

            var playerTexture = content.Load<Texture2D>("tinyRPG-forest-code/PNG/sprites/hero/idle/hero-idle-back/hero-idle-back");
            playerEntity.addComponent(new Sprite(playerTexture));
            //playerEntity.addComponent(new PrototypeSprite(16, 16)).setColor(Color.Red);

            //playerEntity.addComponent(new PlayerMover());

            var testMap = createEntity("testMap");
            testMap.addComponent(new TestMap());

            playerEntity.setPosition(new Vector2(0, 0));
        }
    }
}
