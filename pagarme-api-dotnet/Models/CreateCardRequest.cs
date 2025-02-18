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
    public class CreateCardRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string number;
        private string holderName;
        private int expMonth;
        private int expYear;
        private string cvv;
        private Models.CreateAddressRequest billingAddress;
        private string brand;
        private string billingAddressId;
        private Dictionary<string, string> metadata;
        private string type = "credit";
        private Models.CreateCardOptionsRequest options;
        private string holderDocument;
        private bool privateLabel;
        private string label;
        private string id;
        private string token;

        /// <summary>
        /// Credit card number
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// Holder name, as written on the card
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName 
        { 
            get 
            {
                return this.holderName; 
            } 
            set 
            {
                this.holderName = value;
                onPropertyChanged("HolderName");
            }
        }

        /// <summary>
        /// The expiration month
        /// </summary>
        [JsonProperty("exp_month")]
        public int ExpMonth 
        { 
            get 
            {
                return this.expMonth; 
            } 
            set 
            {
                this.expMonth = value;
                onPropertyChanged("ExpMonth");
            }
        }

        /// <summary>
        /// The expiration year, that can be informed with 2 or 4 digits
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpYear 
        { 
            get 
            {
                return this.expYear; 
            } 
            set 
            {
                this.expYear = value;
                onPropertyChanged("ExpYear");
            }
        }

        /// <summary>
        /// The card's security code
        /// </summary>
        [JsonProperty("cvv")]
        public string Cvv 
        { 
            get 
            {
                return this.cvv; 
            } 
            set 
            {
                this.cvv = value;
                onPropertyChanged("Cvv");
            }
        }

        /// <summary>
        /// Card's billing address
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.CreateAddressRequest BillingAddress 
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
        /// Card brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand 
        { 
            get 
            {
                return this.brand; 
            } 
            set 
            {
                this.brand = value;
                onPropertyChanged("Brand");
            }
        }

        /// <summary>
        /// The address id for the billing address
        /// </summary>
        [JsonProperty("billing_address_id")]
        public string BillingAddressId 
        { 
            get 
            {
                return this.billingAddressId; 
            } 
            set 
            {
                this.billingAddressId = value;
                onPropertyChanged("BillingAddressId");
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
        /// Card type
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Options for creating the card
        /// </summary>
        [JsonProperty("options")]
        public Models.CreateCardOptionsRequest Options 
        { 
            get 
            {
                return this.options; 
            } 
            set 
            {
                this.options = value;
                onPropertyChanged("Options");
            }
        }

        /// <summary>
        /// Document number for the card's holder
        /// </summary>
        [JsonProperty("holder_document")]
        public string HolderDocument 
        { 
            get 
            {
                return this.holderDocument; 
            } 
            set 
            {
                this.holderDocument = value;
                onPropertyChanged("HolderDocument");
            }
        }

        /// <summary>
        /// Indicates whether it is a private label card
        /// </summary>
        [JsonProperty("private_label")]
        public bool PrivateLabel 
        { 
            get 
            {
                return this.privateLabel; 
            } 
            set 
            {
                this.privateLabel = value;
                onPropertyChanged("PrivateLabel");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("label")]
        public string Label 
        { 
            get 
            {
                return this.label; 
            } 
            set 
            {
                this.label = value;
                onPropertyChanged("Label");
            }
        }

        /// <summary>
        /// Identifier
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
        /// token identifier
        /// </summary>
        [JsonProperty("token")]
        public string Token 
        { 
            get 
            {
                return this.token; 
            } 
            set 
            {
                this.token = value;
                onPropertyChanged("Token");
            }
        }
    }
} 