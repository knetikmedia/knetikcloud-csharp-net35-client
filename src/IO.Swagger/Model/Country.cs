/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Country
    /// </summary>
    [DataContract]
    public partial class Country :  IEquatable<Country>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Country" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Iso2">Iso2.</param>
        /// <param name="Iso3">Iso3.</param>
        /// <param name="Name">Name.</param>
        public Country(int? Id = default(int?), string Iso2 = default(string), string Iso3 = default(string), string Name = default(string))
        {
            this.Id = Id;
            this.Iso2 = Iso2;
            this.Iso3 = Iso3;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Iso2
        /// </summary>
        [DataMember(Name="iso2", EmitDefaultValue=false)]
        public string Iso2 { get; set; }
        /// <summary>
        /// Gets or Sets Iso3
        /// </summary>
        [DataMember(Name="iso3", EmitDefaultValue=false)]
        public string Iso3 { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Country {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Iso2: ").Append(Iso2).Append("\n");
            sb.Append("  Iso3: ").Append(Iso3).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Country);
        }

        /// <summary>
        /// Returns true if Country instances are equal
        /// </summary>
        /// <param name="other">Instance of Country to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Country other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Iso2 == other.Iso2 ||
                    this.Iso2 != null &&
                    this.Iso2.Equals(other.Iso2)
                ) && 
                (
                    this.Iso3 == other.Iso3 ||
                    this.Iso3 != null &&
                    this.Iso3.Equals(other.Iso3)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Iso2 != null)
                    hash = hash * 59 + this.Iso2.GetHashCode();
                if (this.Iso3 != null)
                    hash = hash * 59 + this.Iso3.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
