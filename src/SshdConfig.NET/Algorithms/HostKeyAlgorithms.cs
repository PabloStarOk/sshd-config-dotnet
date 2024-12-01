namespace SshdConfig.NET.Algorithms;

public enum HostKeyAlgorithms
{
    SshEd25519,
    SshEd25519CertV01OpensshCom,
    SkSshEd25519OpensshCom,
    SkSshEd25519CertV01OpensshCom,
    EcdsaSha2Nistp256,
    EcdsaSha2Nistp256CertV01OpensshCom,
    EcdsaSha2Nistp384,
    EcdsaSha2Nistp384CertV01OpensshCom,
    EcdsaSha2Nistp521,
    EcdsaSha2Nistp521CertV01OpensshCom,
    SkEcdsaSha2Nistp256OpensshCom,
    SkEcdsaSha2Nistp256CertV01OpensshCom,
    WebauthnSkEcdsaSha2Nistp256OpensshCom,
    SshRsa,
    SshRsaCertV01OpensshCom,
    RsaSha2256,
    RsaSha2256CertV01OpensshCom,
    RsaSha2512,
    RsaSha2512CertV01OpensshCom
}
