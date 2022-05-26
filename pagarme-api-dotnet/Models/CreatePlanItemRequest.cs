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
    public class CreatePlanItemRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private Models.CreatePricingSchemeRequest pricingScheme;
        private string id;
        private string description;
        private int? cycles;
        private int? quantity;

        /// <summary>
        /// Item name
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
        /// Item's pricing scheme
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
        /// Item's id
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
        /// Item's description
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
        /// Number of cycles where the item will be charged
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
    }
} 