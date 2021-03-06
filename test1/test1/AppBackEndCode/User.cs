/*! \file User.cs
 *  \brief A file containing the User Class -created by Brianna Kicia
 * */
namespace test1
{
	/*! \class User
	 *  \brief User 
	 *  
	 *  Provides the class for the people using the application
	 * 
	 */

	public class User
	{
		/**Variables that hold the user's information**/
		private string username, /**< The username */
					   password; /**< The user's password */
		private string[] settings; /**< The user's preferred system settings */
					
		/** A constructor.
		* @param username is the value that will set the internal username
		* @param password is the value that will set the internal password
		**/
		User(string username, string password){
			updateUsername(username);
			updatePassword(password);
		}

		User(){
			updateUsername(string.Empty);
			updatePassword(string.Empty);
		}

		/**A function that takes no arguments and returns the username and password.
			@return The username, password, and other user information
			*/
		string[] getInfo(){
			return new string[5 /*number of settings plus 2*/]; //return username and password appended to the user info array
		}

		/**A function that updates the internal login username
		* @param username is the value that will set the internal username
		**/
		void updateUsername(string username){
			this.username = username;
		}

		/**A function that updates the internal login password
		* @param password is the value that will set the internal password
		**/
		void updatePassword(string password){
			this.password = password;
		}

		/**A function that updates the internal user settings
		* @param settings is the array that will be the user's settings
		**/
		void updateSettings(string[] settings){
			this.settings = settings;
		}

		/**A function that returns the username
		 * @return username
		 * */
		string getUsername(){
			return this.username;
		}

		/**A function that returns the user's password
		 * @return password
		 * */
		string getPassword(){
			return this.password;
		}

		/**A function that returns the user's settings
		 * @return settings
		 * */
		string[] getSettings(){
			return this.settings;
		}

		/**A function that creates a new user in the database.
		 * */
		bool createUser(){
			return true;
		}

		/**A function that updates the user's information
		 * on the database.
		 * */
		bool updateUser(){
			return true;
		}

	}
}
