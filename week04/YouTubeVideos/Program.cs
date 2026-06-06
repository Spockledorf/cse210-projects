using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // V1       
        Video v1 = new Video("My Favorite Video", "Michael Jarvis", 361);

        Comment v1c1 = new Comment("Spockledorf", "First!");
        Comment v1c2 = new Comment("Groot", "I am groot.");
        Comment v1c3 = new Comment("Airbus_747", "*Airplane noises*");
        Comment v1c4 = new Comment("McMcMcMuffin", "I love it!");
        Comment v1c5 = new Comment("Spockledorf", "Wow! So Awesome!");
        
        v1.AddComment(v1c1);
        v1.AddComment(v1c2);
        v1.AddComment(v1c3);
        v1.AddComment(v1c4);
        v1.AddComment(v1c5);
        
        videos.Add(v1);
    
        // V2       
        Video v2 = new Video("Cooking for Blockheads", "SciFi Sam", 1131);

        Comment v2c1 = new Comment("NoodleNinja42", "Finally a tutorial that doesn't assume I already know how to cook. Thank you!");
        Comment v2c2 = new Comment("VoxelVivian", "SciFi Sam never misses. This mod is a game changer for my survival worlds.");
        Comment v2c3 = new Comment("HungerBarHater", "Bro I was literally about to uninstall because of the cooking mechanics. This saved my playthrough.");
        Comment v2c4 = new Comment("CabbagePatchKid99", "Okay but why is SciFi Sam lowkey the most underrated Minecraft channel on here??");
        Comment v2c5 = new Comment("RedstoneRandy", "Can you do a follow-up on connecting this with Applied Energistics? Would be insane.");
        
        v2.AddComment(v2c1);
        v2.AddComment(v2c2);
        v2.AddComment(v2c3);
        // v2.AddComment(v2c4);
        v2.AddComment(v2c5);
        
        videos.Add(v2);
        
        // V3       
        Video v3 = new Video("How To Live Forever - Speedrunners Edition", "Eternal Pancake", 10565);

        Comment v3c1 = new Comment("BlinkAndUMissIt", "Eternal Pancake somehow made immortality feel stressful. I mean that as a compliment.");
        Comment v3c2 = new Comment("GlitchHunter7", "The out of bounds skip at 4:23 to bypass the aging mechanic is genuinely galaxy-brained.");
        Comment v3c3 = new Comment("FasterThanDeath", "Nobody is doing it like Eternal Pancake right now. The community is so lucky to have this.");
        Comment v3c4 = new Comment("ChronoCheese", "Eternal Pancake said death is just a skill issue and honestly I can't argue with the results.");
        Comment v3c5 = new Comment("MilkAndSyrup", "Pancake.");

        v3.AddComment(v3c1);
        // v3.AddComment(v3c2);
        // v3.AddComment(v3c3);
        v3.AddComment(v3c4);
        v3.AddComment(v3c5);

        videos.Add(v3);

        // Display Videos
        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
        
    }
}