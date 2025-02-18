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
    public class CreateCheckoutCreditCardPaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string statementDescriptor;
        private List<Models.CreateCheckoutCardInstallmentOptionRequest> installments;
        private Models.CreatePaymentAuthenticationRequest authentication;
        private bool? capture;

        /// <summary>
        /// Card invoice text descriptor
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor 
        { 
            get 
            {
                return this.statementDescriptor; 
            } 
            set 
            {
                this.statementDescriptor = value;
                onPropertyChanged("StatementDescriptor");
            }
        }

        /// <summary>
        /// Payment installment options
        /// </summary>
        [JsonProperty("installments")]
        public List<Models.CreateCheckoutCardInstallmentOptionRequest> Installments 
        { 
            get 
            {
                return this.installments; 
            } 
            set 
            {
                this.installments = value;
                onPropertyChanged("Installments");
            }
        }

        /// <summary>
        /// Creates payment authentication
        /// </summary>
        [JsonProperty("authentication")]
        public Models.CreatePaymentAuthenticationRequest Authentication 
        { 
            get 
            {
                return this.authentication; 
            } 
            set 
            {
                this.authentication = value;
                onPropertyChanged("Authentication");
            }
        }

        /// <summary>
        /// Authorize and capture?
        /// </summary>
        [JsonProperty("capture")]
        public bool? Capture 
        { 
            get 
            {
                return this.capture; 
            } 
            set 
            {
                this.capture = value;
                onPropertyChanged("Capture");
            }
        }
    }
} 