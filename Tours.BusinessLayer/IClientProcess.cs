using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tours.Dto;

namespace Tours.BusinessLayer
{
    /// <summary>
    /// Декларация действий по работе с клиентом
    /// </summary>
    public interface IClientProcess
    {
        /// <summary>
        /// Возвращает список клиентов
        /// </summary>
        /// <returns>список клиентов</returns>
        IList<ClientDto> GetList();
        /// <summary>
        /// Возвращает клиента по его id
        /// </summary>
        /// <param name="id">id клиента</param>
        /// <returns>клиент</returns>
        ClientDto Get(int id);
        /// <summary>
        /// Добавляет клиента
        /// </summary>
        /// <param name="client"></param>
        void Add(ClientDto client);
        /// <summary>
        /// Обновляет данные о клиенте
        /// </summary>
        /// <param name="client">Клиент, изменения которого надо сохранить</param>
        void Update(ClientDto client);
        /// <summary>
        /// Удаляет клиента
        /// </summary>
        /// <param name="id">id клиента, которого надо удалить</param>
        void Delete(int id);
    }
}
