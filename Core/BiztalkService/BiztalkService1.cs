﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Avanade.Amp.Core.BiztalkService
{
    
    
    public partial class BiztalkServiceWeb
    {
        
        private string mId;
        
        private string mName;
        
        private string mResourceGroupName;
        
        private string mAzureRegion;
        
        public string Id
        {
            get
            {
                return this.mId;
            }
            set
            {
                this.mId = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.mName;
            }
            set
            {
                this.mName = value;
            }
        }
        
        public string ResourceGroupName
        {
            get
            {
                return this.mResourceGroupName;
            }
            set
            {
                this.mResourceGroupName = value;
            }
        }
        
        public string AzureRegion
        {
            get
            {
                return this.mAzureRegion;
            }
            set
            {
                this.mAzureRegion = value;
            }
        }
        
        public static BiztalkService ToBiztalkService(BiztalkServiceWeb biztalkService)
        {
            BiztalkService result = new BiztalkService();
            result.Id = biztalkService.Id;
            result.Name = biztalkService.Name;
            result.ResourceGroupName = biztalkService.ResourceGroupName;
            result.AzureRegion = biztalkService.AzureRegion;
            return result;
        }
        
        public static BiztalkServiceWeb ToBiztalkServiceWeb(BiztalkService biztalkService)
        {
            BiztalkServiceWeb result = new BiztalkServiceWeb();
            result.Id = biztalkService.Id;
            result.Name = biztalkService.Name;
            result.ResourceGroupName = biztalkService.ResourceGroupName;
            result.AzureRegion = biztalkService.AzureRegion;
            return result;
        }
    }
}
