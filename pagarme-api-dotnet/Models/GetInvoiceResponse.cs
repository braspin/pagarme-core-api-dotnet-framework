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
    public class GetInvoiceResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string code;
        private string url;
        private int amount;
        private string status;
        private string paymentMethod;
        private DateTime createdAt;
        private List<Models.GetInvoiceItemResponse> items;
        private Models.GetCustomerResponse customer;
        private Models.GetChargeResponse charge;
        private int installments;
        private Models.GetBillingAddressResponse billingAddress;
        private Models.GetSubscriptionResponse subscription;
        private Models.GetPeriodResponse cycle;
        private Models.GetShippingResponse shipping;
        private Dictionary<string, string> metadata;
        private DateTime? dueAt;
        private DateTime? canceledAt;
        private DateTime? billingAt;
        private DateTime? seenAt;
        private int? totalDiscount;
        private int? totalIncrement;
        private string subscriptionId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("items")]
        public List<Models.GetInvoiceItemResponse> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("charge")]
        public Models.GetChargeResponse Charge 
        { 
            get 
            {
                return this.charge; 
            } 
            set 
            {
                this.charge = value;
                onPropertyChanged("Charge");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("installments")]
        public int Installments 
        { 
            get 
            {
                return this.installments; 
            } 
            set 
            {
                this.installments = value;
                onPropertyChanged("Installments");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("subscription")]
        public Models.GetSubscriptionResponse Subscription 
        { 
            get 
            {
                return this.subscription; 
            } 
            set 
            {
                this.subscription = value;
                onPropertyChanged("Subscription");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("cycle")]
        public Models.GetPeriodResponse Cycle 
        { 
            get 
            {
                return this.cycle; 
            } 
            set 
            {
                this.cycle = value;
                onPropertyChanged("Cycle");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("shipping")]
        public Models.GetShippingResponse Shipping 
        { 
            get 
            {
                return this.shipping; 
            } 
            set 
            {
                this.shipping = value;
                onPropertyChanged("Shipping");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime? DueAt 
        { 
            get 
            {
                return this.dueAt; 
            } 
            set 
            {
                this.dueAt = value;
                onPropertyChanged("DueAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt 
        { 
            get 
            {
                return this.canceledAt; 
            } 
            set 
            {
                this.canceledAt = value;
                onPropertyChanged("CanceledAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("billing_at")]
        public DateTime? BillingAt 
        { 
            get 
            {
                return this.billingAt; 
            } 
            set 
            {
                this.billingAt = value;
                onPropertyChanged("BillingAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("seen_at")]
        public DateTime? SeenAt 
        { 
            get 
            {
                return this.seenAt; 
            } 
            set 
            {
                this.seenAt = value;
                onPropertyChanged("SeenAt");
            }
        }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_discount")]
        public int? TotalDiscount 
        { 
            get 
            {
                return this.totalDiscount; 
            } 
            set 
            {
                this.totalDiscount = value;
                onPropertyChanged("TotalDiscount");
            }
        }

        /// <summary>
        /// Total discounted value
        /// </summary>
        [JsonProperty("total_increment")]
        public int? TotalIncrement 
        { 
            get 
            {
                return this.totalIncrement; 
            } 
            set 
            {
                this.totalIncrement = value;
                onPropertyChanged("TotalIncrement");
            }
        }

        /// <summary>
        /// Subscription Id
        /// </summary>
        [JsonProperty("subscription_id")]
        public string SubscriptionId 
        { 
            get 
            {
                return this.subscriptionId; 
            } 
            set 
            {
                this.subscriptionId = value;
                onPropertyChanged("SubscriptionId");
            }
        }
    }
} 