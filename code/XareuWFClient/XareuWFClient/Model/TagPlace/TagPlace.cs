using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XareuWFClient.Model.TagPlace
{
    public class TagPlace
    {
        public string Name { get; set; }
        public long ParentId { get; set; }
        public long Id { get; set; }

        /// <summary>
        /// Constructor sin parámetros
        /// </summary>
        public TagPlace()
        {
            this.Name = "";
            this.ParentId = 1;
            this.Id = 1;
        }

        /// <summary>
        /// Constructor con el id que queremos que tenga la etiqueta de lugar
        /// </summary>
        /// <param name="parent">Id que queremos atribuir a la etiqueta</param>
        public TagPlace(long id)
        {
            this.Name = "";
            this.Id = id;
            this.ParentId = 1;
        }
    }
}
