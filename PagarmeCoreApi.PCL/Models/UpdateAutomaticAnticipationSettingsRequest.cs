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
    public class UpdateAutomaticAnticipationSettingsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? enabled;
        private string type;
        private int? volumePercentage;
        private int? delay;
        private int? days;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled 
        { 
            get 
            {
                return this.enabled; 
            } 
            set 
            {
                this.enabled = value;
                onPropertyChanged("Enabled");
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
        [JsonProperty("volume_percentage")]
        public int? VolumePercentage 
        { 
            get 
            {
                return this.volumePercentage; 
            } 
            set 
            {
                this.volumePercentage = value;
                onPropertyChanged("VolumePercentage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("delay")]
        public int? Delay 
        { 
            get 
            {
                return this.delay; 
            } 
            set 
            {
                this.delay = value;
                onPropertyChanged("Delay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("days")]
        public int? Days 
        { 
            get 
            {
                return this.days; 
            } 
            private set 
            {
                this.days = value;
                onPropertyChanged("Days");
            }
        }
    }
} 