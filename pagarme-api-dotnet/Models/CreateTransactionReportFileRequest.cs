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
    public class CreateTransactionReportFileRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private DateTime? startAt;
        private string endAt;

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_at")]
        public DateTime? StartAt 
        { 
            get 
            {
                return this.startAt; 
            } 
            set 
            {
                this.startAt = value;
                onPropertyChanged("StartAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("end_at")]
        public string EndAt 
        { 
            get 
            {
                return this.endAt; 
            } 
            set 
            {
                this.endAt = value;
                onPropertyChanged("EndAt");
            }
        }
    }
} 