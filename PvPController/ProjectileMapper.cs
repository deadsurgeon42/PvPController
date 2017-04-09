﻿using Terraria;

namespace PvPController
{
    public static class ProjectileMapper
    {
        public static Item DetermineWeaponUsed(int type, Player player)
        {
            Item weaponUsed = player.TshockPlayer.SelectedItem;
            switch (type)
            {
                case 150: // Nettle Burst (1)
                case 151: // Nettle Burst (2)
                case 152: // Nettle Burst (End)
                    HandleNettleBurst(ref weaponUsed, type, player);
                    break;

                case 238: // Nimbus Rain Cloud
                case 239: // Nimbus Rain
                    HandleNimbus(ref weaponUsed, type, player);
                    break;

                case 244: // Crimson Rain Cloud
                case 245: // Crimson Rain
                    HandleCrimsonRain(ref weaponUsed, type, player);
                    break;
                    
                case 246: // Stynger
                    HandleStynger(ref weaponUsed, type, player);
                    break;

                case 250:
                case 251: // Rainbow (from Rainbow Gun)
                    HandleRainbowGun(ref weaponUsed, type, player);
                    break;
                    
                case 296: // Inferno Blast 
                    HandleInfernoBlast(ref weaponUsed, type, player);
                    break;
                    
                case 307: // Tiny Eater 
                    HandleTinyEater(ref weaponUsed, type, player);
                    break;
                
                case 344: // North Pole (secondary projectile stage)
                    HandleNorthPole(ref weaponUsed, type, player);
                    break;
                    
                case 400: // Molotov Fire (1)
                case 401: // Molotov Fire (2)
                case 402: // Molotov Fire (3)
                    HandleMolotovFire(ref weaponUsed, type, player);
                    break;
                    
                case 411: // Toxic Cloud (1)
                case 412: // Toxic Cloud (2)
                case 413: // Toxic Cloud (3)
                    HandleToxicCloud(ref weaponUsed, type, player);
                    break;
                    
                case 522: // Crystal Charge 
                    HandleCrystalCharge(ref weaponUsed, type, player);
                    break;
                
                case 640: // Luminite Arrow (second phase)
                    player.ProjectileWeapon[type] = player.LastActiveBow;
                    break;

                default:
                    if (Utils.IsBow(player.TshockPlayer.SelectedItem))
                    {
                        player.LastActiveBow = player.TshockPlayer.SelectedItem;
                    }

                    player.ProjectileWeapon[type] = player.TshockPlayer.SelectedItem;
                    break;
            }

            return weaponUsed;
        }

        private static void HandleNettleBurst(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(788);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleNimbus(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1244);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleCrimsonRain(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1256);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleStynger(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1258);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleRainbowGun(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1260);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleInfernoBlast(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1445);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleTinyEater(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1571);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleNorthPole(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(1947);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleMolotovFire(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(2590);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleToxicCloud(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(3105);
            player.ProjectileWeapon[type] = weaponUsed;
        }

        private static void HandleCrystalCharge(ref Item weaponUsed, int type, Player player)
        {
            weaponUsed.SetDefaults(3209);
            player.ProjectileWeapon[type] = weaponUsed;
        }
    }
}
