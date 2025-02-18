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
    public partial interface ISellersController
    {
        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="request">Required parameter: Seller Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse CreateSeller(Models.CreateSellerRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="request">Required parameter: Seller Model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> CreateSellerAsync(Models.CreateSellerRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse UpdateSellerMetadata(string sellerId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> UpdateSellerMetadataAsync(string sellerId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Update Seller model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse UpdateSeller(string id, Models.UpdateSellerRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Update Seller model</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> UpdateSellerAsync(string id, Models.UpdateSellerRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse DeleteSeller(string sellerId, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="sellerId">Required parameter: Seller Id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> DeleteSellerAsync(string sellerId, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Seller Id</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Models.GetSellerResponse GetSellerById(string id);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="id">Required parameter: Seller Id</param>
        /// <return>Returns the Models.GetSellerResponse response from the API call</return>
        Task<Models.GetSellerResponse> GetSellerByIdAsync(string id);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="name">Optional parameter: Example: </param>
        /// <param name="document">Optional parameter: Example: </param>
        /// <param name="code">Optional parameter: Example: </param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="type">Optional parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListSellerResponse response from the API call</return>
        Models.ListSellerResponse GetSellers(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="name">Optional parameter: Example: </param>
        /// <param name="document">Optional parameter: Example: </param>
        /// <param name="code">Optional parameter: Example: </param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="type">Optional parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListSellerResponse response from the API call</return>
        Task<Models.ListSellerResponse> GetSellersAsync(
                int? page = null,
                int? size = null,
                string name = null,
                string document = null,
                string code = null,
                string status = null,
                string type = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

    }
} 