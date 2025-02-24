// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A sql database resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SqlDatabase : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the SqlDatabase class.
        /// </summary>
        public SqlDatabase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDatabase class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="systemData">SystemData of SqlDatabase.</param>
        /// <param name="collation">The collation of the database.</param>
        /// <param name="maxSizeBytes">The max size of the database expressed
        /// in bytes.</param>
        /// <param name="databaseGuid">The Guid of the database.</param>
        /// <param name="status">Status of the database.</param>
        public SqlDatabase(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), string collation = default(string), long? maxSizeBytes = default(long?), System.Guid? databaseGuid = default(System.Guid?), string status = default(string))
            : base(location, id, name, type, tags)
        {
            SystemData = systemData;
            Collation = collation;
            MaxSizeBytes = maxSizeBytes;
            DatabaseGuid = databaseGuid;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets systemData of SqlDatabase.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets the collation of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets the max size of the database expressed in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets the Guid of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseGuid")]
        public System.Guid? DatabaseGuid { get; private set; }

        /// <summary>
        /// Gets status of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
