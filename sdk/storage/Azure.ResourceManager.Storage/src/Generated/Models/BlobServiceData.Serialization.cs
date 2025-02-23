// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class BlobServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Cors))
            {
                writer.WritePropertyName("cors");
                writer.WriteObjectValue(Cors);
            }
            if (Optional.IsDefined(DefaultServiceVersion))
            {
                writer.WritePropertyName("defaultServiceVersion");
                writer.WriteStringValue(DefaultServiceVersion);
            }
            if (Optional.IsDefined(DeleteRetentionPolicy))
            {
                writer.WritePropertyName("deleteRetentionPolicy");
                writer.WriteObjectValue(DeleteRetentionPolicy);
            }
            if (Optional.IsDefined(IsVersioningEnabled))
            {
                writer.WritePropertyName("isVersioningEnabled");
                writer.WriteBooleanValue(IsVersioningEnabled.Value);
            }
            if (Optional.IsDefined(AutomaticSnapshotPolicyEnabled))
            {
                writer.WritePropertyName("automaticSnapshotPolicyEnabled");
                writer.WriteBooleanValue(AutomaticSnapshotPolicyEnabled.Value);
            }
            if (Optional.IsDefined(ChangeFeed))
            {
                writer.WritePropertyName("changeFeed");
                writer.WriteObjectValue(ChangeFeed);
            }
            if (Optional.IsDefined(RestorePolicy))
            {
                writer.WritePropertyName("restorePolicy");
                writer.WriteObjectValue(RestorePolicy);
            }
            if (Optional.IsDefined(ContainerDeleteRetentionPolicy))
            {
                writer.WritePropertyName("containerDeleteRetentionPolicy");
                writer.WriteObjectValue(ContainerDeleteRetentionPolicy);
            }
            if (Optional.IsDefined(LastAccessTimeTrackingPolicy))
            {
                writer.WritePropertyName("lastAccessTimeTrackingPolicy");
                writer.WriteObjectValue(LastAccessTimeTrackingPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BlobServiceData DeserializeBlobServiceData(JsonElement element)
        {
            Optional<StorageSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<CorsRules> cors = default;
            Optional<string> defaultServiceVersion = default;
            Optional<DeleteRetentionPolicy> deleteRetentionPolicy = default;
            Optional<bool> isVersioningEnabled = default;
            Optional<bool> automaticSnapshotPolicyEnabled = default;
            Optional<ChangeFeed> changeFeed = default;
            Optional<RestorePolicyProperties> restorePolicy = default;
            Optional<DeleteRetentionPolicy> containerDeleteRetentionPolicy = default;
            Optional<LastAccessTimeTrackingPolicy> lastAccessTimeTrackingPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = StorageSku.DeserializeStorageSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("cors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cors = CorsRules.DeserializeCorsRules(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultServiceVersion"))
                        {
                            defaultServiceVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deleteRetentionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isVersioningEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isVersioningEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("automaticSnapshotPolicyEnabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            automaticSnapshotPolicyEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("changeFeed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            changeFeed = ChangeFeed.DeserializeChangeFeed(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("restorePolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            restorePolicy = RestorePolicyProperties.DeserializeRestorePolicyProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("containerDeleteRetentionPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            containerDeleteRetentionPolicy = DeleteRetentionPolicy.DeserializeDeleteRetentionPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lastAccessTimeTrackingPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastAccessTimeTrackingPolicy = LastAccessTimeTrackingPolicy.DeserializeLastAccessTimeTrackingPolicy(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BlobServiceData(id, name, type, systemData.Value, sku.Value, cors.Value, defaultServiceVersion.Value, deleteRetentionPolicy.Value, Optional.ToNullable(isVersioningEnabled), Optional.ToNullable(automaticSnapshotPolicyEnabled), changeFeed.Value, restorePolicy.Value, containerDeleteRetentionPolicy.Value, lastAccessTimeTrackingPolicy.Value);
        }
    }
}
