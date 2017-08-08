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
    /// DateOperationResource
    /// </summary>
    [DataContract]
    public partial class DateOperationResource :  IEquatable<DateOperationResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateOperationResource" /> class.
        /// </summary>
        /// <param name="Args">Args.</param>
        /// <param name="Op">Op.</param>
        /// <param name="Type">Type.</param>
        public DateOperationResource(List<ExpressionResource> Args = default(List<ExpressionResource>), string Op = default(string), string Type = default(string))
        {
            this.Args = Args;
            this.Op = Op;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<ExpressionResource> Args { get; set; }

        /// <summary>
        /// Gets or Sets Op
        /// </summary>
        [DataMember(Name="op", EmitDefaultValue=false)]
        public string Op { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateOperationResource {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DateOperationResource);
        }

        /// <summary>
        /// Returns true if DateOperationResource instances are equal
        /// </summary>
        /// <param name="input">Instance of DateOperationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateOperationResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Args == input.Args ||
                    (this.Args != null &&
                    this.Args.SequenceEqual(input.Args))
                ) && 
                (
                    this.Op == input.Op ||
                    (this.Op != null &&
                    this.Op.Equals(input.Op))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Op != null)
                    hashCode = hashCode * 59 + this.Op.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}