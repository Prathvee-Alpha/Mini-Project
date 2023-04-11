# Mini-Project
UID and CT lab assignment.








using System.Data.SqlClient;

// Create a connection to the database
string connectionString = "Data Source=YourDataSource;Initial Catalog=YourDatabase;Integrated Security=True";
SqlConnection connection = new SqlConnection(connectionString);

// Open the connection to the database
connection.Open();

// Create a SqlCommand object to execute a query on the database
string query = "SELECT COUNT(*) FROM YourTable WHERE Username = @Username";
SqlCommand command = new SqlCommand(query, connection);

// Add a parameter to the SqlCommand object
string username = txtUsername.Text; // Replace txtUsername with the name of your textbox
command.Parameters.AddWithValue("@Username", username);

// Execute the query and get the result as an integer
int count = (int) command.ExecuteScalar();

// Check if the username exists in the database
if (count > 0)
{
    // The username exists in the database, so allow access
    // Replace this line with your code to authenticate the user
}
else
{
    // The username does not exist in the database, so deny access
    // Replace this line with your code to handle incorrect usernames
}

// Close the connection to the database
connection.Close();
