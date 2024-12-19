using ComprogProject;
using ConsoleApp1;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml.Linq;
using static Idk;
abstract class Selection
{
    public abstract int GetSelection(string[] options, string prompt);
}
class Idk : Selection, ICharacterCustomization
{
   static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PROJECT_COMPROG;Integrated Security=True;Encrypt=False;";
    private Infos characterInfo;

    public Idk()
    {
        this.characterInfo = new Infos
        {
            NameInput = "Default",
            GenderInput = 1,
            AgeRangeInput = 1,
            CharacterOriginInput = 1,
            SkinColorInput = 1,
            HairInput = 1,
            HairColorInput = 1,
            EyeColorInput = 1,
            FacialExpressionInput = 1,
            BodySizeInput = 1,
            ArmsInput = 1,
            HeadsInput = 1,
            EyesInput = 1,
            LegsInput = 1,
            HeightInput = 1,
            OverallInput = 1,
            TopsInput = 1,
            BottomsInput = 1,
            ShoesInput = 1,
            FaceAccessoriesInput = 1,
            WristAccessoriesInput = 1,
            BackAccessoriesInput = 1,
            NeckAccessoriesInput = 1,
            HeadAccessoriesInput = 1,
            SkinAccessoriesInput = 1,
            ArmorInput = 1,
            WeaponsInput = 1,
            IdlePostureInput = 1,
            FightingStylesInput = 1,
            SplashBackgroundInput = 1,
            VoiceTypesInput = 1,
            EmotesInput = 1,
            EntranceAnimationInput = 1,
            VictoryAnimationInput = 1,
            DefeatAnimationInput = 1,
            HappyExpressionInput = 1,
            AngryExpressionsInput = 1,
            SadExpressionsInput = 1,
            SurprisedExpressionsInput = 1,
            NeutralExpressionsInput = 1,
            FacialHairStylesInput = 1,
            FacialHairInput = false
        };
    }
    public struct Infos
    {
        public string NameInput { get; set; }
        public int GenderInput { get; set; }
        public int AgeRangeInput { get; set; }
        public int CharacterOriginInput { get; set; }
        public int SkinColorInput { get; set; }
        public int HairInput { get; set; }
        public int HairColorInput { get; set; }
        public int EyeColorInput { get; set; }
        public int FacialExpressionInput { get; set; }
        public int BodySizeInput { get; set; }
        public int ArmsInput { get; set; }
        public int HeadsInput { get; set; }
        public int EyesInput { get; set; }
        public int LegsInput { get; set; }
        public int HeightInput { get; set; }
        public int OverallInput { get; set; }
        public int TopsInput { get; set; }
        public int BottomsInput { get; set; }
        public int ShoesInput { get; set; }
        public int FaceAccessoriesInput { get; set; }
        public int WristAccessoriesInput { get; set; }
        public int BackAccessoriesInput { get; set; }
        public int NeckAccessoriesInput { get; set; }
        public int HeadAccessoriesInput { get; set; }
        public int SkinAccessoriesInput { get; set; }
        public int ArmorInput { get; set; }
        public int WeaponsInput { get; set; }
        public int IdlePostureInput { get; set; }
        public int FightingStylesInput { get; set; }
        public int SplashBackgroundInput { get; set; }
        public int VoiceTypesInput { get; set; }
        public int EmotesInput { get; set; }
        public int EntranceAnimationInput { get; set; }
        public int VictoryAnimationInput { get; set; }
        public int DefeatAnimationInput { get; set; }
        public int HappyExpressionInput { get; set; }
        public int AngryExpressionsInput { get; set; }
        public int SadExpressionsInput { get; set; }
        public int SurprisedExpressionsInput { get; set; }
        public int NeutralExpressionsInput { get; set; }
        public int FacialHairStylesInput { get; set; }
        public bool FacialHairInput { get; set; }
    }

    public string Name
    {
        get { return characterInfo.NameInput; }
        set { characterInfo.NameInput = value; }
    }

    public int Gender
    {
        get { return characterInfo.GenderInput; }
        set { characterInfo.GenderInput = value; }
    }

    public int AgeRange
    {
        get { return characterInfo.AgeRangeInput; }
        set { characterInfo.AgeRangeInput = value; }
    }

    public int SkinColor
    {
        get { return characterInfo.SkinColorInput; }
        set { characterInfo.SkinColorInput = value; }
    }

    public int Hair
    {
        get { return characterInfo.HairInput; }
        set { characterInfo.HairInput = value; }
    }

    public int HairColor
    {
        get { return characterInfo.HairColorInput; }
        set { characterInfo.HairColorInput = value; }
    }

    public int EyeColor
    {
        get { return characterInfo.EyeColorInput; }
        set { characterInfo.EyeColorInput = value; }
    }

    public int FacialExpression
    {
        get { return characterInfo.FacialExpressionInput; }
        set { characterInfo.FacialExpressionInput = value; }
    }

    public int BodySize
    {
        get { return characterInfo.BodySizeInput; }
        set { characterInfo.BodySizeInput = value; }
    }

    public int Arms
    {
        get { return characterInfo.ArmsInput; }
        set { characterInfo.ArmsInput = value; }
    }

    public int Heads
    {
        get { return characterInfo.HeadsInput; }
        set { characterInfo.HeadsInput = value; }
    }

