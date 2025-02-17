public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        /*Array ar1 = 
            Array.CreateInstance(typeof(float), 5);
            ar1.SetValue(3.14f, 0); //setter method
            float x = (float)ar1.GetValue(0);//getter method
        Array ar2 = 
            Array.CreateInstance(typeof(int), 3, 4);
            ar2.SetValue(99, 0, 0); //setter method
            int y = (int)ar2.GetValue(0, 0);//getter method
        Array ar3 = 
            Array.CreateInstance(typeof(int), 2, 3, 4);
        Array ar4 = 
            Array.CreateInstance(typeof(int), 
                            new int[]{2, 3, 4, 5});
        Array ar5 = 
            Array.CreateInstance(typeof(int), 
                            new int[]{2, 3, 4, 5}, 
                            new int[]{1, 2, 3, 4});
        ar5.SetValue(99, 1, 2, 3, 4);

        Array ar6 = 
            Array.CreateInstance(typeof(int),
                                new int[]{5}, 
                                new int[]{1}
                                );
        for(int i=ar6.GetLowerBound(0); 
                i<=ar6.GetUpperBound(0); i++)
            ar6.SetValue(i*i, i);
        foreach(int val in ar6)
            Console.WriteLine(val);
        */
        /* Bài tập với Array */
        /*
            (1) Sử dụng Collection.Array để tạo một mảng
            số nguyên 10 phần tử với giá trị sinh
            ngẫu nhiên. (2) Sau đó, chia đôi mảng thành
            2 mảng có số phần tử bằng nhau và giữ 
            nguyên chỉ số cho các phần tử của hai 
            mảng. (3) Sau đó, cộng hai mảng lại với 
            nhau theo đúng thứ tự.
        */
        //Hàm main
        int len = 10;
        Array ar = Array.CreateInstance(typeof(int), len);
        createArray(ar);
        foreach(int val in ar)
            Console.WriteLine(val);
        System.Console.WriteLine("-----------");
        Array o1 = Array.CreateInstance(typeof(int), len/2);
        Array o2 = Array.CreateInstance(typeof(int), new int[1]{len/2}, new int[1]{len/2});
        splitArray(ar, o1, o2);
        for(int i = o1.GetLowerBound(0); i<=o1.GetUpperBound(0); i++)
            Console.WriteLine($"o1[{i}] = {o1.GetValue(i)}");
        System.Console.WriteLine("-----------");
        for(int i = o2.GetLowerBound(0); i<=o2.GetUpperBound(0); i++)
            Console.WriteLine($"o2[{i}] = {o2.GetValue(i)}");
        System.Console.WriteLine("-----------");
        Array result = combineArrays(o1, o2);
        foreach(int val in result)
            Console.WriteLine(val);
    }
    static void createArray(Array ar){
        Random r = new Random();
        for(int i=ar.GetLowerBound(0); 
                i<=ar.GetUpperBound(0); i++)
            ar.SetValue(r.Next(100), i);
    }
    static void splitArray(Array input, Array o1, Array o2){
        for (int i = o1.GetLowerBound(0); i<= o1.GetUpperBound(0);i++){
            o1.SetValue(input.GetValue(i),i);
        }
        for (int i = o2.GetLowerBound(0); i<= o2.GetUpperBound(0);i++){
            o2.SetValue(input.GetValue(i),i);
        }
    }
    static Array combineArrays(Array i1, Array i2){
        Array result = Array.CreateInstance(typeof(int), i1.Length);
        for(int i=i1.GetLowerBound(0); 
                i<=i1.GetUpperBound(0); i++)
            result.SetValue((int)i1.GetValue(i) + 
                (int)i2.GetValue(i+i1.GetUpperBound(0)+1), 
                i);
        return result;
    }
    //Yêu cầu bổ sung: Chỉnh sửa các hàm yêu cầu để
    //có thể hoạt động với mảng có số lẻ các phần tử.
    //Với số lẻ các phần tử, khi chia đôi, thì bỏ đi
    //phần tử ở giữa.
}