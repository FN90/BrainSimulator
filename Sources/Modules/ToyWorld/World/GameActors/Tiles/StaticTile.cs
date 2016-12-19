﻿namespace World.GameActors.Tiles
{
    /// <summary>
    ///     StaticTile is tile, which cannot be updated, but can be replaced by dynamic tile. Only one static
    /// </summary>
    public abstract class StaticTile : Tile
    {
        protected StaticTile() : base()
        {
        }

        protected StaticTile(int textureId) : base(textureId)
        {
        }

        protected StaticTile(string textureName) : base(textureName)
        {
        }
    }
}
