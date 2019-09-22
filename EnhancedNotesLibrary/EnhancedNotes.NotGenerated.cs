using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// xsd.exe /c /l:cs /f /n:DoenaSoft.DVDProfiler.EnhancedNotes EnhancedNotes.xsd

namespace DoenaSoft.DVDProfiler.EnhancedNotes
{
    public sealed partial class EnhancedNotesList
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(EnhancedNotesList));
                }

                return _xmlSerializer;
            }
        }

        public static EnhancedNotesList Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (EnhancedNotesList)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(EnhancedNotesList instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }

    public sealed partial class EnhancedNotes
    {
        private static XmlSerializer _xmlSerializer;

        [XmlIgnore]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if (_xmlSerializer == null)
                {
                    _xmlSerializer = new XmlSerializer(typeof(EnhancedNotes));
                }

                return _xmlSerializer;
            }
        }

        public static EnhancedNotes Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var instance = (EnhancedNotes)(XmlSerializer.Deserialize(fs));

                return instance;
            }
        }

        public static void Serialize(EnhancedNotes instance, string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                using (var xtw = new XmlTextWriter(fs, Encoding.UTF8))
                {
                    xtw.Formatting = Formatting.Indented;

                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(string fileName)
        {
            Serialize(this, fileName);
        }
    }
}