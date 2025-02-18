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
    public class GetCardTokenResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string lastFourDigits;
        private string holderName;
        private string holderDocument;
        private string expMonth;
        private string expYear;
        private string brand;
        private string type;
        private string label;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("last_four_digits")]
        public string LastFourDigits 
        { 
            get 
            {
                return this.lastFourDigits; 
            } 
            set 
            {
                this.lastFourDigits = value;
                onPropertyChanged("LastFourDigits");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exp_month")]
        public string ExpMonth 
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("exp_year")]
        public string ExpYear 
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
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
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
    }
} 