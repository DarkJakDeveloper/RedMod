using System;
using Terraria;
using Terraria.ModLoader;

namespace RedMod.Dusts
{
	// Token: 0x02000007 RID: 7
	public class Smoke : ModDust
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000295C File Offset: 0x00000B5C
		public override void OnSpawn(Dust dust)
		{
			dust.noGravity = true;
			dust.velocity *= 1f;
			dust.velocity.Y = dust.velocity.Y - 0.5f;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002990 File Offset: 0x00000B90
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
