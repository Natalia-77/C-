using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Total_Commander
{
    class FilePanel
    {

        public static int console_height = 16;
        public static int console_width = 120;
        private List<FileSystemInfo> fileobject = new List<FileSystemInfo>();


        private int top;
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                if (0 <= value )//&& value <= Console.WindowHeight - console_height)
                {
                    top = value;
                }
                else
                {
                    throw new Exception(String.Format("Вихід за межі вікна", value));
                }
            }
        }

        private int left;
        public int Left
        {
            get
            {
                return left;
            }
            set
            {
                if (0 <= value )//&& value <= Console.WindowWidth - console_width)
                {
                    left = value;
                }
                else
                {
                    throw new Exception(String.Format("Вихід за межі вікна", value));
                }
            }
        }


        private int height = console_height;
        
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (0 < value && value <= Console.WindowHeight)
                {
                    height = value;
                }
                else
                {
                    throw new Exception(String.Format("Висота більше розміру вікна", value));
                }
            }
        }

        private int width = console_width;
        
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
                    throw new Exception(String.Format("Ширина більше розміру вікна", value));
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



        // Індекс активного елемента.
        private int active_index = 0;

        // Індекс першого елемента.
        private int first_index = 0;

        // Кількість елементів на сторінці.
        private int objectamount = console_height;
       


        public FilePanel()
        {
            SetDiscs();
        }

        public FilePanel(string path)
        {
            this.path = path;
            SetLists();
        }

        // Отримуємо обєкт активний обєкт у вікні.
        public FileSystemInfo GetActiveObject()
        {
            if (fileobject != null && fileobject.Count != 0)
            {
                return fileobject[active_index];
            }
            throw new Exception("Список пустий");
        }

        // Отримуємо весь список з файлами.
        public void SetLists()
        {
            if (fileobject.Count != 0)
            {
                fileobject.Clear();
            }

            discs = false;

            DirectoryInfo newDir = null;
            fileobject.Add(newDir);

            //Directories

            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                fileobject.Add(di);
            }

            //Files

            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                fileobject.Add(fi);
            }
        }


        // Отримуємо директорії.
        public void SetDiscs()
        {
            // Якщо є елементи.
            if (fileobject.Count != 0)
            {
                // Очищаю консоль.
                fileobject.Clear();
            }

            this.discs = true;

            DriveInfo[] discs = DriveInfo.GetDrives();

            // Проходимо по елементам масиву з директоріями.
            foreach (DriveInfo disc in discs)
            {
                if (disc.IsReady)
                {
                    DirectoryInfo dir = new DirectoryInfo(disc.Name);
                    fileobject.Add(dir);
                }
            }
        }

        // Очистка консолі.
        public void Clear()
        {
            for (int i = 1; i < height+1; i++)
            {
                string space = new String(' ', width);
                Console.SetCursorPosition(left,top+ i);
                Console.Write(space);
            }
        }

        // Встановлення значень на початкові індекси.
        public void UpdatePanel()
        {
            first_index = 0;
            active_index = 0;
            Show();
        }
                
        // Вивід обєктів в консоль.
        private void PrintObject(int index)
        {
            if (index < 0 || fileobject.Count <= index)
            {
                throw new Exception(String.Format("Вихід за межі діапазона", index));
            }
           
            if (!discs && index == 0)
            {
                Console.Write("..");
                return;
            }

            int currentCursorTopPosition = Console.CursorTop;
            int currentCursorLeftPosition = Console.CursorLeft;

            Console.Write(" {0}", fileobject[index].Name);
            Console.SetCursorPosition(currentCursorLeftPosition + width / 5, currentCursorTopPosition);
            
            if (fileobject[index] is DirectoryInfo)
            {
                Console.Write(" {0}", ((DirectoryInfo)fileobject[index]).LastWriteTime);
            }
            else
            {
                Console.Write(" {0}", ((FileInfo)fileobject[index]).Length);
            }
        }

        // Виділення кольором активного елемента вікна.
        private void PrintContent()
        {
            if (fileobject.Count == 0)
            {
                return;
            }
            int count = 0;

            int lastElement = first_index + objectamount;

            if (lastElement > fileobject.Count)
            {
                lastElement = fileobject.Count;
            }

            if (active_index >= fileobject.Count)
            {
                active_index = 0;
            }

            for (int i = first_index; i < lastElement; i++)
            {
                Console.SetCursorPosition(left, top + count + 1);

                if (i == active_index && active == true)
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


        public void Show()
        {
            Clear();

            StringBuilder caption = new StringBuilder();
           
            Console.SetCursorPosition(width/2 - caption.ToString().Length, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
           
            PrintContent();
        }


        private void Activate_object(int index)
        {
            int offsetY = active_index - first_index;
            Console.SetCursorPosition(0, offsetY + 1);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            PrintObject(index);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        private void Deactivate_object(int index)
        {
            int offsetY = active_index - first_index;
            Console.SetCursorPosition(0, offsetY + 1);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            PrintObject(index);
        }

        private void ClearContent()
        {
            for (int i = 1; i < height ; i++)
            {
                string space = new String(' ', width );
                Console.SetCursorPosition(left+1, top + i);
                Console.Write(space);
            }
        }

        public void UpdateContent(bool updateList)
        {
            // якщо true,то отримуємо список з файлами і папками.
            if (updateList)
            {
                SetLists();
            }
            ClearContent();
            PrintContent();
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
            if (active_index >= first_index + objectamount - 1)
            {
                first_index++;
                if (first_index + objectamount >= fileobject.Count)
                {
                    first_index = fileobject.Count - objectamount;
                }
                active_index = first_index + objectamount - 1;
                UpdateContent(false);
            }

            else
            {
                if (active_index >= fileobject.Count - 1)
                {
                    return;
                }
                Deactivate_object(active_index);
                active_index++;
                Activate_object(active_index);
            }
        }

        private void Up()
        {
            if (active_index <= first_index)
            {
                first_index --;
                if (first_index < 0)
                {
                    first_index = 0;
                }
                active_index = first_index;
                UpdateContent(false);
            }
            else
            {
                Deactivate_object(active_index);
                active_index --;
                Activate_object(active_index);
            }
        }

    }
}