    public int Eyes
    {
        get { return characterInfo.EyesInput; }
        set { characterInfo.EyesInput = value; }
    }

    public int Legs
    {
        get { return characterInfo.LegsInput; }
        set { characterInfo.LegsInput = value; }
    }

    public int Height
    {
        get { return characterInfo.HeightInput; }
        set { characterInfo.HeightInput = value; }
    }

    public int Overall
    {
        get { return characterInfo.OverallInput; }
        set { characterInfo.OverallInput = value; }
    }

    public int Tops
    {
        get { return characterInfo.TopsInput; }
        set { characterInfo.TopsInput = value; }
    }

    public int Bottoms
    {
        get { return characterInfo.BottomsInput; }
        set { characterInfo.BottomsInput = value; }
    }

    public int Shoes
    {
        get { return characterInfo.ShoesInput; }
        set { characterInfo.ShoesInput = value; }
    }

    public int FaceAccessories
    {
        get { return characterInfo.FaceAccessoriesInput; }
        set { characterInfo.FaceAccessoriesInput = value; }
    }

    public int WristAccessories
    {
        get { return characterInfo.WristAccessoriesInput; }
        set { characterInfo.WristAccessoriesInput = value; }
    }

    public int BackAccessories
    {
        get { return characterInfo.BackAccessoriesInput; }
        set { characterInfo.BackAccessoriesInput = value; }
    }

    public int NeckAccessories
    {
        get { return characterInfo.NeckAccessoriesInput; }
        set { characterInfo.NeckAccessoriesInput = value; }
    }

    public int HeadAccessories
    {
        get { return characterInfo.HeadAccessoriesInput; }
        set { characterInfo.HeadAccessoriesInput = value; }
    }

    public int SkinAccessories
    {
        get { return characterInfo.SkinAccessoriesInput; }
        set { characterInfo.SkinAccessoriesInput = value; }
    }

    public int Armor
    {
        get { return characterInfo.ArmorInput; }
        set { characterInfo.ArmorInput = value; }
    }

    public int Weapons
    {
        get { return characterInfo.WeaponsInput; }
        set { characterInfo.WeaponsInput = value; }
    }

    public int IdlePosture
    {
        get { return characterInfo.IdlePostureInput; }
        set { characterInfo.IdlePostureInput = value; }
    }

    public int FightingStyles
    {
        get { return characterInfo.FightingStylesInput; }
        set { characterInfo.FightingStylesInput = value; }
    }

    public int SplashBackground
    {
        get { return characterInfo.SplashBackgroundInput; }
        set { characterInfo.SplashBackgroundInput = value; }
    }

    public int VoiceTypes
    {
        get { return characterInfo.VoiceTypesInput; }
        set { characterInfo.VoiceTypesInput = value; }
    }

    public int Emotes
    {
        get { return characterInfo.EmotesInput; }
        set { characterInfo.EmotesInput = value; }
    }

    public int EntranceAnimation
    {
        get { return characterInfo.EntranceAnimationInput; }
        set { characterInfo.EntranceAnimationInput = value; }
    }

    public int VictoryAnimation
    {
        get { return characterInfo.VictoryAnimationInput; }
        set { characterInfo.VictoryAnimationInput = value; }
    }

    public int DefeatAnimation
    {
        get { return characterInfo.DefeatAnimationInput; }
        set { characterInfo.DefeatAnimationInput = value; }
    }

    public int HappyExpression
    {
        get { return characterInfo.HappyExpressionInput; }
        set { characterInfo.HappyExpressionInput = value; }
    }

    public int AngryExpression
    {
        get { return characterInfo.AngryExpressionsInput; }
        set { characterInfo.AngryExpressionsInput = value; }
    }
    public int CharacterOrigin
    {
        get { return characterInfo.CharacterOriginInput; }
        set { characterInfo.CharacterOriginInput = value; }
    }

    public int SadExpression
    {
        get { return characterInfo.SadExpressionsInput; }
        set { characterInfo.SadExpressionsInput = value; }
    }

    public int SurprisedExpression
    {
        get { return characterInfo.SurprisedExpressionsInput; }
        set { characterInfo.SurprisedExpressionsInput = value; }
    }

    public int NeutralExpression
    {
        get { return characterInfo.NeutralExpressionsInput; }
        set { characterInfo.NeutralExpressionsInput = value; }
    }

    public int FacialHairStyles
    {
        get { return characterInfo.FacialHairStylesInput; }
        set { characterInfo.FacialHairStylesInput = value; }
    }

    public bool FacialHair
    {
        get { return characterInfo.FacialHairInput; }
        set { characterInfo.FacialHairInput = value; }
    }


