//
//  IDBC.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2016 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

namespace Warcraft.DBC
{
    /// <summary>
    /// Database file interface. Defines accessors to header values.
    /// </summary>
    public interface IDBC
    {
        /// <summary>
        /// The number of held records.
        /// </summary>
        int RecordCount { get; }

        /// <summary>
        /// The number of fields in each record.
        /// </summary>
        int FieldCount { get; }

        /// <summary>
        /// The absolute size of each record.
        /// </summary>
        int RecordSize { get; }

        /// <summary>
        /// The absolute size of the string block.
        /// </summary>
        int StringBlockSize { get; }
    }
}
