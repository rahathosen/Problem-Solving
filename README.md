# Problem-Solving
##### Problem-Solving

# Format
```c#
            var t = int.Parse(Console.ReadLine());  //input size(tast size)
            
            var nStr = Console.ReadLine();      //take the whole line input as a string
            var splt_nStr = nStr.Split(' ');  //splitted the line stored in a string array
            
            var nInt = new int[t];     // create input array will store integer

            for (int i = 0; i < t; i++)
            {
                nInt[i] = int.Parse(splt_nStr[i]); //converted each elements of the string array to int
            }
```
