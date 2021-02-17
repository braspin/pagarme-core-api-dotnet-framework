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
    public class CreateCancelChargeRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? amount;
        private List<Models.CreateCancelChargeSplitRulesRequest> splitRules;
        private List<Models.CreateSplitRequest> split;
        private string operationReference;

        /// <summary>
        /// The amount that will be canceled.
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
        /// The split rules request
        /// </summary>
        [JsonProperty("split_rules")]
        public List<Models.CreateCancelChargeSplitRulesRequest> SplitRules 
        { 
            get 
            {
                return this.splitRules; 
            } 
            set 
            {
                this.splitRules = value;
                onPropertyChanged("SplitRules");
            }
        }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("split")]
        public List<Models.CreateSplitRequest> Split 
        { 
            get 
            {
                return this.split; 
            } 
            set 
            {
                this.split = value;
                onPropertyChanged("Split");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("operation_reference")]
        public string OperationReference 
        { 
            get 
            {
                return this.operationReference; 
            } 
            set 
            {
                this.operationReference = value;
                onPropertyChanged("OperationReference");
            }
        }
    }
} 