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
    public class GetBoletoTransactionResponse : GetTransactionResponse 
    {
        // These fields hold the values for the public properties.
        private string url;
        private string barcode;
        private string nossoNumero;
        private string bank;
        private string documentNumber;
        private string instructions;
        private Models.GetBillingAddressResponse billingAddress;
        private DateTime? dueAt;
        private string qrCode;
        private string line;
        private string pdfPassword;
        private string pdf;
        private DateTime? paidAt;
        private string paidAmount;
        private string type;
        private DateTime? creditAt;
        private string statementDescriptor;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("url")]
        public string Url 
        { 
            get 
            {
                return this.url; 
            } 
            set 
            {
                this.url = value;
                onPropertyChanged("Url");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode 
        { 
            get 
            {
                return this.barcode; 
            } 
            set 
            {
                this.barcode = value;
                onPropertyChanged("Barcode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("nosso_numero")]
        public string NossoNumero 
        { 
            get 
            {
                return this.nossoNumero; 
            } 
            set 
            {
                this.nossoNumero = value;
                onPropertyChanged("NossoNumero");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("bank")]
        public string Bank 
        { 
            get 
            {
                return this.bank; 
            } 
            set 
            {
                this.bank = value;
                onPropertyChanged("Bank");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("document_number")]
        public string DocumentNumber 
        { 
            get 
            {
                return this.documentNumber; 
            } 
            set 
            {
                this.documentNumber = value;
                onPropertyChanged("DocumentNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions 
        { 
            get 
            {
                return this.instructions; 
            } 
            set 
            {
                this.instructions = value;
                onPropertyChanged("Instructions");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("billing_address")]
        public Models.GetBillingAddressResponse BillingAddress 
        { 
            get 
            {
                return this.billingAddress; 
            } 
            set 
            {
                this.billingAddress = value;
                onPropertyChanged("BillingAddress");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime? DueAt 
        { 
            get 
            {
                return this.dueAt; 
            } 
            set 
            {
                this.dueAt = value;
                onPropertyChanged("DueAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode 
        { 
            get 
            {
                return this.qrCode; 
            } 
            set 
            {
                this.qrCode = value;
                onPropertyChanged("QrCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("line")]
        public string Line 
        { 
            get 
            {
                return this.line; 
            } 
            set 
            {
                this.line = value;
                onPropertyChanged("Line");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pdf_password")]
        public string PdfPassword 
        { 
            get 
            {
                return this.pdfPassword; 
            } 
            set 
            {
                this.pdfPassword = value;
                onPropertyChanged("PdfPassword");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("pdf")]
        public string Pdf 
        { 
            get 
            {
                return this.pdf; 
            } 
            set 
            {
                this.pdf = value;
                onPropertyChanged("Pdf");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at")]
        public DateTime? PaidAt 
        { 
            get 
            {
                return this.paidAt; 
            } 
            set 
            {
                this.paidAt = value;
                onPropertyChanged("PaidAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("paid_amount")]
        public string PaidAmount 
        { 
            get 
            {
                return this.paidAmount; 
            } 
            set 
            {
                this.paidAmount = value;
                onPropertyChanged("PaidAmount");
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
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("credit_at")]
        public DateTime? CreditAt 
        { 
            get 
            {
                return this.creditAt; 
            } 
            set 
            {
                this.creditAt = value;
                onPropertyChanged("CreditAt");
            }
        }

        /// <summary>
        /// Soft Descriptor
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
    }
} 