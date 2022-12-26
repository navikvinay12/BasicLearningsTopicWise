
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace Testing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** File Handling Basics ***");
            string path = @"D:\\FileIODemo\tpData.txt";       //@=Verbatim Literal
            if (File.Exists(path))   //if file exists or not returns true or false .
            {
                Console.WriteLine("File found");
            }
            else
            {
                Console.WriteLine("File not found ");
            }

            //-------------Reading Text from a file
            string path = @"D:\\FileIODemo\tpData.txt";
            if (File.Exists(path))   //if file exists or not returns true or false .
            {
                Console.WriteLine("File found");
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("File not found ");
            }

            //----------------Copying file 
            string path = @"D:\\FileIODemo\tpData.txt";
            string path2 = @"D:\\FileIODemo\tpData1.txt";   //this file name is not present but after executing it will be available .
            File.Copy(path, path2);   //Doesnt override if path2 is already present in the folder ,it will throw exception.

            //---------------Copying file with overriding .
            string path = @"D:\\FileIODemo\tpData.txt";
            string path2 = @"D:\\FileIODemo\tpData1.txt";   
            File.Copy(path, path2,true);    //existing file will get overriden and exception will not occur but previus data will wipe out .

            //-------------DirectoryInfo Operations - Creating Directory and SubDirectory
            string path = @"D:\\FileIODemo\NewDirectory";    //New Folder Creating ~ it is unavailble right now ,post executing it will get avail.
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo.Create(); //Can override , will not throw exception even if folder is already there ,so can run this program multiple times. 
            Console.WriteLine("Directory Created .");
            directoryInfo.CreateSubdirectory("NewSubDirectory");
            Console.WriteLine("Another Directory named - SubDirectory Created");

            //-------------Directory MoveTo
            string path = @"D:\\FileIODemo\NewDirectory";
            string path2 = @"D:\\FileIODemo\NewDirectoryForMoving";  //Post execution it will get created.
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo.MoveTo(path2);
            //All files within the NewDirectory will be moved in the NewDirectoryForMoving (which will be newly created)
            //and NewDirectory folder will be deleted .

            //--------------Delete (directory or subdirectory )
            string path = @"D:\\FileIODemo\NewDirectory";
            string path2 = @"D:\\FileIODemo\NewDirectoryForMoving";  //Post execution it will get created.
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            directoryInfo.Delete(); //to delete empty directory only 
            directoryInfo.Delete(true); //to delete directory even if it contains any files/contents.
            Console.WriteLine("Deleted Directory.");

            //--------------GetDirectories (all subdirectory shows)
            string path = @"D:\FileIODemo\new";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            foreach(var item in dirs)
            {
                Console.WriteLine(item);
            }

            //-------------GetFIles -used to get files in the specified folder .
            string path = @"D:\FileIODemo\new";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            foreach (var item in dirs)
            {
                Console.WriteLine(item.GetFiles().Length);  //no of files present in the given folder path .
            }
            //-----------------Some Methods of DirectoryInfo class in File Handing . 
            string path = @"D:\FileIODemo\new\new1";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine(directoryInfo.Name);      //Name ~pathName
            Console.WriteLine(directoryInfo.FullName);      //FullName    ~ fullPath
            Console.WriteLine(directoryInfo.LastAccessTime);        //Last accessed time
            Console.WriteLine(directoryInfo.CreationTime);  //when it was created .
            Console.WriteLine(directoryInfo.Attributes);    //what type is it -whether file or directory.
            Console.WriteLine(directoryInfo.Parent);    //parent directory .~ PWD
            Console.WriteLine(directoryInfo.Root);      //main directory C or D drive. 
            Console.WriteLine(directoryInfo.LastWriteTime); //almost similar to last accessed time .
            //--------------File Stream--------System.IO namespace 
            string path = @"D:\FileIODemo\one.txt";         //@=Verbatim literal
            //override (existing data lost because new file will be creating everytime)
            //using keyword helps to open the file and close the file as the curly brackets makes file opened or close .
            //FileMode.Append to append.
            //FileMode.CreateNew to create new file ,but if already file exists than throws IOException.
            //FileMode.Truncate  to delete only the available contents present inside the file,doesnt deletes file.
            using (FileStream file = new FileStream(path, FileMode.Append,FileAccess.Write)) 
            {
                file.WriteByte(65); //A will be written in the file .B=66 ,a=97,b=98 ,ascii ...
                file.WriteByte(66); //B
                Console.WriteLine("File Created");
            }
            string path = @"D:\FileIODemo\one.txt";
            using(FileStream file=new FileStream(path,FileMode.Append,FileAccess.Write))
            {
                string data = "Learning never ends";    //writing more than a char.
                Byte[] write_data = Encoding.UTF8.GetBytes(data);   //storing in an array bcoz the data is not just a char.
                file.Write(write_data, 0, write_data.Length);   //using Write() to write the given data into file .
            }
            //++++++++++++++++++++++++++++++++++++++++++
            //first time - FileMode.OpenOrCreate , Next time we can FileMode.Append .
            string path = @"D:\FileIODemo\one.txt";
            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))//creating file and than writing
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("Statement no 1");//note use of Write and WriteLine()
                    writer.Write("Statement no 2");
                    writer.WriteLine("Statement no 3");
                    int[] arr = { 11, 22, 33, 44, 55 };
                    char[] arr2 = { 'A', 'B', 'C', 'D' };
                    foreach (var item in arr2)
                    {
                        writer.WriteLine(item + " ");
                    }
                }
            }
        }
    }
}