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
                            ChangePanel();
                            break;
                        case ConsoleKey.Enter:
                           Choise();
                            break;
                        case ConsoleKey.F3:
                           
                            break;
                        case ConsoleKey.F4:
                          
                            break;
                        case ConsoleKey.End:
                            Copy();
                            break;
                        case ConsoleKey.F6:
                            //Move();
                            break;
                        case ConsoleKey.F7:
                          
                            break;
                        case ConsoleKey.F8:
                          
                            break;
                        case ConsoleKey.F9:
                            //Delete();
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

        //private void RefreshPannels()
        //{
        //    if (panels == null || panels.Count == 0)
        //    {
        //        return;
        //    }

        //    foreach (FilePanel panel in panels)
        //    {
        //        if (!panel.isDiscs)
        //        {
        //            panel.UpdateContent(true);
        //        }
        //    }
        //}

        private void ChangePanel()
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

                //RefreshPannels();
            }
            catch 
            {
                throw new Exception(String.Format("Щось не так"));
                
            }
        }

    }
}
