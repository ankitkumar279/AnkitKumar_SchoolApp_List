# AnkitKumar_SchoolApp

This is a simple ASP.NET Core MVC and Web API project for managing Teachers data from a School database.  

## What this project does

- Connects to a MySQL school database
- Shows a list of teachers
- Shows detailed information about each teacher
- Provides API endpoints to get all teachers or a teacher by ID

## How to run

1. Make sure you have MySQL running with the `school` database imported.
2. Update the connection string in `appsettings.json` to match your MySQL server settings.
3. Open the project in Visual Studio.
4. Build and run the project.
5. Use the web pages or API endpoints:
   - Web: `/TeacherPage/List` to see all teachers.
   - Web: `/TeacherPage/Show/{id}` to see a teacher's details.
   - API: `/api/teacher` to get all teachers in JSON.
   - API: `/api/teacher/{id}` to get a teacher by ID in JSON.

## Project Structure

- **Models**: Contains Teacher model and database context.
- **Controllers**: Contains MVC controller for web pages and API controller for REST API.
- **Views**: Razor views for displaying teacher data.

## Testing

- Used Postman and browser to test API and web pages.

---

Thank you!  
Ankit Kumar  
