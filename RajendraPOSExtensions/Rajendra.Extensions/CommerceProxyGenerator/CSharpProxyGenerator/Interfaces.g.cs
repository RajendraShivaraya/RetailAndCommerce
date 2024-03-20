// <auto-generated />
namespace Rajendra.Commerce.RetailProxy.Extension
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.Dynamics.Commerce.RetailProxy;

    
    /// <summary>
    /// Interface for Store Operations Manager.
    /// </summary>
    [GeneratedCodeAttribute("Rajendra.Commerce.RetailProxy.Extension", "1.0")]
    public interface IStoreOperationsManager : IEntityManager
    {
        
        /// <summary>
        /// RajSamplePostFromCommonProject method.
        /// </summary>
        /// <returns>bool object.</returns>
        Task<bool> RajSamplePostFromCommonProject();
    
        /// <summary>
        /// RajSampleGetFromCommonProject method.
        /// </summary>
        /// <returns>bool object.</returns>
        Task<bool> RajSampleGetFromCommonProject();
    
    }
    
    /// <summary>
    /// Interface for RajStoreDayHoursEntity Manager.
    /// </summary>
    [GeneratedCodeAttribute("Rajendra.Commerce.RetailProxy.Extension", "1.0")]
    public interface IRajStoreDayHoursEntityManager : IEntityManager
    {
        
        /// <summary>
        /// GetStoreHoursByRecIdFromCommonProject method.
        /// </summary>
        /// <param name="storeNumber">The storeNumber.</param>
        /// <param name="queryResultSettings">The queryResultSettings.</param>
        /// <returns>Collection of RajStoreDayHoursEntity.</returns>
        Task<PagedResult<RajStoreDayHoursEntity>> GetStoreHoursByRecIdFromCommonProject(string storeNumber, QueryResultSettings queryResultSettings = null);
    
        /// <summary>
        /// GetMyNameFromCommonProject method.
        /// </summary>
        /// <returns>string object.</returns>
        Task<string> GetMyNameFromCommonProject();
    
        /// <summary>
        /// GetSampleForBooleanFromCommonProject method.
        /// </summary>
        /// <returns>bool object.</returns>
        Task<bool> GetSampleForBooleanFromCommonProject();
    
    }
    
 }
