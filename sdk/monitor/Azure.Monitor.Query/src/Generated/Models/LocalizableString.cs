// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The localizable string class. </summary>
    internal partial class LocalizableString
    {
        /// <summary> Initializes a new instance of <see cref="LocalizableString"/>. </summary>
        /// <param name="value"> the invariant value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LocalizableString(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="LocalizableString"/>. </summary>
        /// <param name="value"> the invariant value. </param>
        /// <param name="localizedValue"> the locale specific value. </param>
        internal LocalizableString(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> the invariant value. </summary>
        public string Value { get; }
        /// <summary> the locale specific value. </summary>
        public string LocalizedValue { get; }
    }
}
