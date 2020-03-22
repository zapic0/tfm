using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuServices.DAL
{
    interface IUserDAO
    {
        /// <summary>
        /// Devuelve el usuario que tenga el id indicado
        /// </summary>
        /// <param name="id">Id del usuario a buscar</param>
        /// <returns>Usuario que tenga el id indicado, null si no existe</returns>
        Model.User.User GetUserById(long id);

        /// <summary>
        /// Gets the user ID.
        /// </summary>
        /// <param name="userEmail">The user email.</param>
        /// <param name="userPassword">The user password.</param>
        /// <returns>User ID</returns>
        long GetUserID(string userEmail, string userPassword);

        /// <summary>
        /// Gets the user by email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>User</returns>
        Model.User.User GetUserByEmail(string email);

        /// <summary>
        /// Añade un nuevo usuario a la base de datos
        /// </summary>
        /// <param name="user">Datos del usuario a añadir</param>
        /// <returns>True si se pudo añadir, false en caso contrario</returns>
        bool AddNewUser(Model.User.User user, out long userID);

        /// <summary>
        /// Borra un usuario existente
        /// </summary>
        /// <param name="user">Usuario que queremos borrar</param>
        /// <returns>True si se pudo borrar, false en caso contrario</returns>
        bool DeleteUser(Model.User.User user);

        /// <summary>
        /// Devuelve el usuario que tenga el nombre indicado
        /// </summary>
        /// <param name="name">Nombre del usuario a buscar</param>
        /// <returns>Usuario que tenga el nombre indicado, null si no existe</returns>
        Model.User.User GetUserByName(string name);

        /// <summary>
        /// Edita los valores de un usuario determinado sustituyéndolos por los valores recibidos
        /// </summary>
        /// <param name="user">Valores del usuario que queremos guardar</param>
        /// <returns>True si se pudieron llevar a cabo los cambios, false en caso contrario</returns>
        bool EditUser(Model.User.User user);

        /// <summary>
        /// Devuelve todos los usuarios registrados.
        /// Se especifican el número de resultados por página y la página que queremos recibir.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <returns>Usuarios registrados, null si no existe ninguno</returns>
        List<Model.User.User> GetRegisteredUsers(int number, int page);

        /// <summary>
        /// Devuelve todos los usuarios que coincidan con el nombre a buscar.
        /// Pueden ser usuarios con nombres similares, que contengan la cadena...
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="name">Nombre a buscar</param>
        /// <returns>Usuarios que coinciden con la búsqueda, null si no existen</returns>
        List<Model.User.User> SearchUsersByName(int number, int page, string name);

        /// <summary>
        /// Devuelve todos los usuarios con el karma especificado.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="karma">Karma a buscar</param>
        /// <returns>Usuarios que coinciden con el karma especificado, null si no existen</returns>
        List<Model.User.User> SearchUsersByKarma(int number, int page, float karma);

        /// <summary>
        /// Busca usuarios por su dirección de correo.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="email">Email a buscar</param>
        /// <returns>Usuarios que coinciden con la dirección, null si no existen</returns>
        List<Model.User.User> SearchUsersByEmail(int number, int page, string email);

        /// <summary>
        /// Busca usuarios por su etiqueta de lugar por defecto.
        /// </summary>
        /// <param name="number">Número de usuarios por página</param>
        /// <param name="page">Página a recibir</param>
        /// <param name="tagPlaceId">Id de la etiqueta de lugar</param>
        /// <returns>Usuarios que tienen esa etiqueta de lugar establecida</returns>
        List<Model.User.User> SearchUsersByTagPlace(int number, int page, long tagPlaceId);
    }
}
