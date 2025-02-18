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
    public class CreateSubscriptionItemRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string description;
        private Models.CreatePricingSchemeRequest pricingScheme;
        private string id;
        private string planItemId;
        private List<Models.CreateDiscountRequest> discounts;
        private string name;
        private int? cycles;
        private int? quantity;
        private int? minimumPrice;

        /// <summary>
        /// Item description
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
        /// Pricing scheme
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
        /// Item id
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
        /// Plan item id
        /// </summary>
        [JsonProperty("plan_item_id")]
        public string PlanItemId 
        { 
            get 
            {
                return this.planItemId; 
            } 
            set 
            {
                this.planItemId = value;
                onPropertyChanged("PlanItemId");
            }
        }

        /// <summary>
        /// Discounts for the item
        /// </summary>
        [JsonProperty("discounts")]
        public List<Models.CreateDiscountRequest> Discounts 
        { 
            get 
            {
                return this.discounts; 
            } 
            set 
            {
                this.discounts = value;
                onPropertyChanged("Discounts");
            }
        }

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
        /// Number of cycles which the item will be charged
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
        /// Quantity of items
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
        /// Minimum price
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
    }
} 