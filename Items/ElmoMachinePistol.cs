using Microsoft.Xna.Framework;
using Terraria; 
using Terraria.ID;
using Terraria.ModLoader;

namespace RedMod.Items
{
	/*
		This is the class for Elmo's Machine Pistol.
	*/
	public class ElmoMachinePistol : ModItem
	{
		public override void SetStaticDefaults()
		{
			// Set the item's display name.
			DisplayName.SetDefault("Elmo's Machine Pistol");
			// Set the item's tooltip.
			Tooltip.SetDefault("Handcrafted straight in Skuodas.");
		}

		public override void SetDefaults()
		{
			item.damage = 15; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 5; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 5; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = Item.buyPrice(0, 0, 80, 150); // how much the item sells for (Item.buyPrice is measured like this: Item.buyPrice(platinum, gold, silver, copper))
			item.rare = ItemRarityID.Blue; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		/*
			Add spread to the gun.
		*/
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			/*
				For Elmo:
					A Vector2 is basically a location on the screen. Here, we use the same speed, but rotate it just a little bit.
					This gives the gun spread.
			*/
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}
	}
}