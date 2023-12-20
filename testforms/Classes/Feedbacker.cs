using Org.BouncyCastle.Crypto.Agreement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kotyk.Classes
{
    public class Feedbacker
    {
        public Feedbacker() { }

        private void PrintMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void CourseIsAlreadyAssignedToGroup(Course course, Group group)
        {
            PrintMessage("Course with ID " + course.ID + " is already assigned to group with ID " + group.ID);
        }

        public void CourseAssignedToGroup(Course course, Group group)
        {
            PrintMessage("Course with ID " + course.ID + " was assigned to group with ID " + group.ID);
        }

        public void FailedToAssignCourseToGroup(Course course, Group group)
        {
            PrintMessage("Failed to assign course with ID " + course.ID + " to group with ID " + group.ID);
        }

        public void GroupAssignedToStudent(Group group, Student student)
        {
            PrintMessage("Group with ID " + group.ID + " was assigned to student with ID " + student.ID);
        }

        public void FailedToAssignGroupToStudent(Group group, Student student)
        {
            PrintMessage("Failed to assign group with ID " + group.ID + " to student with ID " + student.ID);
        }

        public void LecturerAssignedToCourse(Lecturer lecturer, Course course)
        {
            PrintMessage("Lecturer with ID " + lecturer.ID + " was assigned to course with ID " + course.ID);
        }

        public void FailedToAssignLecturerToCourse(Lecturer lecturer, Course course)
        {
            PrintMessage("Failed to assign lecturer with ID " + lecturer.ID + " to course with ID " + course.ID);
        }

        public void StudentGradesWereDeleted(Student student)
        {
            PrintMessage("All grades were deleted for student with ID " + student.ID);
        }

        public void CourseWasDeletedFromGroups(Course course)
        {
            PrintMessage("Course with ID " + course.ID + " was deleted from groups");
        }

        public void GroupCoursesWereDeleted(Group group)
        {
            PrintMessage("All courses were deleted from group with ID " + group.ID);
        }

        public void CourseGradesWereDeleted(Course course)
        {
            PrintMessage("All grades were deleted for course with ID " + course.ID);
        }

        public void WrongCredentials()
        {
            PrintMessage("Wrong credentials!");
        }

        public void NoStudents()
        {
            PrintMessage("There are no students in the system");
        }

        public void NoGroups()
        {
            PrintMessage("There are no groups in the system");
        }

        public void NoLecturers()
        {
            PrintMessage("There are no lecturers in the system");
        }

        public void NoCourses()
        {
            PrintMessage("There are no courses in the system");
        }

        public void DeletingLecturerWithCourses(Lecturer lecturer)
        {
            PrintMessage("Cannot delete lecturer with ID " + lecturer.ID + ". There are courses assigned to him");
        }

        public void DeletingGroupWithStudents(Group group)
        {
            PrintMessage("Cannot delete group with ID " + group.ID + " . There are students assigned to it");
        }

        public void NoCoursesFoundForLecturer()
        {
            PrintMessage("No courses found for this lecturer");
        }

        public void NoGroupsForCourse(Course course)
        {
            PrintMessage("No groups found for course with ID " + course.ID);
        }

        public void NoStudentsFoundForCourse()
        {
            PrintMessage("No students found for this course");
        }

        public void NoCoursesFoundForStudent()
        {
            PrintMessage("There are no courses you are enrolled into");
        }

        public void NoGradeForStudentForCourse(string studentID, string courseID)
        {
            PrintMessage("Student with ID " + studentID + " doesnt have a grade for course with ID " + courseID);
        }

        public void GradeAlreadyExists(string studentID, string courseID)
        {
            PrintMessage("Student with ID " + studentID + " already has grade for course with ID " + courseID);
        }

        public void UsernameForTableIsTaken(string table, string username)
        {
            PrintMessage("'" + username + "' username for " + table + " is already taken");
        }

        public void GroupCodeIsTaken(string code)
        {
            PrintMessage("'" + code + "' group code is already taken");
        }

        public void CourseNameIsTaken(string name)
        {
            PrintMessage("'" + name + "' course name is already taken");
        }

        public void FailedToInsertRecord()
        {
            PrintMessage("Failed to insert record");
        }

        public void FailedToDeleteRecord()
        {
            PrintMessage("Failed to delete record");
        }

        public void FailedToUpdateRecord()
        {
            PrintMessage("Failed to update record");
        }

        public void RecordInserted()
        {
            PrintMessage("Record inserted successfully");
        }

        public void RecordDeleted()
        {
            PrintMessage("Record deleted successfully");
        }

        public void RecordUpdated()
        {
            PrintMessage("Record updated successfully");
        }

        public void NoGradesForCourseAndGroup(Course course, Group group)
        {
            PrintMessage("There are no grades for course with ID " + course.ID + " for group with id " + group.ID);
        }

        public void GradeValidation()
        {
            PrintMessage("Grade must be non-empty integer between 1 and 10");
        }

        public void EnterUsername()
        {
            PrintMessage("Enter username");
        }

        public void EnterName()
        {
            PrintMessage("Enter name");
        }

        public void EnterSurname()
        {
            PrintMessage("Enter surname");
        }

        public void PasswordIsSurname()
        {
            PrintMessage("Surname was set as a password");
        }

        public void EnterCode()
        {
            PrintMessage("Enter code");
        }
    }
}
