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
    public class CreateAnticipationRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int amount;
        private string timeframe;
        private DateTime paymentDate;

        /// <summary>
        /// Amount requested for the anticipation
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
        /// Timeframe
        /// </summary>
        [JsonProperty("timeframe")]
        public string Timeframe 
        { 
            get 
            {
                return this.timeframe; 
            } 
            set 
            {
                this.timeframe = value;
                onPropertyChanged("Timeframe");
            }
        }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("payment_date")]
        public DateTime PaymentDate 
        { 
            get 
            {
                return this.paymentDate; 
            } 
            set 
            {
                this.paymentDate = value;
                onPropertyChanged("PaymentDate");
            }
        }
    }
} 