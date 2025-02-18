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
    public class CreatePaymentRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string paymentMethod;
        private Models.CreateCreditCardPaymentRequest creditCard;
        private Models.CreateDebitCardPaymentRequest debitCard;
        private Models.CreateBoletoPaymentRequest boleto;
        private string currency;
        private Models.CreateVoucherPaymentRequest voucher;
        private List<Models.CreateSplitRequest> split;
        private Models.CreateBankTransferPaymentRequest bankTransfer;
        private string gatewayAffiliationId;
        private int? amount;
        private Models.CreateCheckoutPaymentRequest checkout;
        private string customerId;
        private Models.CreateCustomerRequest customer;
        private Dictionary<string, string> metadata;
        private Models.CreateCashPaymentRequest cash;
        private Models.CreatePrivateLabelPaymentRequest privateLabel;
        private Models.CreatePixPaymentRequest pix;

        /// <summary>
        /// Payment method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// Settings for credit card payment
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.CreateCreditCardPaymentRequest CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// Settings for debit card payment
        /// </summary>
        [JsonProperty("debit_card")]
        public Models.CreateDebitCardPaymentRequest DebitCard 
        { 
            get 
            {
                return this.debitCard; 
            } 
            set 
            {
                this.debitCard = value;
                onPropertyChanged("DebitCard");
            }
        }

        /// <summary>
        /// Settings for boleto payment
        /// </summary>
        [JsonProperty("boleto")]
        public Models.CreateBoletoPaymentRequest Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }

        /// <summary>
        /// Currency. Must be informed using 3 characters
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// Settings for voucher payment
        /// </summary>
        [JsonProperty("voucher")]
        public Models.CreateVoucherPaymentRequest Voucher 
        { 
            get 
            {
                return this.voucher; 
            } 
            set 
            {
                this.voucher = value;
                onPropertyChanged("Voucher");
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
        /// Settings for bank transfer payment
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.CreateBankTransferPaymentRequest BankTransfer 
        { 
            get 
            {
                return this.bankTransfer; 
            } 
            set 
            {
                this.bankTransfer = value;
                onPropertyChanged("BankTransfer");
            }
        }

        /// <summary>
        /// Gateway affiliation code
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }

        /// <summary>
        /// The amount of the payment, in cents
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
        /// Settings for checkout payment
        /// </summary>
        [JsonProperty("checkout")]
        public Models.CreateCheckoutPaymentRequest Checkout 
        { 
            get 
            {
                return this.checkout; 
            } 
            set 
            {
                this.checkout = value;
                onPropertyChanged("Checkout");
            }
        }

        /// <summary>
        /// Customer Id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId 
        { 
            get 
            {
                return this.customerId; 
            } 
            set 
            {
                this.customerId = value;
                onPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Customer
        /// </summary>
        [JsonProperty("customer")]
        public Models.CreateCustomerRequest Customer 
        { 
            get 
            {
                return this.customer; 
            } 
            set 
            {
                this.customer = value;
                onPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// Settings for cash payment
        /// </summary>
        [JsonProperty("cash")]
        public Models.CreateCashPaymentRequest Cash 
        { 
            get 
            {
                return this.cash; 
            } 
            set 
            {
                this.cash = value;
                onPropertyChanged("Cash");
            }
        }

        /// <summary>
        /// Settings for private label payment
        /// </summary>
        [JsonProperty("private_label")]
        public Models.CreatePrivateLabelPaymentRequest PrivateLabel 
        { 
            get 
            {
                return this.privateLabel; 
            } 
            set 
            {
                this.privateLabel = value;
                onPropertyChanged("PrivateLabel");
            }
        }

        /// <summary>
        /// Settings for pix payment
        /// </summary>
        [JsonProperty("pix")]
        public Models.CreatePixPaymentRequest Pix 
        { 
            get 
            {
                return this.pix; 
            } 
            set 
            {
                this.pix = value;
                onPropertyChanged("Pix");
            }
        }
    }
} 