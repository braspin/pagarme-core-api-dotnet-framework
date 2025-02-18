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
    public class CreateEmvDataDukptDecryptRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string ksn;

        /// <summary>
        /// Key serial number
        /// </summary>
        [JsonProperty("ksn")]
        public string Ksn 
        { 
            get 
            {
                return this.ksn; 
            } 
            set 
            {
                this.ksn = value;
                onPropertyChanged("Ksn");
            }
        }
    }
} 