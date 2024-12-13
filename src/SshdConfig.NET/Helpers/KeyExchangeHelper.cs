using System.Collections.Immutable;
using SshdConfig.NET.Algorithms;

namespace SshdConfig.NET.Helpers;

public class KeyExchangeHelper
{
    private static readonly ImmutableDictionary<KeyExchangeAlgorithms, string> Algorithms = ImmutableDictionary.CreateRange
    (
        new Dictionary<KeyExchangeAlgorithms, string>()
        {
            { KeyExchangeAlgorithms.SntRup761X25519Sha512, "sntrup761x25519-sha512" },
            { KeyExchangeAlgorithms.SntRup761X25519Sha512OpensshCom, "sntrup761x25519-sha512@openssh.com" },
            { KeyExchangeAlgorithms.MlKem768X25519Sha256, "mlkem768x25519-sha256" },
            { KeyExchangeAlgorithms.Curve25519Sha256, "curve25519-sha256" },
            { KeyExchangeAlgorithms.Curve25519Sha256LibSshOrg, "curve25519-sha256@libssh.org" },
            { KeyExchangeAlgorithms.EcdhSha2NiStp256, "ecdh-sha2-nistp256" },
            { KeyExchangeAlgorithms.EcdhSha2NiStp384, "ecdh-sha2-nistp384" },
            { KeyExchangeAlgorithms.EcdhSha2NiStp521, "ecdh-sha2-nistp521" }
        }
    );

    public static bool GetAlgorithmString(KeyExchangeAlgorithms algorithm, out string kexAlgorithm)
    {
        if (Algorithms.TryGetValue(algorithm, out kexAlgorithm))
            return true;

        kexAlgorithm = string.Empty;
        return false;
    }

    public static bool GetAlgorithmEnum(string algorithmStr, out KeyExchangeAlgorithms algorithm)
    {
        algorithm = default;

        if (!Algorithms.ContainsValue(algorithmStr))
            return false;


        var pair = Algorithms.First(x => x.Value == algorithmStr);
        algorithm = pair.Key;
        return true;
    }
}
