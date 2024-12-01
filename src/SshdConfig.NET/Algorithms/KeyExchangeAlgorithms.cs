namespace SshdConfig.NET.Algorithms;

public enum KeyExchangeAlgorithms
{
    SntRup761X25519Sha512,
    SntRup761X25519Sha512OpensshCom,
    MlKem768X25519Sha256,
    Curve25519Sha256,
    Curve25519Sha256LibSshOrg,
    EcdhSha2NiStp256,
    EcdhSha2NiStp384,
    EcdhSha2NiStp521,
    DiffieHellmanGroup1Sha1,
    DiffieHellmanGroup14Sha1,
    DiffieHellmanGroup14Sha256,
    DiffieHellmanGroup16Sha512,
    DiffieHellmanGroup18Sha512,
    DiffieHellmanGroupExchangeSha1,
    DiffieHellmanGroupExchangeSha256,
}
