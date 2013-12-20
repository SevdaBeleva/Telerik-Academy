using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("Grade must be 0 or positive number!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("Min grade must be 0 or positive number!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Max grade must not be smaller or equal to min grade!");
        }
        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("Comments must not be null or empty!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
