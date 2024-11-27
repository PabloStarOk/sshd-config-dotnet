﻿using SshdConfig.NET.Configuration.Enums;

namespace SshdConfig.NET.Configuration;

public class SshdConfiguration
{
    // Authentication Options
    public string PermitRootLogin { get; internal set; } = "prohibit-password"; // Default is "prohibit-password"
    public List<string> AuthenticationMethods { get; } = ["any"]; // Default is any.
    public bool PublicKeyAuthentication { get; internal set; } = true; // Default is true
    public bool PasswdAuthentication { get; internal set; } = true; // Default is true.
    public bool KbdInteractiveAuthentication { get; internal set; } = true; // Default is true.
    public bool KerberosAuthentication { get; internal set; } // Default is false.
    public bool GssapiAuthentication { get; internal set; } // Default is false.
    public bool GssapiCleanupCredentials { get; internal set; } = true; // Default is yes.
    public List<string> AuthorizedKeysFile { get; } = [".ssh/authoriezd_keys", ".ssh/authorized_keys2"]; // Default is ".ssh/authorized_keys .ssh/authorized_keys2"
    public List<string> AuthorizedKeysCommand { get; } = []; // Default no commands are run.
    public string AuthorizedKeysCommandUser { get; internal set; } = string.Empty;
    public bool HostBasedAuthentication { get; internal set; } // Default is false.
    public List<string> AllowUsers { get; } = []; // Default allows all users.
    public List<string> AllowGroups { get; } = []; // Default allows all groups.
    public List<string> DenyUsers { get; } = [];
    public List<string> DenyGroups { get; } = [];
    public int MaxAuthTries { get; internal set; } = 6; // Default is 6.
    public bool PermitEmptyPasswords { get; internal set; } // Default is no.

    // Networking Options
    public int Port { get; internal set; } = 22; // Default is 22.
    // public ? ListenAddress // TODO: Implement ListenAdress.
    public string AddressFamily { get; internal set; } = "any"; // TODO: Find default value.
    public string PermitTunnel { get; internal set; } = "no"; // Default is no.
    public string GatewayPorts { get; internal set; } = "no"; // Default is no.
    public string AllowTcpForwarding { get; internal set; } = "yes"; // Default is yes.
    public string PermitOpen { get; internal set; } = "any"; // Default is any.

    // Logging Options
    public string SyslogFacility { get; internal set; } = "AUTH"; // Default is AUTH.
    public string LogLevel { get; internal set; } = "INFO"; // Default is INFO.

    // Key Exchange and Host Key Algorithms
    public List<KeyExchange.Algorithms> KexAlgorithms { get; } =
    [
        KeyExchange.Algorithms.SntRup761X25519Sha512,
        KeyExchange.Algorithms.SntRup761X25519Sha512OpensshCom,
        KeyExchange.Algorithms.MlKem768X25519Sha256,
        KeyExchange.Algorithms.Curve25519Sha256,
        KeyExchange.Algorithms.Curve25519Sha256LibSshOrg,
        KeyExchange.Algorithms.EcdhSha2NiStp256,
        KeyExchange.Algorithms.EcdhSha2NiStp384,
        KeyExchange.Algorithms.EcdhSha2NiStp521
    ];
    public List<string> Ciphers { get; } =
    [
        "chacha20-poly1305@openssh.com",
        "aes128-ctr",
        "aes192-ctr",
        "aes256-ctr",
        "aes128-gcm@openssh.com",
        "aes256-gcm@openssh.com"
    ]; // TODO: Implement Ciphers with enums instead of just strings.
    public List<string> Macs { get; } =
    [
        "umac-64-etm@openssh.com",
        "umac-128-etm@openssh.com",
        "hmac-sha2-256-etm@openssh.com",
        "hmac-sha2-512-etm@openssh.com",
        "hmac-sha1-etm@openssh.com",
        "umac-64@openssh.com",
        "umac-128@openssh.com",
        "hmac-sha2-256",
        "hmac-sha2-512,hmac-sha1"
    ]; // TODO: Implement MACs with enums instead of just strings.
    public List<string> HostKey { get; } =
    [
        "/etc/ssh/ssh_host_ecdsa_key",
        "/etc/ssh/ssh_host_ed25519_key",
        "/etc/ssh/ssh_host_rsa_key"
    ]; // TODO: Implement HostKey with enums instead of just strings.
    public List<string> KeyAlgorithms { get; } =
    [
        "ssh-ed25519-cert-v01@openssh.com",
        "ecdsa-sha2-nistp256-cert-v01@openssh.com",
        "ecdsa-sha2-nistp384-cert-v01@openssh.com",
        "ecdsa-sha2-nistp521-cert-v01@openssh.com",
        "sk-ssh-ed25519-cert-v01@openssh.com",
        "sk-ecdsa-sha2-nistp256-cert-v01@openssh.com",
        "rsa-sha2-512-cert-v01@openssh.com",
        "rsa-sha2-256-cert-v01@openssh.com",
        "ssh-ed25519",
        "ecdsa-sha2-nistp256", "ecdsa-sha2-nistp384", "ecdsa-sha2-nistp521",
        "sk-ssh-ed25519@openssh.com",
        "sk-ecdsa-sha2-nistp256@openssh.com",
        "rsa-sha2-512", "rsa-sha2-256"
    ]; // TODO: Implement KeyAlgorithms with enums instead of just strings.

    // Connection Settings
    public List<int> Protocol { get; } = [2,1]; // Default is 2,1
    public int LoginGraceTime { get; internal set; } = 120; // Default is 20 seconds
    public string MaxStartups { get; internal set; } = "10:30:100"; // Default is 10:30:100. // TODO: Implement a custom class to include each value separated by ':'
    public int MaxSessions { get; internal set; } = 10; // Default is 10.
    public int ClientInterval { get; internal set; } // Default is 0.
    public int ClientAliveCountMax { get; internal set; } = 3; // Default value is 3.
    public bool TcpKeepAlive { get; internal set; } = true; // Default is true.

    // Access Control
    public bool AllowAgentForwarding { get; internal set; } = true; // Default is true.
    public bool PermitTty { get; internal set; } = true; // Default is yes.
    public string ForceCommand { get; internal set; } = "none"; // Default is none.

    // Match Blocks and Conditional Settings
    public string PermitUserEnvironment { get; internal set; } = "no"; // Default is no.


    // Session Control
    public bool X11Forwarding { get; internal set; } // Default is no.
    public int X11DisplayOffset { get; internal set; } = 10; // Default is 10.
    public bool PrintMotd { get; internal set; } = true; // Default is yes.
    public bool PrintLastLog { get; internal set; } = true; // Default is yes.
    public List<string> AcceptEnv { get; } = []; // Default is not to accept any env variables.

    // SFTP Settings
    public List<string> Subsystem { get; } = [];

    // Miscellaneous
    public string UseDns { get; internal set; } = "no"; // Default is no.
    public string Compression { get; internal set; } = "yes"; // Default is yes.
    // public ? Banner; // TODO: Implement a banner class to send the content of a file to a remote user before authentication.
    // public ? Match; // TODO: Implement keyword.
    public string IgnoreRhosts { get; internal set; } = "yes"; // Default is yes.
    public bool StrictModes { get; internal set; } = true; // Default is yes.
    public bool UsePam { get; internal set; } // Default is no.
}