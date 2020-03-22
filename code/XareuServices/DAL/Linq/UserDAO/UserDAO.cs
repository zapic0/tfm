using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XareuServices.DAL.Linq.UserDAO
{
    /// <summary>
    /// Class of User data access
    /// </summary>
    public class UserDAO : IUserDAO
    {
        XareuDataClassesDataContext data;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDAO"/> class.
        /// </summary>
        public UserDAO()
        {
            data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
        }

        #region IUserDAO Members

        /// <summary>
        /// Devuelve el usuario que tenga el id indicado
        /// </summary>
        /// <param name="id">Id del usuario a buscar</param>
        /// <returns>
        /// Usuario que tenga el id indicado, null si no existe
        /// </returns>
        public XareuServices.Model.User.User GetUserById(long id)
        {
            var query = from users in data.users
                        where users.user_id == id
                        select users;

            try
            {
                data.Connection.Open();
                return this.getUser(query.First<user>());
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Añade un nuevo usuario a la base de datos
        /// </summary>
        /// <param name="user">Datos del usuario a añadir</param>
        /// <param name="userID"></param>
        /// <returns>
        /// True si se pudo añadir, false en caso contrario
        /// </returns>
        public bool AddNewUser(XareuServices.Model.User.User user, out long userID)
        {
            userID = 0;
            try
            {
                data.Connection.Open();
                Linq.user newUser = this.convertToUser(user);
                data.users.InsertOnSubmit(newUser);
                
                data.SubmitChanges();

                userID = this.getLastInsertedUserID();
                return true;
            }
            catch
            {
                data = new XareuDataClassesDataContext(Util.Configuration.GetConnectionString());
                return false;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Borra un usuario existente
        /// </summary>
        /// <param name="user">Usuario que queremos borrar</param>
        /// <returns>
        /// True si se pudo borrar, false en caso contrario
        /// </returns>
        public bool DeleteUser(XareuServices.Model.User.User user)
        {
            var query = from users in data.users
                        where users.user_nick == user.Nick
                        where users.user_id == user.Id
                        select users;

            try
            {
                data.Connection.Open();
                data.users.DeleteOnSubmit(query.First<user>());
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Devuelve el usuario que tenga el nombre indicado
        /// </summary>
        /// <param name="name">Nombre del usuario a buscar</param>
        /// <returns>
        /// Usuario que tenga el nombre indicado, null si no existe
        /// </returns>
        public XareuServices.Model.User.User GetUserByName(string name)
        {
            var query = from users in data.users
                        where users.user_nick == name
                        select users;

            try
            {
                data.Connection.Open();
                return this.getUser(query.First<user>());
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Edita los valores de un usuario determinado sustituyéndolos por los valores recibidos
        /// </summary>
        /// <param name="user">Valores del usuario que queremos guardar</param>
        /// <returns>
        /// True si se pudieron llevar a cabo los cambios, false en caso contrario
        /// </returns>
        public bool EditUser(XareuServices.Model.User.User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Devuelve todos los usuarios registrados.
        /// Se especifican el número de resultados por página y la página que queremos recibir.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <returns>
        /// Usuarios registrados, null si no existe ninguno
        /// </returns>
        public List<XareuServices.Model.User.User> GetRegisteredUsers(int number, int page)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();

            try
            {
                data.Connection.Open();

                var query = (from users in data.users
                             select users).Skip<user>(number * page).Take<user>(number);

                foreach (user newUser in query)
                {
                    usersList.Add(this.getUser(newUser));
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
            return usersList;
        }

        /// <summary>
        /// Devuelve todos los usuarios que coincidan con el nombre a buscar.
        /// Pueden ser usuarios con nombres similares, que contengan la cadena...
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="name">Nombre a buscar</param>
        /// <returns>
        /// Usuarios que coinciden con la búsqueda, null si no existen
        /// </returns>
        public List<XareuServices.Model.User.User> SearchUsersByName(int number, int page, string name)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();

            try
            {
                data.Connection.Open();

                var query = (from users in data.users
                             where users.user_nick.Contains(name)
                             select users).Skip<user>(number * page).Take<user>(number);

                foreach (user newUser in query)
                {
                    usersList.Add(this.getUser(newUser));
                }
            }
            catch(Exception ex)
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
            return usersList;
        }

        /// <summary>
        /// Devuelve todos los usuarios con el karma especificado.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="karma">Karma a buscar</param>
        /// <returns>
        /// Usuarios que coinciden con el karma especificado, null si no existen
        /// </returns>
        public List<XareuServices.Model.User.User> SearchUsersByKarma(int number, int page, float karma)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();

            
            try
            {
                data.Connection.Open();

                var query = (from users in data.users
                             where users.user_karma == karma
                             select users).Skip<user>(number * page).Take<user>(number);

                foreach (user newUser in query)
                {
                    usersList.Add(this.getUser(newUser));
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
            return usersList;
        }

        /// <summary>
        /// Busca usuarios por su dirección de correo.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="email">Email a buscar</param>
        /// <returns>
        /// Usuarios que coinciden con la dirección, null si no existen
        /// </returns>
        public List<XareuServices.Model.User.User> SearchUsersByEmail(int number, int page, string email)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();

            try
            {
                data.Connection.Open();

                var query = (from users in data.users
                             where users.user_email.Contains(email)
                             select users).Skip<user>(number * page).Take<user>(number);

                foreach (user newUser in query)
                {
                    usersList.Add(this.getUser(newUser));
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
            return usersList;
        }

        /// <summary>
        /// Busca usuarios por su etiqueta de lugar por defecto.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="tagPlaceId">Id de la etiqueta de lugar</param>
        /// <returns>
        /// Usuarios que tienen esa etiqueta de lugar establecida
        /// </returns>
        public List<XareuServices.Model.User.User> SearchUsersByTagPlace(int number, int page, long tagPlaceId)
        {
            List<Model.User.User> usersList = new List<XareuServices.Model.User.User>();
            
            try
            {
                data.Connection.Open();

                var query = (from users in data.users
                             where users.user_default_place == tagPlaceId
                             select users).Skip<user>(number * page).Take<user>(number);

                foreach (user newUser in query)
                {
                    usersList.Add(this.getUser(newUser));
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
            return usersList;
        }

        #endregion

        /// <summary>
        /// Gets the last inserted user ID.
        /// </summary>
        /// <returns></returns>
        private long getLastInsertedUserID()
        {
            try
            {
                data.Connection.Open();
            }
            catch { }
            try
            {
                IEnumerable<user> query = from users in data.users
                                          select users;

                return query.Last<user>().user_id;
            }
            catch
            {
                return 1;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        private Model.User.User getUser(user user)
        {
            Model.User.User newUser = new XareuServices.Model.User.User();

            newUser.DefaultPlace.Id = user.user_default_place;
            newUser.Email = user.user_email;
            newUser.Id = user.user_id;
            newUser.Karma = user.user_karma;
            newUser.Nick = user.user_nick;
            newUser.IsPrivate = user.user_is_private;
            newUser.IsAdmin = user.user_is_admin;
            newUser.SignUp = user.user_signup;
            newUser.DefaultPlace.Id = user.place_tag.place_tag_id;
            newUser.DefaultPlace.Name = user.place_tag.place_tag_name;
            newUser.UserPictureURL = user.user_picture;
            try
            {
                newUser.DefaultPlace.ParentId = (long)user.place_tag.place_tag_parent;
            }
            catch
            {
                newUser.DefaultPlace.ParentId = 0;
            }
            return newUser;
        }

        /// <summary>
        /// Converts to user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        private user convertToUser(Model.User.User user)
        {
            Linq.user newUser = new user();

            newUser.user_default_place = user.DefaultPlace.Id;
            newUser.user_email = user.Email;
            newUser.user_id = user.Id;
            newUser.user_is_admin = user.IsAdmin;
            newUser.user_is_private = user.IsPrivate;
            newUser.user_karma = user.Karma;
            newUser.user_nick = user.Nick;
            newUser.user_password = user.Password;
            newUser.user_signup = user.SignUp;
            newUser.user_picture = user.UserPictureURL;

            return newUser;
        }

        #region IUserDAO Members


        /// <summary>
        /// Gets the user ID.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="userPassword">The user password.</param>
        /// <returns>User ID</returns>
        public long GetUserID(string userEmail, string userPassword)
        {
            try
            {
                data.Connection.Open();

                IEnumerable<user> query = (from users in data.users
                                           where users.user_email == userEmail
                                           where users.user_password == userPassword
                                           select users);

                return query.First<user>().user_id;
            }
            catch
            {
                return 0;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        /// <summary>
        /// Determines whether the specified user ID is admin.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <returns>
        /// 	<c>true</c> if the specified user ID is admin; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAdmin(long userID)
        {
            try
            {
                return this.GetUserById(userID).IsAdmin;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region IUserDAO Members


        /// <summary>
        /// Gets the user by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>User</returns>
        public XareuServices.Model.User.User GetUserByEmail(string email)
        {
            try
            {
                data.Connection.Open();

                var query = from users in data.users
                            where users.user_email == email
                            select users;

                return this.getUser(query.First<user>());
            }
            catch
            {
                return null;
            }
            finally
            {
                data.Connection.Close();
            }
        }

        #endregion
    }
}
