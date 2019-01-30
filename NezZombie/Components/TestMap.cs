using Nez;
using Nez.Tiled;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NezZombie.Components
{
    class TestMap: Component
    {
        private TiledMap _sampleMap;
        public override void initialize()
        {
            var scene = entity.scene;
            var content = scene.content;

            _sampleMap = content.Load<TiledMap>("tinyforest");
            Entity testMap = entity.scene.createEntity("testmap");
            testMap.addComponent(new TiledMapComponent(_sampleMap, null, false)).setRenderLayer(1);
        }
    }
}
