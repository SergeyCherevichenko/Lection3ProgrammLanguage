namespace lection3;
class Program
{
    static void Main(string[] args)
    {
        void task1()
        {
            //=====Работа с текстом
            // Дан текст. В тексте нужно все пробелы заменить чёрточками,
            // маленькие буквы “к” заменить большими “К”,
            // а большие “С” маленькими “с”.
            // Ясна ли задача?

            string text = "— Я думаю, — сказал князь, улыбаясь, — что," +
                           "ежели бы вас послали вместо нашего милого Винценгероде," +
                           "вы бы взяли приступом согласие прусского короля." +
                           "Вы так красноречивы.Вы дадите мне чаю?";


            string modifiedText(string text, char OldValue, char newValue)
            {

                string modifiedText = string.Empty;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == OldValue)
                    {
                        modifiedText = modifiedText + $"{newValue}";
                    }
                    else
                    {
                        modifiedText = modifiedText + text[i];
                    }
                }
                return modifiedText;
            }
            string newString = modifiedText(text, ' ', '|');
            newString = modifiedText(newString, 'к', 'К');
            newString = modifiedText(newString, 'С', 'с');
            Console.WriteLine(newString);

        }

        void task2()
        {
            void PrintArray(int[] array)
            {
                for(int i = 0;i < array.Length ; i++)
                {
                    Console.Write (array[i] + " ");
                }
            }
           
             int [] SortArray(  int[] array)

            {
            int[] array1 = new int[] { 1, 8, 0, -14, 76, 3, -10 };
            for (int i = 0; i < array.Length - 1; i++)

            {
                int minPosition = i;
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[minPosition] > array[j]) minPosition = j;
                }
                int temporary = array[i]; 
                array[i] = array[minPosition];
                array[minPosition] = temporary;

            }
            return array;
        }
            
            int[] array  = new int[]{12,-67,123,-3,0,10,10,15,123};
            PrintArray(array);
            SortArray(array);
            Console.WriteLine();
            PrintArray(array);

    }

    Console.Clear();
        task2();
}
}
