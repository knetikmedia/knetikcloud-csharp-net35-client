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
    /// StateTaxResource
    /// </summary>
    [DataContract]
    public partial class StateTaxResource :  IEquatable<StateTaxResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateTaxResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StateTaxResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StateTaxResource" /> class.
        /// </summary>
        /// <param name="CountryIso3">The iso3 code of the country, cannot be changed (required).</param>
        /// <param name="FederallyExempt">Whether the state is exempt from paying the country tax (required).</param>
        /// <param name="Name">The name of the tax (required).</param>
        /// <param name="Rate">The tax rate as a percentage to a maximum of two decimal places (1.5 means 1.5%) (required).</param>
        /// <param name="StateCode">The code of the state, cannot be changed (required).</param>
        /// <param name="TaxShipping">Whether the tax applies to shipping costs (required).</param>
        public StateTaxResource(string CountryIso3 = default(string), bool? FederallyExempt = default(bool?), string Name = default(string), double? Rate = default(double?), string StateCode = default(string), bool? TaxShipping = default(bool?))
        {
            // to ensure "CountryIso3" is required (not null)
            if (CountryIso3 == null)
            {
                throw new InvalidDataException("CountryIso3 is a required property for StateTaxResource and cannot be null");
            }
            else
            {
                this.CountryIso3 = CountryIso3;
            }
            // to ensure "FederallyExempt" is required (not null)
            if (FederallyExempt == null)
            {
                throw new InvalidDataException("FederallyExempt is a required property for StateTaxResource and cannot be null");
            }
            else
            {
                this.FederallyExempt = FederallyExempt;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for StateTaxResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Rate" is required (not null)
            if (Rate == null)
            {
                throw new InvalidDataException("Rate is a required property for StateTaxResource and cannot be null");
            }
            else
            {
                this.Rate = Rate;
            }
            // to ensure "StateCode" is required (not null)
            if (StateCode == null)
            {
                throw new InvalidDataException("StateCode is a required property for StateTaxResource and cannot be null");
            }
            else
            {
                this.StateCode = StateCode;
            }
            // to ensure "TaxShipping" is required (not null)
            if (TaxShipping == null)
            {
                throw new InvalidDataException("TaxShipping is a required property for StateTaxResource and cannot be null");
            }
            else
            {
                this.TaxShipping = TaxShipping;
            }
        }
        
        /// <summary>
        /// The iso3 code of the country, cannot be changed
        /// </summary>
        /// <value>The iso3 code of the country, cannot be changed</value>
        [DataMember(Name="country_iso3", EmitDefaultValue=false)]
        public string CountryIso3 { get; set; }

        /// <summary>
        /// Whether the state is exempt from paying the country tax
        /// </summary>
        /// <value>Whether the state is exempt from paying the country tax</value>
        [DataMember(Name="federally_exempt", EmitDefaultValue=false)]
        public bool? FederallyExempt { get; set; }

        /// <summary>
        /// The name of the tax
        /// </summary>
        /// <value>The name of the tax</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The tax rate as a percentage to a maximum of two decimal places (1.5 means 1.5%)
        /// </summary>
        /// <value>The tax rate as a percentage to a maximum of two decimal places (1.5 means 1.5%)</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }

        /// <summary>
        /// The code of the state, cannot be changed
        /// </summary>
        /// <value>The code of the state, cannot be changed</value>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Whether the tax applies to shipping costs
        /// </summary>
        /// <value>Whether the tax applies to shipping costs</value>
        [DataMember(Name="tax_shipping", EmitDefaultValue=false)]
        public bool? TaxShipping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateTaxResource {\n");
            sb.Append("  CountryIso3: ").Append(CountryIso3).Append("\n");
            sb.Append("  FederallyExempt: ").Append(FederallyExempt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  TaxShipping: ").Append(TaxShipping).Append("\n");
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
            return this.Equals(input as StateTaxResource);
        }

        /// <summary>
        /// Returns true if StateTaxResource instances are equal
        /// </summary>
        /// <param name="input">Instance of StateTaxResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateTaxResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryIso3 == input.CountryIso3 ||
                    (this.CountryIso3 != null &&
                    this.CountryIso3.Equals(input.CountryIso3))
                ) && 
                (
                    this.FederallyExempt == input.FederallyExempt ||
                    (this.FederallyExempt != null &&
                    this.FederallyExempt.Equals(input.FederallyExempt))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
                ) && 
                (
                    this.TaxShipping == input.TaxShipping ||
                    (this.TaxShipping != null &&
                    this.TaxShipping.Equals(input.TaxShipping))
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
                if (this.CountryIso3 != null)
                    hashCode = hashCode * 59 + this.CountryIso3.GetHashCode();
                if (this.FederallyExempt != null)
                    hashCode = hashCode * 59 + this.FederallyExempt.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.TaxShipping != null)
                    hashCode = hashCode * 59 + this.TaxShipping.GetHashCode();
                return hashCode;
            }
        }

    }

}
