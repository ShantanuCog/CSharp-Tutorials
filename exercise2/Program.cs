using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Student Grade Management System");
        Console.WriteLine("===============================\n");

        // Sample student data
        List<string> studentNames = new List<string> { "Alex", "Taylor", "Jordan" };
        List<List<int>> studentScores = new List<List<int>> {
            new List<int> {95, 88, 92, 85},
            new List<int> {78, 81, 74, 70},
            new List<int> {62, 67, 69, 64}
        };

        // Create two lists, one for grades and one for averages
        List<char> grades = new List<char>();
        List<double> averages = new List<double>();

        // TODO: Calculate averages and print each student's summary
        for (int i = 0; i < studentScores.Count; i++)
        {
            string studentName = studentNames[i];
            List<int> scores = studentScores[i];

            double average = CalculateAverage(scores); // TODO
            char letterGrade = GetLetterGrade(average); // TODO

            // Add average and grade to the lists
            averages.Add(average);
            grades.Add(letterGrade);

            // TODO: Print student details clearly to the console (name, scores, average, letter grade)
            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine($"Scores: {string.Join(", ", scores)}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Grade: {letterGrade}\n");
        }

        // TODO: Compute and print class statistics:
        // - Compute the class's average
        double classAverage = CalculateAverage(averages);
        Console.WriteLine($"Class Average: {classAverage}");
        // - Highest scoring student
        int highestScore = GetHighestScore(studentScores);
        Console.WriteLine($"Highest Scoring Student: {studentNames[highestScore]}");
        // - Lowest scoring student
        int lowestScore = GetLowestScore(studentScores);
        Console.WriteLine($"Lowest Scoring Student: {studentNames[lowestScore]}");
    }

    // TODO: Method to calculate the average score from a list of integers
    static double CalculateAverage(List<int> scores)
    {
        // Implement calculation here
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        return (double)sum / scores.Count;
    }

    // TODO: Method to determine the letter grade based on average score
    static char GetLetterGrade(double average)
    {
        // Implement logic here
        if (average >= 90) return 'A';
        else if (average >= 80) return 'B';
        else if (average >= 70) return 'C';
        else if (average >= 60) return 'D';
        else return 'F';
    }

    // Optional additional methods for class average, highest, and lowest scores
    // Method for calculating the max and min values in the list
    static double maxValue(List<int> scores)
    {
        double max = scores[0];
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > max)
            {
                max = scores[i];
            }
        }
        return max;
    }
    static double minValue(List<int> scores)
    {
        double min = scores[0];
        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] < min)
            {
                min = scores[i];
            }
        }
        return min;
    }
}