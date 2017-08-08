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
    /// InvoiceResource
    /// </summary>
    [DataContract]
    public partial class InvoiceResource :  IEquatable<InvoiceResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResource" /> class.
        /// </summary>
        /// <param name="BillingAddress1">Line one of the customer&#39;s billing address.</param>
        /// <param name="BillingAddress2">Line two of the customer&#39;s billing address.</param>
        /// <param name="BillingCityName">The city for the customer&#39;s billing address.</param>
        /// <param name="BillingCountryName">The country for the customer&#39;s billing address.</param>
        /// <param name="BillingFullName">The customer&#39;s name for the billing address.</param>
        /// <param name="BillingPostalCode">The postal code for the customer&#39;s billing address.</param>
        /// <param name="BillingStateName">The state for the customer&#39;s billing address.</param>
        /// <param name="CartId">The guid of the cart this invoice came from.</param>
        /// <param name="Currency">The code for the currency invoice prices are in.</param>
        /// <param name="CurrentFulfillmentStatus">The fulfillment status of the invoice.</param>
        /// <param name="CurrentPaymentStatus">The payment status of the invoice.</param>
        /// <param name="Discount">The amount of money saved through coupons.</param>
        /// <param name="Email">The customer&#39;s email address.</param>
        /// <param name="ExternalRef">An external reference to filter on.</param>
        /// <param name="FedTax">The amount of federal tax added.</param>
        /// <param name="GrandTotal">The final price of the invoice.</param>
        /// <param name="InvoiceNumber">A reference number for the invoice.</param>
        /// <param name="Items">A list of items within the invoice.</param>
        /// <param name="NamePrefix">The customer&#39;s name prefix.</param>
        /// <param name="OrderNotes">Notes about the order.</param>
        /// <param name="ParentInvoiceId">The id of an invoice this is a child of.</param>
        /// <param name="PaymentMethodId">The id of a saved payment method used to pay for the invoice.</param>
        /// <param name="Phone">The customer&#39;s phone number.</param>
        /// <param name="PhoneNumber">The customer&#39;s phone number.</param>
        /// <param name="Shipping">The shipping cost.</param>
        /// <param name="ShippingAddress1">Line one of the customer&#39;s shipping address.</param>
        /// <param name="ShippingAddress2">Line two of the customer&#39;s shipping address.</param>
        /// <param name="ShippingCityName">The city for the customer&#39;s shipping address.</param>
        /// <param name="ShippingCountryName">The country for the customer&#39;s shipping address.</param>
        /// <param name="ShippingFullName">The customer&#39;s name for the shipping address.</param>
        /// <param name="ShippingPostalCode">The postal code for the customer&#39;s shipping address.</param>
        /// <param name="ShippingStateName">The state for the customer&#39;s shipping address.</param>
        /// <param name="Sort">A number to use in sorting items. default 500..</param>
        /// <param name="StateTax">The amount of state tax added.</param>
        /// <param name="Subtotal">The sum price of all items before shipping, coupons and tax.</param>
        /// <param name="User">The owner of the invoice.</param>
        /// <param name="VendorId">The id of the vendor.</param>
        /// <param name="VendorName">The name of the invoice.</param>
        public InvoiceResource(string BillingAddress1 = default(string), string BillingAddress2 = default(string), string BillingCityName = default(string), string BillingCountryName = default(string), string BillingFullName = default(string), string BillingPostalCode = default(string), string BillingStateName = default(string), string CartId = default(string), string Currency = default(string), string CurrentFulfillmentStatus = default(string), string CurrentPaymentStatus = default(string), double? Discount = default(double?), string Email = default(string), string ExternalRef = default(string), double? FedTax = default(double?), double? GrandTotal = default(double?), string InvoiceNumber = default(string), List<InvoiceItemResource> Items = default(List<InvoiceItemResource>), string NamePrefix = default(string), string OrderNotes = default(string), int? ParentInvoiceId = default(int?), int? PaymentMethodId = default(int?), string Phone = default(string), string PhoneNumber = default(string), double? Shipping = default(double?), string ShippingAddress1 = default(string), string ShippingAddress2 = default(string), string ShippingCityName = default(string), string ShippingCountryName = default(string), string ShippingFullName = default(string), string ShippingPostalCode = default(string), string ShippingStateName = default(string), int? Sort = default(int?), double? StateTax = default(double?), double? Subtotal = default(double?), SimpleUserResource User = default(SimpleUserResource), int? VendorId = default(int?), string VendorName = default(string))
        {
            this.BillingAddress1 = BillingAddress1;
            this.BillingAddress2 = BillingAddress2;
            this.BillingCityName = BillingCityName;
            this.BillingCountryName = BillingCountryName;
            this.BillingFullName = BillingFullName;
            this.BillingPostalCode = BillingPostalCode;
            this.BillingStateName = BillingStateName;
            this.CartId = CartId;
            this.Currency = Currency;
            this.CurrentFulfillmentStatus = CurrentFulfillmentStatus;
            this.CurrentPaymentStatus = CurrentPaymentStatus;
            this.Discount = Discount;
            this.Email = Email;
            this.ExternalRef = ExternalRef;
            this.FedTax = FedTax;
            this.GrandTotal = GrandTotal;
            this.InvoiceNumber = InvoiceNumber;
            this.Items = Items;
            this.NamePrefix = NamePrefix;
            this.OrderNotes = OrderNotes;
            this.ParentInvoiceId = ParentInvoiceId;
            this.PaymentMethodId = PaymentMethodId;
            this.Phone = Phone;
            this.PhoneNumber = PhoneNumber;
            this.Shipping = Shipping;
            this.ShippingAddress1 = ShippingAddress1;
            this.ShippingAddress2 = ShippingAddress2;
            this.ShippingCityName = ShippingCityName;
            this.ShippingCountryName = ShippingCountryName;
            this.ShippingFullName = ShippingFullName;
            this.ShippingPostalCode = ShippingPostalCode;
            this.ShippingStateName = ShippingStateName;
            this.Sort = Sort;
            this.StateTax = StateTax;
            this.Subtotal = Subtotal;
            this.User = User;
            this.VendorId = VendorId;
            this.VendorName = VendorName;
        }
        
        /// <summary>
        /// Line one of the customer&#39;s billing address
        /// </summary>
        /// <value>Line one of the customer&#39;s billing address</value>
        [DataMember(Name="billing_address1", EmitDefaultValue=false)]
        public string BillingAddress1 { get; set; }

        /// <summary>
        /// Line two of the customer&#39;s billing address
        /// </summary>
        /// <value>Line two of the customer&#39;s billing address</value>
        [DataMember(Name="billing_address2", EmitDefaultValue=false)]
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// The city for the customer&#39;s billing address
        /// </summary>
        /// <value>The city for the customer&#39;s billing address</value>
        [DataMember(Name="billing_city_name", EmitDefaultValue=false)]
        public string BillingCityName { get; set; }

        /// <summary>
        /// The country for the customer&#39;s billing address
        /// </summary>
        /// <value>The country for the customer&#39;s billing address</value>
        [DataMember(Name="billing_country_name", EmitDefaultValue=false)]
        public string BillingCountryName { get; set; }

        /// <summary>
        /// The customer&#39;s name for the billing address
        /// </summary>
        /// <value>The customer&#39;s name for the billing address</value>
        [DataMember(Name="billing_full_name", EmitDefaultValue=false)]
        public string BillingFullName { get; set; }

        /// <summary>
        /// The postal code for the customer&#39;s billing address
        /// </summary>
        /// <value>The postal code for the customer&#39;s billing address</value>
        [DataMember(Name="billing_postal_code", EmitDefaultValue=false)]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// The state for the customer&#39;s billing address
        /// </summary>
        /// <value>The state for the customer&#39;s billing address</value>
        [DataMember(Name="billing_state_name", EmitDefaultValue=false)]
        public string BillingStateName { get; set; }

        /// <summary>
        /// The guid of the cart this invoice came from
        /// </summary>
        /// <value>The guid of the cart this invoice came from</value>
        [DataMember(Name="cart_id", EmitDefaultValue=false)]
        public string CartId { get; set; }

        /// <summary>
        /// The date the invoice was created, unix timestamp in seconds
        /// </summary>
        /// <value>The date the invoice was created, unix timestamp in seconds</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The code for the currency invoice prices are in
        /// </summary>
        /// <value>The code for the currency invoice prices are in</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The fulfillment status of the invoice
        /// </summary>
        /// <value>The fulfillment status of the invoice</value>
        [DataMember(Name="current_fulfillment_status", EmitDefaultValue=false)]
        public string CurrentFulfillmentStatus { get; set; }

        /// <summary>
        /// The payment status of the invoice
        /// </summary>
        /// <value>The payment status of the invoice</value>
        [DataMember(Name="current_payment_status", EmitDefaultValue=false)]
        public string CurrentPaymentStatus { get; set; }

        /// <summary>
        /// The amount of money saved through coupons
        /// </summary>
        /// <value>The amount of money saved through coupons</value>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }

        /// <summary>
        /// The customer&#39;s email address
        /// </summary>
        /// <value>The customer&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// An external reference to filter on
        /// </summary>
        /// <value>An external reference to filter on</value>
        [DataMember(Name="external_ref", EmitDefaultValue=false)]
        public string ExternalRef { get; set; }

        /// <summary>
        /// The amount of federal tax added
        /// </summary>
        /// <value>The amount of federal tax added</value>
        [DataMember(Name="fed_tax", EmitDefaultValue=false)]
        public double? FedTax { get; set; }

        /// <summary>
        /// The final price of the invoice
        /// </summary>
        /// <value>The final price of the invoice</value>
        [DataMember(Name="grand_total", EmitDefaultValue=false)]
        public double? GrandTotal { get; set; }

        /// <summary>
        /// The id of the invoice
        /// </summary>
        /// <value>The id of the invoice</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// A reference number for the invoice
        /// </summary>
        /// <value>A reference number for the invoice</value>
        [DataMember(Name="invoice_number", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// A list of items within the invoice
        /// </summary>
        /// <value>A list of items within the invoice</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<InvoiceItemResource> Items { get; set; }

        /// <summary>
        /// The customer&#39;s name prefix
        /// </summary>
        /// <value>The customer&#39;s name prefix</value>
        [DataMember(Name="name_prefix", EmitDefaultValue=false)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// Notes about the order
        /// </summary>
        /// <value>Notes about the order</value>
        [DataMember(Name="order_notes", EmitDefaultValue=false)]
        public string OrderNotes { get; set; }

        /// <summary>
        /// The id of an invoice this is a child of
        /// </summary>
        /// <value>The id of an invoice this is a child of</value>
        [DataMember(Name="parent_invoice_id", EmitDefaultValue=false)]
        public int? ParentInvoiceId { get; set; }

        /// <summary>
        /// The id of a saved payment method used to pay for the invoice
        /// </summary>
        /// <value>The id of a saved payment method used to pay for the invoice</value>
        [DataMember(Name="payment_method_id", EmitDefaultValue=false)]
        public int? PaymentMethodId { get; set; }

        /// <summary>
        /// The customer&#39;s phone number
        /// </summary>
        /// <value>The customer&#39;s phone number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The customer&#39;s phone number
        /// </summary>
        /// <value>The customer&#39;s phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The shipping cost
        /// </summary>
        /// <value>The shipping cost</value>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public double? Shipping { get; set; }

        /// <summary>
        /// Line one of the customer&#39;s shipping address
        /// </summary>
        /// <value>Line one of the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_address1", EmitDefaultValue=false)]
        public string ShippingAddress1 { get; set; }

        /// <summary>
        /// Line two of the customer&#39;s shipping address
        /// </summary>
        /// <value>Line two of the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_address2", EmitDefaultValue=false)]
        public string ShippingAddress2 { get; set; }

        /// <summary>
        /// The city for the customer&#39;s shipping address
        /// </summary>
        /// <value>The city for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_city_name", EmitDefaultValue=false)]
        public string ShippingCityName { get; set; }

        /// <summary>
        /// The country for the customer&#39;s shipping address
        /// </summary>
        /// <value>The country for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_country_name", EmitDefaultValue=false)]
        public string ShippingCountryName { get; set; }

        /// <summary>
        /// The customer&#39;s name for the shipping address
        /// </summary>
        /// <value>The customer&#39;s name for the shipping address</value>
        [DataMember(Name="shipping_full_name", EmitDefaultValue=false)]
        public string ShippingFullName { get; set; }

        /// <summary>
        /// The postal code for the customer&#39;s shipping address
        /// </summary>
        /// <value>The postal code for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_postal_code", EmitDefaultValue=false)]
        public string ShippingPostalCode { get; set; }

        /// <summary>
        /// The state for the customer&#39;s shipping address
        /// </summary>
        /// <value>The state for the customer&#39;s shipping address</value>
        [DataMember(Name="shipping_state_name", EmitDefaultValue=false)]
        public string ShippingStateName { get; set; }

        /// <summary>
        /// A number to use in sorting items. default 500.
        /// </summary>
        /// <value>A number to use in sorting items. default 500.</value>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public int? Sort { get; set; }

        /// <summary>
        /// The amount of state tax added
        /// </summary>
        /// <value>The amount of state tax added</value>
        [DataMember(Name="state_tax", EmitDefaultValue=false)]
        public double? StateTax { get; set; }

        /// <summary>
        /// The sum price of all items before shipping, coupons and tax
        /// </summary>
        /// <value>The sum price of all items before shipping, coupons and tax</value>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; set; }

        /// <summary>
        /// The date the invoice was last updated, unix timestamp in seconds
        /// </summary>
        /// <value>The date the invoice was last updated, unix timestamp in seconds</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// The owner of the invoice
        /// </summary>
        /// <value>The owner of the invoice</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public SimpleUserResource User { get; set; }

        /// <summary>
        /// The id of the vendor
        /// </summary>
        /// <value>The id of the vendor</value>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }

        /// <summary>
        /// The name of the invoice
        /// </summary>
        /// <value>The name of the invoice</value>
        [DataMember(Name="vendor_name", EmitDefaultValue=false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoiceResource {\n");
            sb.Append("  BillingAddress1: ").Append(BillingAddress1).Append("\n");
            sb.Append("  BillingAddress2: ").Append(BillingAddress2).Append("\n");
            sb.Append("  BillingCityName: ").Append(BillingCityName).Append("\n");
            sb.Append("  BillingCountryName: ").Append(BillingCountryName).Append("\n");
            sb.Append("  BillingFullName: ").Append(BillingFullName).Append("\n");
            sb.Append("  BillingPostalCode: ").Append(BillingPostalCode).Append("\n");
            sb.Append("  BillingStateName: ").Append(BillingStateName).Append("\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CurrentFulfillmentStatus: ").Append(CurrentFulfillmentStatus).Append("\n");
            sb.Append("  CurrentPaymentStatus: ").Append(CurrentPaymentStatus).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalRef: ").Append(ExternalRef).Append("\n");
            sb.Append("  FedTax: ").Append(FedTax).Append("\n");
            sb.Append("  GrandTotal: ").Append(GrandTotal).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  NamePrefix: ").Append(NamePrefix).Append("\n");
            sb.Append("  OrderNotes: ").Append(OrderNotes).Append("\n");
            sb.Append("  ParentInvoiceId: ").Append(ParentInvoiceId).Append("\n");
            sb.Append("  PaymentMethodId: ").Append(PaymentMethodId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  ShippingAddress1: ").Append(ShippingAddress1).Append("\n");
            sb.Append("  ShippingAddress2: ").Append(ShippingAddress2).Append("\n");
            sb.Append("  ShippingCityName: ").Append(ShippingCityName).Append("\n");
            sb.Append("  ShippingCountryName: ").Append(ShippingCountryName).Append("\n");
            sb.Append("  ShippingFullName: ").Append(ShippingFullName).Append("\n");
            sb.Append("  ShippingPostalCode: ").Append(ShippingPostalCode).Append("\n");
            sb.Append("  ShippingStateName: ").Append(ShippingStateName).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  StateTax: ").Append(StateTax).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
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
            return this.Equals(input as InvoiceResource);
        }

        /// <summary>
        /// Returns true if InvoiceResource instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAddress1 == input.BillingAddress1 ||
                    (this.BillingAddress1 != null &&
                    this.BillingAddress1.Equals(input.BillingAddress1))
                ) && 
                (
                    this.BillingAddress2 == input.BillingAddress2 ||
                    (this.BillingAddress2 != null &&
                    this.BillingAddress2.Equals(input.BillingAddress2))
                ) && 
                (
                    this.BillingCityName == input.BillingCityName ||
                    (this.BillingCityName != null &&
                    this.BillingCityName.Equals(input.BillingCityName))
                ) && 
                (
                    this.BillingCountryName == input.BillingCountryName ||
                    (this.BillingCountryName != null &&
                    this.BillingCountryName.Equals(input.BillingCountryName))
                ) && 
                (
                    this.BillingFullName == input.BillingFullName ||
                    (this.BillingFullName != null &&
                    this.BillingFullName.Equals(input.BillingFullName))
                ) && 
                (
                    this.BillingPostalCode == input.BillingPostalCode ||
                    (this.BillingPostalCode != null &&
                    this.BillingPostalCode.Equals(input.BillingPostalCode))
                ) && 
                (
                    this.BillingStateName == input.BillingStateName ||
                    (this.BillingStateName != null &&
                    this.BillingStateName.Equals(input.BillingStateName))
                ) && 
                (
                    this.CartId == input.CartId ||
                    (this.CartId != null &&
                    this.CartId.Equals(input.CartId))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CurrentFulfillmentStatus == input.CurrentFulfillmentStatus ||
                    (this.CurrentFulfillmentStatus != null &&
                    this.CurrentFulfillmentStatus.Equals(input.CurrentFulfillmentStatus))
                ) && 
                (
                    this.CurrentPaymentStatus == input.CurrentPaymentStatus ||
                    (this.CurrentPaymentStatus != null &&
                    this.CurrentPaymentStatus.Equals(input.CurrentPaymentStatus))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ExternalRef == input.ExternalRef ||
                    (this.ExternalRef != null &&
                    this.ExternalRef.Equals(input.ExternalRef))
                ) && 
                (
                    this.FedTax == input.FedTax ||
                    (this.FedTax != null &&
                    this.FedTax.Equals(input.FedTax))
                ) && 
                (
                    this.GrandTotal == input.GrandTotal ||
                    (this.GrandTotal != null &&
                    this.GrandTotal.Equals(input.GrandTotal))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.Items == input.Items ||
                    (this.Items != null &&
                    this.Items.SequenceEqual(input.Items))
                ) && 
                (
                    this.NamePrefix == input.NamePrefix ||
                    (this.NamePrefix != null &&
                    this.NamePrefix.Equals(input.NamePrefix))
                ) && 
                (
                    this.OrderNotes == input.OrderNotes ||
                    (this.OrderNotes != null &&
                    this.OrderNotes.Equals(input.OrderNotes))
                ) && 
                (
                    this.ParentInvoiceId == input.ParentInvoiceId ||
                    (this.ParentInvoiceId != null &&
                    this.ParentInvoiceId.Equals(input.ParentInvoiceId))
                ) && 
                (
                    this.PaymentMethodId == input.PaymentMethodId ||
                    (this.PaymentMethodId != null &&
                    this.PaymentMethodId.Equals(input.PaymentMethodId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Shipping == input.Shipping ||
                    (this.Shipping != null &&
                    this.Shipping.Equals(input.Shipping))
                ) && 
                (
                    this.ShippingAddress1 == input.ShippingAddress1 ||
                    (this.ShippingAddress1 != null &&
                    this.ShippingAddress1.Equals(input.ShippingAddress1))
                ) && 
                (
                    this.ShippingAddress2 == input.ShippingAddress2 ||
                    (this.ShippingAddress2 != null &&
                    this.ShippingAddress2.Equals(input.ShippingAddress2))
                ) && 
                (
                    this.ShippingCityName == input.ShippingCityName ||
                    (this.ShippingCityName != null &&
                    this.ShippingCityName.Equals(input.ShippingCityName))
                ) && 
                (
                    this.ShippingCountryName == input.ShippingCountryName ||
                    (this.ShippingCountryName != null &&
                    this.ShippingCountryName.Equals(input.ShippingCountryName))
                ) && 
                (
                    this.ShippingFullName == input.ShippingFullName ||
                    (this.ShippingFullName != null &&
                    this.ShippingFullName.Equals(input.ShippingFullName))
                ) && 
                (
                    this.ShippingPostalCode == input.ShippingPostalCode ||
                    (this.ShippingPostalCode != null &&
                    this.ShippingPostalCode.Equals(input.ShippingPostalCode))
                ) && 
                (
                    this.ShippingStateName == input.ShippingStateName ||
                    (this.ShippingStateName != null &&
                    this.ShippingStateName.Equals(input.ShippingStateName))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.StateTax == input.StateTax ||
                    (this.StateTax != null &&
                    this.StateTax.Equals(input.StateTax))
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.VendorId == input.VendorId ||
                    (this.VendorId != null &&
                    this.VendorId.Equals(input.VendorId))
                ) && 
                (
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
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
                if (this.BillingAddress1 != null)
                    hashCode = hashCode * 59 + this.BillingAddress1.GetHashCode();
                if (this.BillingAddress2 != null)
                    hashCode = hashCode * 59 + this.BillingAddress2.GetHashCode();
                if (this.BillingCityName != null)
                    hashCode = hashCode * 59 + this.BillingCityName.GetHashCode();
                if (this.BillingCountryName != null)
                    hashCode = hashCode * 59 + this.BillingCountryName.GetHashCode();
                if (this.BillingFullName != null)
                    hashCode = hashCode * 59 + this.BillingFullName.GetHashCode();
                if (this.BillingPostalCode != null)
                    hashCode = hashCode * 59 + this.BillingPostalCode.GetHashCode();
                if (this.BillingStateName != null)
                    hashCode = hashCode * 59 + this.BillingStateName.GetHashCode();
                if (this.CartId != null)
                    hashCode = hashCode * 59 + this.CartId.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CurrentFulfillmentStatus != null)
                    hashCode = hashCode * 59 + this.CurrentFulfillmentStatus.GetHashCode();
                if (this.CurrentPaymentStatus != null)
                    hashCode = hashCode * 59 + this.CurrentPaymentStatus.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ExternalRef != null)
                    hashCode = hashCode * 59 + this.ExternalRef.GetHashCode();
                if (this.FedTax != null)
                    hashCode = hashCode * 59 + this.FedTax.GetHashCode();
                if (this.GrandTotal != null)
                    hashCode = hashCode * 59 + this.GrandTotal.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.NamePrefix != null)
                    hashCode = hashCode * 59 + this.NamePrefix.GetHashCode();
                if (this.OrderNotes != null)
                    hashCode = hashCode * 59 + this.OrderNotes.GetHashCode();
                if (this.ParentInvoiceId != null)
                    hashCode = hashCode * 59 + this.ParentInvoiceId.GetHashCode();
                if (this.PaymentMethodId != null)
                    hashCode = hashCode * 59 + this.PaymentMethodId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Shipping != null)
                    hashCode = hashCode * 59 + this.Shipping.GetHashCode();
                if (this.ShippingAddress1 != null)
                    hashCode = hashCode * 59 + this.ShippingAddress1.GetHashCode();
                if (this.ShippingAddress2 != null)
                    hashCode = hashCode * 59 + this.ShippingAddress2.GetHashCode();
                if (this.ShippingCityName != null)
                    hashCode = hashCode * 59 + this.ShippingCityName.GetHashCode();
                if (this.ShippingCountryName != null)
                    hashCode = hashCode * 59 + this.ShippingCountryName.GetHashCode();
                if (this.ShippingFullName != null)
                    hashCode = hashCode * 59 + this.ShippingFullName.GetHashCode();
                if (this.ShippingPostalCode != null)
                    hashCode = hashCode * 59 + this.ShippingPostalCode.GetHashCode();
                if (this.ShippingStateName != null)
                    hashCode = hashCode * 59 + this.ShippingStateName.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.StateTax != null)
                    hashCode = hashCode * 59 + this.StateTax.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.VendorId != null)
                    hashCode = hashCode * 59 + this.VendorId.GetHashCode();
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                return hashCode;
            }
        }

    }

}
