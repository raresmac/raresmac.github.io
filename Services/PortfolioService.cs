namespace raresmac.github.io.Services;

using raresmac.github.io.Models;

public sealed class PortfolioService : IPortfolioService
{
    private static readonly List<string> CategoriesList =
    [
        "Web",
        "C#",
        "Python",
        "Games",
        "Typescript",
        "VR",
        "C++"
    ];

    private readonly List<Project> _projects =
    [
        // WEB
        new Project
        {
            Title = "Lools",
            Category = "Web",
            Description = "Master the Rift with professional-grade cooldown management.",
            ImageUrl = "images/web/lools.webp",
            GithubUrl = "https://github.com/raresmac/Lools",
            ExternalUrl = "https://raresmac.github.io/Lools/",
            Tags = ["Web", "Blazor", "C#"]
        },
        new Project
        {
            Title = "FM26 Tactics",
            Category = "Web",
            Description = "Master the pitch with the world's best tactical setups.",
            ImageUrl = "images/web/fm26-tactics.webp",
            GithubUrl = "https://github.com/raresmac/FM26-Tactics",
            ExternalUrl = "https://raresmac.github.io/FM26-Tactics/",
            Tags = ["Web", "Blazor", "C#"]
        },
        new Project
        {
            Title = "BalatroHub",
            Category = "Web",
            Description = "This is the ultimate curated repository for mastering the world's most addictive roguelike poker.",
            ImageUrl = "images/web/balatrohub.webp",
            GithubUrl = "https://github.com/raresmac/BalatroHub",
            ExternalUrl = "https://raresmac.github.io/BalatroHub/",
            Tags = ["Web", "Blazor", "C#"]
        },
        new Project
        {
            Title = "Stitcherina",
            Category = "Web",
            Description = " Turn memories into thread. Cozy pattern creator & pixel editor for tapestry and cross-stitch lovers.",
            ImageUrl = "images/web/stitcherina.webp",
            GithubUrl = "https://github.com/raresmac/Stitcherina",
            ExternalUrl = "https://raresmac.github.io/Stitcherina/",
            Tags = ["Web", "Blazor", "C#"]
        },

        // C#
        new Project
        {
            Title = "PaintGuesser",
            Category = "C#",
            Description = "PaintGuesser allows you to master all the details of the most important paintings in history.",
            ImageUrl = "images/cs/paintguesser.webp",
            GithubUrl = "https://github.com/raresmac/PaintGuesser",
            ExternalUrl = "https://play.google.com/store/apps/details?id=com.NamelessRose.PaintGuesser",
            Tags = ["C#", "Unity", "Android"]
        },
        new Project
        {
            Title = "PokerUltimateCalc",
            Category = "C#",
            Description = "A high-performance Texas Hold'em Probability Engine and Terminal Simulator written in C# using bitmasking, combinatorial analysis, and Monte Carlo simulations.",
            ImageUrl = "images/cs/pokerultimatecalc.webp",
            GithubUrl = "https://github.com/raresmac/PokerUltimateCalc",
            Tags = ["C#", "Windows"]
        },
        new Project
        {
            Title = "ARt",
            Category = "C#",
            Description = "An AR application for Android for recognizing paintings written in C# and Unity.",
            ImageUrl = "images/cs/art.webp",
            GithubUrl = "https://github.com/raresmac/ARt",
            Tags = ["C#", "Android", "AR"]
        },

        // PYTHON
        new Project
        {
            Title = "OverAchiever",
            Category = "Python",
            Description = "An automated video game tracker that fetches metadata and playtimes from Steam and HowLongToBeat.",
            ImageUrl = "images/python/overachiever.webp",
            GithubUrl = "https://github.com/raresmac/OverAchiever",
            Tags = ["Python", "FastAPI", "PostgreSQL", "Docker", "Gaming"]
        },
        new Project
        {
            Title = "LOL Predictor",
            Category = "Python",
            Description = "Neural network trained to predict match outcomes based on lineups.",
            ImageUrl = "images/python/lol_predictor.webp",
            GithubUrl = "https://github.com/raresmac/LOL_Predictor",
            Tags = ["Python", "ML", "Gaming"]
        },
        new Project
        {
            Title = "PyChess",
            Category = "Python",
            Description = "A simple chess game made with PyGame.",
            ImageUrl = "images/python/pychess.webp",
            GithubUrl = "https://github.com/raresmac/PyChess",
            Tags = ["Python", "Chess", "Gaming"]
        },
        new Project
        {
            Title = "ScanItUp",
            Category = "Python",
            Description = "Document scanner that parses text from images.",
            ImageUrl = "images/python/scanitup.webp",
            GithubUrl = "https://github.com/raresmac/ScanItUp",
            Tags = ["Python", "Utilities"]
        },

        // GAMES
        new Project
        {
            Title = "Sudoku Complete",
            Category = "Games",
            Description = "A polished singleplayer Sudoku experience featuring multiple variants, beautiful board themes and relaxing music.",
            ImageUrl = "images/games/sudoku.webp",
            ExternalUrl = "https://sbox.game/namelessrose/sudoku_complete",
            Tags = ["Games", "C#", "s&box"]
        },
        new Project
        {
            Title = "Blocked Unlocked",
            Category = "Games",
            Description = "A serene and modern block-sliding puzzle.",
            ImageUrl = "images/games/blocked_unlocked.webp",
            ExternalUrl = "https://sbox.game/namelessrose/blocked_unlocked",
            Tags = ["Games", "C#", "s&box"]
        },
        new Project
        {
            Title = "Skyscrapers",
            Category = "Games",
            Description = "Skyscrapers is a sleek, modern 2D grid logic puzzle game based on Sudoku.",
            ImageUrl = "images/games/skyscrapers.webp",
            ExternalUrl = "https://sbox.game/namelessrose/skyscrapers",
            Tags = ["Games", "C#", "s&box"]
        },
        new Project
        {
            Title = "Dartsbox",
            Category = "Games",
            Description = "DartsBox is a multiplayer darts game for s&box. You can play 501 with friends using pro rules like double-outs, having a bunch of customizable options. The aiming takes actual skill, so you have to be precise when trying to hit triples or finish a game.",
            ImageUrl = "images/games/dartsbox.webp",
            ExternalUrl = "https://sbox.game/namelessrose/dartsbox",
            Tags = ["Games", "C#", "s&box"]
        },
        new Project
        {
            Title = "Cabineer",
            Category = "Games",
            Description = "A card game available on itch.io.",
            ImageUrl = "images/games/cabineer.webp",
            ExternalUrl = "https://raresmac.itch.io/cabineer",
            Tags = ["Games", ".NET", "C#"]
        },

        // TS
        new Project
        {
            Title = "Segame",
            Category = "Typescript",
            Description = "Segame is a desktop game library tracker built with Electron, React, and TypeScript.",
            ImageUrl = "images/typescript/segame.webp",
            GithubUrl = "https://github.com/raresmac/Segame",
            Tags = ["TS", "Typescript", "sqlite"]
        },

        // VR
        new Project
        {
            Title = "Memento Vivere",
            Category = "VR",
            Description = "VR game showcasing diverse mechanics and comfort protections.",
            ImageUrl = "images/vr/memento_vivere.webp",
            VideoId = "LEZrbjUFSUQ",
            Tags = ["VR", "Unity", "C#"]
        },

        // C++
        new Project
        {
            Title = "ReadsProfiler",
            Category = "C++",
            Description = "Faculty project for hosting a personal digital library.",
            ImageUrl = "images/cpp/readsprofiler.webp",
            GithubUrl = "https://github.com/raresmac/ReadsProfiler",
            Tags = ["C++", "Graphics", "Books"]
        },
        new Project
        {
            Title = "Electronic Circuits",
            Category = "C++",
            Description = "Creation and editing tool for electronic circuits.",
            ImageUrl = "images/cpp/electronic_circuits.webp",
            GithubUrl = "https://github.com/raresmac/Electronic_Circuits",
            Tags = ["C++", "Graphics", "Electronics"]
        }
    ];

    private readonly List<Certification> _certifications =
    [
        new Certification
        {
            Title = "A Complete Guide to Game Design",
            Organization = "edX",
            DateString = "2026/05/18",
            CredentialUrl = "https://courses.edx.org/certificates/da019d67603443bfae8c80069dd78086",
            Skills = ["Game Design", "Gaming"]
        }
    ];

    public IReadOnlyList<string> GetCategories() => CategoriesList.AsReadOnly();

    public IReadOnlyList<Project> GetProjects() => _projects.AsReadOnly();

    public IReadOnlyList<Project> GetProjectsByCategory(string category) =>
        _projects.Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase)).ToList().AsReadOnly();

    public IReadOnlyList<Certification> GetCertifications() => _certifications.AsReadOnly();
}
