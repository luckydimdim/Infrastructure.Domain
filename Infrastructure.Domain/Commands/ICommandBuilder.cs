﻿using System.Threading.Tasks;

namespace Cmas.Infrastructure.Domain.Commands
{
    /// <summary>
    ///     Интерфейс для построителя команд.
    ///     Позволяет создать и выполнить команду с определенным контекстом.
    /// </summary>
    public interface ICommandBuilder
    {
        /// <summary>
        ///     Создает команду с определенным контекстом и выполняет её.
        /// </summary>
        /// <typeparam name="TCommandContext">Тип контекста команды.</typeparam>
        /// <param name="commandContext">Контекст команды.</param>
        Task<TCommandContext> Execute<TCommandContext>(TCommandContext commandContext)
            where TCommandContext : ICommandContext;
    }
}
