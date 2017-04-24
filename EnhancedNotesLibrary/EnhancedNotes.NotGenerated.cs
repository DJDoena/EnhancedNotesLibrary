using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs EnhancedNotes.xsd /n:DoenaSoft.DVDProfiler.EnhancedNotes

namespace DoenaSoft.DVDProfiler.EnhancedNotes
{
    public sealed partial class EnhancedNotesList
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(EnhancedNotesList));
                }

                return (s_XmlSerializer);
            }
        }

        public static EnhancedNotesList Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                EnhancedNotesList instance = (EnhancedNotesList)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(EnhancedNotesList instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class EnhancedNotes
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(EnhancedNotes));
                }

                return (s_XmlSerializer);
            }
        }

        public static EnhancedNotes Deserialize(String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                EnhancedNotes instance = (EnhancedNotes)(XmlSerializer.Deserialize(fs));

                return (instance);
            }
        }

        public static void Serialize(EnhancedNotes instance
            , String fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(this, fileName);
        }
    }
}