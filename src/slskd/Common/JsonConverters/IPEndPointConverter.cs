﻿// <copyright file="IPEndPointConverter.cs" company="slskd Team">
//     Copyright (c) slskd Team. All rights reserved.
//
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as published
//     by the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
//
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
//
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see https://www.gnu.org/licenses/.
// </copyright>

namespace slskd
{
    using System;
    using System.Net;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    ///     Serializes IPAddress instances.
    /// </summary>
    public class IPEndPointConverter : JsonConverter<IPEndPoint>
    {
        public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(IPEndPoint);

        public override IPEndPoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => IPEndPoint.Parse(reader.GetString());

        public override void Write(Utf8JsonWriter writer, IPEndPoint value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
    }
}
