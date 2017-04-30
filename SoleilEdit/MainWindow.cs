//SoleilEdit
//Soleil/Crusader of Centy/Ragnacenty save editor
//Shendo 2011 - 2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SoleilEdit
{
    public partial class MainWindow : Form
    {
        //Application related strings
        const string ApplicationName = "SoleilEdit";
        const string ApplicationVersion = "1.0";
        const string ApplicationAuthor = "Shendo";
        const string ApplicationDate = "2012-06-30";

        //File data
        string OpenedFileName = null;
        string OpenedFileTitle = null;

        struct SaveSlot
        {
            public bool Active;
            public string PlayerName;
            public int CurrentHealth;
            public int MaximumHealth;
            public int FirstAbilityFlags;
            public int SecondAbilityFlags;
            public int FirstAnimalFlags;
            public int SecondAnimalFlags;
            public int InventoryFlags;
            public int Coins;
        }

        //Container for save data
        byte[] SaveData = new byte[0x3200];

        //Game supports 4 save slots
        SaveSlot[] SaveSlots = new SaveSlot[4];

        //Currently selected slot
        int CurrentSlot = 0;

        //Internal order of ASCII characters
        char[] CharPattern = {' ','0','1','2','3','4','5','6','7','8','9',
                             'A','B','C','D','E','F','G','H','I','J','K',
                             'L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                             'a','b','c','d','e','f','g','h','i','j','k',
                             'l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                             ',','.','"','!','$',';','&','\'','(', ')'};

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Show application info
            UpdateApplicationTitle(null);

            //Load empty data
            CurrentSlot = 0;
            UpdateSlot(0, true);
        }

        //Update application title
        private void UpdateApplicationTitle(string FileName)
        {
            this.Text = ApplicationName + " " + ApplicationVersion;
            if (FileName != null) this.Text += " - [" + FileName + "]";
        }

        //Show open file dialog to select a file to open
        private void ShowOpenDialog()
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            byte[] TempByteArray = null;

            OpenDialog.Filter = "Save file (*.srm)|*.srm";
            OpenDialog.Title = "Open save file";
            OpenDialog.Multiselect = false;

            //Check if OK was pressed
            if (OpenDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            //Check the size of a file
            if ((new FileInfo(OpenDialog.FileName)).Length < 12300) return;

            OpenedFileName = OpenDialog.FileName;
            OpenedFileTitle = Path.GetFileName(OpenedFileName);

            UpdateApplicationTitle(OpenedFileTitle);

            //Read file to array
            TempByteArray = File.ReadAllBytes(OpenedFileName);
            Array.Copy(TempByteArray, SaveData, TempByteArray.Length);

            //Load data
            LoadDataToContainer();

            //Select 1st slot as active
            CurrentSlot = 0;

            //Load data
            UpdateSlot(0, true);

            //Enable "Save/Save as" options
            SaveMenuItem.Enabled = true;
            SaveAsManuItem.Enabled = true;
        }

        //Show save file dialog to select a file to save to
        private void ShowSaveDialog()
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();

            SaveDialog.Filter = "Save file (*.srm)|*.srm";
            SaveDialog.Title = "Save save file";

            //Check if OK was pressed
            if (SaveDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            SaveDataToFile(SaveDialog.FileName);
        }

        //Save data to a specified file
        private void SaveDataToFile(string FileName)
        {
            //Save currenly edited slot
            SaveDataFromEditor(CurrentSlot);

            //Save data to byte array
            SaveDataFromContainer();

            //Calculate checksum for all slots
            CalculateChecksums();

            try
            {
                //Write byte array to a file
                File.WriteAllBytes(FileName, SaveData);
            }
            catch (IOException e)
            {
                //Show error if there was any
                MessageBox.Show(this, e.Message, ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Set file info options
            OpenedFileName = FileName;
            OpenedFileTitle = Path.GetFileName(OpenedFileName);
            UpdateApplicationTitle(OpenedFileTitle);
        }

        //Update slot (save old data, load new data)
        private void UpdateSlot(int DeltaValue, bool FirstRun)
        {
            //Check if min, max values are reached
            if ((CurrentSlot + DeltaValue) < 0) return;
            if ((CurrentSlot + DeltaValue) > 3) return;

            //Save old data
            if (FirstRun == false) SaveDataFromEditor(CurrentSlot);

            //Update current slot
            CurrentSlot += DeltaValue;

            //Load new data
            LoadDataToEditor(CurrentSlot);

            //Update textbox
            SlotTextbox.Text = "Save slot " + (CurrentSlot + 1).ToString();

            //Fix "all letters selected" issue
            SlotTextbox.SelectionStart = SlotTextbox.Text.Length;
        }

        //Convert data from byte array to editor readable
        private void LoadDataToContainer()
        {
            //Cycle trough each slot
            for (int i = 0; i < 4; i++)
            {
                //Load the active attribute
                SaveSlots[i].Active = CheckSlotActive(i);

                //Load data only for active saves
                if (SaveSlots[i].Active == true)
                {
                    SaveSlots[i].CurrentHealth = Get16bitData(0xC5, i);
                    SaveSlots[i].MaximumHealth = Get16bitData(0xC1, i);
                    SaveSlots[i].Coins = Get16bitData(0xCD, i);
                    SaveSlots[i].FirstAbilityFlags = Get16bitData(0x19, i);
                    SaveSlots[i].SecondAbilityFlags = Get16bitData(0x1D, i);
                    SaveSlots[i].FirstAnimalFlags = Get16bitData(0xE1, i);
                    SaveSlots[i].SecondAnimalFlags = Get16bitData(0xDD, i);
                    SaveSlots[i].InventoryFlags = Get16bitData(0xFD, i);
                    SaveSlots[i].PlayerName = SoleilStringToString(0x95, i);
                }
            }
        }

        private void SaveDataFromContainer()
        {
            //Cycle through each slot
            for (int i = 0; i < 4; i++)
            {
                //Check the active attribute
                if (SaveSlots[i].Active == true)
                {
                    Set16bitData(0xC5, i, SaveSlots[i].CurrentHealth);
                    Set16bitData(0xC1, i, SaveSlots[i].MaximumHealth);
                    Set16bitData(0xCD, i, SaveSlots[i].Coins);
                    Set16bitData(0x19, i, SaveSlots[i].FirstAbilityFlags);
                    Set16bitData(0x1D, i, SaveSlots[i].SecondAbilityFlags);
                    Set16bitData(0xE1, i, SaveSlots[i].FirstAnimalFlags);
                    Set16bitData(0xDD, i, SaveSlots[i].SecondAnimalFlags);
                    Set16bitData(0xFD, i, SaveSlots[i].InventoryFlags);
                    StringToSoleilString(0x95, i, SaveSlots[i].PlayerName);
                }
            }
        }

        //Update data from contaier to editor
        private void LoadDataToEditor(int Slot)
        {
            //Load the value to numeric control
            HealthNumeric.Value = SaveSlots[Slot].CurrentHealth;
            MaxHealthNumeric.Value = SaveSlots[Slot].MaximumHealth;
            CoinsNumeric.Value = SaveSlots[Slot].Coins;

            //Abilities
            if ((SaveSlots[Slot].FirstAbilityFlags & 0x1) > 0) AnimalTalkCheck.Checked = true; else AnimalTalkCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAbilityFlags & 0x800) > 0) SwordThrowCheck.Checked = true; else SwordThrowCheck.Checked = false;
            if ((SaveSlots[Slot].SecondAbilityFlags & 0x800) > 0) JumpCheck.Checked = true; else JumpCheck.Checked = false;
            if ((SaveSlots[Slot].SecondAbilityFlags & 0x2) > 0) StrenghtCheck.Checked = true; else StrenghtCheck.Checked = false;

            //Inventory
            if ((SaveSlots[Slot].InventoryFlags & 0x100) > 0) BronzeCheck.Checked = true; else BronzeCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x200) > 0) SilverCheck.Checked = true; else SilverCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x400) > 0) GoldCheck.Checked = true; else GoldCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x800) > 0) HolyCheck.Checked = true; else HolyCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x1000) > 0) PlantCheck.Checked = true; else PlantCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x2000) > 0) ShoesCheck.Checked = true; else ShoesCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x4000) > 0) PowderCheck.Checked = true; else PowderCheck.Checked = false;
            if ((SaveSlots[Slot].InventoryFlags & 0x8000) > 0) HornCheck.Checked = true; else HornCheck.Checked = false;

            //Debug menu
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x8) > 0) AbilitiesCheck.Checked = true; else AbilitiesCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x10) > 0) ResetCheck.Checked = true; else ResetCheck.Checked = false;

            //Animals
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x20) > 0) KittyCheck.Checked = true; else KittyCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x40) > 0) JohnnyCheck.Checked = true; else JohnnyCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x80) > 0) MoaCheck.Checked = true; else MoaCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x100) > 0) LionCheck.Checked = true; else LionCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x200) > 0) PenguyCheck.Checked = true; else PenguyCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x400) > 0) CharlieCheck.Checked = true; else CharlieCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x800) > 0) DinosaurCheck.Checked = true; else DinosaurCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x1000) > 0) DodoCheck.Checked = true; else DodoCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x2000) > 0) LeviathanCheck.Checked = true; else LeviathanCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x4000) > 0) RaccoonCheck.Checked = true; else RaccoonCheck.Checked = false;
            if ((SaveSlots[Slot].FirstAnimalFlags & 0x8000) > 0) CielCheck.Checked = true; else CielCheck.Checked = false;
            if ((SaveSlots[Slot].SecondAnimalFlags & 0x1) > 0) CaterpillarCheck.Checked = true; else CaterpillarCheck.Checked = false;
            if ((SaveSlots[Slot].SecondAnimalFlags & 0x2) > 0) ArmadilloCheck.Checked = true; else ArmadilloCheck.Checked = false;
            if ((SaveSlots[Slot].SecondAnimalFlags & 0x4) > 0) BatCheck.Checked = true; else BatCheck.Checked = false;
            if ((SaveSlots[Slot].SecondAnimalFlags & 0x8) > 0) EggCheck.Checked = true; else EggCheck.Checked = false;

            //Display player name
            NameTextbox.Text = SaveSlots[Slot].PlayerName;

            //Display active info
            if (SaveSlots[Slot].Active == true) ActiveLabel.Text = null; else ActiveLabel.Text = "This save slot is not active, changes won't be saved.";
        }

        //Update data from editor to container
        private void SaveDataFromEditor(int Slot)
        {
            //Numeric controls
            SaveSlots[Slot].CurrentHealth = (int)HealthNumeric.Value;
            SaveSlots[Slot].MaximumHealth = (int)MaxHealthNumeric.Value;
            SaveSlots[Slot].Coins = (int)CoinsNumeric.Value;

            //Abilities
            if (AnimalTalkCheck.Checked == true) SaveSlots[Slot].FirstAbilityFlags |= 0x1; else SaveSlots[Slot].FirstAbilityFlags &= (0x1 ^ 0xFFFF);
            if (SwordThrowCheck.Checked == true) SaveSlots[Slot].FirstAbilityFlags |= 0x800; else SaveSlots[Slot].FirstAbilityFlags &= (0x800 ^ 0xFFFF);
            if (JumpCheck.Checked == true) SaveSlots[Slot].SecondAbilityFlags |= 0x800; else SaveSlots[Slot].SecondAbilityFlags &= (0x800 ^ 0xFFFF);
            if (StrenghtCheck.Checked == true) SaveSlots[Slot].SecondAbilityFlags |= 0x2; else SaveSlots[Slot].SecondAbilityFlags &= (0x2 ^ 0xFFFF);
        
            //Inventory
            if (BronzeCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x100; else SaveSlots[Slot].InventoryFlags &= (0x100 ^ 0xFFFF);
            if (SilverCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x200; else SaveSlots[Slot].InventoryFlags &= (0x200 ^ 0xFFFF);
            if (GoldCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x400; else SaveSlots[Slot].InventoryFlags &= (0x400 ^ 0xFFFF);
            if (HolyCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x800; else SaveSlots[Slot].InventoryFlags &= (0x800 ^ 0xFFFF);
            if (PlantCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x1000; else SaveSlots[Slot].InventoryFlags &= (0x1000 ^ 0xFFFF);
            if (ShoesCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x2000; else SaveSlots[Slot].InventoryFlags &= (0x2000 ^ 0xFFFF);
            if (PowderCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x4000; else SaveSlots[Slot].InventoryFlags &= (0x4000 ^ 0xFFFF);
            if (HornCheck.Checked == true) SaveSlots[Slot].InventoryFlags |= 0x8000; else SaveSlots[Slot].InventoryFlags &= (0x8000 ^ 0xFFFF);

            //Debug menu
            if (AbilitiesCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x8; else SaveSlots[Slot].FirstAnimalFlags &= (0x8 ^ 0xFFFF);
            if (ResetCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x10; else SaveSlots[Slot].FirstAnimalFlags &= (0x10 ^ 0xFFFF);

            //Animals
            if (KittyCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x20; else SaveSlots[Slot].FirstAnimalFlags &= (0x20 ^ 0xFFFF);
            if (JohnnyCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x40; else SaveSlots[Slot].FirstAnimalFlags &= (0x40 ^ 0xFFFF);
            if (MoaCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x80; else SaveSlots[Slot].FirstAnimalFlags &= (0x80 ^ 0xFFFF);
            if (LionCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x100; else SaveSlots[Slot].FirstAnimalFlags &= (0x100 ^ 0xFFFF);
            if (PenguyCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x200; else SaveSlots[Slot].FirstAnimalFlags &= (0x200 ^ 0xFFFF);
            if (CharlieCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x400; else SaveSlots[Slot].FirstAnimalFlags &= (0x400 ^ 0xFFFF);
            if (DinosaurCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x800; else SaveSlots[Slot].FirstAnimalFlags &= (0x800 ^ 0xFFFF);
            if (DodoCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x1000; else SaveSlots[Slot].FirstAnimalFlags &= (0x1000 ^ 0xFFFF);
            if (LeviathanCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x2000; else SaveSlots[Slot].FirstAnimalFlags &= (0x2000 ^ 0xFFFF);
            if (RaccoonCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x4000; else SaveSlots[Slot].FirstAnimalFlags &= (0x4000 ^ 0xFFFF);
            if (CielCheck.Checked == true) SaveSlots[Slot].FirstAnimalFlags |= 0x8000; else SaveSlots[Slot].FirstAnimalFlags &= (0x8000 ^ 0xFFFF);
            if (CaterpillarCheck.Checked == true) SaveSlots[Slot].SecondAnimalFlags |= 0x1; else SaveSlots[Slot].SecondAnimalFlags &= (0x1 ^ 0xFFFF);
            if (ArmadilloCheck.Checked == true) SaveSlots[Slot].SecondAnimalFlags |= 0x2; else SaveSlots[Slot].SecondAnimalFlags &= (0x2 ^ 0xFFFF);
            if (BatCheck.Checked == true) SaveSlots[Slot].SecondAnimalFlags |= 0x4; else SaveSlots[Slot].SecondAnimalFlags &= (0x4 ^ 0xFFFF);
            if (EggCheck.Checked == true) SaveSlots[Slot].SecondAnimalFlags |= 0x8; else SaveSlots[Slot].SecondAnimalFlags &= (0x8 ^ 0xFFFF);

            //Player name
            SaveSlots[Slot].PlayerName = NameTextbox.Text;
        }


        //Check if the slot is active
        private bool CheckSlotActive(int Slot)
        {
            if (SaveData[0x5 + (Slot * 0x1000)] != 0x52) return false;
            if (SaveData[0x7 + (Slot * 0x1000)] != 0x41) return false;
            if (SaveData[0x9 + (Slot * 0x1000)] != 0x47) return false;
            if (SaveData[0xB + (Slot * 0x1000)] != 0x4E) return false;

            //All OK, slot is active
            return true;
        }

        //Calculate checksums for all 4 slots
        private void CalculateChecksums()
        {
            int Checksum = 0;

            //Cycle trough each slot
            for (int j = 0; j < 4; j++)
            {
                Checksum = 0;
                for (int i = 1; i < 340; i += 4)
                {
                    Checksum += Get16bitData(i, j);
                    Checksum &= 0xFFFF;
                }

                Set16bitData(0x155, j, Checksum);
            }
        }

        //Load data from memory
        private int Get16bitData(int Offset, int Slot)
        {
            return SaveData[Offset + (0x1000 * Slot)] << 8 | SaveData[Offset + 2 + (0x1000 * Slot)];
        }

        //Set data to memory
        private void Set16bitData(int Offset, int Slot, int Value)
        {
            SaveData[Offset + (0x1000 * Slot)] = (byte)(Value >> 8);
            SaveData[Offset + 2 + (0x1000 * Slot)] = (byte)(Value & 0xFF);
        }

        //Convert game string data to regular strings
        private string SoleilStringToString(int Offset, int Slot)
        {
            string OutputString = null;
            int TempData;

            //Cycle through each character
            for (int i = 0; i < 20; i+=2)
            {
                TempData = SaveData[Offset + i + (Slot * 0x1000)];

                if ((TempData == 0xFF) || (TempData > CharPattern.Length-1)) break;
                OutputString += CharPattern[TempData];
            }

            return OutputString;
        }

        //Convert regular string to game string
        private void StringToSoleilString(int Offset, int Slot, string Input)
        {
            byte OutputData = 0;
            int i = 0;

            //Go trough all characters
            foreach (char Letter in Input)
            {
                OutputData = 0;

                //Search through all characters to find if there is a match
                for (int j = 0; j < CharPattern.Length; j++)
                {
                    if (CharPattern[j] == Letter)
                    {
                        OutputData = (byte)j;
                        break;
                    }
                }

                //Save data to byte array
                SaveData[Offset + i + (Slot * 0x1000)] = OutputData;

                i+=2;
            }

            //Place string terminator
            SaveData[Offset + i + (Slot * 0x1000)] = 0xFF;
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            //Decrease current slot
            UpdateSlot(-1, false);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Increase current slot
            UpdateSlot(1, false);
        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            //Draw gray rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), 0, 0, this.Width, 30);
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            //Close the window
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            //Select a file to open
            ShowOpenDialog();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            //Show info about this application
            new AboutWindow().initDialog(this, ApplicationName, ApplicationVersion, ApplicationDate, "Copyright © Shendo 2012", ApplicationName +
                " is a save editor for:\nSoleil (Europe),\nCrusader of Centy (America),\nShin Sōseiki Ragnacënty (Japan)." + 
                "\n\nAll trademarks and copyrights are the\nproperty of their respective owners.");
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            //Check if the opened file has a real path
            if (OpenedFileName == null) ShowSaveDialog();
            else SaveDataToFile(OpenedFileName);
        }

        private void SaveAsManuItem_Click(object sender, EventArgs e)
        {
            //Open a save file dialog
            ShowSaveDialog();
        }

        private void ReadMeMenuItem_Click(object sender, EventArgs e)
        {
            //Check if Readme.txt exists
            if (File.Exists(Application.StartupPath + "/Readme.txt")) System.Diagnostics.Process.Start(Application.StartupPath + "/Readme.txt");
            else MessageBox.Show(this, "'ReadMe.txt' was not found.", ApplicationName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
