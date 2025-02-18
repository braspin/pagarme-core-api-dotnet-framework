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
    public class CreateCardPaymentContactlessRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type;
        private Models.CreateApplePayRequest applePay;
        private Models.CreateGooglePayRequest googlePay;
        private Models.CreateEmvDecryptRequest emv;

        /// <summary>
        /// The authentication type
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
        /// The ApplePay encrypted request
        /// </summary>
        [JsonProperty("apple_pay")]
        public Models.CreateApplePayRequest ApplePay 
        { 
            get 
            {
                return this.applePay; 
            } 
            set 
            {
                this.applePay = value;
                onPropertyChanged("ApplePay");
            }
        }

        /// <summary>
        /// The GooglePay encrypted request
        /// </summary>
        [JsonProperty("google_pay")]
        public Models.CreateGooglePayRequest GooglePay 
        { 
            get 
            {
                return this.googlePay; 
            } 
            set 
            {
                this.googlePay = value;
                onPropertyChanged("GooglePay");
            }
        }

        /// <summary>
        /// The Emv encrypted request
        /// </summary>
        [JsonProperty("emv")]
        public Models.CreateEmvDecryptRequest Emv 
        { 
            get 
            {
                return this.emv; 
            } 
            set 
            {
                this.emv = value;
                onPropertyChanged("Emv");
            }
        }
    }
} 