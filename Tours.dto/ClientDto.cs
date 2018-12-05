using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tours.Dto
{
    public class ClientDto
    {
        /// <summary>
        /// id клиента
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес клиента
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// Контактный номер клиента
        /// </summary>
        public string Number { get; set; }
    }
}
