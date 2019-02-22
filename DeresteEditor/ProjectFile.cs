using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace NotemapEditor
{
    [Serializable]
    class ProjectFile

    {
        //for info.txt
        public String title;
        public String artist;
        public String mobile;
        public String tag;
        public String pathToMusic;
        public String ProjDir;
        private string infoTxtPath;

        public int lines=5;
        public int easyLevel=7;
        public int normalLevel=12;
        public int hardLevel=18;
        public int apexLevel=25;

        public string creator;

        public bool initialized;
        
        public string CurrentDifficulty
        {
            get;
            set;
        }
        public int Level
        {
            get
            {
                switch(CurrentDifficulty)
                {
                    case "easy":
                        return easyLevel;
                    case "normal":
                        return normalLevel;
                    case "hard":
                        return hardLevel;
                    case "apex":
                        return apexLevel;
                }
                return 20;
            }
            set
            {
                switch(CurrentDifficulty)
                {
                    case "easy":
                        easyLevel = value;
                        break;
                    case "normal":
                        normalLevel = value;
                        break;
                    case "hard":
                        hardLevel = value;
                        break;
                    case "apex":
                        apexLevel = value;
                        break;
                    default:
                        easyLevel = value;
                        normalLevel = value;
                        hardLevel = value;
                        apexLevel = value;
                        break;
                }
            }
        }
        public ProjectFile()
        {

        }
        public ProjectFile(String projectPath,  String title, String artist, String mobile,String tag)
        {
            if(!Directory.Exists(projectPath))
                Directory.CreateDirectory(projectPath);
            infoTxtPath = projectPath + "info.txt";
            this.title = title;
            this.artist = artist;
            this.mobile = mobile;
            this.tag = tag;

        }

        //# title [악곡 이름]
        //# artist [아티스트 이름, 작곡가 이름, 가수 이름 등등]
        //# mobile
        //# easy [난이도 수치]
        //# normal [난이도 수치]
        //# hard [난이도 수치]
    }
}
