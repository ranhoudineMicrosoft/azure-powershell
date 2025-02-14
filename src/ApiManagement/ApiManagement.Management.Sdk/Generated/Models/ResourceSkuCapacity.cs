// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Describes scaling information of a SKU.
    /// </summary>
    public partial class ResourceSkuCapacity
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuCapacity class.
        /// </summary>
        public ResourceSkuCapacity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuCapacity class.
        /// </summary>

        /// <param name="minimum">The minimum capacity.
        /// </param>

        /// <param name="maximum">The maximum capacity that can be set.
        /// </param>

        /// <param name="defaultProperty">The default capacity.
        /// </param>

        /// <param name="scaleType">The scale type applicable to the sku.
        /// Possible values include: &#39;automatic&#39;, &#39;manual&#39;, &#39;none&#39;</param>
        public ResourceSkuCapacity(int? minimum = default(int?), int? maximum = default(int?), int? defaultProperty = default(int?), string scaleType = default(string))

        {
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.DefaultProperty = defaultProperty;
            this.ScaleType = scaleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the minimum capacity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minimum")]
        public int? Minimum {get; private set; }

        /// <summary>
        /// Gets the maximum capacity that can be set.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maximum")]
        public int? Maximum {get; private set; }

        /// <summary>
        /// Gets the default capacity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "default")]
        public int? DefaultProperty {get; private set; }

        /// <summary>
        /// Gets the scale type applicable to the sku. Possible values include: &#39;automatic&#39;, &#39;manual&#39;, &#39;none&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scaleType")]
        public string ScaleType {get; private set; }
    }
}