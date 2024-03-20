
  // @ts-ignore -- Unused import
  import * as EntityClasses from '@msdyn365-commerce/retail-proxy/dist/Entities/CommerceModels.g';
  import * as Entities from '@msdyn365-commerce/retail-proxy/dist/Entities/CommerceTypes.g';
  // @ts-ignore -- Unused import
  import { jsonLightReadStringPropertyValue } from '@msdyn365-commerce/retail-proxy/dist/externals';

  
    /**
    * RajStoreDayHoursEntity entity interface.
    */
    export interface IRajStoreDayHoursEntity {
    DayOfWeek: number;
    OpenTime: number;
    CloseTime: number;
    Id: number;
    ExtensionProperties?: Entities.CommerceProperty[];
    }
  
  /**
   * RajStoreDayHoursEntity entity class.
   */
  export class RajStoreDayHoursEntityExtensionClass implements IRajStoreDayHoursEntity {
      
        // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
        public DayOfWeek: number;
      
        // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
        public OpenTime: number;
      
        // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
        public CloseTime: number;
      
        // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
        public Id: number;
      
        // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
        public ExtensionProperties: Entities.CommerceProperty[];
      
      // Navigation properties names
      
      /**
       * Construct an object from odata response.
       * @param {any} odataObject The odata result object.
       */
      constructor(odataObject?: any) {
      odataObject = odataObject || {};
            // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
            this.DayOfWeek = odataObject.DayOfWeek;
              
            // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
            this.OpenTime = odataObject.OpenTime;
              
            // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
            this.CloseTime = odataObject.CloseTime;
              
            // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
            this.Id = (odataObject.Id) ? parseInt(odataObject.Id, 10) : 0;
              
        // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
        this.ExtensionProperties = undefined;
        if (odataObject.ExtensionProperties) {
          this.ExtensionProperties = [];
          for (var i = 0; i < odataObject.ExtensionProperties.length; i++) {
            if (odataObject.ExtensionProperties[i]) {
        if (odataObject.ExtensionProperties[i]['@odata.type']) {
          var className: string = odataObject.ExtensionProperties[i]['@odata.type'];
          className = className.substr(className.lastIndexOf('.') + 1).concat("Class");
          if (EntityClasses[className]) {
            this.ExtensionProperties[i] = new EntityClasses[className](odataObject.ExtensionProperties[i])
          }
        } else {
          this.ExtensionProperties[i] = new EntityClasses.CommercePropertyClass(odataObject.ExtensionProperties[i]);
        }
      
            } else {
              // @ts-ignore - TODO bug fix #23427261 - remove ts-ignore - https://microsoft.visualstudio.com/DefaultCollection/OSGS/_workitems/edit/23427261/
              this.ExtensionProperties[i] = undefined;
            }
          }
        }
      
      }
  }
