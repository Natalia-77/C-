using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;


namespace FileManager

{
    class FileManager
    {
        //========================== Static ==========================

        public static int HEIGHT_KEYS = 3;
        
        //========================== Поля ==========================

        public event OnKey KeyPress;
        List<FilePanel> panels = new List<FilePanel>();
        private int activePanelIndex;

        //========================== Методи ==========================



        static FileManager()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(100, 41);
            Console.SetBufferSize(100, 41);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public FileManager()
        {
            FilePanel filePanel = new FilePanel();
            filePanel.Top = 0;
            filePanel.Left = 0;
            this.panels.Add(filePanel);

            filePanel = new FilePanel();
            filePanel.Top = FilePanel.panel_height;
            filePanel.Left = 0;
            this.panels.Add(filePanel);

            activePanelIndex = 0;

            panels[activePanelIndex].Active = true;
            KeyPress += panels[activePanelIndex].KeyboardProcessing;

            foreach (FilePanel fp in panels)
            {
                fp.Show();
            }

            ShowKeys();
        }



        public void Explore()
        {
            bool exit = false;
            while (!exit)
            {
                if (Console.KeyAvailable)
                {                    

                    ConsoleKeyInfo userKey = Console.ReadKey(true);
                    switch (userKey.Key)
                    {
                        case ConsoleKey.Tab:
                            this.ChangeActivePanel();
                            break;
                        case ConsoleKey.Enter:
                            this.ChangeDirectoryOrRunProcess();
                            break;
                        case ConsoleKey.F5:
                            this.Copy();
                            break;
                        case ConsoleKey.F6:
                            this.Move();
                            break;
                        case ConsoleKey.F9:
                            Delete();
                            break;
                        case ConsoleKey.F10:
                            exit = true;
                            Console.ResetColor();
                            Console.Clear();
                            break;
                        case ConsoleKey.DownArrow:
                            goto case ConsoleKey.Help;
                        case ConsoleKey.UpArrow:
                            goto case ConsoleKey.Help;
                        case ConsoleKey.Help:
                            KeyPress(userKey);
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        private void Copy()
        {
            foreach (FilePanel panel in panels)
            {
                if (panel.isDiscs)
                {
                    return;
                }
            }

            if (panels[0].Path == panels[1].Path)
            {
                return;
            }

            try
            {
                string destPath = activePanelIndex == 0 ? panels[1].Path : panels[0].Path;

                FileSystemInfo fileObject = panels[activePanelIndex].GetActiveObject();
                FileInfo currentFile = fileObject as FileInfo;

                if (currentFile != null)
                {
                    string fileName = currentFile.Name;
                    string destName = Path.Combine(destPath, fileName);
                  
                    File.Copy(currentFile.FullName, destName, true);
                }

                else
                {
                    string currentDir = ((DirectoryInfo)fileObject).FullName;
                    string destDir = Path.Combine(destPath, ((DirectoryInfo)fileObject).Name);
                    CopyDirectory(currentDir, destDir);
                }

                RefreshPannels();
            }
            catch (Exception )
            {
                
                Console.WriteLine("Щось пішло не так...");
                return;
            }
        }

        private void CopyDirectory(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                CopyDirectory(subdir.FullName, temppath);
            }
        }

        private void Delete()
        {
            if (panels[activePanelIndex].isDiscs)
            {
                return;
            }

            FileSystemInfo fileObject = panels[activePanelIndex].GetActiveObject();
            try
            {
                if (fileObject is DirectoryInfo)
                {
                    ((DirectoryInfo)fileObject).Delete(true);
                }
                else
                {
                    ((FileInfo)fileObject).Delete();
                }
                RefreshPannels();
            }
            catch (Exception )
            {
                
                Console.WriteLine("Щось пішло не так...");
                return;
            }
        }



        private void Move()
        {
            foreach (FilePanel panel in panels)
            {
                if (panel.isDiscs)
                {
                    return;
                }
            }

            if (panels[0].Path == panels[1].Path)
            {
                return;
            }

            try
            {
                string destPath = activePanelIndex == 0 ? panels[1].Path : panels[0].Path;
                FileSystemInfo fileObject = panels[activePanelIndex].GetActiveObject();

                string objectName = fileObject.Name;
                string destName = Path.Combine(destPath, objectName);

                if (fileObject is FileInfo)
                {
                    ((FileInfo)fileObject).MoveTo(destName);
                }
                else
                {
                    ((DirectoryInfo)fileObject).MoveTo(destName);
                }

                RefreshPannels();
            }
            catch (Exception )
            {
                
                Console.WriteLine("Щось пішло не так...");
                return;
            }

        }



        private void RefreshPannels()
        {
            if (this.panels == null || this.panels.Count == 0)
            {
                return;
            }

            foreach (FilePanel panel in panels)
            {
                if (!panel.isDiscs)
                {
                    panel.UpdateContent(true);
                }
            }
        }

        private void ChangeActivePanel()
        {
            panels[activePanelIndex].Active = false;
            KeyPress -= panels[activePanelIndex].KeyboardProcessing;
            panels[activePanelIndex].UpdateContent(false);

            activePanelIndex++;
            if (activePanelIndex >= panels.Count)
            {
                activePanelIndex = 0;
            }

            panels[activePanelIndex].Active = true;
            KeyPress += panels[activePanelIndex].KeyboardProcessing;
            panels[activePanelIndex].UpdateContent(false);
        }

        private void ChangeDirectoryOrRunProcess()
        {
            FileSystemInfo fsInfo = panels[activePanelIndex].GetActiveObject();
            if (fsInfo != null)
            {
                if (fsInfo is DirectoryInfo)
                {
                    try
                    {
                        Directory.GetDirectories(fsInfo.FullName);
                    }
                    catch
                    {
                        return;
                    }

                    panels[activePanelIndex].Path = fsInfo.FullName;
                    panels[activePanelIndex].SetLists();
                    panels[activePanelIndex].UpdatePanel();
                }
                else
                {
                    Process.Start(((FileInfo)fsInfo).FullName);
                }
            }
            else
            {
                string currentPath = panels[activePanelIndex].Path;
                DirectoryInfo currentDirectory = new DirectoryInfo(currentPath);
                DirectoryInfo upLevelDirectory = currentDirectory.Parent;

                if (upLevelDirectory != null)
                {
                    panels[activePanelIndex].Path = upLevelDirectory.FullName;
                    panels[activePanelIndex].SetLists();
                    panels[activePanelIndex].UpdatePanel();
                }

                else
                {
                    panels[activePanelIndex].SetDiscs();
                    panels[activePanelIndex].UpdatePanel();
                }
            }
        }

        private void ShowKeys()
        {
            string[] menu = { "F5 Copy", "F6 Move", "F9 Delete", "F10 Exit" };

            int cellLeft = panels[0].Left;
            int cellTop = FilePanel.panel_height * panels.Count;// висота .
            int cellWidth = FilePanel.panel_width / menu.Length;// ширина однієї--ширина панелі/довжину масиву.
            int cellHeight = HEIGHT_KEYS;

            for (int i = 0; i < menu.Length; i++)
            {
                PsCon.PsCon.PrintFrameLine(cellLeft+i*cellWidth , cellTop, cellWidth, cellHeight, ConsoleColor.Red, ConsoleColor.Black);
                PsCon.PsCon.PrintString(menu[i], cellLeft + i * cellWidth + 1, cellTop + 1, ConsoleColor.Green, ConsoleColor.Black);
            }
        }

        
    }

}