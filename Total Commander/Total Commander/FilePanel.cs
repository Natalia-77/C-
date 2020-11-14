using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace FileManager
{
    class FilePanel
    {
        //========================== Static ==========================

        public static int panel_height = 18;
        public static int panel_width = 100;

        //========================== Поля ==========================        

        private int top;
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                if (0 <= value && value <= Console.WindowHeight - panel_height)
                {
                    top = value;
                }
                else
                {
                    throw new Exception(String.Format("Вихід за межі", value));
                }
            }
        }

        private int left;
        public int Left
        {
            get
            {
                return this.left;
            }
            set
            {
                if (0 <= value && value <= Console.WindowWidth - panel_width)
                {
                    this.left = value;
                }
                else
                {
                    throw new Exception(String.Format("Вихід за межі", value));
                }
            }
        }

        private int height = panel_height;
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (0 < value && value <= Console.WindowHeight)
                {
                    this.height = value;
                }
                else
                {
                    throw new Exception(String.Format("Вихід за межі", value));
                }
            }
        }

        private int width = FilePanel.panel_width;
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (0 < value && value <= Console.WindowWidth)
                {
                    width = value;
                }
                else
                {
                    throw new Exception(String.Format("Вихід за межі", value));
                }
            }
        }



        private string path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                DirectoryInfo di = new DirectoryInfo(value);
                if (di.Exists)
                {
                    path = value;
                }
                else
                {
                    throw new Exception(String.Format("Такого шляху немає", value));
                }
            }
        }

        private int activeObjectIndex = 0;
        private int firstObjectIndex = 0;
        private int displayedObjectsAmount = panel_height - 2;

        private bool active;
        public bool Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
        private bool discs;
        public bool isDiscs
        {
            get
            {
                return discs;
            }
        }



        private List<FileSystemInfo> fsObjects = new List<FileSystemInfo>();

        //========================== Методи ==========================



        public FilePanel()
        {
            SetDiscs();
        }

        public FilePanel(string path)
        {
            this.path = path;
            SetLists();
        }



        public FileSystemInfo GetActiveObject()
        {
            if (fsObjects != null && fsObjects.Count != 0)
            {
                return fsObjects[activeObjectIndex];
            }
            throw new Exception("Список пустий");
        }


        public void KeyboardProcessing(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    Up();
                    break;
                case ConsoleKey.DownArrow:
                    Down();
                    break;
                default:
                    break;
            }
        }

        private void Down()
        {
            // Якщо активний індекс більше /рівний кількості обєктів в консолі
            if (activeObjectIndex >= firstObjectIndex + displayedObjectsAmount - 1)
            {
                // збільшуємо  індекс першого обєкта,який буде зверху таблиці в консолі.
                firstObjectIndex ++;
                
                if (firstObjectIndex + displayedObjectsAmount >= fsObjects.Count)
                {
                    firstObjectIndex = fsObjects.Count - displayedObjectsAmount;
                }
                activeObjectIndex = firstObjectIndex + displayedObjectsAmount - 1;
                UpdateContent(false);
            }

            else
            {
                if (activeObjectIndex >= fsObjects.Count - 1)
                {
                    return;
                }
                DeactivateObject(activeObjectIndex);
                activeObjectIndex++;
                ActivateObject(activeObjectIndex);
            }
        }

        private void Up()
        {
            if (activeObjectIndex <= firstObjectIndex)
            {
                firstObjectIndex --;
                if (firstObjectIndex < 0)
                {
                    firstObjectIndex = 0;
                }
                activeObjectIndex = firstObjectIndex;
                UpdateContent(false);
            }
            else
            {
                DeactivateObject(activeObjectIndex);
                activeObjectIndex--;
                ActivateObject(activeObjectIndex);
            }
        }




        public void SetLists()
        {
            if (this.fsObjects.Count != 0)
            {
                this.fsObjects.Clear();
            }

            this.discs = false;

            DirectoryInfo levelUpDirectory = null;
            this.fsObjects.Add(levelUpDirectory);

            //Directories

            string[] directories = Directory.GetDirectories(this.path);
            foreach (string directory in directories)
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                this.fsObjects.Add(di);
            }

            //Files

            string[] files = Directory.GetFiles(this.path);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                this.fsObjects.Add(fi);
            }
        }

        public void SetDiscs()
        {
            if (fsObjects.Count != 0)
            {
                fsObjects.Clear();
            }

            this.discs = true;

            DriveInfo[] discs = DriveInfo.GetDrives();
            foreach (DriveInfo disc in discs)
            {
                if (disc.IsReady)
                {
                    DirectoryInfo di = new DirectoryInfo(disc.Name);
                    this.fsObjects.Add(di);
                }
            }
        }


        public void Show()
        {
            Clear();

            PsCon.PsCon.PrintFrameDoubleLine(left, top, width, height, ConsoleColor.White, ConsoleColor.Black);

            StringBuilder caption = new StringBuilder();
            if (discs)
            {
                caption.Append(' ').Append("Диски").Append(' ');
            }
            else
            {
                caption.Append(' ').Append(path).Append(' ');
            }
            PsCon.PsCon.PrintString(caption.ToString(), left + width / 3 - caption.ToString().Length / 3, top, ConsoleColor.White, ConsoleColor.Black);

            PrintContent();
        }

        public void Clear()
        {
            for (int i = 0; i < this.height; i++)
            {
                string space = new String(' ', this.width);
                Console.SetCursorPosition(this.left, this.top + i);
                Console.Write(space);
            }
        }

        private void PrintContent()
        {
            if (this.fsObjects.Count == 0)
            {
                return;
            }
            int count = 0;

            int lastElement = this.firstObjectIndex + this.displayedObjectsAmount;
            if (lastElement > fsObjects.Count)
            {
                lastElement = fsObjects.Count;
            }


            if (activeObjectIndex >= fsObjects.Count)
            {
                activeObjectIndex = 0;
            }

            for (int i = firstObjectIndex; i < lastElement; i++)
            {
                Console.SetCursorPosition(left + 1, top + count + 1);

                if (i == activeObjectIndex && active == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                PrintObject(i);
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                count++;
            }
        }

        private void ClearContent()
        {
            for (int i = 1; i < this.height - 1; i++)
            {
                string space = new String(' ', this.width - 2);
                Console.SetCursorPosition(this.left + 1, this.top + i);
                Console.Write(space);
            }
        }

        private void PrintObject(int index)
        {
            if (index < 0 || fsObjects.Count <= index)
            {
                throw new Exception(String.Format("Вихід за межі.", index));
            }

            int currentCursorTopPosition = Console.CursorTop;
            int currentCursorLeftPosition = Console.CursorLeft;

            if (!discs && index == 0)
            {
                Console.Write("..");
                return;
            }

            Console.Write("{0}", fsObjects[index].Name);
            Console.SetCursorPosition(currentCursorLeftPosition + this.width / 2, currentCursorTopPosition);
            if (fsObjects[index] is DirectoryInfo)
            {
                Console.Write("{0}", ((DirectoryInfo)fsObjects[index]).LastWriteTime);
            }
            else
            {
                Console.Write("{0}", ((FileInfo)fsObjects[index]).Length);
            }
        }

        public void UpdatePanel()
        {
            firstObjectIndex = 0;
            activeObjectIndex = 0;
            Show();
        }

        public void UpdateContent(bool updateList)
        {
            if (updateList)
            {
                SetLists();
            }
            ClearContent();
            PrintContent();
        }

        private void ActivateObject(int index)
        {
            int offsetY = activeObjectIndex - firstObjectIndex;
            Console.SetCursorPosition(left + 1, top+offsetY  + 1);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            PrintObject(index);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void DeactivateObject(int index)
        {
            int offsetY = activeObjectIndex - firstObjectIndex;
            Console.SetCursorPosition(left + 1, top + offsetY + 1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            PrintObject(index);
        }
    }

}

