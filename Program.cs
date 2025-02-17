﻿public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Array ar1 = 
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
        Array ar = Array.CreateInstance(typeof(int), 10);
        createArray(ar);
        foreach(int val in ar)
            Console.WriteLine(val);
    }
    static void createArray(Array ar){
        Random r = new Random();
        for(int i=ar.GetLowerBound(0); 
                i<=ar.GetUpperBound(0); i++)
            ar.SetValue(r.Next(100), i);
    }
    static void splitArray(Array input, Array o1, Array o2){

    }
    static Array combineArrays(Array i1, Array i2){
        return null;
    }
}