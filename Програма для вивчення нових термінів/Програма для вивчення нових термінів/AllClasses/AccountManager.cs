using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Json = System.Runtime.Serialization.Json.DataContractJsonSerializer;

namespace Програма_для_вивчення_нових_термінів
{
    internal class AccountManager
    {
        private const string accountsFilePath = "accounts.json";
        private List<User> users;

        public AccountManager()
        {
            LoadAccounts();
        }

        public bool SignUp(string userName, DateTime dateOfBirth, string email, string password)
        {
            if (users.Exists(user => user.UserName == userName))
            {
                AppContext.ShowMessage("User with this username already exists.", "Error", MessageType.Error);
                return false;
            }

            User newUser = new User(userName, dateOfBirth, email, password);

            users.Add(newUser);
            SaveAccounts();

            AppContext.ShowMessage("Account successfully created.", "Success", MessageType.Success);
            return true;
        }

        public bool DoesExistName(string name)
        {
            if (users.Exists(user => user.UserName == name))
                return true;
            return false;
        }

        public User SignIn(string userName, string password)
        {
            if (users == null) 
            {
                AppContext.ShowMessage("Incorrect username or password.", "Error", MessageType.Error);
                return null;
            }
            
            else
            {
                User user = users.Find(u => u.UserName == userName && u.Password == password);

                if (user != null)
                {
                    AppContext.ShowMessage("You have successfully signed in to your account.", "Success", MessageType.Success);
                    return user;
                }
                else
                {
                    AppContext.ShowMessage("Incorrect username or password.", "Error", MessageType.Error);
                    return null;
                }             
            }
        }

        public void DeleteCurrentUser()
        {
            User current = AppContext.Instance.CurrentUser;

            if (current != null)
            {
                int index = users.FindIndex(u => u.UserName == current.UserName);

                if (index != -1)
                {
                    users.RemoveAt(index);
                    SaveAccounts();
                    AppContext.ShowMessage("Account successfully deleted.", "Success", MessageType.Success);
                }
                else
                {
                    AppContext.ShowMessage("Current user not found in the account list.", "Error", MessageType.Error);
                }
            }
            else
            {
                AppContext.ShowMessage("No current user logged in.", "Error", MessageType.Error);
            }
        }


        private void LoadAccounts()
        {
            try
            {
                if (File.Exists(accountsFilePath) && new FileInfo(accountsFilePath).Length > 0)
                {
                    try
                    {
                        Json jsonFormatter = new Json(typeof(List<User>));
                        
                        using (FileStream fs = new FileStream(accountsFilePath, FileMode.Open))
                        {
                            users = (List<User>)jsonFormatter.ReadObject(fs);
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        AppContext.ShowMessage("File not found", "Error", MessageType.Error);
                    }
                    catch (Exception ex)
                    {
                        AppContext.ShowMessage($"An error occurred while reading from the file: {ex.Message}", "Error", MessageType.Error);
                    }
                }
                else
                {
                    if (File.Exists(accountsFilePath)) File.Delete(accountsFilePath);
                    users = new List<User>();
                }
            }
            catch (Exception ex)
            {
                AppContext.ShowMessage($"Error loading accounts: {ex.Message}", "Error", MessageType.Error);
            }

        }

        private void SaveAccounts()
        {
            try
            {
                Json jsonFormatter = new Json(typeof(List<User>));
                using (FileStream fs = new FileStream(accountsFilePath, FileMode.Create))
                {
                    jsonFormatter.WriteObject(fs, users);
                }
            }

            catch (Exception ex)
            {
                AppContext.ShowMessage($"Error loading accounts: {ex.Message}", "Error", MessageType.Error);
            }
        }

         public void UpdateUser(User updateUser, string previousName)
        {
            User existingUser = users.Find(u => u.UserName == previousName);
            if (existingUser != null)
            {
                users.Remove(existingUser);
                users.Add(updateUser);
                SaveAccounts();
            }
            else
            {
                AppContext.ShowMessage("User not found.", "Error", MessageType.Error);
            }
        }
    }
}
