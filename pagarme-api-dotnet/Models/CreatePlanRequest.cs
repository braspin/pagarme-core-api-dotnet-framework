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
    public class CreatePlanRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string description;
        private string statementDescriptor;
        private List<Models.CreatePlanItemRequest> items;
        private bool shippable;
        private List<string> paymentMethods;
        private List<int> installments;
        private string currency;
        private string interval;
        private int intervalCount;
        private List<int> billingDays;
        private string billingType;
        private Models.CreatePricingSchemeRequest pricingScheme;
        private Dictionary<string, string> metadata;
        private int? minimumPrice;
        private int? cycles;
        private int? quantity;
        private int? trialPeriodDays;

        /// <summary>
        /// Plan's name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Text that will be printed on the credit card's statement
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Plan items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreatePlanItemRequest> Items 
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
        /// Indicates if the plan is shippable
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable 
        { 
            get 
            {
                return this.shippable; 
            } 
            set 
            {
                this.shippable = value;
                onPropertyChanged("Shippable");
            }
        }

        /// <summary>
        /// Allowed payment methods for the plan
        /// </summary>
        [JsonProperty("payment_methods")]
        public List<string> PaymentMethods 
        { 
            get 
            {
                return this.paymentMethods; 
            } 
            set 
            {
                this.paymentMethods = value;
                onPropertyChanged("PaymentMethods");
            }
        }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments")]
        public List<int> Installments 
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
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Interval
        /// </summary>
        [JsonProperty("interval")]
        public string Interval 
        { 
            get 
            {
                return this.interval; 
            } 
            set 
            {
                this.interval = value;
                onPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// Interval counts between two charges. For instance, if the interval is 'month' and count is 2, the customer will be charged once every two months.
        /// </summary>
        [JsonProperty("interval_count")]
        public int IntervalCount 
        { 
            get 
            {
                return this.intervalCount; 
            } 
            set 
            {
                this.intervalCount = value;
                onPropertyChanged("IntervalCount");
            }
        }

        /// <summary>
        /// Allowed billings days for the subscription, in case the plan type is 'exact_day'
        /// </summary>
        [JsonProperty("billing_days")]
        public List<int> BillingDays 
        { 
            get 
            {
                return this.billingDays; 
            } 
            set 
            {
                this.billingDays = value;
                onPropertyChanged("BillingDays");
            }
        }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("billing_type")]
        public string BillingType 
        { 
            get 
            {
                return this.billingType; 
            } 
            set 
            {
                this.billingType = value;
                onPropertyChanged("BillingType");
            }
        }

        /// <summary>
        /// Plan's pricing scheme
        /// </summary>
        [JsonProperty("pricing_scheme")]
        public Models.CreatePricingSchemeRequest PricingScheme 
        { 
            get 
            {
                return this.pricingScheme; 
            } 
            set 
            {
                this.pricingScheme = value;
                onPropertyChanged("PricingScheme");
            }
        }

        /// <summary>
        /// Metadata
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
        /// Minimum price that will be charged
        /// </summary>
        [JsonProperty("minimum_price")]
        public int? MinimumPrice 
        { 
            get 
            {
                return this.minimumPrice; 
            } 
            set 
            {
                this.minimumPrice = value;
                onPropertyChanged("MinimumPrice");
            }
        }

        /// <summary>
        /// Number of cycles
        /// </summary>
        [JsonProperty("cycles")]
        public int? Cycles 
        { 
            get 
            {
                return this.cycles; 
            } 
            set 
            {
                this.cycles = value;
                onPropertyChanged("Cycles");
            }
        }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Trial period, where the customer will not be charged.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public int? TrialPeriodDays 
        { 
            get 
            {
                return this.trialPeriodDays; 
            } 
            set 
            {
                this.trialPeriodDays = value;
                onPropertyChanged("TrialPeriodDays");
            }
        }
    }
} 