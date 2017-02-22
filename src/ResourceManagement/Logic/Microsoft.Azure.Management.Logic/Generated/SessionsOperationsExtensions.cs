// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SessionsOperations.
    /// </summary>
    public static partial class SessionsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of integration account sessions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<IntegrationAccountSession> ListByIntegrationAccounts(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, ODataQuery<IntegrationAccountSessionFilter> odataQuery = default(ODataQuery<IntegrationAccountSessionFilter>))
            {
                return operations.ListByIntegrationAccountsAsync(resourceGroupName, integrationAccountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration account sessions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccountSession>> ListByIntegrationAccountsAsync(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, ODataQuery<IntegrationAccountSessionFilter> odataQuery = default(ODataQuery<IntegrationAccountSessionFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIntegrationAccountsWithHttpMessagesAsync(resourceGroupName, integrationAccountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an integration account session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='sessionName'>
            /// The integration account session name.
            /// </param>
            public static object Get(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, string sessionName)
            {
                return operations.GetAsync(resourceGroupName, integrationAccountName, sessionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an integration account session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='sessionName'>
            /// The integration account session name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, string sessionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, integrationAccountName, sessionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates an integration account session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='sessionName'>
            /// The integration account session name.
            /// </param>
            /// <param name='session'>
            /// The integration account session.
            /// </param>
            public static IntegrationAccountSession CreateOrUpdate(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, string sessionName, IntegrationAccountSession session)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, integrationAccountName, sessionName, session).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates an integration account session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='sessionName'>
            /// The integration account session name.
            /// </param>
            /// <param name='session'>
            /// The integration account session.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntegrationAccountSession> CreateOrUpdateAsync(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, string sessionName, IntegrationAccountSession session, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, integrationAccountName, sessionName, session, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an integration account session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='sessionName'>
            /// The integration account session name.
            /// </param>
            public static void Delete(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, string sessionName)
            {
                operations.DeleteAsync(resourceGroupName, integrationAccountName, sessionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an integration account session.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='integrationAccountName'>
            /// The integration account name.
            /// </param>
            /// <param name='sessionName'>
            /// The integration account session name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISessionsOperations operations, string resourceGroupName, string integrationAccountName, string sessionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, integrationAccountName, sessionName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a list of integration account sessions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<IntegrationAccountSession> ListByIntegrationAccountsNext(this ISessionsOperations operations, string nextPageLink)
            {
                return operations.ListByIntegrationAccountsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of integration account sessions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<IntegrationAccountSession>> ListByIntegrationAccountsNextAsync(this ISessionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByIntegrationAccountsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

