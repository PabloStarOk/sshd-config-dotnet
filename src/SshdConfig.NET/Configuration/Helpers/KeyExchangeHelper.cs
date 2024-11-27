using System.Collections.Immutable;
using KexAlgorithms = SshdConfig.NET.Configuration.Algorithms.KeyExchange;

namespace SshdConfig.NET.Configuration.Helpers;

public class KeyExchangeHelper
{
    private static readonly ImmutableDictionary<KexAlgorithms, string> Algorithms = ImmutableDictionary.CreateRange
    (
        new Dictionary<KexAlgorithms, string>()
        {
            { KexAlgorithms.SntRup761X25519Sha512, "sntrup761x25519-sha512" },
            { KexAlgorithms.SntRup761X25519Sha512OpensshCom, "sntrup761x25519-sha512@openssh.com" },
            { KexAlgorithms.MlKem768X25519Sha256, "mlkem768x25519-sha256" },
            { KexAlgorithms.Curve25519Sha256, "curve25519-sha256" },
            { KexAlgorithms.Curve25519Sha256LibSshOrg, "curve25519-sha256@libssh.org" },
            { KexAlgorithms.EcdhSha2NiStp256, "ecdh-sha2-nistp256" },
            { KexAlgorithms.EcdhSha2NiStp384, "ecdh-sha2-nistp384" },
            { KexAlgorithms.EcdhSha2NiStp521, "ecdh-sha2-nistp521" }
        }
    );

    public static bool GetAlgorithmString(KexAlgorithms algorithm, out string kexAlgorithm)
    {
        if (Algorithms.TryGetValue(algorithm, out kexAlgorithm))
            return true;

        kexAlgorithm = string.Empty;
        return false;
    }

    public static bool GetAlgorithmEnum(string algorithmStr, out KexAlgorithms algorithm)
    {
        algorithm = default;

        if (!Algorithms.ContainsValue(algorithmStr))
            return false;


        var pair = Algorithms.First(x => x.Value == algorithmStr);
        algorithm = pair.Key;
        return true;
    }
}
