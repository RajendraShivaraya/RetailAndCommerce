
    /*!
    * Copyright (c) Microsoft Corporation.
    * All rights reserved. See LICENSE in the project root for license information.
    * THIS FILE IS AN AUTOGENERATED TYPESCRIPT PROXY EXTENSION.
    * TO USE THIS FILE, IT MUST BE ADDED TO A D365COMMERCE APPLICATION
    */
    import {
        AsyncResult,
        callActionOrExecute,
        DataServiceQuery,
        IContext,
        IDataServiceRequest,
        IQueryResultSettings,
        // @ts-ignore -- Unused import
        NullResult
    } from '@msdyn365-commerce/retail-proxy';
    // @ts-ignore -- Unused import
    import * as EntityClasses from '@msdyn365-commerce/retail-proxy/dist/Entities/CommerceModels.g';
    // @ts-ignore -- Unused import
    import * as Entities from '@msdyn365-commerce/retail-proxy/dist/Entities/CommerceTypes.g';
    import * as DataServiceEntities from './DataServiceEntities.g';

    
    function rajSamplePostQuery(): DataServiceQuery {
          return new DataServiceQuery();
          }

    
    export function rajSamplePostInput (
        
    ): IDataServiceRequest {
      const query = rajSamplePostQuery();
      return query.createDataServiceRequestForOperation(
          'RajSamplePost',
          true, 
            ''
          ,
          'false',
          { bypassCache: 'get', returnEntity: '' },
          {
          
          }
      );
    }

    export function rajSamplePostAsync (
        context: IContext
        ): AsyncResult<boolean> {
        const request = rajSamplePostInput();
        return callActionOrExecute<boolean>(request, context.callerContext);
        }
      
    function rajSampleGetQuery(): DataServiceQuery {
          return new DataServiceQuery();
          }

    
    export function rajSampleGetInput (
        
    ): IDataServiceRequest {
      const query = rajSampleGetQuery();
      return query.createDataServiceRequestForOperation(
          'RajSampleGet',
          false, 
            ''
          ,
          'false',
          { bypassCache: 'get', returnEntity: '' },
          {
          
          }
      );
    }

    export function rajSampleGetAsync (
        context: IContext
        ): AsyncResult<boolean> {
        const request = rajSampleGetInput();
        return callActionOrExecute<boolean>(request, context.callerContext);
        }
      

        // @ts-ignore
        function rajendraEntityAPIQuery(id?: number): DataServiceQuery {
        const key = (id) ? { Id: id } :null;
        return new DataServiceQuery("RajendraEntityAPI", "RajStoreDayHoursEntity", DataServiceEntities.RajStoreDayHoursEntityExtensionClass, key);
        }

        
    export function createGetStoreHoursByRecIdInput(queryResultSettings: IQueryResultSettings, storeNumber: string): IDataServiceRequest {
    const query = rajendraEntityAPIQuery().resultSettings(queryResultSettings);
    return query.createDataServiceRequestForOperation('GetStoreHoursByRecId', true, DataServiceEntities.RajStoreDayHoursEntityExtensionClass, 'true', {bypassCache: 'none', returnEntity: 'DataServiceEntities.IRajStoreDayHoursEntity'}, {storeNumber: storeNumber });
    }

    
    export function getStoreHoursByRecIdAsync(context: IContext, storeNumber: string): AsyncResult<DataServiceEntities.IRajStoreDayHoursEntity[]> {
    const request = createGetStoreHoursByRecIdInput(
      context.queryResultSettings || {}, storeNumber);
    return callActionOrExecute<DataServiceEntities.IRajStoreDayHoursEntity[]>(request, context.callerContext);
    }
  
    export function createGetMyNameInput(): IDataServiceRequest {
    const query = rajendraEntityAPIQuery();
    return query.createDataServiceRequestForOperation('GetMyName', false, '', 'false', {bypassCache: 'none', returnEntity: ''}, { });
    }

    
    export function getMyNameAsync(context: IContext): AsyncResult<string> {
    const request = createGetMyNameInput();
    return callActionOrExecute<string>(request, context.callerContext);
    }
  
    export function createGetSampleForBooleanInput(): IDataServiceRequest {
    const query = rajendraEntityAPIQuery();
    return query.createDataServiceRequestForOperation('GetSampleForBoolean', false, '', 'false', {bypassCache: 'none', returnEntity: ''}, { });
    }

    
    export function getSampleForBooleanAsync(context: IContext): AsyncResult<boolean> {
    const request = createGetSampleForBooleanInput();
    return callActionOrExecute<boolean>(request, context.callerContext);
    }
  