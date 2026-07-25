Imports System.Reflection

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '==================================================  
        '2026-06-24-01-06-13-AM
        '================================================== 
        'todo dev junk
        '================================================== 
        'remember what the door mouse said
        'feed your head
        'collide - white rabbit
        '==================================================
        '2026-06-24-01-07-26-AM
        'text1 Left side
        'text2 middle side
        'text3 Right side
        'text4 Right side
        'makes it easy to add New code gen buttons that do the same thing that just add stuff
        'would make it easy to update line combine with it too
        'keeping this seperate as a development environment for New functions for the file
        '==================================================

        '==================================================


        '==================================================

        'ListBox1.Items.Add("")
        'ListBox1.Items.Add("A Better Mousetrap (SE03)")
        'ListBox1.Items.Add("A Brotherhood Betrayed (MS11)")
        'ListBox1.Items.Add("A Brush with Death (MS14)")
        'ListBox1.Items.Add("A Door in Niben Bay (SE01Door)")
        'ListBox1.Items.Add("A Kiss Before Dying (Dark16Kiss)")
        'ListBox1.Items.Add("A Knife in the Dark (Dark01Knife)")
        'ListBox1.Items.Add("A Liquid Solution (SE41)")
        'ListBox1.Items.Add("A Mage's Staff (MG08MagesStaff)")
        'ListBox1.Items.Add("A Matter of Honor (Dark14Honor)")
        'ListBox1.Items.Add("A Plot Revealed (MG14Plot)")
        'ListBox1.Items.Add("A Rat Problem (FGC01Rats)")
        'ListBox1.Items.Add("A Shadow Over Hackdirt (MS45)")
        'ListBox1.Items.Add("A Venerable Vintage (SQ08)")
        'ListBox1.Items.Add("A Watery Grave (Dark02Watery)")
        'ListBox1.Items.Add("Accidents Happen (Dark03Accidents)")
        'ListBox1.Items.Add("Acrobatics Training (TrainingAcrobatics)")
        'ListBox1.Items.Add("Addiction (SE04)")
        'ListBox1.Items.Add("Affairs of a Wizard (Dark10SpecialWizard)")
        'ListBox1.Items.Add("Ahdarji's Heirloom (TG04Mistake)")
        'ListBox1.Items.Add("Alchemy Acquisitions (MG19Alchemy)")
        'ListBox1.Items.Add("Alchemy Training (TrainingAlchemy)")
        'ListBox1.Items.Add("Allies for Bruma (MQ11)")
        'ListBox1.Items.Add("Alteration Training (TrainingAlteration)")
        'ListBox1.Items.Add("Ambush (MG17Ambush)")
        'ListBox1.Items.Add("Amelion's Debt (FGC07Heirloom)")
        'ListBox1.Items.Add("An Unexpected Voyage (MS31)")
        'ListBox1.Items.Add("Anvil Recommendation (MG04Restore)")
        'ListBox1.Items.Add("Arena (ArenaDialogue)")
        'ListBox1.Items.Add("Armorer Training (TrainingArmorer)")
        'ListBox1.Items.Add("Arrow of Extrication (TG09Arrow)")
        'ListBox1.Items.Add("Athletics Training (TrainingAthletics)")
        'ListBox1.Items.Add("Attack on Fort Sutch (MS94)")
        'ListBox1.Items.Add("Azani Blackheart (FGD05Oreyn)")
        'ListBox1.Items.Add("Azura (DAAzura)")
        'ListBox1.Items.Add("Bad Medicine (Dark07Medicine)")
        'ListBox1.Items.Add("Baiting the Trap (SE03A)")
        'ListBox1.Items.Add("Battlehorn Castle (DLCBattlehornCastle)")
        'ListBox1.Items.Add("Bear Season (SQ06)")
        'ListBox1.Items.Add("Blade Training (TrainingBlade)")
        'ListBox1.Items.Add("Block Training (TrainingBlock)")
        'ListBox1.Items.Add("Blood Price (TG04BloodPrice)")
        'ListBox1.Items.Add("Blood of the Daedra (MQ08)")
        'ListBox1.Items.Add("Blood of the Damned (Dark02WateryFIN)")
        'ListBox1.Items.Add("Blood of the Divines (MQ09)")
        'ListBox1.Items.Add("Blunt Training (TrainingBlunt)")
        'ListBox1.Items.Add("Boethia (DABoethia)")
        'ListBox1.Items.Add("Boots of Springheel Jak (TG10Boots)")
        'ListBox1.Items.Add("Bravil Recommendation (MG03Illusion)")
        'ListBox1.Items.Add("Breaking the Siege of Kvatch (MS48)")
        'ListBox1.Items.Add("Brithaur (SE35)")
        'ListBox1.Items.Add("Broken Vows (Dark12Harem)")
        'ListBox1.Items.Add("Bruma Gate (MQ10)")
        'ListBox1.Items.Add("Bruma Recommendation (MG06Bruma)")
        'ListBox1.Items.Add("Buy a house in Bravil (HouseBravil)")
        'ListBox1.Items.Add("Buy a house in Cheydinhal (HouseCheydinhal)")
        'ListBox1.Items.Add("Buy a house in Leyawiin (HouseLeyawiin)")
        'ListBox1.Items.Add("Buy a house in the Imperial City (HouseImperialCity)")
        'ListBox1.Items.Add("Buying a house in Skingrad (HouseSkingrad)")
        'ListBox1.Items.Add("Canvas the Castle (MS51)")
        'ListBox1.Items.Add("Caught in the Hunt (MS08)")
        'ListBox1.Items.Add("Cheydinhal Recommendation (MG02Alter)")
        'ListBox1.Items.Add("Clavicus Vile (DAClavicusVile)")
        'ListBox1.Items.Add("Confront the King (MG18KingofWorms)")
        'ListBox1.Items.Add("Conjuration Training (TrainingConjuration)")
        'ListBox1.Items.Add("Corruption and Conscience (MS10)")
        'ListBox1.Items.Add("Dagon Shrine (MQ06)")
        'ListBox1.Items.Add("Darkness Eternal (DarkVamp)")
        'ListBox1.Items.Add("Deepscorn Hollow (DLCDeepscorn)")
        'ListBox1.Items.Add("Defense of Bruma (MQ13)")
        'ListBox1.Items.Add("Deliver the Amulet (MQ02)")
        'ListBox1.Items.Add("Den of Thieves (FGC03Thieves)")
        'ListBox1.Items.Add("Destruction Training (TrainingDestruction)")
        'ListBox1.Items.Add("Drunk and Disorderly (FGD02DandD)")
        'ListBox1.Items.Add("Dunbarrow Cove (DLC06ThievesDen)")
        'ListBox1.Items.Add("Enter the Eliminator (Dark06WandererFIN)")
        'ListBox1.Items.Add("Everything In Its Place (SE39)")
        'ListBox1.Items.Add("Falling Awake (SE40)")
        'ListBox1.Items.Add("Final Justice (Dark13Justice)")
        'ListBox1.Items.Add("Final Resting (SE36)")
        'ListBox1.Items.Add("Find the Heir (MQ03)")
        'ListBox1.Items.Add("Finding the Thieves Guild (TG00FindThievesGuild)")
        'ListBox1.Items.Add("Fingers of the Mountain (MG05Fingers)")
        'ListBox1.Items.Add("Fingers of the Mountain, Part II (MG05A)")
        'ListBox1.Items.Add("Following a Lead (Dark17Following)")
        'ListBox1.Items.Add("Frostcrag Spire (DLCFrostcragSpire)")
        'ListBox1.Items.Add("Ghosts of Vitharn (SE32)")
        'ListBox1.Items.Add("Go Fish (SQ09)")
        'ListBox1.Items.Add("Goblin Trouble (MS46)")
        'ListBox1.Items.Add("Great Gate (MQ14)")
        'ListBox1.Items.Add("Hand to Hand Training (TrainingHandtoHand)")
        'ListBox1.Items.Add("Heavy Armor Training (TrainingHeavyArmor)")
        'ListBox1.Items.Add("Helping Hands (HouseServant)")
        'ListBox1.Items.Add("Hermaeus Mora (DAHermaeusMora)")
        'ListBox1.Items.Add("Hircine (DAHircine)")
        'ListBox1.Items.Add("Honor Thy Mother (Dark18Mother)")
        'ListBox1.Items.Add("Horse Armor (DLCHorseArmor)")
        'ListBox1.Items.Add("Illusion Training (TrainingIllusion)")
        'ListBox1.Items.Add("Imperial Corruption (MS26) ")
        'ListBox1.Items.Add("Imperial Dragon Armor (MQDragonArmor)")
        'ListBox1.Items.Add("Independent Thievery (TGStolenGoods)")
        'ListBox1.Items.Add("Infiltration (FGD08Infiltration)")
        'ListBox1.Items.Add("Information Gathering (FGD07Kidnap)")
        'ListBox1.Items.Add("Information at a Price (MG13Information)")
        'ListBox1.Items.Add("Join the Mages Guild (MG00Join)")
        'ListBox1.Items.Add("Knights of the White Stallion (MS92)")
        'ListBox1.Items.Add("Legacy Lost (MS16A)")
        'ListBox1.Items.Add("Leyawiin Recommendation (MG07Leyawiin)")
        'ListBox1.Items.Add("Liberation or Apprehension? (MG12Gate)")
        'ListBox1.Items.Add("Lifting the Vale (MS12)")
        'ListBox1.Items.Add("Light Armor Training (TrainingLightArmor)")
        'ListBox1.Items.Add("Light the Dragonfires (MQ16)")
        'ListBox1.Items.Add("Lost Histories (TG06Atonement)")
        'ListBox1.Items.Add("Malacath (DAMalacath)")
        'ListBox1.Items.Add("Marksman Training (TrainingMarksman)")
        'ListBox1.Items.Add("May the Best Thief Win (TG01BestThief)")
        'ListBox1.Items.Add("Mazoga the Orc (MS91)")
        'ListBox1.Items.Add("Mephala (DAMephala)")
        'ListBox1.Items.Add("Mercantile Training (TrainingMercantile)")
        'ListBox1.Items.Add("Meridia (DAMeridia)")
        'ListBox1.Items.Add("Miscarcand (MQ12)")
        'ListBox1.Items.Add("Misdirection (TG05Misdirection)")
        'ListBox1.Items.Add("Molag Bal (DAMolagBal)")
        'ListBox1.Items.Add("More Unfinished Business (FGD04Defector)")
        'ListBox1.Items.Add("My Brother's Keeper (Dark05AssassinatedFIN)")
        'ListBox1.Items.Add("Mystery at Harlun's Watch (FGC10Swamp)")
        'ListBox1.Items.Add("Mysticism Training (TrainingMysticism)")
        'ListBox1.Items.Add("Namira (DANamira)")
        'ListBox1.Items.Add("Nature's Fury (ND03)")
        'ListBox1.Items.Add("Necromancer's Moon (MG11NecroMoon)")
        'ListBox1.Items.Add("Newheim's Flagon (FGC03Flagon)")
        'ListBox1.Items.Add("Next of Kin (Dark11Kin)")
        'ListBox1.Items.Add("No Rest for the Wicked (Dark03AccidentsFIN)")
        'ListBox1.Items.Add("No Stone Unturned (SQ04)")
        'ListBox1.Items.Add("Nocturnal (DANocturnal)")
        'ListBox1.Items.Add("Nothing You Can Possess (MS22)")
        'ListBox1.Items.Add("Of Secret And Shadow (Dark09RetirementFIN)")
        'ListBox1.Items.Add("Order of the Virtuous Blood (MS23)")
        'ListBox1.Items.Add("Origin of the Gray Prince (MS52)")
        'ListBox1.Items.Add("Paradise (MQ15)")
        'ListBox1.Items.Add("Paranoia (MS38)")
        'ListBox1.Items.Add("Permanent Retirement (Dark09Retirement)")
        'ListBox1.Items.Add("Peryite (DAPeryite)")
        'ListBox1.Items.Add("Pilgrimage (NDPilgrim)")
        'ListBox1.Items.Add("Priory of the Nine (ND02)")
        'ListBox1.Items.Add("Raid on Greyland (SQ02)")
        'ListBox1.Items.Add("Rebuilding the Gatekeeper (SE09)")
        'ListBox1.Items.Add("Repairing the Orrery (DLCOrrery)")
        'ListBox1.Items.Add("Restoration Training (TrainingRestoration)")
        'ListBox1.Items.Add("Retaking The Fringe (SE08)")
        'ListBox1.Items.Add("Revenge Served Cold (SQ03)")
        'ListBox1.Items.Add("Ritual of Accession (SE07)")
        'ListBox1.Items.Add("Ritual of Dementia (SE07A)")
        'ListBox1.Items.Add("Ritual of Mania (SE07B)")
        'ListBox1.Items.Add("Sanguine (DASanguine)")
        'ListBox1.Items.Add("Scheduled for Execution (Dark04Execution)")
        'ListBox1.Items.Add("Secrets of the Ayleids (MS27)")
        'ListBox1.Items.Add("Security Training (TrainingSecurity)")
        'ListBox1.Items.Add("Seeking Your Roots (MS39)")
        'ListBox1.Items.Add("Separated at Birth (MS16)")
        'ListBox1.Items.Add("Sheogorath (DASheogorath)")
        'ListBox1.Items.Add("Sins of the Father (MS16B)")
        'ListBox1.Items.Add("Skingrad Recommendation (MG01Destruct)")
        'ListBox1.Items.Add("Sneak Training (TrainingSneak)")
        'ListBox1.Items.Add("Speechcraft Training (TrainingSpeechcraft)")
        'ListBox1.Items.Add("Spies (MQ07)")
        'ListBox1.Items.Add("Stendarr's Mercy (ND06)")
        'ListBox1.Items.Add("Symbols of Office (SE11)")
        'ListBox1.Items.Add("Taking Care of Lex (TG07Lex)")
        'ListBox1.Items.Add("Taxonomy of Obsession (SE37)")
        'ListBox1.Items.Add("Tears of the Savior (MS37)")
        'ListBox1.Items.Add("The Antipodean Hammer (SE30)")
        'ListBox1.Items.Add("The Assassin's Gambit (Dark08WhodunitFIN)")
        'ListBox1.Items.Add("The Assassinated Man (Dark05Assassinated)")
        'ListBox1.Items.Add("The Battle for Castle Kvatch (MS49)")
        'ListBox1.Items.Add("The Blessing of Talos (ND09)")
        'ListBox1.Items.Add("The Bloodworm Helm (MG15Helm)")
        'ListBox1.Items.Add("The Cold Flame of Agnon (SE06)")
        'ListBox1.Items.Add("The Coldest Sleep (Dark15Coldest)")
        'ListBox1.Items.Add("The Collector (MS21)")
        'ListBox1.Items.Add("The Coming Storm (SE44)")
        'ListBox1.Items.Add("The Dead Drop (Dark10SanctuaryFIN)")
        'ListBox1.Items.Add("The Desolate Mine (FGC06Courier)")
        'ListBox1.Items.Add("The Elven Maiden (TG03Elven)")
        'ListBox1.Items.Add("The End of Order (SE13)")
        'ListBox1.Items.Add("The Faithful Squire (ND07)")
        'ListBox1.Items.Add("The Fork of Horripilation (SE45)")
        'ListBox1.Items.Add("The Forlorn Watchman (MS06)")
        'ListBox1.Items.Add("The Fugitives (FGC08Prison)")
        'ListBox1.Items.Add("The Ghost Ship of Anvil (MS93)")
        'ListBox1.Items.Add("The Gravefinder's Repose (SQ05)")
        'ListBox1.Items.Add("The Great Divide (SE46)")
        'ListBox1.Items.Add("The Helpless Army (SE10)")
        'ListBox1.Items.Add("The Hist (FGD09Hist)")
        'ListBox1.Items.Add("The Killing Field (MS18)")
        'ListBox1.Items.Add("The Lady of Paranoia (SE05)")
        'ListBox1.Items.Add("The Lonely Wanderer (Dark06Wanderer)")
        'ListBox1.Items.Add("The Master's Son (FGD03Viranus)")
        'ListBox1.Items.Add("The Museum of Oddities (SE38)")
        'ListBox1.Items.Add("The Necromancer's Amulet (MG16Amulet)")
        'ListBox1.Items.Add("The Night Mother's Child (Dark07MedicineFIN)")
        'ListBox1.Items.Add("The Noble's Daughter (FGC09Ogres)")
        'ListBox1.Items.Add("The Path of Dawn (MQ05)")
        'ListBox1.Items.Add("The Path of the Righteous (ND04)")
        'ListBox1.Items.Add("The Potato Snatcher (SQ01)")
        'ListBox1.Items.Add("The Prince of Madness (SE14)")
        'ListBox1.Items.Add("The Purification (Dark10Sanctuary)")
        'ListBox1.Items.Add("The Renegade Shadowscale (MSShadowscale)")
        'ListBox1.Items.Add("The Roots of Madness (SE12)")
        'ListBox1.Items.Add("The Rosethorn Cache (HouseSkingradQuest)")
        'ListBox1.Items.Add("The Shrine of the Crusader (ND01)")
        'ListBox1.Items.Add("The Siren's Deception (MS04)")
        'ListBox1.Items.Add("The Stone of St. Alessia (FGC05Stone)")
        'ListBox1.Items.Add("The Sunken One (SQ07)")
        'ListBox1.Items.Add("The Sword of the Crusader (ND08)")
        'ListBox1.Items.Add("The Ultimate Heist (TG11Heist)")
        'ListBox1.Items.Add("The Unfortunate Shopkeeper (FGC02Protect)")
        'ListBox1.Items.Add("The Wandering Scholar (FGC04Scholar)")
        'ListBox1.Items.Add("The Wayward Knight (MS13)")
        'ListBox1.Items.Add("Through A Nightmare, Darkly (MS05)")
        'ListBox1.Items.Add("Through the Fringe of Madness (SE02)")
        'ListBox1.Items.Add("To Help A Hero (SE34)")
        'ListBox1.Items.Add("To Serve Sithis (Dark04ExecutionFIN)")
        'ListBox1.Items.Add("Trolls of Forsaken Mine (FGD06DeadViranus)")
        'ListBox1.Items.Add("Turning a Blind Eye (TG08Blind)")
        'ListBox1.Items.Add("Tutorial (MQ01)")
        'ListBox1.Items.Add("Two Sides of the Coin (MS09)")
        'ListBox1.Items.Add("Ulterior Motives (MG09Motives)")
        'ListBox1.Items.Add("Umaril the Unfeathered (ND10)")
        'ListBox1.Items.Add("Understanding Madness (SE04Shell)")
        'ListBox1.Items.Add("Unearthing Mehrunes Razor (DL9MehrunesQuest)")
        'ListBox1.Items.Add("Unfinished Business (FGD01Default)")
        'ListBox1.Items.Add("Unfriendly Competition (MS29)")
        'ListBox1.Items.Add("Untaxing the Poor (TG02taxes)")
        'ListBox1.Items.Add("Ushnar's Terror (SE43)")
        'ListBox1.Items.Add("Vaermina (DAVaermina)")
        'ListBox1.Items.Add("Vahtacen's Secret (MG10Vahtacen)")
        'ListBox1.Items.Add("Vampire Cure (MS40)")
        'ListBox1.Items.Add("Welcome to the Family (Dark01KnifeFIN)")
        'ListBox1.Items.Add("Weynon Priory (MQ04)")
        'ListBox1.Items.Add("When the Vow Breaks (SQ10)")
        'ListBox1.Items.Add("Where Spirits Have Lease (MS02)")
        'ListBox1.Items.Add("Whispers of Death (Dark19Whispers)")
        'ListBox1.Items.Add("Whodunit? (Dark08Whodunit)")
        'ListBox1.Items.Add("Whom Gods Annoy (MS43)")
        'ListBox1.Items.Add("Wisdom of the Ages (ND05)")
        'ListBox1.Items.Add("Work is Never Done (SE42)")
        'ListBox1.Items.Add("Zero Visibility (MS47)")
        '

        zUpdateAllCounts()


    End Sub

    Public Sub zList1TestDataJunk()

        ListBox1.Items.Add("7TkYx2WcYHguso6BCJOrtffttaWhIMoltMMeZ3PM")
        ListBox1.Items.Add("YNivIPI0hfnvvAwU169LxCA")
        ListBox1.Items.Add("DeUozzGZqsXzyBbfMmPQIJq2jFMOIvm3lO2rdn2Aws9t")
        ListBox1.Items.Add("b1dVB1x8Ci4Mf1heRrwfP")
        ListBox1.Items.Add("Tx4fOub6PURGCgQHLo4x1zWYP22j5H1I83HK4nueeg2lYc5RDDDS")
        ListBox1.Items.Add("lsjN8TP38S9vMbLebuy9RmvOwGOhhd2m0oI30o2iQvYOyJqr2vNvASLwWOidhKSEJp3IVYePUiDRlwz")
        ListBox1.Items.Add("X0cw4hJ7U7mVAXqhcoGaOW38R9")
        ListBox1.Items.Add("JKzkud9V5zQPDlCuVQ4roJQ23HoiTzQ3utjlLsg45b")
        ListBox1.Items.Add("CXSgU30")
        ListBox1.Items.Add("78OQ2ea1UAwYh2EqKshdDo1y24vH7CJEArLlu0xVdH7lIa098CNDsD35z5wqylq19HaIA5bfv67Jj5dAEFUv")
        ListBox1.Items.Add("LR")
        ListBox1.Items.Add("AhUzRqRLj7QUTDOGOkzd3njvUYm8UxcfYoIHNwKAuHOSqL")
        ListBox1.Items.Add("tg")
        ListBox1.Items.Add("jca24cvbhMlbYVv93YP3XC1nAhC3nHgIKHeaGl9ZGe6zR3Nknr8512ZP9QbDPMLU9wxO0zPWRztkVU7DzyHzW6gD")
        ListBox1.Items.Add("S24H4Wkl8Rm14sCqwmqE1toZzq1YmcBJL9pzHc1O2fZQpVJtfxGs2gEpLywOOW4mRT8Ac62AhQbenMY")
        ListBox1.Items.Add("OWsFo7sjRJLaf3F")
        ListBox1.Items.Add("vR739jTAei")
        ListBox1.Items.Add("8KV4uPtgzMffWZWxliNSOBXt8FUmpeid")
        ListBox1.Items.Add("VdCIYjN3BDqEFdIUHWlVfKMhm50akBlDJaCgHVzVpVsTSGYaVfm0xiSPhEig70WspOKEcvF3H0kT6mSIx")
        ListBox1.Items.Add("ZmvbXHZyGaOAoX4i1YtT6vOjNSDcdxe22eOvkDY5A3p37pPyxz")
        ListBox1.Items.Add("IQeGKKVK")
        ListBox1.Items.Add("JgjHBBB9y98ge8gO2")
        ListBox1.Items.Add("waMyMaKUdDiGQ65XgigqfA1snGAwbyiDmH1hixLrOaCYdfP8vhhrX10JS9dwy")
        ListBox1.Items.Add("vCfvwtf1v6V")
        ListBox1.Items.Add("65L0UZplkJn7j3NVYdeaOcZYicOfAkIWywaJ")
        ListBox1.Items.Add("sLoEoLeN6ns9dJuXihQipPOL3Vzsjso7cmaEmO9NUy23AobXa56s4oiFitdNukxnpMGGzsAr17KODhpzp38z77")
        ListBox1.Items.Add("dcvsYwYYSHYCgO68cHCkDzHeNPXyN9cqBNtk3bginL")
        ListBox1.Items.Add("L3djfXGxSpBk65BjqEG6eU9k0tULHD2QklrlUzYjCWDh7u7KfLyRTbyl7ysMBYRYePkF0bwzalktCFvLzEl5mhKjFzrL")
        ListBox1.Items.Add("ACMEpFirldMLekohPhEtAcpRJ8VGo6lCfIe0dLy1vaLlRgd05cNoPCPAxGc2PdJgRaT1glAy")
        ListBox1.Items.Add("ohJFSukphxzJp7eUKOhvQZuT1Q5P9ISzVGpW8nAQn6nXV5OGQ9jnst8LUFeD3aaQFJpvNlTondKG9ajWN")
        ListBox1.Items.Add("fm")
        ListBox1.Items.Add("HPCe93xT3TAfLD1h")
        ListBox1.Items.Add("2ekR0MyS88ukfED4RBMWw64Tou7q5LsbJmiRgesm60y8SAqUxSWuJOQVjDYXcnNyrF0UCIywg")
        ListBox1.Items.Add("ARF1DPA2uR3eiueK0ZaSXlGQOGeKELkGqSVj")
        ListBox1.Items.Add("gtIxSbg6NPl8aBEAVek9QV2MPAtzpdRRsFXrh")
        ListBox1.Items.Add("iSDMhoSWkVzeEz1XrCUuB8BVTFZZdkmad0z46SC6IegkRrWGU")
        ListBox1.Items.Add("fC8qZarTB")
        ListBox1.Items.Add("nE2G20eEJoUnHoquyvm8syhrylOkKz1qASUusm")
        ListBox1.Items.Add("783Skc0KOHWVuaf6")
        ListBox1.Items.Add("0PZFlyR7ZUdV5eGzkgwxfeAyN7ASb8p3UuZGbq7EqvJu65l0S4HbP0Ok6f7tIzWXEPboa5h")
        ListBox1.Items.Add("NpO5lYHRQgUo4nlZQxIxqqhpoYAXzeJ0jFGE4wXr5CvAtcQEqdpgLLikIK2eTS")
        ListBox1.Items.Add("ASTthS3KmaL5ea7cwzkBBQhzkVxB69mTatcdZVgXbkswoctPG0faXBxiJURMeV")
        ListBox1.Items.Add("yQpwfBSe4vlzZcaFrVWCSVkFu7Mni8Oniqi35NaIA5f")
        ListBox1.Items.Add("5tSjKdDnJVO8W54kFiIVBDtwqpzevV8zJGDPSPRwUDUbNzwnqkFXLdqBoTXy99WC565wHzXinJ7a50")
        ListBox1.Items.Add("kboWmOzmBU14qIZe1YmVEd")
        ListBox1.Items.Add("3tzCd9gBh82pLdyNXJVlLpVqtAEA6ymXPbs4APTQbuLTnc")
        ListBox1.Items.Add("nCORx0oejf61unZTB6U3CMTdXwIUDxIVKTRcah5GtdSKdr6Bix56HOVLuu4ZV1cFZOdQ30CORL6kGxm7OK9KgHDu")
        ListBox1.Items.Add("YGEr9e0E1mCZFEmcYghsqu32fwGeGrtqAveyfEHHshf0TeTMC6rYWJV")
        ListBox1.Items.Add("WnaKEKW3Z4a7XYfF6mPWznOcnyRARkWdzLjr8pxyGy2rbKzOonetJ")
        ListBox1.Items.Add("SB1U0Wc8nUeqtXmvd57XRmVW2FF08ILiOkgUQYpvdudjs7w6cL9I1")
        ListBox1.Items.Add("EwsFWByuj95HCL1SmRR5J4EMCGe45CH5")
        ListBox1.Items.Add("iLNwiMU3oHPq5vYvygtXC4lN0gQgUTbPHnnyYwkGMGkucdDg4akM0hxJE9MEdIAYeUrlBFSbN4TBqTBkZb")
        ListBox1.Items.Add("SjvBF8FpBtrZoLNyd4QJXgjqLsaQNItRf4wABDid9431KlcPRGtsNEmBfNCX3ckqauRQZ1sHQpGfM4rQyn5wRFOOVQ")
        ListBox1.Items.Add("h1pyDr")
        ListBox1.Items.Add("lKTxLoBO4ljgk4X6EHsHPviBZAuUIREMdbqoTV7R7yzIdFllJ94VYE5tKjn7qCF")
        ListBox1.Items.Add("LPTiVuzs81Rf5yoBrq8oeSy4AQSNF8FBRRJZi15DsrnsdQpOXk077X2uPEORRkCbUkx0W")
        ListBox1.Items.Add("bYBTSYwyU8yabfC3wrBAD9yLpjZYoLE9B2h5xgQZomRhDu7LJPtRbq3gNsEG9Fj1s6hCsZ6RN231tMKkCp2")
        ListBox1.Items.Add("A8hSL4mlzekgy")
        ListBox1.Items.Add("H4AkGzU1K1NUIz5xEy5")
        ListBox1.Items.Add("D3CYnIdyMjggozxyocXv7xEzJofEdavful85Y2QRdUHbRkFWSIuKXgIIiJ4wtG1BILzIitoIgX5wp9Ro")
        ListBox1.Items.Add("fwtegFFUGjgTGMJ5zTej")
        ListBox1.Items.Add("jc5gVjgrvxUQyKrYgGJ2t5DjW4OEGPMcNsltj63Asp7M75p9tQSJ1x3JKwU0ziXT5twbtNnoICxk3wkJHbLr")

    End Sub

    Private Sub btCodeGenTextBoxtoListPop_Click(sender As Object, e As EventArgs) Handles btCodeGenTextBoxToListPop.Click
        zCodeGenMultiLineTextBoxToVBListBoxAddItemsTextBlock(TextBox1, TextBox2)
    End Sub

    Private Sub btCodeGenTextBoxWindowsBatchToAHKBatchLinesString_Click(sender As Object, e As EventArgs) Handles btCodeGenTextBoxWindowsBatchToAHKBatchLinesString.Click
        zTextLinesToListbox(TextBox1, ListBox1, 1)
        '2026-06-24-00-53-18-AM
        'default batch string format
        'back tick? ` above tab and n is new line
        '`n

        'default from hex image batch format from autohotkey format
        'also includes writing batch file in autohotkey format

        'zbatstr := ""
        'zbatstr := zbatstr "`nrem this is a batch file to run image magick"
        'zbatstr := zbatstr "`nrem for the purpose of generating a random"
        'zbatstr := zbatstr "`nrem hex code image of a solid color at 184x184"
        'zbatstr := zbatstr "`nrem C:\zonide\zip\ahk\heximage"
        'zbatstr := zbatstr "`nchdir /d D:"
        'zbatstr := zbatstr "`ncd C:\zonide\zip\ahk\heximage"
        'zbatstr := zbatstr "`nconvert -size 184x184 xc:#" zrandhex " " zrhimgn ".png"

        ';C\zonide\zip\ahk\bat\hexbat.bat
        'zpath := "C:\zonide\zip\ahk\bat\hexbat.bat"
        '
        ';open file
        ';`n option stand-alone `n to `r`n when writing
        'zile := FileOpen(zpath, "w`n")
        '	If !zile Then
        '            	{
        '		zwmsg(zpath)
        '            Return
        '	}
        '
        ';write the file
        'zile.Write(zbatstr)
        '
        ';close the file
        'zile.Close()

        'default batch from zfilelist-move

        'REM 2026-06-23-12-00-04-PM
        'REM works with auto hot key test.ahk
        'REM zfilelist.txt from test.exe based file lists
        'REM you can use wild cards to seach directories
        'REM like *blah*.mp3 will return all files with blah that are .mp3 files in zfilelist
        'REM using control shift f and specifying
        'REM the paths and search in the input boxes
        'REM checks any file type
        '
        'REM meant as structure
        'REM to be changed as needed
        'REM for the zfile directory
        'REM that you have to change manually
        'REM this makes executing commmands on
        'REM just a specific file list search
        '
        '       @echo off
        '       
        '       setlocal EnableDelayedExpansion
        '       
        '       rem make sure that the paths end in \
        '       rem "C:\farts\" is correct
        '       rem "C:\farts" is incorrect
        '       set "zsrcpath=C:\zonide\non-zip\music\"
        '       echo "zsrcpath !zsrcpath!"
        '       set "zfile=zfilelist.txt"
        '       echo "zfile !zfile!"
        '       set "zdestpath=C:\zonide\non-zip\music\"
        '       echo "zdestpath !zdestpath!"
        '       set "zsrcfilepath=!zsrcpath!!zfile!"
        '       echo "zsrcfilepath !zsrcfilepath!"
        '       
        '       cd!zsrcpath!
        '       
        '       For / f "usebackq delims=" %%a in ("!zsrcfilepath!") do (
        '           REM this is where it reads the files
        '       	REM then performs commands on each file name
        '       	REM using %%a
        '       	echo %%a
        '       	Move / y "%%a" "!zdestpath!"
        '       
        '       )
        '       

    End Sub

    Private Sub btCodeGen4TextBox1ListBoxGeneralLeftCenterRightOutput_Click(sender As Object, e As EventArgs) Handles btCodeGen4TextBox1ListBoxGeneralLeftCenterRightOutput.Click
        '2026-06-24-02-07-41-AM
        'this takes the 3 text boxes and assembles a string from them
        'text1  & text2 & text3
        'then outputs them in to both the list box
        'and as lines in the output text box 4
        'this is for general use for new functions and subs
        'for the vabbajacksandvich.vb
        'rather than re write it everytime
        'i can just use this with different substitutions
        'this version is for controls which is mainly for line combine
        'which as of writing this has to be updated with another text box
        'the existing code will still work with the other stuff
        'unchanged with text 1 and 2 and the output listbox

        'in a different version im going to remove the controls
        'and just use variables and arrays

        'leaving the stuff commented out
        'makes it easier to copy and paste later
        'make it pretty later
        'or ever

        'input left side
        If TextBox1.Text = "" Then Exit Sub
        'input center
        If TextBox2.Text = "" Then Exit Sub
        'input right side
        If TextBox3.Text = "" Then Exit Sub
        'If TextBox4.Text = "" Then Exit Sub
        'If ListBox1.Items.Count = 0 Then Exit Sub
        'If ListBox1.SelectedIndex = -1 Then
        '    ListBox1.SelectedIndex = 0
        'End If
        ListBox1.Items.Clear()
        'output box
        TextBox4.Text = ""

        'left
        Dim zT1str As String = TextBox1.Text
        'center
        Dim zT2str As String = TextBox2.Text
        'right
        Dim zT3str As String = TextBox3.Text

        'Dim zT4str As String = TextBox4.Text

        'zScanStringReturnAsArray()
        'Dim zTmp(50000) As String
        'zTmp = zScanReturnAsArray(Input String, Thing to find)

        'have to do temp arrays for each listbox

        'copy paste
        'Dim zTmpList(50000) As String
        'Dim zTmpCount As Integer = 0
        'Dim zTempCodeLine As String
        'Dim zTmp(50000) As String
        ''vabbajacksandvich.vb global
        ''zr = vbcrlf
        'zTmp = zScanStringReturnAsArray(zT1str, zR)
        'zTmpCount = zGetArrayCount(zTmp)

        'text1.text
        'temp list 1
        Dim zTmpCount1 As Integer = 0
        Dim zTempCodeLine1 As String
        Dim zTmp1(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        zTmp1 = zScanStringReturnAsArray(zT1str, zR)
        zTmpCount1 = zGetArrayCount(zTmp1)

        'text2.text
        'temp list 2
        Dim zTmpCount2 As Integer = 0
        Dim zTempCodeLine2 As String
        Dim zTmp2(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        zTmp2 = zScanStringReturnAsArray(zT2str, zR)
        zTmpCount2 = zGetArrayCount(zTmp2)

        'text3.text
        'temp list 3
        Dim zTmpCount3 As Integer = 0
        Dim zTempCodeLine3 As String
        Dim zTmp3(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        zTmp3 = zScanStringReturnAsArray(zT3str, zR)
        zTmpCount3 = zGetArrayCount(zTmp3)

        If zTmpCount1 = 0 Then Exit Sub
        If zTmpCount2 = 0 Then Exit Sub
        If zTmpCount3 = 0 Then Exit Sub

        If zTmpCount1 = zTmpCount2 And zTmpCount1 = zTmpCount3 Then
            'temp counts match
            'easier to write this part first since they all match
            Dim zI1 As Integer = 0
            Dim zTempStr As String
            Dim zTout As String
            For zI1 = 0 To zTmpCount1
                Application.DoEvents()
                zTempCodeLine1 = zTmp1(zI1)
                zTempCodeLine2 = zTmp1(zI1)
                zTempCodeLine3 = zTmp1(zI1)
                zTempStr = zTempCodeLine1 & zTempCodeLine2 & zTempCodeLine3 & zR
                ListBox1.Items.Add(zTempStr)
                zTout = zTout & zTempStr
            Next
            TextBox4.Text = zTout
        Else
            'temp counts do not match
            'might want to merge them with uneven things?
            'this makes it easier to do that later
            Exit Sub
        End If

    End Sub

    Public Sub zCodeGenClearAll()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ListBox1.Items.Clear()
        txtTestDataString.Text = "Test Data String"
        txtTestDataAmount.Text = "0"
        txtTestDataLength.Text = "0"
        txtTestDataReturn.Text = "0"
        txtTestDataRandomStringEveryCycle.Text = "0"
        txtTestDataRandomLengthEveryCycle.Text = "0"

    End Sub

    Private Sub btClearAll_Click(sender As Object, e As EventArgs) Handles btClearAllSetDefaults.Click
        zCodeGenClearAll()
    End Sub

    'Public Function zTestDataString(
    'Optional zString As String = "",
    'Optional zLength As Integer = 0,
    'Optional zAmount As Integer = 0,
    'Optional zReturn As Integer = 0,
    'Optional zRandomStringEveryCycle As Integer = 0,
    'Optional zRandomLengthEveryCycle As Integer = 0) As String

    Private Sub btTestData_Click(sender As Object, e As EventArgs) Handles btTestDataNoReturn.Click
        'TextBox1.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 0, 0, 0)
        'TextBox2.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 0, 0, 0)
        'TextBox3.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 0, 0, 0)
        '2026-06-24-09-01-12-AM
        'zStringToIntegerWithTrimLeadingZeros()
        'TextBox1.Text = zTestDataString(txtTestDataString.Text,
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataReturn.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox1.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(0),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox2.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(0),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox3.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(0),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        zUpdateAllCounts()
    End Sub

    Private Sub btTestData1Return_Click(sender As Object, e As EventArgs) Handles btTestData1Return.Click
        'TextBox1.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 1, 0, 0)
        'TextBox2.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 1, 0, 0)
        'TextBox3.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 1, 0, 0)

        TextBox1.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(1),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox2.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(1),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox3.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(1),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        zUpdateAllCounts()
    End Sub

    Private Sub btTestData2Returns_Click(sender As Object, e As EventArgs) Handles btTestData2Returns.Click
        'TextBox1.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 2, 0, 0)
        'TextBox2.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 2, 0, 0)
        'TextBox3.Text = zTestDataString(txtTestDataString.Text, CInt(zTrimLeadingZero(txtTestDataLength.Text)), CInt(zTrimLeadingZero(txtTestDataAmount.Text)), 2, 0, 0)

        TextBox1.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(2),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox2.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(2),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        TextBox3.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(2),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        zUpdateAllCounts()
    End Sub

    Public Sub zFormatInputTextBoxesToHave1Return()

        zTextBoxFormat1Return(TextBox1)
        zTextBoxFormat1Return(TextBox2)
        zTextBoxFormat1Return(TextBox3)
        zTextBoxFormat1Return(TextBox4)


    End Sub

    Public Sub zUpdateAllCounts()
        zFormatInputTextBoxesToHave1Return()
        Dim zTmpCount1 As Integer = 0
        Dim zTempCodeLine1 As String
        Dim zTmp1(50000) As String
        Dim zTmpCount2 As Integer = 0
        Dim zTempCodeLine2 As String
        Dim zTmp2(50000) As String
        Dim zTmpCount3 As Integer = 0
        Dim zTempCodeLine3 As String
        Dim zTmp3(50000) As String
        Dim zTmpCount4 As Integer = 0
        Dim zTempCodeLine4 As String
        Dim zTmp4(50000) As String

        If TextBox1.Text <> "" Then
            'text1.text
            'temp list 1
            'vabbajacksandvich.vb global
            'zr = vbcrlf
            zTmp1 = zScanStringReturnAsArray(TextBox1.Text, zR)
            zTmpCount1 = zGetArrayCount(zTmp1)
        End If

        If TextBox2.Text <> "" Then
            'text2.text
            'temp list 2
            'vabbajacksandvich.vb global
            'zr = vbcrlf
            zTmp2 = zScanStringReturnAsArray(TextBox2.Text, zR)
            zTmpCount2 = zGetArrayCount(zTmp2)
        End If

        If TextBox3.Text <> "" Then
            'text3.text
            'temp list 3
            'vabbajacksandvich.vb global
            'zr = vbcrlf
            zTmp3 = zScanStringReturnAsArray(TextBox3.Text, zR)
            zTmpCount3 = zGetArrayCount(zTmp3)
        End If

        If TextBox4.Text <> "" Then
            'text4.text
            'temp list 4
            'vabbajacksandvich.vb global
            'zr = vbcrlf
            zTmp4 = zScanStringReturnAsArray(TextBox4.Text, zR)
            zTmpCount4 = zGetArrayCount(zTmp4)
        End If

        'update text box line count labels
        lbCount1.Text = zTmpCount1
        lbCount2.Text = zTmpCount2
        lbCount3.Text = zTmpCount3
        lbCount4.Text = zTmpCount4
        lbCountList1.Text = ListBox1.Items.Count

        'update text box length labels
        lbLength1.Text = Len(TextBox1.Text)
        lbLength2.Text = Len(TextBox2.Text)
        lbLength3.Text = Len(TextBox3.Text)
        lbLength4.Text = Len(TextBox4.Text)

    End Sub

    Private Sub btUpdateAllCounts_Click(sender As Object, e As EventArgs) Handles btUpdateAllCounts.Click
        zUpdateAllCounts()
    End Sub

    Private Sub btGetCount1_Click(sender As Object, e As EventArgs) Handles btGetCount1.Click
        'text1.text
        'temp list 1
        Dim zTmpCount1 As Integer = 0
        Dim zTempCodeLine1 As String
        Dim zTmp1(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        If TextBox1.Text <> "" Then
            zTmp1 = zScanStringReturnAsArray(TextBox1.Text, zR)
            zTmpCount1 = zGetArrayCount(zTmp1)
        End If
        lbCount1.Text = zTmpCount1
    End Sub

    Private Sub btGetCount2_Click(sender As Object, e As EventArgs) Handles btGetCount2.Click
        'text2.text
        'temp list 2
        Dim zTmpCount2 As Integer = 0
        Dim zTempCodeLine2 As String
        Dim zTmp2(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        If TextBox2.Text <> "" Then
            zTmp2 = zScanStringReturnAsArray(TextBox2.Text, zR)
            zTmpCount2 = zGetArrayCount(zTmp2)
        End If
        lbCount2.Text = zTmpCount2
    End Sub

    Private Sub btGetCount3_Click(sender As Object, e As EventArgs) Handles btGetCount3.Click
        'text3.text
        'temp list 3
        Dim zTmpCount3 As Integer = 0
        Dim zTempCodeLine3 As String
        Dim zTmp3(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        If TextBox3.Text <> "" Then
            zTmp3 = zScanStringReturnAsArray(TextBox3.Text, zR)
            zTmpCount3 = zGetArrayCount(zTmp3)
        End If
        lbCount3.Text = zTmpCount3
    End Sub

    Private Sub btGetCount4_Click(sender As Object, e As EventArgs) Handles btGetCount4.Click
        'text4.text
        'temp list 4
        Dim zTmpCount4 As Integer = 0
        Dim zTempCodeLine4 As String
        Dim zTmp4(50000) As String
        'vabbajacksandvich.vb global
        'zr = vbcrlf
        If TextBox4.Text <> "" Then
            zTmp4 = zScanStringReturnAsArray(TextBox4.Text, zR)
            zTmpCount4 = zGetArrayCount(zTmp4)
        End If
        lbCount4.Text = zTmpCount4
    End Sub

    Private Sub btGetCountList1_Click(sender As Object, e As EventArgs) Handles btGetCountList1.Click
        lbCountList1.Text = ListBox1.Items.Count
    End Sub

    Private Sub btClear1_Click(sender As Object, e As EventArgs) Handles btClear1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub btClear2_Click(sender As Object, e As EventArgs) Handles btClear2.Click
        TextBox2.Text = ""

    End Sub

    Private Sub btClear3_Click(sender As Object, e As EventArgs) Handles btClear3.Click
        TextBox3.Text = ""

    End Sub

    Private Sub btClear4_Click(sender As Object, e As EventArgs) Handles btClear4.Click
        TextBox4.Text = ""

    End Sub

    Private Sub btClearList1_Click(sender As Object, e As EventArgs) Handles btClearList1.Click
        ListBox1.Items.Clear()

    End Sub

    Public Sub zSanitizeTestDataBoxes()
        '2026-06-24-09-11-35-AM

        'TextBox1.Text = zTestDataString(txtTestDataString.Text,
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataReturn.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        'zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        'not filtering this
        'too many potential special characters
        'plus the optionals allow for it to be null
        'txtTestDataString.Text = zAlphaNumFilterWithDashPlusSpace(txtTestDataString.Text)

        'these have to be right
        txtTestDataLength.Text = zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text)
        txtTestDataAmount.Text = zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text)
        txtTestDataReturn.Text = zStringToIntegerWithTrimLeadingZeros(txtTestDataReturn.Text)
        txtTestDataRandomStringEveryCycle.Text = zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text)
        txtTestDataRandomLengthEveryCycle.Text = zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text)

        'defaults
        'TextBox1.Text = ""
        'TextBox2.Text = ""
        'TextBox3.Text = ""
        'TextBox4.Text = ""
        'ListBox1.Items.Clear()
        'txtTestDataString.Text = "Test Data String"
        'txtTestDataAmount.Text = "0"
        'txtTestDataLength.Text = "0"
        'txtTestDataReturn.Text = "0"
        'txtTestDataRandomStringEveryCycle.Text = "0"
        'txtTestDataRandomLengthEveryCycle.Text = "0"

        'check for nulls
        'set appropriate defaults
        'not this
        'If txtTestDataString.Text = "" Then
        '    txtTestDataString.Text = "Test Data String"
        'End If
        If txtTestDataAmount.Text = "" Then
            txtTestDataAmount.Text = "0"
        End If
        If txtTestDataLength.Text = "" Then
            txtTestDataLength.Text = "0"
        End If
        If txtTestDataReturn.Text = "" Then
            txtTestDataReturn.Text = "0"
        End If
        If txtTestDataRandomStringEveryCycle.Text = "" Then
            txtTestDataRandomStringEveryCycle.Text = "0"
        End If
        If txtTestDataRandomLengthEveryCycle.Text = "" Then
            txtTestDataRandomLengthEveryCycle.Text = "0"
        End If


    End Sub

    Private Sub btTestDataSendItUsingOptionalsOnly_Click(sender As Object, e As EventArgs) Handles btTestDataSendItUsingOptionalsOnly.Click
        zSanitizeTestDataBoxes()

        TextBox1.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataReturn.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))
        TextBox2.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataReturn.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))
        TextBox3.Text = zTestDataString(txtTestDataString.Text,
        zStringToIntegerWithTrimLeadingZeros(txtTestDataLength.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataAmount.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataReturn.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomStringEveryCycle.Text),
        zStringToIntegerWithTrimLeadingZeros(txtTestDataRandomLengthEveryCycle.Text))

        zUpdateAllCounts()

    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        zOnTopCheckBox(Me, ckOnTop)
    End Sub
End Class
