/*
 * PagarmeCoreApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagarmeCoreApi.PCL;
using PagarmeCoreApi.PCL.Utilities;
using PagarmeCoreApi.PCL.Http.Request;
using PagarmeCoreApi.PCL.Http.Response;
using PagarmeCoreApi.PCL.Http.Client;

namespace PagarmeCoreApi.PCL.Controllers
{
    public partial interface ITransactionsController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransactionResponse response from the API call</return>
        Models.GetTransactionResponse GetTransaction(string transactionId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetTransactionResponse response from the API call</return>
        Task<Models.GetTransactionResponse> GetTransactionAsync(string transactionId);

    }
} 