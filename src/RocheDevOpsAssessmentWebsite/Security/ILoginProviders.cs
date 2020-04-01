namespace RocheDevOpsAssessment.Security
{
    public interface ILoginProviders
    {
        ILoginProviderCredentials Facebook { get; }
        ILoginProviderCredentials Google { get; }
        ILoginProviderCredentials Microsoft { get; }
        ILoginProviderCredentials Twitter { get; }
    }
}