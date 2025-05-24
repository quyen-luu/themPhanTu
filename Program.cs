public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu mang: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Hay nhap tung phan tu cua mang: ");

        //them phan tu
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Phan tu: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        //in mang ra man hinh
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] + "; ");
        }

        //phan tu can chen
        Console.Write("Nhap phan tu can chen: ");
        int newvalue = Convert.ToInt32(Console.ReadLine());

        //vi tri can chen
        Console.Write("Nhap vi tri can chen: ");
        int pos = Convert.ToInt32(Console.ReadLine());

        //khai bao mang moi
        int[] newArray = new int[n + 1];

        //nua dau cua mang newArray
        for (int i = 0; i < pos; i++)
        {
            newArray[i] = array[i];
        }

        //gan phan tu newValue vao vi tri pos cua mang moi
        newArray[pos] = newvalue;

        //nua sau cua mang moi
        for (int i = pos; i < n; i++)
        {
            newArray[i + 1] = array[i];
        }

        //hien thi mang ra man hinh
        foreach (int item in newArray)
        {
            Console.Write(item + "; ");
        }
    }
}