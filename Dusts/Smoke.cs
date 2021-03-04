using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace RedMod.Dusts
{
    /*
        This is the actual smoke spawned by the projectile.
    */
    public class Smoke : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.noGravity = true;
            dust.velocity *= 1f;
            dust.velocity.Y -= 0.5f;
        }

        public override bool Update(Dust dust)
        {
            dust.position += dust.velocity;
            dust.rotation += dust.velocity.X * 0.1f;
            dust.scale -= 0.002f;
            if (dust.scale < 0.02f)
            {
                dust.active = false;
            }
            return false;
        }
    }
}