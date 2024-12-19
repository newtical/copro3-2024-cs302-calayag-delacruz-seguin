using System;
namespace ComprogProject
{
    public static class ArrayStorage
    {
        // 1) Gender
        public static string[] gender = { "Male", "Female", "Cisgender", "Transgender", "Bigender", "Non-binary", };
        // 2) Character Origins
        public static string[] characterOrigins = { "Human", "Cyborg", "Alien", "Demon", "Angel", "Elemental Being", "Undead", "Mythical Creature", "Animal"};
        // 3) Skin
        public static string[] skinColor = { "White", "Fair", "Brown", "Black", "Yellow", "Green", "Red", "Blue", "Gold", "Silver", "Bronze", "Scaled", "Glittering", "Crystal-like", "Stone" };
        // 4) Age Range
        public static string[] ageRange = { "Child", "Teen", "Mid 30s", "Mid 40s", "Mid 50s", "Senior", "Ageless", };
        // 5) Hair
        public static string[] hair = { "Spiky", "Slicked-Back", "Pixie", "Crown Braid", "Braids", "Buzz", "Mohawk", "Shaved/Bald", "Long Medieval" };
        // 6) Hair Color
        public static string[] hairColor = { "Black", "White", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Brown", "Blonde", "Silver", "Pink", "Gray" };
        // 7) Eye Color
        public static string[] eyeColor = { "Brown", "Blue", "Green", "Gray", "Hazel", "Blind", "Red", "Clear", "Heterochromatic" };
        // 8) Facial Expressions
        public static string[] facialExpressions = { "Happy Expressions", "Angry Expressions", "Sad Expressions", "Suprised Expressions", "Neutral Expressions" };

        public static string[] happyExpressions = { "Smiling", "Grinning", "Relaxed" };

        public static string[] angryExpressions = { "Narrowed Eyes", "Furrowed Brow", "Tightened Jaw" };

        public static string[] sadExpressions = { "Downturned Mouth", "Tearful", "Soft Eyes", };

        public static string[] surprisedExpressions = { "Wide Eyes", "Raised Eyebrows", "Open Mouth" };

        public static string[] neutralExpressions = { "Relaxed Eyes", "Neutral Mouth", "Flat Facial Features" };
        // 9) Body Size
        public static string[] bodySize = { "Petite", "Athletic Lean", "Extra Muscular", "Stocky and Broad", "Heavy" };

        // 10) Extra Body Parts (Example, you can store these as numbers or ranges)
        public static int[] arms = { 0, 1, 2, 3, 4, 5, 6 };
        public static int[] heads = { 1, 2, 3, 4, 5 };
        public static int[] eyes = { 0, 1, 2, 3, 4, 5, 6 };
        public static int[] legs = { 0, 1, 2, 3, 4, 5, 6 };
        // 11) Height
        public static string[] height = { "Small", "Average", "Tall", "Giant" };
        // 12) Clothing
        public static string[] overalls = { "Karate gi", "Jiu-Jitsu robes", "Firefighter", "Military outfits", "Suit", "Dress", "Medieval Knight", "Fantasy Mage Robes", "Samurai Armor", "Ninja Suit", "Circus Performer Outfit", "Pirate Outfit", "None" };

        public static string[] tops = { "Tank Top", "Crop Top", "Leather Jacket", "Hoodie", "Tunic", "Mesh Shirt", "T-shirt", "Button-Up Shirt", "Sweatshirt", "Sports Bra", "Military Vest", "Kimono", "Corset", "Exo-suit Upper Body", "Polo Shirt", "Tracksuit Jacket", "Blazer", "Windbreaker", "Crop Hoodie" };

        public static string[] bottoms = { "Skinny Jeans", "Shorts", "Track Pants", "Tactical Pants", "Tights", "Skirt", "Trousers", "Cargo Pants", "Joggers", "Sweatpants", "Leggings", "Denim Shorts", "Biker Shorts", "Capris", "Palazzo Pants", "Cargo Shorts", "Kilt", "Battle Skirt", "Ripped Jeans", "Capri Pants", "Formal Slacks", "Padded Pants" };

        public static string[] shoes = { "Combat Boots", "Sneakers", "Barefoot", "Tactical Footwear", "Sandals/Flip Flops", "Cowboy Boots", "Gladiator Sandals", "Wrestling Boots", "Training Shoes" };
        // 13) Accessories (Face, Wrist, Back, Neck, Head, Skin, Armor)
        public static string[] faceAccessories = { "Mask", "Glasses", "Eyepatches", "Crowns", "Muzzles", "Gas Mask", "Face Paint", "Bandages", "Visor", "Faceplate", "Beads", "Scarification", "Sunglasses", "Animal Mask", "Noses (prosthetics)", "Breathable Faceguard", "None" };

        public static string[] wristAccessories = { "Watch", "Wristbands", "Bracelets", "Armguards", "Cuffs", "Bangles", "Fingerless Gloves", "Wrist Ribbons", "Arm Sleeves", "Gauntlets", "Leather Straps", "Energy Bracelets", "Tactical Gloves", "Digital Wristband", "Energy Cuffs", "None" };

        public static string[] backAccessories = { "Backpack", "Capes", "Wings", "Quivers", "Shields", "Tails", "Extra Arms", "Cloak", "Hoverboard", "Jetpack", "Scarves", "Pouches", "Harness", "Back-mounted Weapons", "Mechanical Wings", "None" };

        public static string[] neckAccessories = { "Chains", "Chokers", "Amulets", "Fur", "Bow (Ribbon)", "Neck Scarves", "Neck Brace", "Medallions", "Collars", "Ties", "Neck Plates", "Spiked Neckband", "Bandanas", "Pearls", "Scarf with Hood", "None" };

        public static string[] headAccessories = { "Top Hat", "Helmets", "Hoods", "Horns", "Glasses", "Headsets", "Bandanas", "Beanies", "Crowns", "Visors", "Headbands", "Hair Accessories", "Rebreather Masks", "Faceplates", "VR Goggles", "None" };

        public static string[] skinAccessories = { "Freckles", "Tattoos", "Tribal Prints", "Scars", "Cyberpunk Marks", "Moles", "Glowing Veins", "Birthmarks", "Piercings", "Paint", "Wrinkles", "Alien Skin", "Bioluminescent Tattoos", "Body Paint", "Skin Armor", "None" };

        public static string[] armor = { "Heavy Armor", "Light Armor", "Clocks/Robes", "Exo-suits", "None" };
        // 14) Weapon Type
        public static string[] weapons = { "Daggers", "Swords", "Bows", "Guns", "Improvised", "Hands", "Magic" };

        public static string[] daggers = { "Dual Daggers", "Single Dagger", "Throwing Daggers", "Tanto", "Stiletto", "Kukri" };

        public static string[] swords = { "Katana", "Trident", "Longsword", "Saber", "Rapier", "Cutlass" };

        public static string[] bows = { "Longbow", "Crossbow", "Shortbow", "Warbow", "Flatbow", "Self-bow" };

        public static string[] guns = { "Rifles", "Revolver", "Shotgun", "SMG", "Snipers", "Flamethrower", "Machine gun" };

        public static string[] improvised = { "Frying Pan", "Baguette", "Chainsaw", "Baseball bat", "Wood" };

        public static string[] hands = { "Claws", "Fist", "Boxing Gloves", "Hidden blade", "War Fan" };

        public static string[] magic = { "Wand", "Book", "Cane", "Magic Hands", "Elements" };
        // 15) Idle Posture
        public static string[] idlePosture = { "Neutral", "Offensive", "Defensive", "Low (Squat)", "High (Stand Tall)", "Fighting Stance", "Low Guard" };
        // 16) Fighting Styles
        public static string[] fightingStyles = { "Martial Arts", "Boxing", "Muay Thai", "Magic", "Weaponry", "Traps" };

        // 17) Splash Background
        public static string[] splashBackground = { "Futuristic City", "Jungle/Forest", "Ancient Ruins", "Underground", "Volcanic Environment", "Space", "Snow/Arctic", "Urban Streets" };
        // 18) Voice Types
        public static string[] voiceTypes = { "Deep Voice", "High-Pitched Voice", "Gravelly Voice", "Smooth Voice", "Electronic/Modulated Voice", "Echoing Voice" };
        // 19) Emotes
        public static string[] emotes = { "Taunt", "Uses Weapons", "Uses an Item", "Stands Still", "Sits", "Uses Magic", "Dance", "Performs Action", "Taunt" };
        // 20) Entrance Animation
        public static string[] entranceAnimation = { "Jumps in", "Walk in", "Uses a transportation", "Teleports", "Flies" };
        // 21) Victory Animation
        public static string[] victoryAnimation = { "Victory Poses", "Taunts", "Laughs", "Fatalities", "Power ups", "Idle" };
        // 22) Defeat Animation
        public static string[] defeatAnimation = { "Collapsing", "Vanishing", "Dying", "Crushed", "Falling", "Last Stand" };


    }
}