    public void Randomize()
    {
        Random random = new Random();

        Gender = random.Next(1, ArrayStorage.gender.Length + 1);
        AgeRange = random.Next(1, ArrayStorage.ageRange.Length + 1);
        CharacterOrigin = random.Next(1, ArrayStorage.characterOrigins.Length + 1);
        Arms = random.Next(1, ArrayStorage.arms.Length + 1);
        Heads = random.Next(1, ArrayStorage.heads.Length + 1);
        Eyes = random.Next(1, ArrayStorage.eyes.Length + 1);
        Legs = random.Next(1, ArrayStorage.legs.Length + 1);
        Tops = random.Next(1, ArrayStorage.tops.Length + 1);
        Overall = random.Next(1, ArrayStorage.overalls.Length + 1);
        Bottoms = random.Next(1, ArrayStorage.bottoms.Length + 1);
        Shoes = random.Next(1, ArrayStorage.shoes.Length + 1);
        FacialExpression = random.Next(1, ArrayStorage.facialExpressions.Length + 1);
        AngryExpression = random.Next(1, ArrayStorage.angryExpressions.Length + 1);
        HappyExpression = random.Next(1, ArrayStorage.happyExpressions.Length + 1);
        SadExpression = random.Next(1, ArrayStorage.sadExpressions.Length + 1);
        SurprisedExpression = random.Next(1, ArrayStorage.surprisedExpressions.Length + 1);
        NeutralExpression = random.Next(1, ArrayStorage.neutralExpressions.Length + 1);
        FaceAccessories = random.Next(1, ArrayStorage.faceAccessories.Length + 1);
        WristAccessories = random.Next(1, ArrayStorage.wristAccessories.Length + 1);
        BackAccessories = random.Next(1, ArrayStorage.backAccessories.Length + 1);
        NeckAccessories = random.Next(1, ArrayStorage.neckAccessories.Length + 1);
        HeadAccessories = random.Next(1, ArrayStorage.headAccessories.Length + 1);
        SkinAccessories = random.Next(1, ArrayStorage.skinAccessories.Length + 1);
        Armor = random.Next(1, ArrayStorage.armor.Length + 1);
        IdlePosture = random.Next(1, ArrayStorage.idlePosture.Length + 1);
        Emotes = random.Next(1, ArrayStorage.emotes.Length + 1);
        EntranceAnimation = random.Next(1, ArrayStorage.entranceAnimation.Length + 1);
        VictoryAnimation = random.Next(1, ArrayStorage.victoryAnimation.Length + 1);
        DefeatAnimation = random.Next(1, ArrayStorage.defeatAnimation.Length + 1);
        Hair = random.Next(1, ArrayStorage.hair.Length + 1);
        SkinColor = random.Next(1, ArrayStorage.skinColor.Length + 1);
        HairColor = random.Next(1, ArrayStorage.hairColor.Length + 1);
        EyeColor = random.Next(1, ArrayStorage.eyeColor.Length + 1);
        BodySize = random.Next(1, ArrayStorage.bodySize.Length + 1);
        Height = random.Next(1, ArrayStorage.height.Length + 1);
        Weapons = random.Next(1, ArrayStorage.weapons.Length + 1);
        FightingStyles = random.Next(1, ArrayStorage.fightingStyles.Length + 1);
        SplashBackground = random.Next(1, ArrayStorage.splashBackground.Length + 1);
        VoiceTypes = random.Next(1, ArrayStorage.voiceTypes.Length + 1);
        FacialHair = random.Next(0, 2) == 1;

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Character Randomized!");
    }

