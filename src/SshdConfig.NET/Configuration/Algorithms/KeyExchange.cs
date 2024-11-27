namespace SshdConfig.NET.Configuration.Algorithms;

public enum KeyExchange
{
    SntRup761X25519Sha512,
    SntRup761X25519Sha512OpensshCom,
    MlKem768X25519Sha256,
    Curve25519Sha256,
    Curve25519Sha256LibSshOrg,
    EcdhSha2NiStp256,
    EcdhSha2NiStp384,
    EcdhSha2NiStp521,
}
