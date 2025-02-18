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
    public class GetAnticipationLimitsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.GetAnticipationLimitResponse max;
        private Models.GetAnticipationLimitResponse min;

        /// <summary>
        /// Max limit
        /// </summary>
        [JsonProperty("max")]
        public Models.GetAnticipationLimitResponse Max 
        { 
            get 
            {
                return this.max; 
            } 
            set 
            {
                this.max = value;
                onPropertyChanged("Max");
            }
        }

        /// <summary>
        /// Min limit
        /// </summary>
        [JsonProperty("min")]
        public Models.GetAnticipationLimitResponse Min 
        { 
            get 
            {
                return this.min; 
            } 
            set 
            {
                this.min = value;
                onPropertyChanged("Min");
            }
        }
    }
} 