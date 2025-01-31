// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> VpnSiteLink Resource. </summary>
    public partial class VpnSiteLink : WritableSubResource
    {
        /// <summary> Initializes a new instance of VpnSiteLink. </summary>
        public VpnSiteLink()
        {
        }

        /// <summary> Initializes a new instance of VpnSiteLink. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="linkProperties"> The link provider properties. </param>
        /// <param name="ipAddress"> The ip-address for the vpn-site-link. </param>
        /// <param name="fqdn"> FQDN of vpn-site-link. </param>
        /// <param name="bgpProperties"> The set of bgp properties. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN site link resource. </param>
        internal VpnSiteLink(string id, string etag, string name, string type, VpnLinkProviderProperties linkProperties, string ipAddress, string fqdn, VpnLinkBgpSettings bgpProperties, ProvisioningState? provisioningState) : base(id)
        {
            Etag = etag;
            Name = name;
            Type = type;
            LinkProperties = linkProperties;
            IpAddress = ipAddress;
            Fqdn = fqdn;
            BgpProperties = bgpProperties;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> The link provider properties. </summary>
        public VpnLinkProviderProperties LinkProperties { get; set; }
        /// <summary> The ip-address for the vpn-site-link. </summary>
        public string IpAddress { get; set; }
        /// <summary> FQDN of vpn-site-link. </summary>
        public string Fqdn { get; set; }
        /// <summary> The set of bgp properties. </summary>
        public VpnLinkBgpSettings BgpProperties { get; set; }
        /// <summary> The provisioning state of the VPN site link resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
