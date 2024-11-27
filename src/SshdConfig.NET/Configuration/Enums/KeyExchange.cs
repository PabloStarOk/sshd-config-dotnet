using System.Collections.Immutable;

namespace SshdConfig.NET.Configuration.Enums;

public static class KeyExchange
{
    private static readonly ImmutableDictionary<Algorithms, string> KexAlgorithms = ImmutableDictionary.CreateRange<Algorithms, string>
    (
        new Dictionary<Algorithms, string>()
        {
            { Algorithms.SntRup761X25519Sha512, "sntrup761x25519-sha512" },
            { Algorithms.SntRup761X25519Sha512OpensshCom, "sntrup761x25519-sha512@openssh.com" },
            { Algorithms.MlKem768X25519Sha256, "mlkem768x25519-sha256" },
            { Algorithms.Curve25519Sha256, "curve25519-sha256" },
            { Algorithms.Curve25519Sha256LibSshOrg, "curve25519-sha256@libssh.org" },
            { Algorithms.EcdhSha2NiStp256, "ecdh-sha2-nistp256" },
            { Algorithms.EcdhSha2NiStp384, "ecdh-sha2-nistp384" },
            { Algorithms.EcdhSha2NiStp521, "ecdh-sha2-nistp521" }
        }
    );

    public enum Algorithms
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

    public static bool GetAlgorithmString(Algorithms algorithm, out string kexAlgorithm)
    {
        if (KexAlgorithms.TryGetValue(algorithm, out kexAlgorithm))
            return true;

        kexAlgorithm = string.Empty;
        return false;
    }

    public static bool GetAlgorithmEnum(string algorithmStr, out Algorithms algorithm)
    {
        algorithm = default;

        if (!KexAlgorithms.ContainsValue(algorithmStr))
            return false;


        var pair = KexAlgorithms.First(x => x.Value == algorithmStr);
        algorithm = pair.Key;
        return true;
    }
}
