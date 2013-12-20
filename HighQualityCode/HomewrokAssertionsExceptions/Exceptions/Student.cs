using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public IList<Exam> Exams { get; private set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (String.IsNullOrEmpty(firstName))
        {
            throw new ArgumentNullException("first name is missing!");
        }

        if (String.IsNullOrEmpty(lastName))
        {
            throw new ArgumentNullException("last name is missing!");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("Exam list is not defined!");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentException("Exam list is empty.");
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            // Cannot calculate average on missing exams
           throw new ArgumentNullException("Exam value must not be null.");
        }
        if (this.Exams.Count == 0)
        {
            // No exams --> return -1;
            throw new ArgumentException("Exam list is empty. No calculation could be made over missing marks!");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
