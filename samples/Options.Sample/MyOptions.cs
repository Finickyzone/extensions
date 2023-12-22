using Finickyzone.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace Finickyzone.Extensions.Samples;

[BindConfiguration(Section = "Options:Default"), ValidateDataAnnotation, ValidateOnStart]
[BindConfiguration(Name = Name1, Section = $"Options:{Name1}"), ValidateDataAnnotation(Name = Name1), ValidateOnStart(Name = Name1)]
[BindConfiguration(Name = Name2, Section = $"Options:{Name2}"), ValidateDataAnnotation(Name = Name2), ValidateOnStart(Name = Name2)]
public sealed record MyOptions
{
    internal const string Name1 = nameof(Name1);
    internal const string Name2 = nameof(Name2);

    [Required]
    public string Value { get; set; } = null!;
}