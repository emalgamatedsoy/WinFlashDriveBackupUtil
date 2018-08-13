using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackupUtility
{


    class ModelBackupUtil
    {
        private String writeTo;
        private String readFrom;
        private HashSet<String> Files;
        private HashSet<String> PictureTypes;
        private HashSet<String> VideoTypes;
        private HashSet<String> DocumentTypes;
        private HashSet<String> MusicTypes;
        private Boolean picture;
        private Boolean video;
        private Boolean document;
        private Boolean music;

        /// <summary>
        /// set all model fields to be default.
        /// </summary>
        public ModelBackupUtil()
        {
            writeTo = "";
            readFrom = "";
            Files = new HashSet<String>();
            picture = false;
            video = false;
            document = false;
            music = false;
            CreatePictureTypes();
            CreateVideoTypes();
            CreateDocumentTypes();
            CreateMusicTypes();
        }


        //Getters for the model.

        /// <summary>
        /// Get folder to write to.
        /// </summary>
        /// <returns></returns>
        public String getwriteTo() { return writeTo; }
        /// <summary>
        /// get file system to read from.
        /// </summary>
        /// <returns></returns>
        public String getreadFrom() { return readFrom; }
        /// <summary>
        /// get file hashset
        /// </summary>
        /// <returns></returns>
        public HashSet<String> getFiles(){ return Files; }
        /// <summary>
        /// returns if picture is included in scan.
        /// </summary>
        /// <returns></returns>
        public Boolean getPicture() { return picture; }
        /// <summary>
        /// returns if video is included in scan.
        /// </summary>
        /// <returns></returns>
        public Boolean getVideo() { return video; }
        /// <summary>
        /// returns if document is included in scan.
        /// </summary>
        /// <returns></returns>
        public Boolean getDocument() { return document; }
        /// <summary>
        /// returns if music is included in scan.
        /// </summary>
        /// <returns></returns>
        public Boolean getMusic() { return music; }
        //creation of hashmaps...

        /// <summary>
        /// Create hashset of Picture types.
        /// listed in instantiation in an easy, readable format.
        /// </summary>
        public void CreatePictureTypes()
        {
            PictureTypes = new HashSet<String>
            {
              ".png",
              ".jpg",
              ".jpeg",
              ".tif",
              ".tiff",
              ".aiff",
              ".ogg",
              ".gif",
              ".bmp"
            };
        }


        /// <summary>
        /// Creates videotypes hashset.
        /// listed in instantiation in an easy, readable format.
        /// </summary>
        public void CreateVideoTypes()
        {
            VideoTypes = new HashSet<String>
            {
              ".mp4",
              ".wmv",
              ".avi",
              ".3gp",
              ".flv",
              ".m4v",
              ".mpg",
              ".mpeg"
            };
        }

        /// <summary>
        /// Creates document types hashset
        /// listed in instantiation in an easy, readable format.
        /// </summary>
        public void CreateDocumentTypes()
        {
            DocumentTypes = new HashSet<String>
            {
              ".doc",
              ".docx",
              ".rtf",
              ".odt",
              ".pdf",
              ".html"
            };
        }

        /// <summary>
        /// Creates music types hashset
        /// listed in instantiation in an easy, readable format.
        /// </summary>
        public void CreateMusicTypes()
        {
            MusicTypes = new HashSet<String>
            {
                ".mp3",
                ".ogg",
                ".wmv",
                ".wav",
                ".flac",
                ".m4a"
            };
        }

        //returns if string is listed in corresponding types.

        /// <summary>
        /// takes a string (used as file handle)
        /// identifies if it contains any picture file format in hashset.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Boolean isPictureType(String s)
        {
            foreach (String pic in PictureTypes)
            {
                if (s.Contains(pic))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// takes a string (used as file handle)
        /// identifies if it contains any video file formats in hashset.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>

        public Boolean isVideoType(String s)
        {
            foreach (String vid in VideoTypes)
            {
                if (s.Contains(vid))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// takes a string (used as file handle)
        /// returns if string contains any document types in hashset.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Boolean isDocumentType(String s)
        {
            foreach (String doc in DocumentTypes)
            {
                if (s.Contains(doc))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// takes a string (used as file handle)
        /// returns if string contains any music types in hashset.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public Boolean isMusicType(String s)
        {
            foreach (String mus in MusicTypes)
            {
                if (s.Contains(mus))
                    return true;
            }
            return false;
        }

        //setters

        /// <summary>
        /// sets folder to write to.
        /// </summary>
        /// <param name="writeTo"></param>
        public void setwriteTo(String writeTo)
        {
            this.writeTo = writeTo;
        }
        /// <summary>
        /// sets file system to traverse.
        /// </summary>
        /// <param name="readFrom"></param>
        public void setreadFrom(String readFrom)
        {
            this.readFrom = readFrom;
        }

        /// <summary>
        /// sets the files to the model.
        /// </summary>
        /// <param name="Files"></param>
        public void setFiles(HashSet<String> Files)
        {
            this.Files = Files;
        }

        /// <summary>
        /// sets pictures status for file scan.
        /// </summary>
        /// <param name="picture"></param>
        public void setPicture(Boolean picture)
        {
            this.picture = picture;
        }

        /// <summary>
        /// sets video status for file scan.
        /// </summary>
        /// <param name="video"></param>
        public void setVideo(Boolean video)
        {
            this.video = video;
        }

        /// <summary>
        /// sets document status for file scan.
        /// </summary>
        /// <param name="document"></param>
        public void setDocument(Boolean document)
        {
            this.document = document;
        }

        /// <summary>
        /// sets music status for file scan.
        /// </summary>
        /// <param name="music"></param>
        public void setMusic(Boolean music)
        {
            this.music = music;
        }
        //File list FILO

        /// <summary>
        /// adds string file handle to List.
        /// </summary>
        /// <param name="s"></param>
        public void AddFile(String s)
        {
            Files.Add(s);
        }

        /// <summary>
        /// removes selected string file handle from list.
        /// </summary>
        /// <param name="s"></param>
        public void RemoveFile(String s)
        {
            Files.Remove(s);
        }
        
    }

}
