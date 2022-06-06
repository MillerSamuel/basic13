int[] arraytest={2,3,10};

static void PrintNumbers()
{
    for (int i=1;i<=255;i++){
        Console.WriteLine(i);
    }
}
// PrintNumbers();

static void PrintOdds()
{
    for (int i=1;i<=255;i++){
        if(i%2==1){
        Console.WriteLine(i);
        }
    }
}
// PrintOdds();

static void PrintSum()
{
    int sum=0;
    for (int i=1;i<=255;i++){
        sum+=i;
        Console.WriteLine("Num-"+i+" Sum-"+sum);
    }
}
// PrintSum();

static void LoopArray(int[] numbers)
{
    for(int i=0;i<numbers.Length;i++){
        Console.WriteLine(numbers[i]);
    }
}
// LoopArray(arraytest);

static int FindMax(int[] numbers)
{
    int max=numbers[0];
    for(int i=0;i<numbers.Length;i++){
        if(numbers[i]>max){
            max=numbers[i];
        }
    }
    return max;
}
// Console.WriteLine(FindMax(arraytest));


static void GetAverage(int[] numbers)
{
    int sum=0;
    for (int i=0;i<numbers.Length;i++){
        sum+=numbers[i];
    }
    Console.WriteLine(sum/numbers.Length);
}
// GetAverage(arraytest);


static int[] OddArray()
{
    int[] arr=new int[128];
    int num=1;
    for(int i=0;i<128;i++){
        arr[i]=num;
        num+=2;
    }
    return arr;
}
// foreach (var num in OddArray()){
//     Console.WriteLine(num);
// }



static int GreaterThanY(int[] numbers, int y)
{
    int count=0;
    foreach(var num in numbers){
        if(y<num){
            count++;
        }
    }
    return count;
}

// Console.WriteLine(GreaterThanY(arraytest,2));



static void SquareArrayValues(int[] numbers)
{
    for (int i=0;i<numbers.Length;i++){
        numbers[i]*=numbers[i];
        Console.WriteLine(numbers[i]);
    }
}
// SquareArrayValues(arraytest);



static void EliminateNegatives(int[] numbers)
{
    for (int i=0;i<numbers.Length;i++){
        if(numbers[i]<0){
            numbers[i]=0;
        }
        Console.WriteLine(numbers[i]);
    }
}
// EliminateNegatives(arraytest);



static void MinMaxAverage(int[] numbers)
{
    int max=numbers[0];
    int min=numbers[0];
    int sum=0;
    for (int i=0;i<numbers.Length;i++){
        if(numbers[i]>max){
            max=numbers[i];
        }
        if(numbers[i]<min){
            max=numbers[i];
        }
        sum+=numbers[i];
    }
    Console.WriteLine("Max="+max+" Min="+min);
    Console.WriteLine("Avg="+(sum/numbers.Length));
}
// MinMaxAverage(arraytest);


static void ShiftValues(int[] numbers)
{
    for (int i=0;i<numbers.Length-1;i++){
        numbers[i]=numbers[i+1];
    }
    numbers[numbers.Length-1]=0;
}
// ShiftValues(arraytest);


static object[] NumToString(int[] numbers)
{
    object[] newarr=new object[numbers.Length];
    for (int i=0;i<numbers.Length;i++){
        if(numbers[i]<0){
            newarr[i]="Dojo";
        }
        else{
            newarr[i]=numbers[i];
        }
    }
    return newarr;
}
// object[] newarr=NumToString(arraytest);
// foreach(var obj in newarr){
//     Console.WriteLine(obj);
// }


