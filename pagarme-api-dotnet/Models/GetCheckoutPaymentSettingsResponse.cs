/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;


namespace PagarmeCoreApi.PCL.Models
{
    public class GetCheckoutPaymentSettingsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string successUrl;
        private string paymentUrl;
        private List<string> acceptedPaymentMethods;
        private string status;
        private Models.GetCustomerResponse customer;
        private int? amount;
        private string defaultPaymentMethod;
        private string gatewayAffiliationId;

        /// <summary>
        /// Success Url
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl 
        { 
            get 
            {
                return this.successUrl; 
            } 
            set 
            {
                this.successUrl = value;
                onPropertyChanged("SuccessUrl");
            }
        }

        /// <summary>
        /// Payment Url
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl 
        { 
            get 
            {
                return this.paymentUrl; 
            } 
            set 
            {
                this.paymentUrl = value;
                onPropertyChanged("PaymentUrl");
            }
        }

        /// <summary>
        /// Accepted Payment Methods
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods 
        { 
            get 
            {
                return this.acceptedPaymentMethods; 
            } 
            set 
            {
                this.acceptedPaymentMethods = value;
                onPropertyChanged("AcceptedPaymentMethods");
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer 
        { 
            get 
            {
                return this.customer; 
            } 
            set 
            {
                this.customer = value;
                onPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// Payment amount
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Default Payment Method
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod 
        { 
            get 
            {
                return this.defaultPaymentMethod; 
            } 
            set 
            {
                this.defaultPaymentMethod = value;
                onPropertyChanged("DefaultPaymentMethod");
            }
        }

        /// <summary>
        /// Gateway Affiliation Id
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }
    }
} 