# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

# Azure.ResourceManager.Compute

> see https://aka.ms/autorest

``` yaml
azure-arm: true
library-name: Compute
namespace: Azure.ResourceManager.Compute
require: https://github.com/Azure/azure-rest-api-specs/blob/e50265479cae5da79144cce18a80751214a4ceca/specification/compute/resource-manager/readme.md
tag: package-2022-04-04
output-folder: $(this-folder)/Generated
clear-output-folder: true
skip-csproj: true
modelerfour:
  flatten-payloads: false

format-by-name-rules:
  'tenantId': 'uuid'
  'etag': 'etag'
  'location': 'azure-location'
  'locations': 'azure-location'
  '*Uri': 'Uri'
  '*Uris': 'Uri'

keep-plural-enums:
- IntervalInMins
- ExpandTypeForGetCapacityReservationGroups

prepend-rp-prefix:
- UsageName
- UsageUnit
- ApiError
- ApiErrorBase
- DeleteOptions
- ProtocolType

rename-rules:
  CPU: Cpu
  CPUs: Cpus
  Os: OS
  Ip: IP
  Ips: IPs
  ID: Id
  IDs: Ids
  VM: Vm
  VMs: Vms
  Vmos: VmOS
  VMScaleSet: VmScaleSet
  DNS: Dns
  VPN: Vpn
  NAT: Nat
  WAN: Wan
  Ipv4: IPv4
  Ipv6: IPv6
  Ipsec: IPsec
  SSO: Sso
  URI: Uri
  SSD: Ssd
  SAS: Sas
  VCPUs: VCpus
  RestorePointCollection: RestorePointGroup # the word `collection` is reserved by the SDK, therefore we need to rename all the occurrences of this in all resources and models
  EncryptionSettingsCollection: EncryptionSettingsGroup # the word `collection` is reserved by the SDK, therefore we need to rename all the occurrences of this in all resources and models

list-exception:
- /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/restorePointCollections/{restorePointGroupName}/restorePoints/{restorePointName} # compute RP did not provide an API for listing this resource
- /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}

request-path-to-resource-name:
  /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}/virtualMachines/{instanceId}/runCommands/{runCommandName}: VirtualMachineScaleSetVmRunCommand

override-operation-name:
  VirtualMachines_Start: PowerOn
  VirtualMachineScaleSets_Start: PowerOn
  VirtualMachineScaleSetVMs_Start: PowerOn
  CloudServices_Start: PowerOn
  CloudServicesUpdateDomain_GetUpdateDomain: GetUpdateDomain
  CloudServicesUpdateDomain_ListUpdateDomains: GetUpdateDomains
  CloudServicesUpdateDomain_WalkUpdateDomain: WalkUpdateDomain
  GallerySharingProfile_Update: UpdateSharingProfile
  VirtualMachineImages_ListPublishers: GetVirtualMachineImagePublishers
  VirtualMachineImages_ListSkus: GetVirtualMachineImageSkus
  VirtualMachineImages_ListOffers: GetVirtualMachineImageOffers
  VirtualMachineImagesEdgeZone_ListSkus: GetVirtualMachineImageEdgeZoneSkus
  VirtualMachineScaleSetRollingUpgrades_StartOSUpgrade: StartOSUpgrade
  LogAnalytics_ExportRequestRateByInterval: ExportLogAnalyticsRequestRateByInterval
  LogAnalytics_ExportThrottledRequests: ExportLogAnalyticsThrottledRequests

request-path-to-resource-data:
  /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}: SharedGallery
  /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}: SharedGalleryImage
  /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}/images/{galleryImageName}/versions/{galleryImageVersionName}: SharedGalleryImageVersion
  /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}: CommunityGallery
  /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}: CommunityGalleryImage
  /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/communityGalleries/{publicGalleryName}/images/{galleryImageName}/versions/{galleryImageVersionName}: CommunityGalleryImageVersion

rename-mapping:
  DiskSecurityTypes.ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey: ConfidentialVmGuestStateOnlyEncryptedWithPlatformKey
  ResourceSku: ComputeResourceSku
  ResourceSkuCapacity: ComputeResourceSkuCapacity
  ResourceSkuLocationInfo: ComputeResourceSkuLocationInfo
  ResourceSkuRestrictions: ComputeResourceSkuRestrictions
  ResourceSkuRestrictionInfo: ComputeResourceSkuRestrictionInfo
  SubResource: ComputeWriteableSubResourceData
  SubResourceReadOnly: ComputeSubResourceData
  HyperVGenerationType: HyperVGeneration
  HyperVGenerationTypes: HyperVGeneration
  VirtualMachineExtension.properties.type: ExtensionType
  VirtualMachineExtensionUpdate.properties.type: ExtensionType
  VirtualMachineScaleSetExtension.properties.type: ExtensionType
  VirtualMachineScaleSetExtensionUpdate.properties.type: ExtensionType
  VirtualMachineScaleSetVMExtension.properties.type: ExtensionType
  VirtualMachineScaleSetVMExtensionUpdate.properties.type: ExtensionType
  RollingUpgradeStatusInfo: VirtualMachineScaleSetRollingUpgrade
  OperatingSystemTypes: SupportedOperatingSystemType
  VirtualMachineImageResource: VirtualMachineImageBase
  RestorePointCollectionSourceProperties: RestorePointCollectionSource
  RestorePointExpandOptions: RestorePointExpand
  RestorePointCollectionExpandOptions: RestorePointCollectionExpand
  ImageReference.sharedGalleryImageId: sharedGalleryImageUniqueId
  UpdateResource: ComputeUpdateResourceData
  SubResourceWithColocationStatus: ComputeSubResourceDataWithColocationStatus
  SshPublicKey: SshPublicKeyInfo
  SshPublicKeyResource: SshPublicKey
  LogAnalyticsOperationResult: LogAnalytics
  PrivateLinkResource: ComputePrivateLinkResourceData
  Disk: ManagedDisk
  Encryption: DiskEncryption
  CreationData: DiskCreationData
  Architecture: ArchitectureType
  OSFamily: CloudServiceOSFamily
  OSFamily.name: ResourceName
  OSFamily.properties.name: OSFamilyName
  OSVersion: CloudServiceOSVersion
  UpdateDomain: UpdateDomainIdentifier
  Extension: CloudServiceExtension
  RoleInstance: CloudServiceRoleInstance
  UpdateResourceDefinition: GalleryUpdateResourceData
  StorageAccountType: ImageStorageAccountType
  SharingProfile.permissions: permission
  UserArtifactManage: UserArtifactManagement
  GalleryExpandParams: GalleryExpand
  PirResource: PirResourceData
  PirSharedGalleryResource: PirSharedGalleryResourceData
  PirCommunityGalleryResource: PirCommunityGalleryResourceData
  PirCommunityGalleryResource.type: ResourceType
  ExpandTypesForGetCapacityReservationGroups: CapacityReservationGroupGetExpand
  ExpandTypesForGetVMScaleSets: VirtualMachineScaleSetGetExpand
  DedicatedHostGroup.properties.hosts: DedicatedHosts
  UefiSettings.secureBootEnabled: IsSecureBootEnabled
  UefiSettings.vTpmEnabled: IsVirtualTpmEnabled

directive:
# copy the systemData from common-types here so that it will be automatically replaced
  - from: common.json
    where: $.definitions
    transform: >
      $.SubResource.properties.id["x-ms-format"] = "arm-id";
      $.SubResourceReadOnly.properties.id["x-ms-format"] = "arm-id";
      $.SystemData = {
        "description": "Metadata pertaining to creation and last modification of the resource.",
        "type": "object",
        "readOnly": true,
        "properties": {
            "createdBy": {
            "type": "string",
            "description": "The identity that created the resource."
            },
            "createdByType": {
            "type": "string",
            "description": "The type of identity that created the resource.",
            "enum": [
                "User",
                "Application",
                "ManagedIdentity",
                "Key"
            ],
            "x-ms-enum": {
                "name": "createdByType",
                "modelAsString": true
            }
            },
            "createdAt": {
            "type": "string",
            "format": "date-time",
            "description": "The timestamp of resource creation (UTC)."
            },
            "lastModifiedBy": {
            "type": "string",
            "description": "The identity that last modified the resource."
            },
            "lastModifiedByType": {
            "type": "string",
            "description": "The type of identity that last modified the resource.",
            "enum": [
                "User",
                "Application",
                "ManagedIdentity",
                "Key"
            ],
            "x-ms-enum": {
                "name": "createdByType",
                "modelAsString": true
            }
            },
            "lastModifiedAt": {
            "type": "string",
            "format": "date-time",
            "description": "The timestamp of resource last modification (UTC)"
            }
          }
        };
  - from: virtualMachine.json
    where: $.definitions
    transform: >
      $.VirtualMachineInstallPatchesParameters.properties.maximumDuration["format"] = "duration";
  - from: virtualMachineImage.json
    where: $.definitions
    transform: >
      $.VirtualMachineImageProperties.properties.dataDiskImages.description = "The list of data disk images information.";
  - from: virtualMachineScaleSet.json
    where: $.definitions
    transform: >
      $.VirtualMachineScaleSetExtension.properties.type["x-ms-format"] = "resource-type";
      $.VirtualMachineScaleSetExtensionUpdate.properties.type["x-ms-format"] = "resource-type";
      $.VirtualMachineScaleSetVMExtension.properties.type["x-ms-format"] = "resource-type";
      $.VirtualMachineScaleSetVMExtensionUpdate.properties.type["x-ms-format"] = "resource-type";
      $.VirtualMachineScaleSetSku.properties.resourceType["x-ms-format"] = "resource-type";
      $.VirtualMachineScaleSetVMInstanceView.properties.assignedHost["x-ms-format"] = "arm-id";
  - from: restorePoint.json
    where: $.definitions
    transform: >
      $.RestorePointCollectionSourceProperties.properties.id["x-ms-format"] = "arm-id";
  - from: sshPublicKey.json
    where: $.definitions
    transform: >
      $.SshPublicKeyGenerateKeyPairResult.properties.id["x-ms-format"] = "arm-id";
  - from: diskRPCommon.json
    where: $.definitions
    transform: >
      $.PurchasePlan["x-ms-client-name"] = "DiskPurchasePlan";
      $.GrantAccessData.properties.access.description = "The Access Level, accepted values include None, Read, Write.";
  - from: disk.json
    where: $.definitions
    transform: >
      $.Disk.properties.managedBy["x-ms-format"] = "arm-id";
      $.Disk.properties.managedByExtended.items["x-ms-format"] = "arm-id";
      $.DiskProperties.properties.diskAccessId["x-ms-format"] = "arm-id";
      $.DiskUpdateProperties.properties.diskAccessId["x-ms-format"] = "arm-id";
  - from: diskAccess.json
    where: $.definitions
    transform: >
      $.PrivateLinkResourceProperties.properties.groupId["x-ms-format"] = "arm-id";
  - from: diskRestorePoint.json
    where: $.definitions
    transform: >
      $.DiskRestorePointProperties.properties.sourceResourceId["x-ms-format"] = "arm-id";
      $.DiskRestorePointProperties.properties.diskAccessId["x-ms-format"] = "arm-id";
      $.DiskRestorePointProperties.properties.sourceResourceLocation["x-ms-format"] = "azure-location";
  - from: snapshot.json
    where: $.definitions
    transform: >
      $.SnapshotProperties.properties.diskAccessId["x-ms-format"] = "arm-id";
      $.SnapshotUpdateProperties.properties.diskAccessId["x-ms-format"] = "arm-id";
  - from: diskRPCommon.json
    where: $.definitions
    transform: >
      $.Encryption.properties.diskEncryptionSetId["x-ms-format"] = "arm-id";
      $.CreationData.properties.storageAccountId["x-ms-format"] = "arm-id";
      $.CreationData.properties.sourceResourceId["x-ms-format"] = "arm-id";
      $.DiskSecurityProfile.properties.secureVMDiskEncryptionSetId["x-ms-format"] = "arm-id";
      $.ImageDiskReference.properties.id["x-ms-format"] = "arm-id";
  - from: cloudService.json
    where: $.definitions
    transform: >
      $.CloudService.properties.properties["x-ms-client-flatten"] = true;
      $.OSFamily.properties.properties["x-ms-client-flatten"] = true;
      $.OSVersion.properties.properties["x-ms-client-flatten"] = true;
      $.UpdateDomain.properties.id["x-ms-format"] = "arm-id";
      $.Extension.properties.properties["x-ms-client-flatten"] = true;
      $.CloudServiceRole.properties.properties["x-ms-client-flatten"] = true;
      $.RoleInstance.properties.properties["x-ms-client-flatten"] = true;
      $.LoadBalancerConfiguration.properties.id["x-ms-format"] = "arm-id";
      $.LoadBalancerConfiguration.properties.properties["x-ms-client-flatten"] = true;
      $.LoadBalancerFrontendIPConfiguration.properties.properties["x-ms-client-flatten"] = true;
  - from: gallery.json
    where: $.definitions
    transform: >
      $.DiskImageEncryption.properties.diskEncryptionSetId["x-ms-format"] = "arm-id";
      $.GalleryArtifactVersionSource.properties.id["x-ms-format"] = "arm-id";
  - from: communityGallery.json
    where: $.definitions
    transform: >
      $.PirCommunityGalleryResource.properties.type["x-ms-format"] = "resource-type";
  - from: cloudService.json
    where: $.definitions.LoadBalancerConfigurationProperties
    transform: >
      $.properties.frontendIpConfigurations = $.properties.frontendIPConfigurations;
      $.properties.frontendIpConfigurations["x-ms-client-name"] = "frontendIPConfigurations";
      $.required = ["frontendIpConfigurations"];
      $.properties.frontendIPConfigurations = undefined;
    reason: Service returns response with property name as frontendIpConfigurations.
  - from: cloudService.json
    where: $.paths
    transform: >
      $["/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cloudServices/{cloudServiceName}"].put.parameters[4]["required"] = true;
```
