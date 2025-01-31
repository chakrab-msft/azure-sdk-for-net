// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The sku name. </summary>
    public readonly partial struct DiskStorageAccountTypes : IEquatable<DiskStorageAccountTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DiskStorageAccountTypes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskStorageAccountTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLRSValue = "Standard_LRS";
        private const string PremiumLRSValue = "Premium_LRS";
        private const string StandardSSDLRSValue = "StandardSSD_LRS";
        private const string UltraSSDLRSValue = "UltraSSD_LRS";
        private const string PremiumZRSValue = "Premium_ZRS";
        private const string StandardSSDZRSValue = "StandardSSD_ZRS";

        /// <summary> Standard HDD locally redundant storage. Best for backup, non-critical, and infrequent access. </summary>
        public static DiskStorageAccountTypes StandardLRS { get; } = new DiskStorageAccountTypes(StandardLRSValue);
        /// <summary> Premium SSD locally redundant storage. Best for production and performance sensitive workloads. </summary>
        public static DiskStorageAccountTypes PremiumLRS { get; } = new DiskStorageAccountTypes(PremiumLRSValue);
        /// <summary> Standard SSD locally redundant storage. Best for web servers, lightly used enterprise applications and dev/test. </summary>
        public static DiskStorageAccountTypes StandardSSDLRS { get; } = new DiskStorageAccountTypes(StandardSSDLRSValue);
        /// <summary> Ultra SSD locally redundant storage. Best for IO-intensive workloads such as SAP HANA, top tier databases (for example, SQL, Oracle), and other transaction-heavy workloads. </summary>
        public static DiskStorageAccountTypes UltraSSDLRS { get; } = new DiskStorageAccountTypes(UltraSSDLRSValue);
        /// <summary> Premium SSD zone redundant storage. Best for the production workloads that need storage resiliency against zone failures. </summary>
        public static DiskStorageAccountTypes PremiumZRS { get; } = new DiskStorageAccountTypes(PremiumZRSValue);
        /// <summary> Standard SSD zone redundant storage. Best for web servers, lightly used enterprise applications and dev/test that need storage resiliency against zone failures. </summary>
        public static DiskStorageAccountTypes StandardSSDZRS { get; } = new DiskStorageAccountTypes(StandardSSDZRSValue);
        /// <summary> Determines if two <see cref="DiskStorageAccountTypes"/> values are the same. </summary>
        public static bool operator ==(DiskStorageAccountTypes left, DiskStorageAccountTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskStorageAccountTypes"/> values are not the same. </summary>
        public static bool operator !=(DiskStorageAccountTypes left, DiskStorageAccountTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskStorageAccountTypes"/>. </summary>
        public static implicit operator DiskStorageAccountTypes(string value) => new DiskStorageAccountTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskStorageAccountTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskStorageAccountTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
