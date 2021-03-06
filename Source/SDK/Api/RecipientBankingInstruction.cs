//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// Recipient bank Details.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class RecipientBankingInstruction : PayPalSerializableObject
    {
        /// <summary>
        /// Name of the financial institution.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_name")]
        public string bank_name { get; set; }

        /// <summary>
        /// Name of the account holder
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_holder_name")]
        public string account_holder_name { get; set; }

        /// <summary>
        /// bank account number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "account_number")]
        public string account_number { get; set; }

        /// <summary>
        /// bank routing number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routing_number")]
        public string routing_number { get; set; }

        /// <summary>
        /// IBAN equivalent of the bank
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "international_bank_account_number")]
        public string international_bank_account_number { get; set; }

        /// <summary>
        /// BIC identifier of the financial institution
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bank_identifier_code")]
        public string bank_identifier_code { get; set; }
    }
}
