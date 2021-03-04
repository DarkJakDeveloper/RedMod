using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedMod.Items
{
	// Token: 0x02000005 RID: 5
	public class MantvySword : ModItem
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002736 File Offset: 0x00000936
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("The Sword of Mantvydas");
			base.Tooltip.SetDefault("Red's ultra sword.");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002758 File Offset: 0x00000958
		public override void SetDefaults()
		{
			base.item.damage = 196;
			base.item.melee = true;
			base.item.width = 40;
			base.item.height = 40;
			base.item.useTime = 20;
			base.item.useAnimation = 20;
			base.item.useStyle = 1;
			base.item.knockBack = 6f;
			base.item.value = 10000;
			base.item.rare = 2;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002809 File Offset: 0x00000A09
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(2, 10);
			modRecipe.AddTile(18);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}
	}
}
