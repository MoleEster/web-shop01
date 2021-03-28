using Site0303.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site0303.Data
{
    public class DbObjects
    {
        public static void Initial(AppDbContent content)
        {
            if (!content.Category1.Any())
            {
                content.Category1.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Product.Any())
            {
                content.AddRange(
                    new Product
                    {
                        Name = "Smith & Wesson M&P 15T Rifle 5.56x45mm 16\" Barrel 30-Round M-Lok Polymer Black",
                        Description = "Smith & Wesson M&P15 Rifles are the ideal modern sporting rifle." +
                         " Built to perform multiple uses under various conditions, M&P15 Rifles are as versatile as they are reliable." +
                         "   Engineered for a wide variety of recreational, sport shooting and professional applications," +
                         " M&P15 Rifles are easy to accessorize, but hard to put down. M&P15 Rifles are lightweight" +
                         " and rugged embodying the best combination of function and form.",
                        img = "/gunsImg/Smith&WessonMP15T.jpg",
                        IsAviable = true,
                        IsFavorite = false,
                        Category1 = Categories["firearms"],
                        Price = 2000
                    },
                    new Product
                    {
                        Name = "Savage MSR10 Competition HD Rifle 308 Winchester",
                        Description = "To finish at the top of any event, shooters need the customization and precision" +
                         " engineered into every facet of the MSR10 Competition HD. Its advanced barrel is built specifically" +
                         " for the rifle in a collaborative effort between Savage and PROOF Research. The unique ported muzzle" +
                         " break allows the shooter to tune the recoil impulse to stabilize the muzzle for faster, more accurate" +
                         " follow-up shots. Further customization follows with the gas block, which can be adjusted for optimal cycling" +
                         " of the full range of bullet weights, as well as for use with a suppressor. The gas block is also wrapped in a custom" +
                         " handguard and topped with an integral picatinny rail.",
                        img = "/gunsImg/SavageMSR10CompetitionHDRifle308Winchester.jpg",
                        IsAviable = true,
                        IsFavorite = false,
                        Category1 = Categories["firearms"],
                        Price = 3603
                    },
                    new Product
                    {
                        Name = "Savage MSR10 Competition HD Rifle 308 Winchester",
                        Description = "The design philosophy behind the Radian Model 1 is simple: use the highest quality raw materials," +
                         " most precise CNC machining equipment, and best components available to create a weapon that seamlessly blends" +
                         " form and function. Beyond quality and aesthetics, the Model 1 features fully ambidextrous controls, adding much-needed" +
                         " utility for both left and right handed shooters. Every Model 1 is assembled by hand, one at a time, by a trained gunsmith who inspects" +
                         ", test fires, and cleans the weapon to personally guarantee it meets the most rigid quality standards. No detail has gone overlooked, which is why the Model 1" +
                         ", like every Radian product, is guaranteed for life.",
                        img = "/gunsImg/RadianMDL1Rifle30RoundMLok.jpg",
                        IsAviable = false,
                        IsFavorite = false,
                        Category1 = Categories["firearms"],
                        Price = 3603
                    },
                    new Product
                    {
                        Name = "Alexander Arms Ulfberht Rifle 338 Lapua Magnum 27\" Barrel 10-Round Polymer Black",
                        Description = "Alexander Arms Ulfberht fully-complete, semi-automatic, .338 Lapua Magnum rifle." +
                         " Voted as Shooting Illustrated 2015 Rifle of the Year, Ulfberht features a custom-designed, " +
                         "adjustable gas piston operating system with magazine feeding. It has a steel receiver with 30 MOA" +
                         " of elevation built in, 27.5-inch chrome moly barrel with 1:9.3\" twist rate, standard metric muzzle" +
                         " threading for this caliber of M18x1.5 with three - prong flash hider installed, folding Magpul PRS stock," +
                         " and Geissele SSA two - stage, match - type trigger.The rifle is 41.25 inches long with the stock folded and 50" +
                         " inches long with the stock extended.Its total height is approximately 8.5 inches and its width is 3.5 inches.The total" +
                         " rifle weight is 19.8 pounds.The rifle ships in a hard case with four custom, 10 - round, polymer magazines.When prepared for" +
                         " shipment in its hard case, the entire package weighs 50 pounds.",
                        img = "/gunsImg/AlexanderArmsUlfberhtRifle338.jpg",
                        IsAviable = true,
                        IsFavorite = true,
                        Category1 = Categories["firearms"],
                        Price = 5800
                    },
                    new Product
                    {
                        Name = "Biegler Bladeworks Zukuri Butterfly Knife Titanium Blue Holes (4.5\" Damascus)",
                        Description = "This Biegler Bladeworks Zukuri custom balisong has a skeletonized titanium handle and a Damascus blade." +
                         " This high-end balisong has a trailing point blade. It's an excellent flipper that is sure to impress, just as much as your skills with it.",
                        img = "/knifesImg/Biegler-Bladeworks-Zukuri-Butterfly-Ti-Blue-Holes-Damascus.jpg",
                        IsAviable = true,
                        IsFavorite = true,
                        Category1 = Categories["steel-arms"],
                        Price = 1100
                    },
                    new Product
                    {
                        Name = "Biegler Bladeworks Zukuri Butterfly Knife Titanium Blue Holes (4.5\" Damascus)",
                        Description = "This Brend 3 Custom Auto features a hand ground and polished blade from Walter Brend himself and a stainless" +
                         " handle with abalone inlays and push button. Item includes a 3D machined titanium pocket clip. The Brend 3" +
                         " Auto is the medium size in the Pro-Tech Brend automatic knife line between the Brend 1 (large) and" +
                         " the Brend 2 (small).\n The Brend 3 has a 3.75\" blade with Walter Brend's famous \"Model 1\" shape. The handle is anodized 6061-T6" +
                         " aluminum with inlays, push button, and a tip-up pocket clip. The action is Pro-Tech perfect and this knife is a great user or display piece.",
                        img = "/knifesImg/Protech-Brend-3-Custom-Auto-Abalone-Hand-Ground-Polished.jpg",
                        IsAviable = true,
                        IsFavorite = false,
                        Category1 = Categories["steel-arms"],
                        Price = 1995
                    }
                    );
            }

            content.SaveChanges();
        }



        public static Dictionary<string, Category1> category;
        public static Dictionary<string, Category1> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category1[]
                    {
                     new Category1{ category1Name="firearms", Desc = "Regular guns to protect yourself from a distance"},
                     new Category1{ category1Name="steel-arms", Desc = "elegant fast and appearing out of nowhere"},
                    };
                    category = new Dictionary<string, Category1>();
                    foreach (Category1 item in list)
                    {
                        category.Add(item.category1Name, item);
                    }
                }
                return category;
            }
        }
    }
}
