﻿// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using NpgsqlTypes;

namespace PostgreSQLCopyHelper
{
    public static class BinaryDataTypeExtensions
    {
        public static PostgreSQLCopyHelper<TEntity> MapByteArray<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, byte[]> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Bytea);
        }
    }
}
