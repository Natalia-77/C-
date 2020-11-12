using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Total_Commander
{


    class FileManager
    {
        public event Program.UseKey KeyPress;
        List<FilePanel> panels = new List<FilePanel>();
        private int activePanelIndex;

        static FileManager()
        {
            Console.CursorVisible = false;
            //Console.SetWindowSize(120, 41);
            //Console.SetBufferSize(120, 41);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public FileManager()
        {
            Table tab = new Table();
            FilePanel filePanel = new FilePanel();
            filePanel.Top = 0;
            filePanel.Left =0;
            panels.Add(filePanel);

            filePanel = new FilePanel();

            filePanel.Top = FilePanel.console_height;           
            filePanel.Left = 0;
            panels.Add(filePanel);

            activePanelIndex = 0;

            panels[activePanelIndex].Active = true;
            KeyPress += panels[activePanelIndex].KeyboardProcessing;

            foreach (FilePanel fp in panels)
            {
                fp.Show();
            }

            //tab.Keys(0,0);
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
                            
                            break;
                        case ConsoleKey.Enter:
                           Choise();
                            break;
                        case ConsoleKey.F3:
                           
                            break;
                        case ConsoleKey.F4:
                          
                            break;
                        case ConsoleKey.F5:
                           
                            break;
                        case ConsoleKey.F6:
                          
                            break;
                        case ConsoleKey.F7:
                          
                            break;
                        case ConsoleKey.F8:
                          
                            break;
                        case ConsoleKey.F9:
                            
                            break;
                        case ConsoleKey.F10:
                            exit = true;
                            Console.ResetColor();
                            Console.Clear();
                            break;
                        case ConsoleKey.DownArrow:
                          
                        case ConsoleKey.UpArrow:
                           
                        case ConsoleKey.PageUp:
                            KeyPress(userKey);
                            break;
                        default:
                            break;
                    }
                }
            }
        }


        private void Choise()
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

    }
}
