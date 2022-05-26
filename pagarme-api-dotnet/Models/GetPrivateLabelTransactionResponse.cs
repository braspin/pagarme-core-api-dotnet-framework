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
    public class GetPrivateLabelTransactionResponse : GetTransactionResponse 
    {
        // These fields hold the values for the public properties.
        private string statementDescriptor;
        private string acquirerName;
        private string acquirerAffiliationCode;
        private string acquirerTid;
        private string acquirerNsu;
        private string acquirerAuthCode;
        private string operationType;
        private Models.GetCardResponse card;
        private string acquirerMessage;
        private string acquirerReturnCode;
        private int? installments;

        /// <summary>
        /// Text that will appear on the credit card's statement
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
        /// Acquirer name
        /// </summary>
        [JsonProperty("acquirer_name")]
        public string AcquirerName 
        { 
            get 
            {
                return this.acquirerName; 
            } 
            set 
            {
                this.acquirerName = value;
                onPropertyChanged("AcquirerName");
            }
        }

        /// <summary>
        /// Aquirer affiliation code
        /// </summary>
        [JsonProperty("acquirer_affiliation_code")]
        public string AcquirerAffiliationCode 
        { 
            get 
            {
                return this.acquirerAffiliationCode; 
            } 
            set 
            {
                this.acquirerAffiliationCode = value;
                onPropertyChanged("AcquirerAffiliationCode");
            }
        }

        /// <summary>
        /// Acquirer TID
        /// </summary>
        [JsonProperty("acquirer_tid")]
        public string AcquirerTid 
        { 
            get 
            {
                return this.acquirerTid; 
            } 
            set 
            {
                this.acquirerTid = value;
                onPropertyChanged("AcquirerTid");
            }
        }

        /// <summary>
        /// Acquirer NSU
        /// </summary>
        [JsonProperty("acquirer_nsu")]
        public string AcquirerNsu 
        { 
            get 
            {
                return this.acquirerNsu; 
            } 
            set 
            {
                this.acquirerNsu = value;
                onPropertyChanged("AcquirerNsu");
            }
        }

        /// <summary>
        /// Acquirer authorization code
        /// </summary>
        [JsonProperty("acquirer_auth_code")]
        public string AcquirerAuthCode 
        { 
            get 
            {
                return this.acquirerAuthCode; 
            } 
            set 
            {
                this.acquirerAuthCode = value;
                onPropertyChanged("AcquirerAuthCode");
            }
        }

        /// <summary>
        /// Operation type
        /// </summary>
        [JsonProperty("operation_type")]
        public string OperationType 
        { 
            get 
            {
                return this.operationType; 
            } 
            set 
            {
                this.operationType = value;
                onPropertyChanged("OperationType");
            }
        }

        /// <summary>
        /// Card data
        /// </summary>
        [JsonProperty("card")]
        public Models.GetCardResponse Card 
        { 
            get 
            {
                return this.card; 
            } 
            set 
            {
                this.card = value;
                onPropertyChanged("Card");
            }
        }

        /// <summary>
        /// Acquirer message
        /// </summary>
        [JsonProperty("acquirer_message")]
        public string AcquirerMessage 
        { 
            get 
            {
                return this.acquirerMessage; 
            } 
            set 
            {
                this.acquirerMessage = value;
                onPropertyChanged("AcquirerMessage");
            }
        }

        /// <summary>
        /// Acquirer Return Code
        /// </summary>
        [JsonProperty("acquirer_return_code")]
        public string AcquirerReturnCode 
        { 
            get 
            {
                return this.acquirerReturnCode; 
            } 
            set 
            {
                this.acquirerReturnCode = value;
                onPropertyChanged("AcquirerReturnCode");
            }
        }

        /// <summary>
        /// Number of installments
        /// </summary>
        [JsonProperty("installments")]
        public int? Installments 
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
    }
} 