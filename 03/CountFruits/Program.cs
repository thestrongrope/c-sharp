// countApplesAndOranges(7, 11, 5, 15, new List<int> {-2, 2, 1} , new List<int> {5, -6});
countApplesAndOranges(7, 10, 4, 12, new List<int> {2, 3, -4} , new List<int> {3, -2, -4});

// Apples 3
// Oranges 2
countApplesAndOranges(10, 20, 5, 25, new List<int> {5, 3, -1, 10, 20, 9} , new List<int> {-5, -10, 10, -20});

/*

    -100 ------------------------------ 0 --A------=========--------B----- 100

*/

// DRY => Do not Repeat Yourself
// Loops & Functions

static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges) {
    int totalApples = countFruits(s, t, a, apples);
    int totalOranges = countFruits(s, t, b, oranges);
    Console.WriteLine(totalApples);
    Console.WriteLine(totalOranges);
}

static int countFruits(int houseStart, int houseEnd, int treePosition, List<int> relativePositions) {
    int totalFruitsInHouse = 0;
    foreach(int relativePosition in relativePositions) {
        int position = treePosition + relativePosition;
        if(position >= houseStart && position <= houseEnd) {
            totalFruitsInHouse++;
        }
    }
    return totalFruitsInHouse;
}

