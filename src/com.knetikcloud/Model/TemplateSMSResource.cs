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
    /// TemplateSMSResource
    /// </summary>
    [DataContract]
    public partial class TemplateSMSResource :  IEquatable<TemplateSMSResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSMSResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateSMSResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateSMSResource" /> class.
        /// </summary>
        /// <param name="From">The phone number to attribute the outgoing message to. Optional if the config text.out_number is set..</param>
        /// <param name="Recipients">A list of user ids to send the message to. (required).</param>
        /// <param name="Template">A mustache template (required).</param>
        /// <param name="TemplateVars">A map of values to fill in the template.</param>
        public TemplateSMSResource(string From = default(string), List<int?> Recipients = default(List<int?>), string Template = default(string), Object TemplateVars = default(Object))
        {
            // to ensure "Recipients" is required (not null)
            if (Recipients == null)
            {
                throw new InvalidDataException("Recipients is a required property for TemplateSMSResource and cannot be null");
            }
            else
            {
                this.Recipients = Recipients;
            }
            // to ensure "Template" is required (not null)
            if (Template == null)
            {
                throw new InvalidDataException("Template is a required property for TemplateSMSResource and cannot be null");
            }
            else
            {
                this.Template = Template;
            }
            this.From = From;
            this.TemplateVars = TemplateVars;
        }
        
        /// <summary>
        /// The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.
        /// </summary>
        /// <value>The phone number to attribute the outgoing message to. Optional if the config text.out_number is set.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// A list of user ids to send the message to.
        /// </summary>
        /// <value>A list of user ids to send the message to.</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<int?> Recipients { get; set; }

        /// <summary>
        /// A mustache template
        /// </summary>
        /// <value>A mustache template</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

        /// <summary>
        /// A map of values to fill in the template
        /// </summary>
        /// <value>A map of values to fill in the template</value>
        [DataMember(Name="template_vars", EmitDefaultValue=false)]
        public Object TemplateVars { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateSMSResource {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TemplateVars: ").Append(TemplateVars).Append("\n");
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
            return this.Equals(input as TemplateSMSResource);
        }

        /// <summary>
        /// Returns true if TemplateSMSResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateSMSResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateSMSResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    (this.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.TemplateVars == input.TemplateVars ||
                    (this.TemplateVars != null &&
                    this.TemplateVars.Equals(input.TemplateVars))
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TemplateVars != null)
                    hashCode = hashCode * 59 + this.TemplateVars.GetHashCode();
                return hashCode;
            }
        }

    }

}
