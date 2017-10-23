/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.knetikcloud.Client.SwaggerDateConverter;

namespace com.knetikcloud.Model
{
    /// <summary>
    /// RevenueCountryReportResource
    /// </summary>
    [DataContract]
    public partial class RevenueCountryReportResource :  IEquatable<RevenueCountryReportResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevenueCountryReportResource" /> class.
        /// </summary>
        /// <param name="Country">Country.</param>
        /// <param name="Revenue">Revenue.</param>
        /// <param name="Volume">Volume.</param>
        public RevenueCountryReportResource(string Country = default(string), decimal? Revenue = default(decimal?), long? Volume = default(long?))
        {
            this.Country = Country;
            this.Revenue = Revenue;
            this.Volume = Volume;
        }
        
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public decimal? Revenue { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public long? Volume { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevenueCountryReportResource {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RevenueCountryReportResource);
        }

        /// <summary>
        /// Returns true if RevenueCountryReportResource instances are equal
        /// </summary>
        /// <param name="input">Instance of RevenueCountryReportResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevenueCountryReportResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }

    }

}
