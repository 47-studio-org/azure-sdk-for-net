// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Directory
    /// </summary>
    public partial class ActiveDirectory
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDirectory class.
        /// </summary>
        public ActiveDirectory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveDirectory class.
        /// </summary>
        /// <param name="activeDirectoryId">Id of the Active Directory</param>
        /// <param name="username">Username of Active Directory domain
        /// administrator</param>
        /// <param name="password">Plain text password of Active Directory
        /// domain administrator, value is masked in the response</param>
        /// <param name="domain">Name of the Active Directory domain</param>
        /// <param name="dns">Comma separated list of DNS server IP addresses
        /// (IPv4 only) for the Active Directory domain</param>
        /// <param name="status">Status of the Active Directory. Possible
        /// values include: 'Created', 'InUse', 'Deleted', 'Error',
        /// 'Updating'</param>
        /// <param name="statusDetails">Any details in regards to the Status of
        /// the Active Directory</param>
        /// <param name="smbServerName">NetBIOS name of the SMB server. This
        /// name will be registered as a computer account in the AD and used to
        /// mount volumes</param>
        /// <param name="organizationalUnit">The Organizational Unit (OU)
        /// within the Windows Active Directory</param>
        /// <param name="site">The Active Directory site the service will limit
        /// Domain Controller discovery to</param>
        /// <param name="backupOperators">Users to be added to the Built-in
        /// Backup Operator active directory group. A list of unique usernames
        /// without domain specifier</param>
        /// <param name="kdcIP">kdc server IP addresses for the active
        /// directory machine. This optional parameter is used only while
        /// creating kerberos volume.</param>
        /// <param name="adName">Name of the active directory machine. This
        /// optional parameter is used only while creating kerberos
        /// volume</param>
        /// <param name="serverRootCACertificate">When LDAP over SSL/TLS is
        /// enabled, the LDAP client is required to have base64 encoded Active
        /// Directory Certificate Service's self-signed root CA certificate,
        /// this optional parameter is used only for dual protocol with LDAP
        /// user-mapping volumes.</param>
        /// <param name="aesEncryption">If enabled, AES encryption will be
        /// enabled for SMB communication.</param>
        /// <param name="ldapSigning">Specifies whether or not the LDAP traffic
        /// needs to be signed.</param>
        /// <param name="securityOperators">Domain Users in the Active
        /// directory to be given SeSecurityPrivilege privilege (Needed for SMB
        /// Continuously available shares for SQL). A list of unique usernames
        /// without domain specifier</param>
        public ActiveDirectory(string activeDirectoryId = default(string), string username = default(string), string password = default(string), string domain = default(string), string dns = default(string), string status = default(string), string statusDetails = default(string), string smbServerName = default(string), string organizationalUnit = default(string), string site = default(string), IList<string> backupOperators = default(IList<string>), string kdcIP = default(string), string adName = default(string), string serverRootCACertificate = default(string), bool? aesEncryption = default(bool?), bool? ldapSigning = default(bool?), IList<string> securityOperators = default(IList<string>))
        {
            ActiveDirectoryId = activeDirectoryId;
            Username = username;
            Password = password;
            Domain = domain;
            Dns = dns;
            Status = status;
            StatusDetails = statusDetails;
            SmbServerName = smbServerName;
            OrganizationalUnit = organizationalUnit;
            Site = site;
            BackupOperators = backupOperators;
            KdcIP = kdcIP;
            AdName = adName;
            ServerRootCACertificate = serverRootCACertificate;
            AesEncryption = aesEncryption;
            LdapSigning = ldapSigning;
            SecurityOperators = securityOperators;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the Active Directory
        /// </summary>
        [JsonProperty(PropertyName = "activeDirectoryId")]
        public string ActiveDirectoryId { get; set; }

        /// <summary>
        /// Gets or sets username of Active Directory domain administrator
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets plain text password of Active Directory domain
        /// administrator, value is masked in the response
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets name of the Active Directory domain
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets comma separated list of DNS server IP addresses (IPv4
        /// only) for the Active Directory domain
        /// </summary>
        [JsonProperty(PropertyName = "dns")]
        public string Dns { get; set; }

        /// <summary>
        /// Gets status of the Active Directory. Possible values include:
        /// 'Created', 'InUse', 'Deleted', 'Error', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets any details in regards to the Status of the Active Directory
        /// </summary>
        [JsonProperty(PropertyName = "statusDetails")]
        public string StatusDetails { get; private set; }

        /// <summary>
        /// Gets or sets netBIOS name of the SMB server. This name will be
        /// registered as a computer account in the AD and used to mount
        /// volumes
        /// </summary>
        [JsonProperty(PropertyName = "smbServerName")]
        public string SmbServerName { get; set; }

        /// <summary>
        /// Gets or sets the Organizational Unit (OU) within the Windows Active
        /// Directory
        /// </summary>
        [JsonProperty(PropertyName = "organizationalUnit")]
        public string OrganizationalUnit { get; set; }

        /// <summary>
        /// Gets or sets the Active Directory site the service will limit
        /// Domain Controller discovery to
        /// </summary>
        [JsonProperty(PropertyName = "site")]
        public string Site { get; set; }

        /// <summary>
        /// Gets or sets users to be added to the Built-in Backup Operator
        /// active directory group. A list of unique usernames without domain
        /// specifier
        /// </summary>
        [JsonProperty(PropertyName = "backupOperators")]
        public IList<string> BackupOperators { get; set; }

        /// <summary>
        /// Gets or sets kdc server IP addresses for the active directory
        /// machine. This optional parameter is used only while creating
        /// kerberos volume.
        /// </summary>
        [JsonProperty(PropertyName = "kdcIP")]
        public string KdcIP { get; set; }

        /// <summary>
        /// Gets or sets name of the active directory machine. This optional
        /// parameter is used only while creating kerberos volume
        /// </summary>
        [JsonProperty(PropertyName = "adName")]
        public string AdName { get; set; }

        /// <summary>
        /// Gets or sets when LDAP over SSL/TLS is enabled, the LDAP client is
        /// required to have base64 encoded Active Directory Certificate
        /// Service's self-signed root CA certificate, this optional parameter
        /// is used only for dual protocol with LDAP user-mapping volumes.
        /// </summary>
        [JsonProperty(PropertyName = "serverRootCACertificate")]
        public string ServerRootCACertificate { get; set; }

        /// <summary>
        /// Gets or sets if enabled, AES encryption will be enabled for SMB
        /// communication.
        /// </summary>
        [JsonProperty(PropertyName = "aesEncryption")]
        public bool? AesEncryption { get; set; }

        /// <summary>
        /// Gets or sets specifies whether or not the LDAP traffic needs to be
        /// signed.
        /// </summary>
        [JsonProperty(PropertyName = "ldapSigning")]
        public bool? LdapSigning { get; set; }

        /// <summary>
        /// Gets or sets domain Users in the Active directory to be given
        /// SeSecurityPrivilege privilege (Needed for SMB Continuously
        /// available shares for SQL). A list of unique usernames without
        /// domain specifier
        /// </summary>
        [JsonProperty(PropertyName = "securityOperators")]
        public IList<string> SecurityOperators { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Dns != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(Dns, "^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)((, ?)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Dns", "^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)((, ?)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))*$");
                }
            }
            if (KdcIP != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(KdcIP, "^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)((, ?)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))*$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "KdcIP", "^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)((, ?)(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?))*$");
                }
            }
            if (AdName != null)
            {
                if (AdName.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdName", 64);
                }
                if (AdName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdName", 1);
                }
            }
            if (ServerRootCACertificate != null)
            {
                if (ServerRootCACertificate.Length > 10240)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ServerRootCACertificate", 10240);
                }
                if (ServerRootCACertificate.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ServerRootCACertificate", 1);
                }
            }
        }
    }
}
