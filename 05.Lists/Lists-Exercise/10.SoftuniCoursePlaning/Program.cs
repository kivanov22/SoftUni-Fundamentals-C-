using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _10.SoftuniCoursePlaning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] cmdArg = input.Split(":").ToArray();// no operation on it thats why no need to make it a list
                string command = cmdArg[0];
                string lessonTitle = cmdArg[1];

                if (command == "Add")
                {
                    if (!courses.Contains(lessonTitle))//true without the ! , but we need if it doesn't exist
                    {
                        courses.Add(lessonTitle);
                    }
                } 
                else if (command == "Insert")//runtime error if index is out of range
                {
                    int index = int.Parse(cmdArg[2]);

                    if (!courses.Contains(lessonTitle))
                    {

                        courses.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    courses.Remove(lessonTitle);
                }
               
                else if (command == "Swap")//from here start
                {
                    string secondLessonTitle = cmdArg[2];
                    int indexOfFirstLesson = courses.IndexOf(lessonTitle);
                    int indexOfSecondLesson = courses.IndexOf(secondLessonTitle);


                    if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)//check if indexes are valid and not off range
                    {
                        courses[indexOfFirstLesson] = secondLessonTitle;
                        courses[indexOfSecondLesson] = lessonTitle;

                        string firstLessonExercise = $"{lessonTitle}-Exercise";
                        int indexOfFirstExercise = indexOfFirstLesson + 1;

                        if (indexOfFirstLesson < courses.Count &&
                            courses[indexOfFirstExercise] == firstLessonExercise)//check valid index and if there is an exercise
                        {
                            courses.RemoveAt(indexOfFirstExercise);//remove index
                            indexOfFirstExercise = courses.IndexOf(lessonTitle);//take index of course
                            courses.Insert(indexOfFirstExercise, firstLessonExercise);//insert after course
                        }
                        string secondLessonExercise = $"{secondLessonTitle}-Exercise";
                        int indexOfSecondExercise = indexOfSecondLesson + 1;

                        if (indexOfSecondExercise < courses.Count &&
                            courses[indexOfSecondExercise] == secondLessonExercise)
                        {
                            courses.RemoveAt(indexOfSecondLesson + 1);//remove index
                            indexOfSecondExercise = courses.IndexOf(secondLessonTitle);//take index of course
                            courses.Insert(indexOfSecondExercise + 1, secondLessonExercise);//insert after course
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    int index = courses.IndexOf(lessonTitle);
                    string exercise = $"{lessonTitle}-Exercise";
                    bool isThereALesson = courses.Contains(lessonTitle);
                    bool isThereAExercise = courses.Contains(exercise);

                    if (isThereALesson && !isThereAExercise)
                    {
                        courses.Insert(index + 1, exercise);
                    }
                    else if (!isThereALesson)
                    {
                        courses.Add(lessonTitle);
                        courses.Add(exercise);
                    }
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