    public interface ICharacterCustomization
    {
        void CharacterCustomization();
        void Outputs();
    }
    public bool IsNameTaken(string name)
    {
        string query = "SELECT COUNT(*) FROM CHARACTER_SELECTION WHERE characterName = @name";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking name: {ex.Message}");
                return false;
            }
        }
    }
    public void CharacterCustomization()
    {

        while (true)
        {
            characterInfo.NameInput = GetName("Enter your name");

            // Check if the name already exists in the database
            if (IsNameTaken(characterInfo.NameInput))
            {
                Console.WriteLine("This name is already taken, please choose another one.");
            }
            else
            {
                break;
            }
        }
        string userInput;
        while (true)
        {
            Console.WriteLine("Would you like to Randomize Character Creation? Y/N");
            userInput = Console.ReadLine();

            if (!(userInput.Equals("Y", StringComparison.OrdinalIgnoreCase) || userInput.Equals("N", StringComparison.OrdinalIgnoreCase)))
            {
                Console.Clear();
                Console.WriteLine("Invalid Selection, Try again");
                Console.WriteLine(" ");
            }
            else
            {
                Console.Clear();
                break;
            }
        }

        if (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            Randomize();
        }
        else
        {
            characterInfo.CharacterOriginInput = GetSelection(ArrayStorage.characterOrigins, "Select your Origin");
            characterInfo.GenderInput = GetSelection(ArrayStorage.gender, "Select your Gender");
            characterInfo.AgeRangeInput = GetSelection(ArrayStorage.ageRange, "Select your Age Range");
            characterInfo.SkinColorInput = GetSelection(ArrayStorage.skinColor, "Select your Skin Color");
            characterInfo.HairInput = GetSelection(ArrayStorage.hair, "Select your Hair Style");
            characterInfo.HairColorInput = GetSelection(ArrayStorage.hairColor, "Select your Hair Color");
            characterInfo.EyeColorInput = GetSelection(ArrayStorage.eyeColor, "Select your Eye Color");
            characterInfo.FacialExpressionInput = GetSelection(ArrayStorage.facialExpressions, "Select your Facial Expression");

            if (characterInfo.FacialExpressionInput == 1)
            {
                characterInfo.HappyExpressionInput = GetSelection(ArrayStorage.happyExpressions, "Select your Happy Expression");
            }
            else if (characterInfo.FacialExpressionInput == 2)
            {
                characterInfo.AngryExpressionsInput = GetSelection(ArrayStorage.angryExpressions, "Select your Angry Expression");
            }
            else if (characterInfo.FacialExpressionInput == 3)
            {
                characterInfo.SadExpressionsInput = GetSelection(ArrayStorage.sadExpressions, "Select your Sad Expression");
            }
            else if (characterInfo.FacialExpressionInput == 4)
            {
                characterInfo.SurprisedExpressionsInput = GetSelection(ArrayStorage.surprisedExpressions, "Select your Surprised Expression");
            }
            else if (characterInfo.FacialExpressionInput == 5)
            {
                characterInfo.NeutralExpressionsInput = GetSelection(ArrayStorage.neutralExpressions, "Select your Neutral Expression");
            }

            characterInfo.ArmsInput = GetSelection("Input the number of arms:");
            characterInfo.HeadsInput = GetSelection("Input the number of heads:");
            characterInfo.EyesInput = GetSelection("Input the number of eyes:");
            characterInfo.LegsInput = GetSelection("Input the number of legs:");


            characterInfo.BodySizeInput = GetSelection(ArrayStorage.bodySize, "Select your Body Size");
            characterInfo.FacialHairInput = GetFacialHair("Would you like to have Facial Hair? Y/N");


            characterInfo.HeightInput = GetSelection(ArrayStorage.height, "Select your Height");
            characterInfo.OverallInput = GetSelection(ArrayStorage.overalls, "Select your Clothing (Overalls)");
            characterInfo.TopsInput = GetSelection(ArrayStorage.tops, "Select your Clothing (Tops)");
            characterInfo.BottomsInput = GetSelection(ArrayStorage.bottoms, "Select your Clothing (Bottoms)");
            characterInfo.ShoesInput = GetSelection(ArrayStorage.shoes, "Select your Shoes");
            characterInfo.FaceAccessoriesInput = GetSelection(ArrayStorage.faceAccessories, "Select your Face Accessories");
            characterInfo.WristAccessoriesInput = GetSelection(ArrayStorage.wristAccessories, "Select your Wrist Accessories");
            characterInfo.BackAccessoriesInput = GetSelection(ArrayStorage.backAccessories, "Select your Back Accessories");
            characterInfo.NeckAccessoriesInput = GetSelection(ArrayStorage.neckAccessories, "Select your Neck Accessories");
            characterInfo.HeadAccessoriesInput = GetSelection(ArrayStorage.headAccessories, "Select your Head Accessories");
            characterInfo.SkinAccessoriesInput = GetSelection(ArrayStorage.skinAccessories, "Select your Skin Accessories");
            characterInfo.ArmorInput = GetSelection(ArrayStorage.armor, "Select your Armor");
            characterInfo.WeaponsInput = GetSelection(ArrayStorage.weapons, "Select your Weapon Type");
            characterInfo.IdlePostureInput = GetSelection(ArrayStorage.idlePosture, "Select your Idle Posture");
            characterInfo.FightingStylesInput = GetSelection(ArrayStorage.fightingStyles, "Select your Fighting Style");
            characterInfo.SplashBackgroundInput = GetSelection(ArrayStorage.splashBackground, "Select your Splash Background");
            characterInfo.VoiceTypesInput = GetSelection(ArrayStorage.voiceTypes, "Select your Voice Type");
            characterInfo.EmotesInput = GetSelection(ArrayStorage.emotes, "Select your Emote");
            characterInfo.EntranceAnimationInput = GetSelection(ArrayStorage.entranceAnimation, "Select your Entrance Animation");
            characterInfo.VictoryAnimationInput = GetSelection(ArrayStorage.victoryAnimation, "Select your Victory Animation");
            characterInfo.DefeatAnimationInput = GetSelection(ArrayStorage.defeatAnimation, "Select your Defeat Animation");
        }

        SaveCharacterToDatabase(characterInfo);
        Outputs();
        Program.GoBackToMenu();
    }
    public int GetSelection(string ques)
    {
        int input = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Maximum of 6");
                Console.WriteLine(ques);
                input = Convert.ToInt32(Console.ReadLine());

                if (input > 6)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, Exceeded Maximum count. Try again.");
                }
                else if (input <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, must be greater than 0. Try again.");
                }
                else
                {
                    // Valid input
                    break;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Please enter a valid number.");
            }
        }

        Console.Clear();
        return input;
    }
    public void Outputs()
    {
        string facialExpression = ArrayStorage.facialExpressions[characterInfo.FacialExpressionInput - 1];

        string expressionType = characterInfo.FacialExpressionInput switch
        {
            1 => ArrayStorage.happyExpressions[characterInfo.HappyExpressionInput - 1],
            2 => ArrayStorage.angryExpressions[characterInfo.AngryExpressionsInput - 1],
            3 => ArrayStorage.sadExpressions[characterInfo.SadExpressionsInput - 1],
            4 => ArrayStorage.surprisedExpressions[characterInfo.SurprisedExpressionsInput - 1],
            5 => ArrayStorage.neutralExpressions[characterInfo.NeutralExpressionsInput - 1],
            _ => "Unknown Expression"
        };

        Console.WriteLine("Character Creation Successful!");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Your Character:");
        Console.WriteLine($"Name: {characterInfo.NameInput}");
        Console.WriteLine($"Origin: {ArrayStorage.characterOrigins[characterInfo.CharacterOriginInput - 1]}");
        Console.WriteLine($"Gender: {ArrayStorage.gender[characterInfo.GenderInput - 1]}");
        Console.WriteLine($"Age Range: {ArrayStorage.ageRange[characterInfo.AgeRangeInput - 1]}");
        Console.WriteLine($"Skin Color: {ArrayStorage.skinColor[characterInfo.SkinColorInput - 1]}");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Hair Style: {ArrayStorage.hair[characterInfo.HairInput - 1]}");
        Console.WriteLine($"Hair Color: {ArrayStorage.hairColor[characterInfo.HairColorInput - 1]}");
        Console.WriteLine($"Eye Color: {ArrayStorage.eyeColor[characterInfo.EyeColorInput - 1]}");
        Console.WriteLine($"Body Size: {ArrayStorage.bodySize[characterInfo.BodySizeInput - 1]}");
        Console.WriteLine($"Height: {ArrayStorage.height[characterInfo.HeightInput - 1]}");

        if (characterInfo.FacialHairInput)
        {
            Console.WriteLine($"Facial Hair: True");
        }
        else
        {
            Console.WriteLine("Facial Hair: None");
        }
        Console.WriteLine($"Arms: {characterInfo.ArmsInput}");
        Console.WriteLine($"Head: {characterInfo.HeadsInput}");
        Console.WriteLine($"Eyes: {characterInfo.EyesInput}");
        Console.WriteLine($"Legs: {characterInfo.LegsInput}");

        Console.WriteLine($"{facialExpression} : {expressionType}");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Clothings:");
        Console.WriteLine($"Overall: {ArrayStorage.overalls[characterInfo.OverallInput - 1]}");
        Console.WriteLine($"Tops: {ArrayStorage.tops[characterInfo.TopsInput - 1]}");
        Console.WriteLine($"Bottoms: {ArrayStorage.bottoms[characterInfo.BottomsInput - 1]}");
        Console.WriteLine($"Shoes: {ArrayStorage.shoes[characterInfo.ShoesInput - 1]}");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("Accessories:");
        Console.WriteLine($"Face Accessories: {ArrayStorage.faceAccessories[characterInfo.FaceAccessoriesInput - 1]}");
        Console.WriteLine($"Wrist Accessories: {ArrayStorage.wristAccessories[characterInfo.WristAccessoriesInput - 1]}");
        Console.WriteLine($"Back Accessories: {ArrayStorage.backAccessories[characterInfo.BackAccessoriesInput - 1]}");
        Console.WriteLine($"Neck Accessories: {ArrayStorage.neckAccessories[characterInfo.NeckAccessoriesInput - 1]}");
        Console.WriteLine($"Head Accessories: {ArrayStorage.headAccessories[characterInfo.HeadAccessoriesInput - 1]}");
        Console.WriteLine($"Skin Accessories: {ArrayStorage.skinAccessories[characterInfo.SkinAccessoriesInput - 1]}");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine($"Armor: {ArrayStorage.armor[characterInfo.ArmorInput - 1]}");
        Console.WriteLine($"Weapons: {ArrayStorage.weapons[characterInfo.WeaponsInput - 1]}");
        Console.WriteLine($"Idle Posture: {ArrayStorage.idlePosture[characterInfo.IdlePostureInput - 1]}");
        Console.WriteLine($"Fighting Styles: {ArrayStorage.fightingStyles[characterInfo.FightingStylesInput - 1]}");
        Console.WriteLine($"Splash Background: {ArrayStorage.splashBackground[characterInfo.SplashBackgroundInput - 1]}");
        Console.WriteLine($"Voice Type: {ArrayStorage.voiceTypes[characterInfo.VoiceTypesInput - 1]}");
        Console.WriteLine($"Emotes: {ArrayStorage.emotes[characterInfo.EmotesInput - 1]}");
        Console.WriteLine($"Entrance Animation: {ArrayStorage.entranceAnimation[characterInfo.EntranceAnimationInput - 1]}");
        Console.WriteLine($"Victory Animation: {ArrayStorage.victoryAnimation[characterInfo.VictoryAnimationInput - 1]}");
        Console.WriteLine($"Defeat Animation: {ArrayStorage.defeatAnimation[characterInfo.DefeatAnimationInput - 1]}");
    }
    string GetName(string prompt)
    {
        string name = null;

        while (true)
        {
            Console.WriteLine(prompt);
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.Clear();
                Console.WriteLine("Name cannot be empty. Please try again.");
            }
            else
            {
                Console.Clear();
                break;
            }
        }

        return name;
    }
    bool GetFacialHair(string prompt)
    {
        bool value = false;

        while (true)
        {
            Console.WriteLine(prompt);
            string userinput = Console.ReadLine();
            if (!(userinput.Equals("Y", StringComparison.OrdinalIgnoreCase) || userinput.Equals("N", StringComparison.OrdinalIgnoreCase)))
            {
                Console.Clear();

                Console.WriteLine("Invalid Selection, Try again");

            }
            else if (userinput.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                value = true;
                break;
            }

            if (userinput.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                value = false;
                break;
            }
        }
        Console.Clear();
        return value;
    }
    public override int GetSelection(string[] options, string prompt)
    {
        while (true)
        {
            int input = 0;
            try
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(prompt);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {options[i]}");

                }
                Console.WriteLine("----------------------------------------");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (input >= 1 && input <= options.Length)
                {
                    return input;
                }
                Console.WriteLine("Invalid Value! Please select a valid option.");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please try again.");
            }


        }
    }
    static void SaveCharacterToDatabase(Infos characterInfo)
    {

        string insertQuery = @"
        INSERT INTO CHARACTER_SELECTION 
        (
            characterName, gender, age, origin, skinColor, hairStyle, hairColor, eyeColor, 
            bodySize, height, facialHair, overall, tops, bottoms, shoes, 
            faceAccessories, wristAccessories, backAccessories, neckAccessories, headAccessories, 
            skinAccessories, armor, weapons, idlePosture, fightingStyle, splashBackground, 
            voiceType, emotes, entranceAnimation, victoryAnimation, defeatAnimation, arms, heads, eyes, legs
        ) 
        VALUES 
        (
            @name, @gender, @age, @origin, @skinColor, @hairStyle, @hairColor, @eyeColor, 
            @bodySize, @height, @facialHair, @overall, @tops, @bottoms, @shoes, 
            @faceAccessories, @wristAccessories, @backAccessories, @neckAccessories, @headAccessories, 
            @skinAccessories, @armor, @weapons, @idlePosture, @fightingStyle, @splashBackground, 
            @voiceType, @emotes, @entranceAnimation, @victoryAnimation, @defeatAnimation, @arms, @heads, @eyes, @legs
        )";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", characterInfo.NameInput);
                    command.Parameters.AddWithValue("@gender", ArrayStorage.gender[characterInfo.GenderInput - 1]);
                    command.Parameters.AddWithValue("@age", ArrayStorage.ageRange[characterInfo.AgeRangeInput - 1]);
                    command.Parameters.AddWithValue("@origin", ArrayStorage.characterOrigins[characterInfo.CharacterOriginInput - 1]);

                    command.Parameters.AddWithValue("@skinColor", ArrayStorage.skinColor[characterInfo.SkinColorInput - 1]);
                    command.Parameters.AddWithValue("@hairStyle", ArrayStorage.hair[characterInfo.HairInput - 1]);
                    command.Parameters.AddWithValue("@hairColor", ArrayStorage.hairColor[characterInfo.HairColorInput - 1]);
                    command.Parameters.AddWithValue("@eyeColor", ArrayStorage.eyeColor[characterInfo.EyeColorInput - 1]);
                    command.Parameters.AddWithValue("@bodySize", ArrayStorage.bodySize[characterInfo.BodySizeInput - 1]);
                    command.Parameters.AddWithValue("@height", ArrayStorage.height[characterInfo.HeightInput - 1]);
                    command.Parameters.AddWithValue("@facialHair", characterInfo.FacialHairInput);

                    command.Parameters.AddWithValue("@overall", ArrayStorage.overalls[characterInfo.OverallInput - 1]);
                    command.Parameters.AddWithValue("@tops", ArrayStorage.tops[characterInfo.TopsInput - 1]);
                    command.Parameters.AddWithValue("@bottoms", ArrayStorage.bottoms[characterInfo.BottomsInput - 1]);
                    command.Parameters.AddWithValue("@shoes", ArrayStorage.shoes[characterInfo.ShoesInput - 1]);

                    command.Parameters.AddWithValue("@faceAccessories", ArrayStorage.faceAccessories[characterInfo.FaceAccessoriesInput - 1]);
                    command.Parameters.AddWithValue("@wristAccessories", ArrayStorage.wristAccessories[characterInfo.WristAccessoriesInput - 1]);
                    command.Parameters.AddWithValue("@backAccessories", ArrayStorage.backAccessories[characterInfo.BackAccessoriesInput - 1]);
                    command.Parameters.AddWithValue("@neckAccessories", ArrayStorage.neckAccessories[characterInfo.NeckAccessoriesInput - 1]);
                    command.Parameters.AddWithValue("@headAccessories", ArrayStorage.headAccessories[characterInfo.HeadAccessoriesInput - 1]);
                    command.Parameters.AddWithValue("@skinAccessories", ArrayStorage.skinAccessories[characterInfo.SkinAccessoriesInput - 1]);

                    command.Parameters.AddWithValue("@armor", ArrayStorage.armor[characterInfo.ArmorInput - 1]);
                    command.Parameters.AddWithValue("@weapons", ArrayStorage.weapons[characterInfo.WeaponsInput - 1]);
                    command.Parameters.AddWithValue("@idlePosture", ArrayStorage.idlePosture[characterInfo.IdlePostureInput - 1]);
                    command.Parameters.AddWithValue("@fightingStyle", ArrayStorage.fightingStyles[characterInfo.FightingStylesInput - 1]);
                    command.Parameters.AddWithValue("@splashBackground", ArrayStorage.splashBackground[characterInfo.SplashBackgroundInput - 1]);
                    command.Parameters.AddWithValue("@voiceType", ArrayStorage.voiceTypes[characterInfo.VoiceTypesInput - 1]);
                    command.Parameters.AddWithValue("@emotes", ArrayStorage.emotes[characterInfo.EmotesInput - 1]);
                    command.Parameters.AddWithValue("@entranceAnimation", ArrayStorage.entranceAnimation[characterInfo.EntranceAnimationInput - 1]);
                    command.Parameters.AddWithValue("@victoryAnimation", ArrayStorage.victoryAnimation[characterInfo.VictoryAnimationInput - 1]);
                    command.Parameters.AddWithValue("@defeatAnimation", ArrayStorage.defeatAnimation[characterInfo.DefeatAnimationInput - 1]);

                    command.Parameters.AddWithValue("@arms", characterInfo.ArmsInput);
                    command.Parameters.AddWithValue("@heads", characterInfo.HeadsInput);
                    command.Parameters.AddWithValue("@eyes", characterInfo.EyesInput);
                    command.Parameters.AddWithValue("@legs", characterInfo.LegsInput);




                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Character saved successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to save character.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving character: {ex.Message}");
            }
        }
    }
    public static void DisplaySavedCharacters()
    {
      
       
        string selectQuery = "SELECT characterId, characterName FROM CHARACTER_SELECTION";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Select Character");
                        int count = 0;

                        while (reader.Read())
                        {
                            count++;
                            int characterId = reader.GetInt32(0);
                            string characterName = reader.GetString(1);


                            Console.WriteLine($"{characterName}");
                        }

                        if (count == 0)
                        {
                            Console.WriteLine("No characters saved yet.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving saved characters: {ex.Message}");
            }
        }
    }
    public static void DisplayAllSavedCharacters()
    {
        string selectQuery = "SELECT * FROM CHARACTER_SELECTION";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int count = 0;

                        while (reader.Read())
                        {
                            count++;
                            Console.WriteLine($"Character {count}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($"Name: {reader["characterName"]}");
                            Console.WriteLine($"Origin: {reader["origin"]}");
                            Console.WriteLine($"Gender: {reader["gender"]}");
                            Console.WriteLine($"Age: {reader["age"]}");
                            Console.WriteLine($"Skin Color: {reader["skinColor"]}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($"Hair Style: {reader["hairStyle"]}");
                            Console.WriteLine($"Hair Color: {reader["hairColor"]}");
                            Console.WriteLine($"Eye Color: {reader["eyeColor"]}");
                            Console.WriteLine($"Body Size: {reader["bodySize"]}");
                            Console.WriteLine($"Height: {reader["height"]}");
                            Console.WriteLine($"Facial Hair: {reader["facialHair"]}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Clothings:");
                            Console.WriteLine($"Overall: {reader["overall"]}");
                            Console.WriteLine($"Tops: {reader["tops"]}");
                            Console.WriteLine($"Bottoms: {reader["bottoms"]}");
                            Console.WriteLine($"Shoes: {reader["shoes"]}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Accessories:");
                            Console.WriteLine($"Face Accessories: {reader["Faceaccessories"]}");
                            Console.WriteLine($"Wrist Accessories: {reader["Wristaccessories"]}");
                            Console.WriteLine($"Back Accessories: {reader["Backaccessories"]}");
                            Console.WriteLine($"Neck Accessories: {reader["Neckaccessories"]}");
                            Console.WriteLine($"Head Accessories: {reader["Headaccessories"]}");
                            Console.WriteLine($"Skin Accessories: {reader["Skinaccessories"]}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($"Armor: {reader["armor"]}");
                            Console.WriteLine($"Weapons: {reader["weapons"]}");
                            Console.WriteLine($"Idle Posture: {reader["idlePosture"]}");
                            Console.WriteLine($"Fighting Styles: {reader["fightingStyle"]}");
                            Console.WriteLine($"Splash Background: {reader["splashBackground"]}");
                            Console.WriteLine($"Voice Type: {reader["voiceType"]}");
                            Console.WriteLine($"Emotes: {reader["emotes"]}");
                            Console.WriteLine($"Entrance Animation: {reader["entranceAnimation"]}");
                            Console.WriteLine($"Victory Animation: {reader["victoryAnimation"]}");
                            Console.WriteLine($"Defeat Animation: {reader["defeatAnimation"]}");
                            Console.WriteLine("========================================");

                        }

                        if (count == 0)
                        {
                            Console.WriteLine("No characters saved yet.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving saved characters: {ex.Message}");
            }
        }
    }

    public static void DataBase()
    {
        while (true)
        {
            try
            {
                string userchoice;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("[1] Load Character");
                Console.WriteLine("[2] View all Characters");
                Console.WriteLine("[3] Delete Character");
                Console.WriteLine("[4] Back");
                Console.WriteLine("----------------------------------------");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (choice == 1)
                {
                    DisplaySavedCharacters();
                    userchoice = Console.ReadLine();
                    Console.Clear();
                    ReadCharacterFromDatabase(userchoice);
                    Program.GoBackToMenu();
                    break;
                }
                else if (choice == 3)
                {
                    DisplaySavedCharacters();
                    userchoice = Console.ReadLine();
                    Console.Clear();
                    DeleteCharacterFromDatabase(userchoice);
                    Program.GoBackToMenu();
                    break;
                }
                else if (choice == 2)
                {
                    DisplayAllSavedCharacters();
                    Program.GoBackToMenu();
                    break;
                }
                else if (choice == 4) { break; }


            }

            catch (Exception ex)
            {

                Console.Clear();
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
    static void DeleteCharacterFromDatabase(string name)
    {
        while (true)
        {
            string selectQuery = "SELECT characterId, characterName FROM CHARACTER_SELECTION WHERE characterName = @name";
            string deleteQuery = "DELETE FROM CHARACTER_SELECTION WHERE characterName = @name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@name", name);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        int characterId = Convert.ToInt32(reader["characterId"]);
                        string characterName = reader["characterName"].ToString();

                        Console.WriteLine($"Character found!");
                        Console.WriteLine($"Name: {characterName}");
                        reader.Close();

                        Console.WriteLine("Do you want to delete this character? (y/n)");
                        string confirmation = Console.ReadLine();

                        if (confirmation.ToLower() == "y")
                        {
                            using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@name", name);
                                int rowsAffected = deleteCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    Console.WriteLine("Character deleted successfully!");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Failed to delete the character.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Character deletion canceled.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Character not found with the given name.");
                        break;
                    }
                }
            }
        }
    }

    public static void ReadCharacterFromDatabase(string characterName)
    {
        string query = "SELECT * FROM CHARACTER_SELECTION WHERE characterName = @characterName";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@characterName", characterName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["characterName"].ToString();
                            string origin = reader["origin"].ToString();
                            string gender = reader["gender"].ToString();
                            string age = reader["age"].ToString();
                            string skinColor = reader["skinColor"].ToString();
                            string hairStyle = reader["hairStyle"].ToString();
                            string hairColor = reader["hairColor"].ToString();
                            string eyeColor = reader["eyeColor"].ToString();
                            string bodySize = reader["bodySize"].ToString();
                            string height = reader["height"].ToString();
                            string facialHair = reader["facialHair"].ToString();
                            string clothingOverall = reader["overall"].ToString();
                            string clothingTops = reader["tops"].ToString();
                            string clothingBottoms = reader["bottoms"].ToString();
                            string shoes = reader["shoes"].ToString();
                            string accessoriesFace = reader["faceAccessories"].ToString();
                            string accessoriesWrist = reader["wristAccessories"].ToString();
                            string accessoriesBack = reader["backAccessories"].ToString();
                            string accessoriesNeck = reader["neckAccessories"].ToString();
                            string accessoriesHead = reader["headAccessories"].ToString();
                            string accessoriesSkin = reader["skinAccessories"].ToString();
                            string armor = reader["armor"].ToString();
                            string weapons = reader["weapons"].ToString();
                            string idlePosture = reader["idlePosture"].ToString();
                            string fightingStyle = reader["fightingStyle"].ToString();
                            string splashBackground = reader["splashBackground"].ToString();
                            string voiceType = reader["voiceType"].ToString();
                            string emotes = reader["emotes"].ToString();
                            string entranceAnimation = reader["entranceAnimation"].ToString();
                            string victoryAnimation = reader["victoryAnimation"].ToString();
                            string defeatAnimation = reader["defeatAnimation"].ToString();

                            // Display character details
                            Console.WriteLine("Successfully loading character!:\n");
                            Console.WriteLine("Your Character:");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($"Name: {name}");
                            Console.WriteLine($"Origin: {origin}");
                            Console.WriteLine($"Gender: {gender}");
                            Console.WriteLine($"Age: {age}");
                            Console.WriteLine($"Skin Color: {skinColor}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($"Hair Style: {hairStyle}");
                            Console.WriteLine($"Hair Color: {hairColor}");
                            Console.WriteLine($"Eye Color: {eyeColor}");
                            Console.WriteLine($"Body Size: {bodySize}");
                            Console.WriteLine($"Height: {height}");
                            Console.WriteLine($"Facial Hair: {facialHair}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Clothings:");
                            Console.WriteLine($"Overall: {clothingOverall}");
                            Console.WriteLine($"Tops: {clothingTops}");
                            Console.WriteLine($"Bottoms: {clothingBottoms}");
                            Console.WriteLine($"Shoes: {shoes}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("Accessories:");
                            Console.WriteLine($"Face Accessories: {accessoriesFace}");
                            Console.WriteLine($"Wrist Accessories: {accessoriesWrist}");
                            Console.WriteLine($"Back Accessories: {accessoriesBack}");
                            Console.WriteLine($"Neck Accessories: {accessoriesNeck}");
                            Console.WriteLine($"Head Accessories: {accessoriesHead}");
                            Console.WriteLine($"Skin Accessories: {accessoriesSkin}");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine($"Armor: {armor}");
                            Console.WriteLine($"Weapons: {weapons}");
                            Console.WriteLine($"Idle Posture: {idlePosture}");
                            Console.WriteLine($"Fighting Styles: {fightingStyle}");
                            Console.WriteLine($"Splash Background: {splashBackground}");
                            Console.WriteLine($"Voice Type: {voiceType}");
                            Console.WriteLine($"Emotes: {emotes}");
                            Console.WriteLine($"Entrance Animation: {entranceAnimation}");
                            Console.WriteLine($"Victory Animation: {victoryAnimation}");
                            Console.WriteLine($"Defeat Animation: {defeatAnimation}");
                        }
                        else
                        {
                            Console.WriteLine($"Character with name {characterName} not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving the character: {ex.Message}");
            }
        }
    }

}
