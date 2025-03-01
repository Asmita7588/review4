using review4Week;

internal class Program
{
    private static void Main(string[] args)
    {
        ValidateEmailFormat.ValidateEmail("asmita@gmail.com");

         string str = "Extract only ten digit phone number 7588742638 and another num is 9561791389";
        ValidateEmailFormat.ExtractPhoneNum(str);

        ValidateEmailFormat.CheckStrongPassword("Asmita@123");

        ValidateEmailFormat.ExactDateFormat();

        ValidateEmailFormat.ReplaceWhiteSpaces();

        ValidateEmailFormat.CheckFileSize();

        ValidateEmailFormat.CheckPlaindromeString();
        SortingFunction sortingFunction = new SortingFunction();
        List<int> list = new List<int> { 2, 4, 1, 6, 8, 7, 5 };
        sortingFunction.SortList(list);
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        //file operations
        FileOperations.WriteToFile();
        FileOperations.ReadFromFile();
        FileOperations.WriteToJsonFile();

        FileOperations.ReadFromFile();
    }
}