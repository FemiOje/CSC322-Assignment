using System;

/// <summary>
/// Represents a university student.
/// </summary>
public class Student
{
    /// <summary>
    /// Gets or sets the name of the student.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the student's matriculation number.
    /// </summary>
    public int MatricNumber { get; set; }

    /// <summary>
    /// Gets or sets the student's contact address.
    /// </summary>
    public string ContactAddress { get; set; }

    /// <summary>
    /// Gets or sets the student's phone number.
    /// </summary>
    public int PhoneNumber { get; set; }

    /// <summary>
    /// Enrolls the student in a course.
    /// </summary>
    /// <param name="matricNumber">The student's matriculation number.</param>
    /// <param name="courseCode">The course code.</param>
    /// <returns>True if the student is successfully enrolled, otherwise false.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="courseCode"/> is null or empty.</exception>
    public bool RegisterCourse(int matricNumber, int courseCode)
    {
        if (string.IsNullOrEmpty(courseCode))
        {
            throw new ArgumentException("Course code cannot be null or empty.", nameof(courseCode));
        }

        return true; // Enroll successful
    }

    /// <summary>
    /// Removes a course from the student's course form.
    /// </summary>
    /// <param name="matricNumber">The student's matriculation number.</param>
    /// <param name="courseCode">The course code.</param>
    /// <returns>True if the course is successfully removed, otherwise false.</returns>
    /// <exception cref="ArgumentException">Thrown when <paramref name="courseCode"/> is null or empty.</exception>
    public bool RemoveCourse(int matricNumber, int courseCode)
    {
        if (string.IsNullOrEmpty(courseCode))
        {
            throw new ArgumentException("Course code cannot be null or empty.", nameof(courseCode));
        }

        return true; // Removal successful
    }


    /// <summary>
    /// Updates the student's contact address
    /// </summary>
    /// <param name="matricNumber">The student's matriculation number.</param>
    /// <param name="newAddress">The new address.</param>
    /// <returns>The new contact address</returns>
    private int UpdateContactAddress(int matricNumber, string newAddress)
    {
        ContactAddress = newAddress;
        return ContactAddress;
    }


    /// <summary>
    /// Updates the student's phone number
    /// </summary>
    /// <param name="matricNumber">The student's matriculation number.</param>
    /// <param name="phoneNumber">The student's phone number.</param>
    /// <returns>The new phone number</returns>
    private int UpdatePhoneNumber(int matricNumber, int phoneNumber)
    {
        PhoneNumber = phoneNumber;
        return PhoneNumber;
    }
}
