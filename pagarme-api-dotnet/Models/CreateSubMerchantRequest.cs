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
    public class CreateSubMerchantRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string paymentFacilitatorCode;
        private string code;
        private string name;
        private string merchantCategoryCode;
        private string document;
        private string type;
        private Models.CreatePhoneRequest phone;
        private Models.CreateAddressRequest address;

        /// <summary>
        /// Payment Facilitator Code
        /// </summary>
        [JsonProperty("payment_facilitator_code")]
        public string PaymentFacilitatorCode 
        { 
            get 
            {
                return this.paymentFacilitatorCode; 
            } 
            set 
            {
                this.paymentFacilitatorCode = value;
                onPropertyChanged("PaymentFacilitatorCode");
            }
        }

        /// <summary>
        /// Code
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
        /// Name
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
        /// Merchant Category Code
        /// </summary>
        [JsonProperty("merchant_category_code")]
        public string MerchantCategoryCode 
        { 
            get 
            {
                return this.merchantCategoryCode; 
            } 
            set 
            {
                this.merchantCategoryCode = value;
                onPropertyChanged("MerchantCategoryCode");
            }
        }

        /// <summary>
        /// Document number. Only numbers, no special characters.
        /// </summary>
        [JsonProperty("document")]
        public string Document 
        { 
            get 
            {
                return this.document; 
            } 
            set 
            {
                this.document = value;
                onPropertyChanged("Document");
            }
        }

        /// <summary>
        /// Document type. Can be either 'individual' or 'company'
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
        /// Phone
        /// </summary>
        [JsonProperty("phone")]
        public Models.CreatePhoneRequest Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("address")]
        public Models.CreateAddressRequest Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }
    }
} 