// countApplesAndOranges(7, 11, 5, 15, new List<int> {-2, 2, 1} , new List<int> {5, -6});
countApplesAndOranges(7, 10, 4, 12, new List<int> {2, 3, -4} , new List<int> {3, -2, -4});

// Apples 3
// Oranges 2
countApplesAndOranges(10, 20, 5, 25, new List<int> {5, 3, -1, 10, 20, 9} , new List<int> {-5, -10, 10, -20});

/*

    -100 ------------------------------ 0 --A------=========--------B----- 100

*/

static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges) {
    int totalApplesInHouse = 0;
    int totalOrangesInHouse = 0;

    foreach(int applePosition in apples) {
        int positionOfApple = a + applePosition;
        if(positionOfApple >= s && positionOfApple <= t) {
            totalApplesInHouse++;
        }
    }

    foreach(int orangePosition in oranges) {
        int positionOfOrange = b + orangePosition;
        if(positionOfOrange >= s && positionOfOrange <= t) {
            totalOrangesInHouse++;
        }
    }    

    Console.WriteLine($"Apples: {totalApplesInHouse}, Oranges: {totalOrangesInHouse}");
}

