/*
 * Created by SharpDevelop.
 * User: sergi
 * Date: 15/06/2016
 * Time: 10:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BW_tool
{
	/// <summary>
	/// Description of Entralink_DreamWorld.
	/// </summary>
	public partial class Entralink_DreamWorld : Form
	{
		public Entralink_DreamWorld(int DW, string Area)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			area_label.Text = Area;
			exclusive_label.Text = "";
			world = DW;
			setup_world();
			if (DW < 8)
			{
				moveboxA.Visible = true;
				moveboxC.Visible = true;
				atkA.Visible = true;
				atkB.Visible = true;
				atkC.Visible = true;
				
				Move.Text = "Move";
				
				pgl_region_box.Visible = false;
				region_lab.Visible = false;
				move_lab.Visible = false;
				
				addall_but.Visible = (DW != 7); //Skip Pokemon Cafe Forest
			}
			else if (DW == 8)
			{
				moveboxA.Visible = false;
				moveboxC.Visible = false;
				atkA.Visible = false;
				atkB.Visible = false;
				atkC.Visible = false;
				
				Move.Text = "Info";
				
				pgl_region_box.Visible = true;
				region_lab.Visible = true;
				move_lab.Visible = true;
				
				addall_but.Visible = false;
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		private int world = 0;
		private void setup_world()
		{
			switch (world)
			{
				case 0://Pleasant forest
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Rattata",
						"Nidoran (F)            (BW*)",
						"Nidoran (M)            (BW*)",
						"Oddish",
						"Bellsprout",
						"Ponyta",
						"Farfetch'd",
						"Doduo",
						"Exeggcute",
						"Lickitung",
						"Tangela",
						"Kangaskhan",
						"Sentret",
						"Igglybuff              (BW*)",
						"Mareep",
						"Hoppip                 (BW*)",
						"Sunkern",
						"Stantler",
						"Poochyena",
						"Lotad                  (BW*)",
						"Taillow                (BW*)",
						"Surskit",
						"Bidoof",
						"Shinx",
						"Tympole                (B2W2*)",
						"Cottonee               (B2W2*)",
						"Petilil                (B2W2*)",
						"Karrablast             (B2W2*)",
						"Shelmet                (B2W2*)",
						"Glameow",
						"Scolipede              (B2W2*)",
						"Psyduck",
						"Growlithe",
						"Scyther",
						"Tauros",
						"Marill",
						"Sudowoodo",
						"Girafarig",
						"Miltank",
						"Zigzagoon",
						"Electrike              (BW*)",
						"Castform               (BW*)",
						"Pachirisu              (BW*)",
						"Buneary",
						"Vulpix",
						"Poliwag",
						"Natu",
						"Elekid",
						"Skitty"});
					speciesbox.SelectedIndex = 0;
					break;
				case 1://Windskept Sky
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Butterfree             (BW*)",
						"Pidgey",
						"Spearow",
						"Zubat",
						"Aerodactyl",
						"Hoothoot               (BW*)",
						"Ledyba",
						"Hoppip",
						"Yanma",
						"Murkrow",
						"Gligar",
						"Delibird",
						"Taillow",
						"Wingull                 (BW*)",
						"Swablu                  (BW*)",
						"Staravia",
						"Pidove                  (B2W2*)",
						"Sigilyph                (B2W2*)",
						"Ducklett                (B2W2*)",
						"Emolga                  (B2W2*)",
						"Skarmory",
						"Tropius",
						"Drifloon                (BW*)",
						"Chatot                  (BW*)"});
					speciesbox.SelectedIndex = 0;
					break;
				case 2:
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Slowpoke                (BW*)",
						"Seel",
						"Shellder",
						"Krabby                  (BW*)",
						"Horsea",
						"Goldeen",
						"Seaking                 (BW*)",
						"Staryu                  (BW*)",
						"Magikarp",
						"Omanyte",
						"Kabuto",
						"Chinchou",
						"Wooper",
						"Qwilfish",
						"Corsola                 (BW*)",
						"Remoraid",
						"Mantine",
						"Wailmer",
						"Barboach",
						"Clamperl",
						"Relicanth",
						"Luvdisc",
						"Buizel",
						"Finneon",
						"Basculin (Red Striped)  (B2W2*)",
						"Basculin (Blue Striped) (B2W2*)",
						"Alomomola               (B2W2*)",
						"Stunfisk                (B2W2*)",
						"Tirtouga                (B2W2*)",
						"Tentacool",
						"Carvanha",
						"Corphish",
						"Lileep",
						"Anorith",
						"Feebas",
						"Shellos (West Sea)      (BW*)",
						"Shellos (East Sea)      (BW*)",
						"Lapras",
						"Dratini"});
					speciesbox.SelectedIndex = 0;
					break;
				case 3: // Spooky Mannor
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Gastly",
						"Drowzee",
						"Mr. Mime",
						"Spinarak",
						"Misdreavus",
						"Wobbuffet               (BW*)",
						"Houndour",
						"Smoochum                (BW*)",
						"Mawile                  (BW*)",
						"Meditite                (BW*)",
						"Spoink",
						"Shuppet",
						"Duskull",
						"Chimecho",
						"Stunky",
						"Bronzor                 (BW*)",
						"Elgyem                  (B2W2*)",
						"Pawniard                (B2W2*)",
						"Galvantula              (B2W2*)",
						"Meowth                  (BW*)",
						"Snubbull",
						"Smeargle",
						"Volbeat",
						"Illumise",
						"Rotom                   (BW*)",
						"Abra",
						"Ralts                   (BW*)",
						"Sableye                 (BW*)",
						"Spiritomb               (BW*)",
						"Duosion                 (B2W2*)",
						"Golett                  (B2W2*)"});
					speciesbox.SelectedIndex = 0;
					break;
				case 4:
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Mankey                  (BW*)",
						"Machop",
						"Magnemite",
						"Koffing",
						"Rhyhorn                 (BW*)",
						"Slugma",
						"Phanpy                  (BW*)",
						"Larvitar",
						"Torkoal",
						"Trapinch",
						"Cacnea",
						"Burmy",
						"Hippopotas",
						"Skorupi                 (BW*)",
						"Heatmor                 (B2W2*)",
						"Durant                  (B2W2*)",
						"Maractus                (B2W2*)",
						"Crustle                 (B2W2*)",
						"Magby",
						"Teddiursa               (BW*)",
						"Makuhita                (BW*)",
						"Numel",
						"Spinda                  (BW*)",
						"Absol",
						"Beldum                  (BW*)",
						"Croagunk",
						"Tyrogue",
						"Bagon",
						"Krookodile              (B2W2*)",
						"Riolu                   (BW*)"});
					speciesbox.SelectedIndex = 0;
					break;
				case 5: //Icy cave
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Sandshrew",
						"Geodude",
						"Onix",
						"Voltorb",
						"Cubone",
						"Cleffa                  (BW*)",
						"Shuckle                 (BW*)",
						"Whismur",
						"Nosepass                (BW*)",
						"Aron",
						"Lunatone",
						"Solrock",
						"Baltoy",
						"Spheal                  (BW*)",
						"Cranidos                (BW*)",
						"Snover",
						"Drilbur                 (B2W2*)",
						"Druddigon               (B2W2*)",
						"Diglett",
						"Dunsparce               (BW*)",
						"Boldore                 (B2W2*)",
						"Vanillish               (B2W2*)",
						"Klang                   (B2W2*)",
						"Sneasel",
						"Snorunt",
						"Shieldon                (BW*)",
						"Swinub",
						"Gible",
						"Axew                    (B2W2*)"});
					speciesbox.SelectedIndex = 0;
					break;
				case 6: //Dream Park
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Paras",
						"Pineco",
						"Wurmple",
						"Seedot",
						"Slakoth",
						"Nincada",
						"Plusle",
						"Minun",
						"Gulpin",
						"Kecleon",
						"Kricketot",
						"Cherubi",
						"Carnivine",
						"Audino                  (B2W2*)",
						"Throh                   (B2W2*)",
						"Sawk                    (B2W2*)",
						"Scraggy                 (B2W2*)",
						"Venonat                 (BW*)",
						"Grimer                  (BW*)",
						"Combee                  (BW*)",
						"Beedrill                (BW*)",
						"Ekans",
						"Togepi",
						"Aipom",
						"Shroomish",
						"Gurdurr                 (B2W2*)",
						"Roselia",
						"Zangoose                (BW*)",
						"Seviper                 (BW*)",
						"Chansey",
						"Pinsir",
						"Eevee",
						"Snorlax",
						"Heracross"});
					speciesbox.SelectedIndex = 0;
					break;
				case 7://Pokemon Cafe forest
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Poliwhirl",
						"Eevee",
						"Smeargle",
						"Burmy"});
					speciesbox.SelectedIndex = 0;
					break;
				case 8://PGL Promotions
					speciesbox.Items.Clear();
					speciesbox.Items.AddRange(new object[] {
						"Vaporeon",
						"Jolteon",
						"Flareon",
						"Espeon",
						"Umbreon",
						"Leafeon",
						"Glaceon",
						"Bulbasaur",
						"Charmander",
						"Squirtle",
						"Croagunk",
						"Turtwig",
						"Chimchar",
						"Piplup",
						"Arceus",
						"Treecko",
						"Torchic",
						"Mudkip",
						"Togekiss",
						"Mamoswine",
						"Porygon",
						"Rayquaza",
						"Banette",
						"Croagunk",
						"Altaria",
						"Blissey",
						"Lucario",
						"Gothorita",
						"Pikachu",
						"Jumpluff",
						"Pansage",
						"Pansear",
						"Panpour",
						"Turtwig",
						"Chimchar",
						"Piplup",
						"Gothorita",
						"Scizor",
						"Garchomp",
						"Dragonite",
						"Tyranitar",
						"Dragonite",
						"Metagross"});
					speciesbox.SelectedIndex = 0;
					break;
			}
			atkA.Checked = true;
			update_atk();
		}
		void Ok_butClick(object sender, EventArgs e)
		{
			if (world < 8)
			{
				//Handle forms
				int anim = form_anim(gender);
				if (world == 2 && (speciesbox.SelectedIndex == 25 || speciesbox.SelectedIndex == 36 )) //Blue basculin, East Sea shellos
					Entralink.dream_pkm = Entralink.forest.create_pkm(world_species[world][speciesbox.SelectedIndex], world_attacks[world][speciesbox.SelectedIndex][atk], gender, 1, anim);
				else
					Entralink.dream_pkm = Entralink.forest.create_pkm(world_species[world][speciesbox.SelectedIndex], world_attacks[world][speciesbox.SelectedIndex][atk], gender, 0, anim);
			}
			else if (world == 8)
			{
				//PGL animations come from world_anims like every other area now.
				//Nearly every PGL distribution uses LOOK_AROUND; Mamoswine is the one
				//known exception, index 2 (WALK_LOOK_AROUND), stored raw as 4.
				int anim = form_anim(gender);
				Entralink.dream_pkm = Entralink.forest.create_pkm(world_species[world][speciesbox.SelectedIndex], PGL_attacks[speciesbox.SelectedIndex], gender, 0, anim);
			}
			this.Close();
		}
		void Cancel_butClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Addall_butClick(object sender, EventArgs e)
		{
			//Adds every species in the current Dream World area to the forest,
			//each with a random (valid) gender, its documented idle animation,
			//and a random move - B or C, except Magikarp which only ever gets A or B.
			//BW-exclusive species are skipped on a B2W2 save and vice versa.
			//If the current forest area fills up, remaining species spill into the next area.
			//Not available for Pokemon Cafe Forest or PGL Promotions.
			if (world == 7 || world >= 8)
			{
				this.Close();
				return;
			}
			
			int startArea = Entralink.forest.Area;
			bool ranOutOfRoom = false;
			
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			int count = speciesbox.Items.Count;
			int i = 0;
			for (i = 0; i < count; i++)
			{
				int dex = world_species[world][i];
				
				//Skip species that don't belong on this cart version
				bool skip = false;
				int j = 0;
				if (MainForm.save.B2W2 == true)
				{
					for (j = 0; j < world_BW1_exclusives[world].Length; j++)
					{
						if (world_BW1_exclusives[world][j] == dex)
							skip = true;
					}
				}
				else
				{
					for (j = 0; j < world_BW2_exclusives[world].Length; j++)
					{
						if (world_BW2_exclusives[world][j] == dex)
							skip = true;
					}
				}
				if (skip)
					continue;
				
				//Work out which genders are actually valid for this species
				bool femaleOnly = false;
				bool maleOnly = false;
				bool genderless = false;
				for (j = 0; j < Entralink.BW_femaleonly.Length; j++)
				{
					if (dex == Entralink.BW_femaleonly[j])
						femaleOnly = true;
				}
				for (j = 0; j < Entralink.BW_maleonly.Length; j++)
				{
					if (dex == Entralink.BW_maleonly[j])
						maleOnly = true;
				}
				for (j = 0; j < Entralink.BW_genderless.Length; j++)
				{
					if (dex == Entralink.BW_genderless[j])
						genderless = true;
				}
				
				int gnd = 0;
				if (femaleOnly)
					gnd = 1;
				else if (maleOnly)
					gnd = 0;
				else if (genderless)
					gnd = 2;
				else
					gnd = rnd.Next(2); //Random male/female
				
				//Same documented per-species/gender animation used by the single-add flow
				int anim = form_anim(i, gnd);
				
				//Magikarp (dex 129) always gets a random A/B; anyone else without a documented
				//C move (-1) is treated the same way - random A/B. Everyone else gets random B/C.
				int[] atkEntry = world_attacks[world][i];
				bool hasC = atkEntry.Length > 2 && atkEntry[2] != -1;
				int atkIndex = 0;
				if (dex == 129 || !hasC)
					atkIndex = rnd.Next(2);       //0 = A, 1 = B
				else
					atkIndex = rnd.Next(2) + 1;   //1 = B, 2 = C
				int mv = atkEntry[atkIndex];
				
				int frm = 0;
				if (world == 2 && (i == 25 || i == 36)) //Blue Basculin, East Sea Shellos
					frm = 1;
				
				UInt32 pkm = Entralink.forest.create_pkm(dex, mv, gnd, frm, anim);
				if (AddWithAreaSpillover(pkm) == false)
				{
					ranOutOfRoom = true;
					break; //Every area from here on is also full, no point continuing
				}
			}
			
			if (ranOutOfRoom)
				MessageBox.Show("Ran out of free slots in every area - not all species could be added.");
			
			Entralink.forest.Area = startArea; //Restore the area that was selected before Add All ran
			Entralink.dream_pkm = 0;
			this.Close();
		}
		
		//Tries to place pkm in the currently selected forest area; if that area is full,
		//moves on to the next area (and the one after that, etc.) until it finds room.
		//Returns false only once every remaining area has been tried and all are full.
		private bool AddWithAreaSpillover(UInt32 pkm)
		{
			int area = Entralink.forest.Area;
			while (area < 28)
			{
				Entralink.forest.Area = area;
				if (AddToCurrentArea(pkm))
					return true;
				area++;
			}
			return false;
		}
		
		//Places pkm in the first empty slot of the forest's currently selected area.
		//Returns false if that area has no empty slots.
		private bool AddToCurrentArea(UInt32 pkm)
		{
			int max = (Entralink.forest.Area > 0 && Entralink.forest.Area < 4) ? 10 : 20;
			int savedIndex = Entralink.forest.Indexpkm;
			
			for (int idx = 0; idx < max; idx++)
			{
				Entralink.forest.Indexpkm = idx;
				if (Entralink.forest.is_pkm_empty())
				{
					Entralink.forest.edit_pkm(pkm);
					Entralink.forest.Indexpkm = savedIndex;
					return true;
				}
			}
			
			Entralink.forest.Indexpkm = savedIndex;
			return false;
		}
		void SpeciesboxSelectedIndexChanged(object sender, EventArgs e)
		{
			//atkA.Checked = true;
			update_atk();
			update_gnd();
			
			bool exclusive = false;
			if(world < 8)
			{
				int i=0;
				if (MainForm.save.B2W2 == true)
				{
					for(i=0;i<world_BW1_exclusives[world].Length;i++)
					{
						if(world_BW1_exclusives[world][i] == world_species[world][speciesbox.SelectedIndex])
						{
							exclusive = true;
						}
					}
					if (exclusive == true)
					{
						exclusive_label.Text = "BW Only";
						ok_but.Enabled = false;
					}
					                               
				}else
				{
					for(i=0;i<world_BW2_exclusives[world].Length;i++)
					{
						if(world_BW2_exclusives[world][i] == world_species[world][speciesbox.SelectedIndex])
						{
							exclusive = true;
						}
					}
					if (exclusive == true)
					{
						exclusive_label.Text = "B2W2 Only";
						ok_but.Enabled = false;
					}
				}
				
			}else if (world == 8)
			{
				if (MainForm.save.B2W2 == true)
				{
					if (PGL_exclusives[speciesbox.SelectedIndex] == 0)
					{
						exclusive_label.Text = "BW Only";
						ok_but.Enabled = false;
						exclusive = true;
					}
				}
				else
				{
					if (PGL_exclusives[speciesbox.SelectedIndex] == 1)
					{
						exclusive_label.Text = "B2W2 Only";
						ok_but.Enabled = false;
						exclusive = true;
					}
				}
				
				pgl_region_box.SelectedIndex = speciesbox.SelectedIndex;				
			}
			
			if (exclusive == false)
			{
				exclusive_label.Text = "";
				ok_but.Enabled = true;
			}
			
		}

		
		int[][] world_species = new int[][]
		{
			new int[]{019, 029, 032, 043, 069, 077, 083, 084, 102, 108, 114, 115, 161, 174, 179, 187, 191, 234, 261, 270, 276, 283, 399, 403, 535, 546, 548, 588, 616, 431, 545, 054, 058, 123, 128, 183, 185, 203, 241, 263, 309, 351, 417, 427, 037, 060, 177, 239, 300},
			new int[]{12, 16, 21, 41, 142, 163, 165, 187, 193, 198, 207, 225, 276, 278, 333, 397, 519, 561, 580, 587, 227, 357, 425, 441},
			new int[]{79, 86, 90, 98, 116, 118, 119, 120, 129, 138, 140, 170, 194, 211, 222, 223, 226, 320, 339, 366, 369, 370, 418, 456, 550, 550, 594, 618, 564, 72, 318, 341, 345, 347, 349, 422, 422, 131, 147},
			new int[]{92, 96, 122, 167, 200, 202, 228, 238, 303, 307, 325, 353, 355, 358, 434, 436, 605, 624, 596, 52, 209, 235, 313, 314, 479, 63, 280, 302, 442, 578, 622},
			new int[]{56, 66, 81, 109, 111, 218, 231, 246, 324, 328, 331, 412, 449, 451, 631, 632, 556, 558, 240, 216, 296, 322, 327, 359, 374, 453, 236, 371, 553, 447},
			new int[]{27, 74, 95, 100, 104, 173, 213, 293, 299, 304, 337, 338, 343, 363, 408, 459, 529, 621, 50, 206, 525, 583, 600, 215, 361, 410, 220, 443, 610},
			new int[]{46, 204, 265, 273, 287, 290, 311, 312, 316, 352, 401, 420, 455, 531, 538, 539, 559, 48, 88, 415, 15, 23, 175, 190, 285, 533, 315, 335, 336, 113, 127, 133, 143, 214},
			new int[]{061, 133, 235, 412}, //Pokemon Cafe forest
			new int[]{134, 135, 136, 196, 197, 470, 471, 1, 4, 7, 453, 387, 390, 393, 493, 252, 255, 258, 468, 473, 137, 384, 354, 453, 334, 242, 448, 575, 25, 189, 511, 513, 515, 387, 390, 393, 575, 212, 445, 149, 248, 149, 376, 376}
		};
		
		int[][][] world_attacks = new int[][][]
		{
			new int[][]{ new int[]{98, 382, 231}, new int[]{10, 389, 162}, new int[]{64, 68, 162}, new int[]{230, 298, 202}, new int[]{22, 235, 402}, new int[]{33, 37, 257}, new int[]{210, 355, 348}, new int[]{45, 175, 355}, new int[]{140, 235, 202}, new int[]{122, 214, 431}, new int[]{79, 73, 402}, new int[]{252, 68, 409}, new int[]{10, 203, 343}, new int[]{47, 313, 270}, new int[]{84, 115, 351}, new int[]{235, 270, 331}, new int[]{72, 230, 414}, new int[]{33, 50, 285}, new int[]{336, 305, 399}, new int[]{71, 73, 352}, new int[]{64, 119, 366}, new int[]{145, 56, 202}, new int[]{33, 401, 290}, new int[]{268, 393, 400}, new int[]{496, 414, 352}, new int[]{73, 227, 388}, new int[]{79, 204, 230}, new int[]{203, 224, 450}, new int[]{51, 226, 227}, new int[]{252, 372, 290}, new int[]{342, 390, 276}, new int[]{346, 227, 362}, new int[]{44, 34, 203}, new int[]{98, 226, 366}, new int[]{99, 231, 431}, new int[]{111, 453, 8}, new int[]{175, 205, 272}, new int[]{93, 243, 285}, new int[]{111, 174, 231}, new int[]{33, 271, 387}, new int[]{86, 423, 324}, new int[]{52, 466, 352}, new int[]{98, 343, 351}, new int[]{193, 252, 409}, new int[]{46, 257, 399}, new int[]{95, 54, 214}, new int[]{101, 297, 202}, new int[]{84, 238, 393}, new int[]{193, 321, 445} },
			new int[][]{ new int[]{93, 355, 314}, new int[]{16, 211, 290}, new int[]{64, 185, 211}, new int[]{48, 95, 162}, new int[]{44, 372, 446}, new int[]{193, 101, 278}, new int[]{4, 450, 9}, new int[]{235, 227, 340}, new int[]{98, 364, 202}, new int[]{64, 109, 355}, new int[]{28, 364, 366}, new int[]{217, 420, 264}, new int[]{64, 203, 413}, new int[]{55, 239, 351}, new int[]{64, 297, 355}, new int[]{17, 297, 366}, new int[]{16, 95, 234}, new int[]{95, 500, 257}, new int[]{432, 362, 382}, new int[]{98, 403, 204}, new int[]{64, 65, 355}, new int[]{16, 73, 318}, new int[]{107, 95, 285}, new int[]{119, 417, 272} },
			new int[][]{ new int[]{281, 335, 362}, new int[]{29, 333, 214}, new int[]{110, 112, 196}, new int[]{11, 133, 290}, new int[]{145, 190, 362}, new int[]{64, 60, 352}, new int[]{352, 214, 203}, new int[]{55, 278, 196}, new int[]{150, 175, 340}, new int[]{44, 330, 196}, new int[]{71, 175, 446}, new int[]{86, 133, 351}, new int[]{55, 34, 401}, new int[]{40, 453, 290}, new int[]{145, 109, 446}, new int[]{199, 350, 362}, new int[]{48, 243, 314}, new int[]{55, 214, 340}, new int[]{189, 214, 209}, new int[]{250, 445, 392}, new int[]{55, 214, 414}, new int[]{204, 300, 196}, new int[]{346, 163, 352}, new int[]{213, 186, 352}, new int[]{29, 97, 428}, new int[]{29, 97, 428}, new int[]{392, 243, 220}, new int[]{189, 174, 281}, new int[]{205, 175, 334}, new int[]{48, 367, 202}, new int[]{44, 37, 399}, new int[]{106, 232, 283}, new int[]{51, 243, 202}, new int[]{10, 446, 440}, new int[]{150, 445, 243}, new int[]{189, 281, 290}, new int[]{189, 281, 290}, new int[]{109, 32, 196}, new int[]{86, 352, 225} },
			new int[][]{ new int[]{95, 50, 482}, new int[]{95, 427, 409}, new int[]{112, 298, 285}, new int[]{40, 527, 450}, new int[]{149, 194, 517}, new int[]{243, 204, 227}, new int[]{336, 364, 399}, new int[]{186, 445, 285}, new int[]{313, 424, 8}, new int[]{96, 409, 203}, new int[]{149, 285, 278}, new int[]{101, 194, 220}, new int[]{50, 220, 271}, new int[]{35, 95, 304}, new int[]{103, 492, 389}, new int[]{95, 285, 356}, new int[]{377, 112, 417}, new int[]{210, 427, 389}, new int[]{486, 50, 228}, new int[]{10, 95, 290}, new int[]{204, 370, 38}, new int[]{166, 445, 214}, new int[]{148, 271, 366}, new int[]{204, 313, 366}, new int[]{86, 351, 324}, new int[]{100, 285, 356}, new int[]{93, 194, 270}, new int[]{193, 389, 180}, new int[]{180, 220, 196}, new int[]{105, 286, 271}, new int[]{205, 7, 9} },
			new int[][]{ new int[]{67, 179, 9}, new int[]{67, 418, 270}, new int[]{319, 278, 356}, new int[]{123, 399, 482}, new int[]{30, 68, 38}, new int[]{52, 517, 257}, new int[]{175, 484, 402}, new int[]{44, 399, 446}, new int[]{52, 90, 446}, new int[]{44, 324, 202}, new int[]{71, 298, 9}, new int[]{182, 450, 173}, new int[]{44, 254, 276}, new int[]{44, 97, 401}, new int[]{510, 257, 202}, new int[]{210, 203, 422}, new int[]{42, 73, 191}, new int[]{157, 68, 400}, new int[]{52, 9, 257}, new int[]{313, 242, 264}, new int[]{292, 270, 8}, new int[]{52, 34, 257}, new int[]{383, 252, 276}, new int[]{364, 224, 276}, new int[]{36, 428, 442}, new int[]{40, 409, 441}, new int[]{252, 364, 183}, new int[]{44, 349, 200}, new int[]{242, 68, 212}, new int[]{203, 418, 264} },
			new int[][]{ new int[]{28, 68, 162}, new int[]{111, 446, 431}, new int[]{20, 446, 431}, new int[]{268, 324, 363}, new int[]{125, 195, 67}, new int[]{227, 312, 214}, new int[]{227, 270, 504}, new int[]{253, 283, 428}, new int[]{33, 446, 246}, new int[]{106, 283, 457}, new int[]{93, 414, 236}, new int[]{93, 428, 234}, new int[]{229, 356, 428}, new int[]{181, 90, 401}, new int[]{29, 442, 7}, new int[]{75, 419, 202}, new int[]{229, 319, 431}, new int[]{44, 424, 389}, new int[]{28, 251, 446}, new int[]{111, 277, 446}, new int[]{479, 174, 484}, new int[]{429, 420, 286}, new int[]{451, 356, 393}, new int[]{269, 8, 67}, new int[]{181, 311, 352}, new int[]{182, 68, 90}, new int[]{316, 246, 333}, new int[]{82, 200, 203}, new int[]{82, 68, 400} },
			new int[][]{ new int[]{78, 440, 235}, new int[]{120, 390, 356}, new int[]{40, 450, 173}, new int[]{74, 331, 492}, new int[]{281, 400, 389}, new int[]{141, 203, 400}, new int[]{86, 435, 324}, new int[]{86, 435, 324}, new int[]{139, 151, 202}, new int[]{185, 285, 513}, new int[]{522, 283, 253}, new int[]{73, 505, 331}, new int[]{44, 476, 380}, new int[]{270, 227, 281}, new int[]{20, 8, 276}, new int[]{249, 9, 530}, new int[]{67, 252, 409}, new int[]{50, 226, 285}, new int[]{139, 114, 425}, new int[]{16, 366, 314}, new int[]{31, 314, 210}, new int[]{40, 251, 399}, new int[]{118, 381, 253}, new int[]{10, 252, 7}, new int[]{78, 331, 264}, new int[]{67, 183, 409}, new int[]{74, 79, 129}, new int[]{98, 458, 67}, new int[]{44, 34, 401}, new int[]{45, 68, 270}, new int[]{11, 370, 382}, new int[]{28, 204, 129}, new int[]{133, 7, 278}, new int[]{30, 175, 264} },			
			new int[][]{ new int[]{240, 114, 352}, new int[]{ 270, 204, 129}, new int[]{ 166, 445, 214}, new int[]{ 182, 450, 173} } //Pokemon Cafe forest
		};
		
		int[] PGL_attacks = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 217, 0, 0, 0, 538, 398, 206, 0, 418, 243, 29, 206, 437, 257, 56, 254, 252, 297, 286, 211, 0, 9, 69, 245, 38};
		
		/* Method deprecated, it seems there's no gender restriction outside pokemon being male/female only or genderless
		int[][] world_gender = new int[][]
		{
			 // 0: only male, 1: only female, 2: genderless, 3: male/female
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{0, 0},
			new int[]{3, 3, 3, 3} //Pokemon Cafe forest
		};
		*/
		int[][] world_BW1_exclusives = new int[][]
		{
			new int[]{029, 032, 174, 187, 270, 276, 283, 309, 351, 417},//Pleasant Forest
			new int[]{012, 163, 278, 333, 425, 441},//Windswept Sky
			new int[]{079, 098, 119, 120, 222, 422, 422},
			new int[]{202, 238, 303, 307, 436, 052, 479, 280, 302, 442},
			new int[]{056, 111, 231, 451, 216, 296, 327, 374, 447},
			new int[]{173, 213, 299, 363, 408, 206, 410},
			new int[]{048, 88, 415, 15, 335, 336},
			new int[]{0} //Pokemon Cafe forest
		};
		
		int[][] world_BW2_exclusives = new int[][]
		{
			new int[]{535, 546, 548, 588, 616, 545},//Pleasant Forest
			new int[]{519, 561, 580, 587},//Windswept Sky
			new int[]{550, 550, 594, 618, 564},
			new int[]{605, 624, 596, 578},
			new int[]{631, 632, 556, 558, 553},
			new int[]{529, 621, 525, 583, 600, 610},
			new int[]{531, 538, 539, 559, 533},
			new int[]{0} //Pokemon Cafe forest
		};
		
		int[] PGL_exclusives = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2};
		
		/*
		 * Per-species Dream World idle animation, sourced from PDW animation research data.
		 * Shape mirrors world_species / world_attacks: [world][species index][gender]
		 * where gender is 0 = male, 1 = female, 2 = genderless.
		 * Values are animation *indices* (0-7), matching Entralink's animbox1 ordering:
		 *   0 = LOOK_AROUND
		 *   1 = WALK_AROUND
		 *   2 = WALK_LOOK_AROUND
		 *   3 = WALK_VERTICALLY
		 *   4 = WALK_HORIZONTALLY
		 *   5 = WALK_LOOK_HORIZONTALLY
		 *   6 = SPIN_RIGHT
		 *   7 = SPIN_LEFT
		 * The raw value stored in the save is index * 2 (see anim_raw below).
		 * -1 means that gender does not occur for this species in this area.
		 */
		int[][][] world_anims = new int[][][]
		{
			//Pleasant Forest
			new int[][]{
				new int[]{  4,  5, -1}, // 0 Rattata
				new int[]{ -1,  7, -1}, // 1 Nidoran
				new int[]{  6, -1, -1}, // 2 Nidoran
				new int[]{  0,  0, -1}, // 3 Oddish
				new int[]{  0,  0, -1}, // 4 Bellsprout
				new int[]{  6,  7, -1}, // 5 Ponyta
				new int[]{  2,  3, -1}, // 6 Farfetch'd
				new int[]{  5,  1, -1}, // 7 Doduo
				new int[]{  4,  5, -1}, // 8 Exeggcute
				new int[]{  6,  7, -1}, // 9 Lickitung
				new int[]{  2,  3, -1}, //10 Tangela
				new int[]{ -1,  0, -1}, //11 Kangaskhan
				new int[]{  0,  1, -1}, //12 Sentret
				new int[]{  6,  7, -1}, //13 Igglybuff
				new int[]{  1,  2, -1}, //14 Mareep
				new int[]{  0,  1, -1}, //15 Hoppip
				new int[]{  2,  3, -1}, //16 Sunkern
				new int[]{  4,  5, -1}, //17 Stantler
				new int[]{  3,  4, -1}, //18 Poochyena
				new int[]{  3,  4, -1}, //19 Lotad
				new int[]{  5,  6, -1}, //20 Taillow
				new int[]{  5,  6, -1}, //21 Surskit
				new int[]{  6,  7, -1}, //22 Bidoof
				new int[]{  7,  0, -1}, //23 Shinx
				new int[]{  7,  7, -1}, //24 Tympole
				new int[]{  6,  6, -1}, //25 Cottonee
				new int[]{ -1,  6, -1}, //26 Petilil
				new int[]{  5,  5, -1}, //27 Karrablast
				new int[]{  0,  0, -1}, //28 Shelmet
				new int[]{  5,  6, -1}, //29 Glameow
				new int[]{  3,  3, -1}, //30 Scolipede
				new int[]{  1,  2, -1}, //31 Psyduck
				new int[]{  7,  0, -1}, //32 Growlithe
				new int[]{  1,  2, -1}, //33 Scyther
				new int[]{  3, -1, -1}, //34 Tauros
				new int[]{  7,  0, -1}, //35 Marill
				new int[]{  6,  7, -1}, //36 Sudowoodo
				new int[]{  0,  1, -1}, //37 Girafarig
				new int[]{ -1,  2, -1}, //38 Miltank
				new int[]{  3,  4, -1}, //39 Zigzagoon
				new int[]{  5,  6, -1}, //40 Electrike
				new int[]{  7,  0, -1}, //41 Castform
				new int[]{  1,  2, -1}, //42 Pachirisu
				new int[]{  3,  4, -1}, //43 Buneary
				new int[]{  3,  4, -1}, //44 Vulpix
				new int[]{  5,  6, -1}, //45 Poliwag
				new int[]{  7,  0, -1}, //46 Natu
				new int[]{  1,  2, -1}, //47 Elekid
				new int[]{  3,  4, -1}  //48 Skitty
			},
			//Windswept Sky
			new int[][]{
				new int[]{  4,  5, -1}, // 0 Butterfree
				new int[]{  4,  5, -1}, // 1 Pidgey
				new int[]{  0,  1, -1}, // 2 Spearow
				new int[]{  2,  3, -1}, // 3 Zubat
				new int[]{  6,  7, -1}, // 4 Aerodactyl
				new int[]{  2,  3, -1}, // 5 Hoothoot
				new int[]{  0,  1, -1}, // 6 Ledyba
				new int[]{  2,  3, -1}, // 7 Hoppip
				new int[]{  6,  7, -1}, // 8 Yanma
				new int[]{  1,  1, -1}, // 9 Murkrow
				new int[]{  0,  1, -1}, //10 Gligar
				new int[]{  2,  3, -1}, //11 Delibird
				new int[]{  4,  5, -1}, //12 Taillow
				new int[]{  6,  7, -1}, //13 Wingull
				new int[]{  3,  2, -1}, //14 Swablu  // ! !!
				new int[]{  4,  5, -1}, //15 Staravia
				new int[]{  2,  2, -1}, //16 Pidove
				new int[]{  1,  1, -1}, //17 Sigilyph
				new int[]{  5,  5, -1}, //18 Ducklett
				new int[]{  5,  5, -1}, //19 Emolga
				new int[]{  3,  4, -1}, //20 Skarmory
				new int[]{  5,  6, -1}, //21 Tropius
				new int[]{  7,  3, -1}, //22 Drifloon  // ! !!
				new int[]{  1,  2, -1}  //23 Chatot
			},
			//Sparkling Sea
			new int[][]{
				new int[]{  1,  2, -1}, // 0 Slowpoke
				new int[]{  4,  4, -1}, // 1 Seel
				new int[]{  0,  0, -1}, // 2 Shellder
				new int[]{  4,  4, -1}, // 3 Krabby
				new int[]{  0,  1, -1}, // 4 Horsea
				new int[]{  6,  7, -1}, // 5 Goldeen
				new int[]{  0,  1, -1}, // 6 Seaking
				new int[]{ -1, -1,  0}, // 7 Staryu
				new int[]{  2,  3, -1}, // 8 Magikarp
				new int[]{  0,  1, -1}, // 9 Omanyte
				new int[]{  2,  3, -1}, //10 Kabuto
				new int[]{  6,  6, -1}, //11 Chinchou
				new int[]{  6,  7, -1}, //12 Wooper
				new int[]{  6,  7, -1}, //13 Qwilfish
				new int[]{  4,  5, -1}, //14 Corsola
				new int[]{  6,  7, -1}, //15 Remoraid
				new int[]{  2,  3, -1}, //16 Mantine
				new int[]{  4,  5, -1}, //17 Wailmer
				new int[]{  2,  3, -1}, //18 Barboach
				new int[]{  0,  0, -1}, //19 Clamperl
				new int[]{  4,  5, -1}, //20 Relicanth
				new int[]{  4,  5, -1}, //21 Luvdisc
				new int[]{  2,  3, -1}, //22 Buizel
				new int[]{  4,  5, -1}, //23 Finneon
				new int[]{  0,  0, -1}, //24 Basculin
				new int[]{  0,  0, -1}, //25 Basculin
				new int[]{  7,  7, -1}, //26 Alomomola
				new int[]{  1,  1, -1}, //27 Stunfisk
				new int[]{  6,  6, -1}, //28 Tirtouga
				new int[]{  7,  0, -1}, //29 Tentacool
				new int[]{  5,  6, -1}, //30 Carvanha
				new int[]{  6,  1, -1}, //31 Corphish  // ! !!
				new int[]{  0,  0, -1}, //32 Lileep
				new int[]{  3,  4, -1}, //33 Anorith
				new int[]{  2,  3, -1}, //34 Feebas
				new int[]{  4,  6, -1}, //35 Shellos  // ! !!
				new int[]{  5,  7, -1}, //36 Shellos  // ! !!
				new int[]{  1,  2, -1}, //37 Lapras
				new int[]{  0,  1, -1}  //38 Dratini
			},
			//Spooky Manor
			new int[][]{
				new int[]{  2,  2, -1}, // 0 Gastly
				new int[]{  4,  4, -1}, // 1 Drowzee
				new int[]{  1,  1, -1}, // 2 Mr. Mime
				new int[]{  5,  5, -1}, // 3 Spinarak
				new int[]{  3,  3, -1}, // 4 Misdreavus
				new int[]{  0,  0, -1}, // 5 Wobbuffet
				new int[]{  2,  1, -1}, // 6 Houndour  // ! !!
				new int[]{ -1,  5, -1}, // 7 Smoochum
				new int[]{  2,  2, -1}, // 8 Mawile
				new int[]{  5,  5, -1}, // 9 Meditite
				new int[]{  7,  7, -1}, //10 Spoink
				new int[]{  3,  3, -1}, //11 Shuppet
				new int[]{  6,  7, -1}, //12 Duskull
				new int[]{  4,  3, -1}, //13 Chimecho  // ! !!
				new int[]{  1,  1, -1}, //14 Stunky
				new int[]{ -1, -1,  0}, //15 Bronzor
				new int[]{  3,  3, -1}, //16 Elgyem
				new int[]{  4,  4, -1}, //17 Pawniard
				new int[]{  1,  1, -1}, //18 Galvantula
				new int[]{  5,  5, -1}, //19 Meowth
				new int[]{  1,  1, -1}, //20 Snubbull
				new int[]{  4,  4, -1}, //21 Smeargle
				new int[]{  2, -1, -1}, //22 Volbeat
				new int[]{ -1,  2, -1}, //23 Illumise
				new int[]{ -1, -1,  0}, //24 Rotom
				new int[]{  0,  0, -1}, //25 Abra
				new int[]{  5,  5, -1}, //26 Ralts
				new int[]{  1,  2, -1}, //27 Sableye
				new int[]{  0,  0, -1}, //28 Spiritomb
				new int[]{  4,  4, -1}, //29 Duosion
				new int[]{ -1, -1,  7}  //30 Golett
			},
			//Rugged Mountain
			new int[][]{
				new int[]{  5,  5, -1}, // 0 Mankey
				new int[]{  4,  4, -1}, // 1 Machop
				new int[]{ -1, -1,  1}, // 2 Magnemite
				new int[]{  0,  0, -1}, // 3 Koffing
				new int[]{  3,  3, -1}, // 4 Rhyhorn
				new int[]{  7,  7, -1}, // 5 Slugma
				new int[]{  1,  1, -1}, // 6 Phanpy
				new int[]{  4,  4, -1}, // 7 Larvitar
				new int[]{  3,  3, -1}, // 8 Torkoal
				new int[]{  0,  0, -1}, // 9 Trapinch
				new int[]{  1,  1, -1}, //10 Cacnea
				new int[]{  0,  0, -1}, //11 Burmy
				new int[]{  4,  4, -1}, //12 Hippopotas
				new int[]{  2,  2, -1}, //13 Skorupi
				new int[]{  4,  4, -1}, //14 Heatmor
				new int[]{  3,  3, -1}, //15 Durant
				new int[]{  0,  0, -1}, //16 Maractus
				new int[]{  6,  6, -1}, //17 Crustle
				new int[]{  5,  5, -1}, //18 Magby
				new int[]{  2,  2, -1}, //19 Teddiursa
				new int[]{  6,  6, -1}, //20 Makuhita
				new int[]{  7,  7, -1}, //21 Numel
				new int[]{  5,  5, -1}, //22 Spinda
				new int[]{  5,  5, -1}, //23 Absol
				new int[]{ -1, -1,  3}, //24 Beldum
				new int[]{  1,  1, -1}, //25 Croagunk
				new int[]{  2, -1, -1}, //26 Tyrogue
				new int[]{  1,  1, -1}, //27 Bagon
				new int[]{  5,  5, -1}, //28 Krookodile
				new int[]{  4,  4, -1}  //29 Riolu
			},
			//Icy Cave
			new int[][]{
				new int[]{  5,  5, -1}, // 0 Sandshrew
				new int[]{  0,  0, -1}, // 1 Geodude
				new int[]{  1,  1, -1}, // 2 Onix
				new int[]{ -1, -1,  2}, // 3 Voltorb
				new int[]{  7,  7, -1}, // 4 Cubone
				new int[]{  5,  5, -1}, // 5 Cleffa
				new int[]{  0,  0, -1}, // 6 Shuckle
				new int[]{  3,  3, -1}, // 7 Whismur
				new int[]{  0,  0, -1}, // 8 Nosepass
				new int[]{  7,  7, -1}, // 9 Aron
				new int[]{ -1, -1,  1}, //10 Lunatone
				new int[]{ -1, -1,  1}, //11 Solrock
				new int[]{ -1, -1,  6}, //12 Baltoy
				new int[]{  4,  4, -1}, //13 Spheal
				new int[]{  1,  1, -1}, //14 Cranidos
				new int[]{  7,  7, -1}, //15 Snover
				new int[]{  1,  1, -1}, //16 Drilbur
				new int[]{  4,  4, -1}, //17 Druddigon
				new int[]{  2,  2, -1}, //18 Diglett
				new int[]{  6,  6, -1}, //19 Dunsparce
				new int[]{  6,  7, -1}, //20 Boldore
				new int[]{  0,  0, -1}, //21 Vanillish
				new int[]{ -1, -1,  6}, //22 Klang
				new int[]{  4,  4, -1}, //23 Sneasel
				new int[]{  5,  5, -1}, //24 Snorunt
				new int[]{  0,  0, -1}, //25 Shieldon
				new int[]{  7,  7, -1}, //26 Swinub
				new int[]{  2,  2, -1}, //27 Gible
				new int[]{  5,  5, -1}  //28 Axew
			},
			//Dream Park
			new int[][]{
				new int[]{  6,  6, -1}, // 0 Paras
				new int[]{  7,  7, -1}, // 1 Pineco
				new int[]{  0,  0, -1}, // 2 Wurmple
				new int[]{  4,  4, -1}, // 3 Seedot
				new int[]{  0,  0, -1}, // 4 Slakoth
				new int[]{  6,  6, -1}, // 5 Nincada
				new int[]{  2,  2, -1}, // 6 Plusle
				new int[]{  2,  2, -1}, // 7 Minun
				new int[]{  6,  6, -1}, // 8 Gulpin
				new int[]{  5,  5, -1}, // 9 Kecleon
				new int[]{  5,  5, -1}, //10 Kricketot
				new int[]{  7,  7, -1}, //11 Cherubi
				new int[]{  0,  0, -1}, //12 Carnivine
				new int[]{  4,  4, -1}, //13 Audino
				new int[]{  0, -1, -1}, //14 Throh
				new int[]{  1, -1, -1}, //15 Sawk
				new int[]{  5,  5, -1}, //16 Scraggy
				new int[]{  6,  6, -1}, //17 Venonat
				new int[]{  7,  7, -1}, //18 Grimer
				new int[]{  2,  2, -1}, //19 Combee
				new int[]{  2,  2, -1}, //20 Beedrill
				new int[]{  3,  3, -1}, //21 Ekans
				new int[]{  3,  3, -1}, //22 Togepi
				new int[]{  2,  2, -1}, //23 Aipom
				new int[]{  6,  6, -1}, //24 Shroomish
				new int[]{  3,  3, -1}, //25 Gurdurr
				new int[]{  4,  4, -1}, //26 Roselia
				new int[]{  1,  1, -1}, //27 Zangoose
				new int[]{  5,  5, -1}, //28 Seviper
				new int[]{ -1,  4, -1}, //29 Chansey
				new int[]{  4,  4, -1}, //30 Pinsir
				new int[]{  1,  1, -1}, //31 Eevee
				new int[]{  0,  0, -1}, //32 Snorlax
				new int[]{  3,  3, -1}  //33 Heracross
			},
			//Pokemon Cafe forest (area 50)
			new int[][]{
				new int[]{  5,  5, -1}, // 0 Poliwhirl
				new int[]{  1,  1, -1}, // 1 Eevee
				new int[]{  4,  4, -1}, // 2 Smeargle
				new int[]{  0,  0, -1}  // 3 Burmy
			},
			//PGL promotions
			new int[][]{
				new int[]{  0, -1, -1}, // 0 Vaporeon
				new int[]{  0, -1, -1}, // 1 Jolteon
				new int[]{  0, -1, -1}, // 2 Flareon
				new int[]{  0, -1, -1}, // 3 Espeon
				new int[]{  0, -1, -1}, // 4 Umbreon
				new int[]{  0, -1, -1}, // 5 Leafeon
				new int[]{  0, -1, -1}, // 6 Glaceon
				new int[]{  0, -1, -1}, // 7 Bulbasaur
				new int[]{  0, -1, -1}, // 8 Charmander
				new int[]{  0, -1, -1}, // 9 Squirtle
				new int[]{  0, -1, -1}, //10 Croagunk
				new int[]{  0, -1, -1}, //11 Turtwig
				new int[]{  0, -1, -1}, //12 Chimchar
				new int[]{  0, -1, -1}, //13 Piplup
				new int[]{ -1, -1,  0}, //14 Arceus
				new int[]{  0, -1, -1}, //15 Treecko
				new int[]{  0, -1, -1}, //16 Torchic
				new int[]{  0, -1, -1}, //17 Mudkip
				new int[]{  0, -1, -1}, //18 Togekiss
				new int[]{  2, -1, -1}, //19 Mamoswine
				new int[]{ -1, -1,  0}, //20 Porygon
				new int[]{ -1, -1,  0}, //21 Rayquaza
				new int[]{ -1,  0, -1}, //22 Banette
				new int[]{  0, -1, -1}, //23 Croagunk
				new int[]{  0, -1, -1}, //24 Altaria
				new int[]{ -1,  0, -1}, //25 Blissey
				new int[]{  0, -1, -1}, //26 Lucario
				new int[]{  0, -1, -1}, //27 Gothorita
				new int[]{  0, -1, -1}, //28 Pikachu
				new int[]{  0, -1, -1}, //29 Jumpluff
				new int[]{  0, -1, -1}, //30 Pansage
				new int[]{  0, -1, -1}, //31 Pansear
				new int[]{  0, -1, -1}, //32 Panpour
				new int[]{  0, -1, -1}, //33 Turtwig
				new int[]{  0, -1, -1}, //34 Chimchar
				new int[]{  0, -1, -1}, //35 Piplup
				new int[]{  0, -1, -1}, //36 Gothorita
				new int[]{  0, -1, -1}, //37 Scizor
				new int[]{  0, -1, -1}, //38 Garchomp
				new int[]{  0, -1, -1}, //39 Dragonite
				new int[]{  0, -1, -1}, //40 Tyranitar
				new int[]{  0, -1, -1}, //41 Dragonite
				new int[]{ -1, -1,  0}, //42 Metagross
				new int[]{ -1, -1,  0}  //43 (unreachable - extra world_species entry)
			}
		};

		/// <summary>
		/// Returns the raw animation value to store for the currently selected
		/// species and gender, taken from world_anims. Falls back to the other
		/// gender's documented animation, and finally to a random one, when the
		/// combination has no research data. All nine worlds are now covered,
		/// so the random fallback should not normally be reached.
		/// </summary>
		private int form_anim(int gnd)
		{
			return form_anim(speciesbox.SelectedIndex, gnd);
		}
		
		private int form_anim(int sel, int gnd)
		{
			if (world < 0 || world >= world_anims.Length)
				return random_form_anim();
			if (sel < 0 || sel >= world_anims[world].Length)
				return random_form_anim();
			
			int[] entry = world_anims[world][sel];
			int index = -1;
			
			if (gnd >= 0 && gnd < entry.Length)
				index = entry[gnd];
			
			//Gender not documented for this species/area - use whatever it does have
			if (index < 0)
			{
				for (int i = 0; i < entry.Length; i++)
				{
					if (entry[i] >= 0)
					{
						index = entry[i];
						break;
					}
				}
			}
			
			if (index < 0)
				return random_form_anim(); //no data at all for this area
			
			return index * 2; //save stores the animation index doubled
		}

		public static int random_form_anim()
		{
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			int anim = rnd.Next(15);
			if (IsOdd(anim) == true)
				anim = anim-1;
			return anim;
		}
	    public static bool IsOdd(int value)
	    {
			return value % 2 != 0;
	    }
	    
	    private int atk = 0;
	    private void update_atk()
	    {
	    	
	    	if (world < 8)
	    	{
		    	bool isMagikarp = (world_species[world][speciesbox.SelectedIndex] == 129);
		    	
		    	//Magikarp has no usable C move - lock it out entirely
		    	atkC.Enabled = !isMagikarp;
		    	moveboxC.Enabled = !isMagikarp;
		    	
		    	if (isMagikarp && atkC.Checked == true)
		    	{
		    		atkB.Checked = true; //Triggers update_atk() again with C unchecked
		    		return;
		    	}
		    	
	    		if (atkA.Checked == true)
	    			atk = 0;
	    		else if (atkB.Checked == true)
	    			atk = 1;
	    		else if (atkC.Checked == true)
	    			atk = 2;
	    		
	    		moveboxA.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][0];
	    		movebox.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][1];
	    		
	    		if (isMagikarp)
	    			moveboxC.SelectedIndex = -1; //No C move for Magikarp
	    		else
	    			moveboxC.SelectedIndex = world_attacks[world][speciesbox.SelectedIndex][2];
	    	}else if (world == 8)
	    	{
	    		movebox.SelectedIndex = PGL_attacks[speciesbox.SelectedIndex];
	    	}

	    }
		void AtkACheckedChanged(object sender, EventArgs e)
		{
			update_atk();
		}
		void AtkBCheckedChanged(object sender, EventArgs e)
		{
			update_atk();
		}
		void AtkCCheckedChanged(object sender, EventArgs e)
		{
			update_atk();
		}
		
		private int gender = 0;
	    private void update_gnd()
	    {
			//Handle genders		
			bool special_gender = false;
			int i=0;
			for(i=0;i<Entralink.BW_femaleonly.Length;i++)
			{
				if(world_species[world][speciesbox.SelectedIndex] == Entralink.BW_femaleonly[i])
				{
					//Only female
					special_gender = true;
					gnd_female.Checked = true;
					gnd_male.Enabled = false;
					gnd_female.Enabled = true;
					gnd_none.Enabled = false;
				}
			}
			
			for(i=0;i<Entralink.BW_maleonly.Length;i++)
			{
				if(world_species[world][speciesbox.SelectedIndex] == Entralink.BW_maleonly[i])
				{
					//Only male
					special_gender = true;
					gnd_male.Checked = true;
					gnd_male.Enabled = true;
					gnd_female.Enabled = false;
					gnd_none.Enabled = false;
				}
			}
			
			for(i=0;i<Entralink.BW_genderless.Length;i++)
			{
				if(world_species[world][speciesbox.SelectedIndex] == Entralink.BW_genderless[i])
				{
					//Only genderless
					special_gender = true;
					gnd_none.Checked = true;
					gnd_male.Enabled = false;
					gnd_female.Enabled = false;
					gnd_none.Enabled = true;
				}
			}
			
			if (special_gender == false)
			{
					//Male/female
					if (gender == 2 || (world == 8) )
				    {
						if (world == 8 && speciesbox.SelectedIndex == 22) //Banette is the only female pokemon distributed via PGL
						{
							gnd_female.Checked = true;
							gnd_male.Enabled = false;
							gnd_female.Enabled = true;
						}else{
							if (world == 8)
								gnd_female.Enabled = false;
							gnd_male.Checked = true;
							gnd_male.Enabled = true;
						}
				    }
					if (gnd_male.Checked == false && gnd_female.Checked == false && gnd_none.Checked == false)
					{
						if (world == 8 && speciesbox.SelectedIndex == 22) //Banette is the only female pokemon distributed via PGL
						{
							gnd_female.Enabled = true;
							gnd_female.Checked = true;
							gnd_male.Enabled = false;
						}else{
							if (world == 8)
								gnd_female.Enabled = false;
							gnd_male.Checked = true;
							gnd_male.Enabled = true;
						}
					}
					if (world != 8)
						gnd_male.Enabled = true;
					if (world != 8)
						gnd_female.Enabled = true;
					gnd_none.Enabled = false;
			}
	    	
	    /*	
			switch(world_gender[world][speciesbox.SelectedIndex])
			{
				case 0://male only
					gnd_male.Checked = true;
					gnd_male.Enabled = true;
					gnd_female.Enabled = false;
					gnd_none.Enabled = false;
					break;
				case 1://female only
					gnd_female.Checked = true;
					gnd_male.Enabled = false;
					gnd_female.Enabled = true;
					gnd_none.Enabled = false;
					break;
				case 2://genderless
					gnd_none.Checked = true;
					gnd_male.Enabled = false;
					gnd_female.Enabled = false;
					gnd_none.Enabled = true;
					break;
				default://male/female
					if (gender == 2)
						gnd_male.Checked = true;
					if (gnd_male.Checked == false && gnd_female.Checked == false && gnd_none.Checked == false)
						gnd_male.Checked = true;
					gnd_male.Enabled = true;
					gnd_female.Enabled = true;
					gnd_none.Enabled = false;
					break;
			}
		 */
	    	
	    	if (gnd_male.Checked == true)
	    		gender = 0;
	    	else if (gnd_female.Checked == true)
	    		gender = 1;
	    	else if (gnd_none.Checked == true)
	    		gender = 2;
	   
	    }

		void Gnd_maleCheckedChanged(object sender, EventArgs e)
		{
			update_gnd();
		}
		void Gnd_femaleCheckedChanged(object sender, EventArgs e)
		{
			update_gnd();
		}
		void Gnd_noneCheckedChanged(object sender, EventArgs e)
		{
			update_gnd();
		}
		
	}
}
