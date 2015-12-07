﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace SynchUpdatedFiles
{
    

    public class FileVersion : IComparable<FileVersion>
    {
        public int Major { get; set; }

        public int Minor { get; set; }

        public int Build { get; set; }

        public int Private { get; set; }


        public int CompareTo(FileVersion other)
        {
            var result = Major.CompareTo(other.Major);
            result = result == 0 ? Minor.CompareTo(other.Minor) : result;
            result = result == 0 ? Build.CompareTo(other.Build) : result;
            result = result == 0 ? Private.CompareTo(other.Private) : result;

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}.{3}", Major, Minor, Build, Private);
        }
    }


    public class FileMetadata
    {
        public string Filename { get; set; }

        public FileVersion FileVersionTarget { get; set; }

        public FileVersion FileVersionSource { get; set; }
    }


    public class RepositoryApi
    {



        public static bool Read(out FileVersion fileVersion, string directory, string filename)
        {
            var result = false;

            fileVersion = new FileVersion();

            var fullpath = Path.Combine(directory, filename);
            var fi = new FileInfo(fullpath);
            if (fi.Exists)
            {
                var t1 = FileVersionInfo.GetVersionInfo(fi.FullName);
                var t2 = t1.FileVersion.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                int t3;
                fileVersion.Major = int.TryParse(t2[0], out t3) ? t3 : 0;
                fileVersion.Minor = int.TryParse(t2[1], out t3) ? t3 : 0;
                fileVersion.Build = int.TryParse(t2[2], out t3) ? t3 : 0;
                fileVersion.Private = int.TryParse(t2[3], out t3) ? t3 : 0;

                result = true;
            }

            return result;
        }

        public static bool ReadDeep(out FileVersion fileVersion, string directory, string filename)
        {
            var di = new DirectoryInfo(directory);
            var fileList = di.GetFiles(filename, SearchOption.AllDirectories);
            if (fileList.Length == 1)
            {
                var current = fileList[0];
                return Read(out fileVersion, current.DirectoryName, filename);
            }

            fileVersion = null;
            return false;
        }


        public DirectoryInfo TargetDirectory { get; set; }

        public DirectoryInfo SourceDirectory { get; set; }

        public List<FileMetadata> FileList { get; set; }

        private List<FileInfo> TargetDirectoryList { get; set; }

        public int Analyze()
        {
            TargetDirectoryList = TargetDirectory.GetFiles("*.dll").ToList();
            FileList = new List<FileMetadata>();

            foreach (var fileInfo in TargetDirectoryList)
            {
                var t1 = new FileMetadata();
                FileVersion fv;

                if (Read(out fv, TargetDirectory.FullName, fileInfo.Name))
                {
                    t1.Filename = fileInfo.Name;
                    t1.FileVersionTarget = fv;

                    if (ReadDeep(out fv, SourceDirectory.FullName, fileInfo.Name))
                    {
                        t1.FileVersionSource = fv;
                        FileList.Add(t1);
                    }
                }

            }

            return FileList.Count;
        }

    }
}
