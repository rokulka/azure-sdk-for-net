// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualHubData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualWan))
            {
                writer.WritePropertyName("virtualWan");
                JsonSerializer.Serialize(writer, VirtualWan);
            }
            if (Optional.IsDefined(VpnGateway))
            {
                writer.WritePropertyName("vpnGateway");
                JsonSerializer.Serialize(writer, VpnGateway);
            }
            if (Optional.IsDefined(P2sVpnGateway))
            {
                writer.WritePropertyName("p2SVpnGateway");
                JsonSerializer.Serialize(writer, P2sVpnGateway);
            }
            if (Optional.IsDefined(ExpressRouteGateway))
            {
                writer.WritePropertyName("expressRouteGateway");
                JsonSerializer.Serialize(writer, ExpressRouteGateway);
            }
            if (Optional.IsDefined(AzureFirewall))
            {
                writer.WritePropertyName("azureFirewall");
                JsonSerializer.Serialize(writer, AzureFirewall);
            }
            if (Optional.IsDefined(SecurityPartnerProvider))
            {
                writer.WritePropertyName("securityPartnerProvider");
                JsonSerializer.Serialize(writer, SecurityPartnerProvider);
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(RouteTable))
            {
                writer.WritePropertyName("routeTable");
                writer.WriteObjectValue(RouteTable);
            }
            if (Optional.IsDefined(SecurityProviderName))
            {
                writer.WritePropertyName("securityProviderName");
                writer.WriteStringValue(SecurityProviderName);
            }
            if (Optional.IsCollectionDefined(VirtualHubRouteTableV2S))
            {
                writer.WritePropertyName("virtualHubRouteTableV2s");
                writer.WriteStartArray();
                foreach (var item in VirtualHubRouteTableV2S)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(VirtualRouterAsn))
            {
                writer.WritePropertyName("virtualRouterAsn");
                writer.WriteNumberValue(VirtualRouterAsn.Value);
            }
            if (Optional.IsCollectionDefined(VirtualRouterIPs))
            {
                writer.WritePropertyName("virtualRouterIps");
                writer.WriteStartArray();
                foreach (var item in VirtualRouterIPs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllowBranchToBranchTraffic))
            {
                writer.WritePropertyName("allowBranchToBranchTraffic");
                writer.WriteBooleanValue(AllowBranchToBranchTraffic.Value);
            }
            if (Optional.IsDefined(PreferredRoutingGateway))
            {
                writer.WritePropertyName("preferredRoutingGateway");
                writer.WriteStringValue(PreferredRoutingGateway.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualHubData DeserializeVirtualHubData(JsonElement element)
        {
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualWan = default;
            Optional<WritableSubResource> vpnGateway = default;
            Optional<WritableSubResource> p2SVpnGateway = default;
            Optional<WritableSubResource> expressRouteGateway = default;
            Optional<WritableSubResource> azureFirewall = default;
            Optional<WritableSubResource> securityPartnerProvider = default;
            Optional<string> addressPrefix = default;
            Optional<VirtualHubRouteTable> routeTable = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<string> securityProviderName = default;
            Optional<IList<VirtualHubRouteTableV2Data>> virtualHubRouteTableV2s = default;
            Optional<string> sku = default;
            Optional<RoutingState> routingState = default;
            Optional<IReadOnlyList<WritableSubResource>> bgpConnections = default;
            Optional<IReadOnlyList<WritableSubResource>> ipConfigurations = default;
            Optional<long> virtualRouterAsn = default;
            Optional<IList<string>> virtualRouterIps = default;
            Optional<bool> allowBranchToBranchTraffic = default;
            Optional<PreferredRoutingGateway> preferredRoutingGateway = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualWan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualWan = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("vpnGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            vpnGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("p2SVpnGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            p2SVpnGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expressRouteGateway = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("azureFirewall"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureFirewall = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("securityPartnerProvider"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            securityPartnerProvider = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routeTable"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routeTable = VirtualHubRouteTable.DeserializeVirtualHubRouteTable(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("securityProviderName"))
                        {
                            securityProviderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualHubRouteTableV2s"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualHubRouteTableV2Data> array = new List<VirtualHubRouteTableV2Data>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualHubRouteTableV2Data.DeserializeVirtualHubRouteTableV2Data(item));
                            }
                            virtualHubRouteTableV2s = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"))
                        {
                            sku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routingState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            routingState = new RoutingState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bgpConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            bgpConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.ToString()));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterAsn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            virtualRouterAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("virtualRouterIps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            virtualRouterIps = array;
                            continue;
                        }
                        if (property0.NameEquals("allowBranchToBranchTraffic"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowBranchToBranchTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("preferredRoutingGateway"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            preferredRoutingGateway = new PreferredRoutingGateway(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualHubData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToNullable(etag), virtualWan, vpnGateway, p2SVpnGateway, expressRouteGateway, azureFirewall, securityPartnerProvider, addressPrefix.Value, routeTable.Value, Optional.ToNullable(provisioningState), securityProviderName.Value, Optional.ToList(virtualHubRouteTableV2s), sku.Value, Optional.ToNullable(routingState), Optional.ToList(bgpConnections), Optional.ToList(ipConfigurations), Optional.ToNullable(virtualRouterAsn), Optional.ToList(virtualRouterIps), Optional.ToNullable(allowBranchToBranchTraffic), Optional.ToNullable(preferredRoutingGateway));
        }
    }
}
