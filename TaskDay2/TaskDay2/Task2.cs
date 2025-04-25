using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDay2
{

    // 2. Client need to build an application to manage data using group of SQL files.
    // a. we need to develop load text and save text functionalities for group of SQL files in the application directory.
    // b. we need a manager class that manages the load and saves the text of group of SQL files along with the SqlFile Class.

    //public abstract class IFile
    //{
    //    public string FilePath { get; set; }
    //    public string FileText { get; set; }
    //    public abstract string LoadText();
    //    public abstract string SaveText();
    //}

    //public class SqlFile: IFile
    //{
    //    public override string LoadText()
    //    {
    //        return $"load {FileText} from sql {FilePath}";
    //    }

    //    public override string SaveText()
    //    {
    //        return "Save Text From sql";
    //    }
    //}

    //public class  FileManager
    //{
    //    private List<IFile> lstFiles { get; set; }

    //    public FileManager(List<IFile> files)
    //    {
    //        lstFiles = files;
    //    }
    //    public string GetTextFromFiles()
    //    {
    //        StringBuilder objStrBuilder = new StringBuilder();
    //        foreach (var objFile in lstFiles)
    //        {
    //            objStrBuilder.Append(objFile.LoadText());
    //        }
    //        return objStrBuilder.ToString();
    //    }
    //    public void SaveTextIntoFiles()
    //    {
    //        foreach (var objFile in lstFiles)
    //        {
    //            objFile.SaveText();
    //        }
    //    }
    //}

    // c. New Requirement:
    // After some time our leaders might tell us that we may have a few read-only files in the application folder, 
    // so we need to restrict the flow whenever it tries to do a save on them.

    //solution for c ,d,e

    public abstract class IFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public abstract string LoadText();

    }
    public interface ISaveText
    {
        string SaveText();
    }
    public class SqlFile:IFile
    {
        public override string LoadText()
        {
            return $"from sql {FileText}";
        }

    }
    public class WriteSqlFile : SqlFile, ISaveText
    {
        public string SaveText()
        {
            return "Save To file";
        }
    }
    public class FileManager
    {
        public string GetTextFromFiles(List<IFile> lstFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in lstFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles(List<ISaveText>lstFiles)
        {
            foreach (var objFile in lstFiles)
            {
                objFile.SaveText();
            }
        }
    }

    // d. To avoid an exception we need to modify "SqlFileManager" by adding one condition to the loop.
    //public abstract class IFile
    //{
    //    public string FilePath { get; set; }
    //    public string FileText { get; set; }
    //    public abstract string LoadText();

    //}
    //public interface ISaveText
    //{
    //    string SaveText();
    //}
    //public class SqlFile : IFile
    //{
    //    public override string LoadText()
    //    {
    //        return $"from sql {FileText}";
    //    }

    //}
    //public class WriteSqlFile : SqlFile, ISaveText
    //{
    //    public string SaveText()
    //    {
    //        return "Save To file";
    //    }
    //}
    //public class FileManager
    //{
    //    public string GetTextFromFiles(List<IFile> lstFiles)
    //    {
    //        StringBuilder objStrBuilder = new StringBuilder();
    //        foreach (var objFile in lstFiles)
    //        {
    //            objStrBuilder.Append(objFile.LoadText());
    //        }
    //        return objStrBuilder.ToString();
    //    }
    //    public void SaveTextIntoFiles(List<ISaveText> lstFiles)
    //    {
    //        foreach (var objFile in lstFiles)
    //        {
    //            objFile.SaveText();
    //        }
    //    }
    //}

    //e. Apply needed refactoring to for better design and mention the current design smells

    //public abstract class IFile
    //{
    //    public string FilePath { get; set; }
    //    public string FileText { get; set; }
    //    public abstract string LoadText();

    //}
    //public interface ISaveText
    //{
    //    string SaveText();
    //}
    //public class SqlFile : IFile
    //{
    //    public override string LoadText()
    //    {
    //        return $"from sql {FileText}";
    //    }

    //}
    //public class WriteSqlFile : SqlFile, ISaveText
    //{
    //    public string SaveText()
    //    {
    //        return "Save To file";
    //    }
    //}
    //public class FileManager
    //{
    //    public string GetTextFromFiles(List<IFile> lstFiles)
    //    {
    //        StringBuilder objStrBuilder = new StringBuilder();
    //        foreach (var objFile in lstFiles)
    //        {
    //            objStrBuilder.Append(objFile.LoadText());
    //        }
    //        return objStrBuilder.ToString();
    //    }
    //    public void SaveTextIntoFiles(List<ISaveText> lstFiles)
    //    {
    //        foreach (var objFile in lstFiles)
    //        {
    //            objFile.SaveText();
    //        }
    //    }
    //}

}
