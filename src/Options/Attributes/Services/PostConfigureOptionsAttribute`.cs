namespace Finickyzone.Extensions.Options;

/// <inheritdoc />
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
public class PostConfigureOptionsAttribute<TOptions>() : PostConfigureOptionsAttribute(typeof(TOptions)) where TOptions : class;