namespace Bhouse.Test.CodeQualityLearningModelTests.Models.Data;

/// <summary>
/// Represents a series of metrics collected for an individual method written in an
/// object-oriented programming language.
/// </summary>
public class ObjectOrientedMethodMetrics
{
    /// <summary>
    /// The primary key identifier of the collected method metric.
    /// </summary>
    public int SampleId {get; set;}

    /// <summary>
    /// The primary key identifier of the SampleCodeReference where our method's code text is stored.
    /// </summary>
    public int SampleCodeReferenceId {get; set;}

    /// <summary>
    /// Flag representing of the method has a codesmell or not.
    /// </summary>
    public bool HasSmell {get; set;}

    /// <summary>
    /// Flag representing of the method has the 'Complex Methods' codesmell or not.
    /// </summary>
    public bool HasComplexMethod {get; set;}

    /// <summary>
    /// Flag representing of the method has the 'Long Parameter List' codesmell or not.
    /// </summary>
    public bool HasLongParameterList {get; set;}

    /// <summary>
    /// Flag representing of the method has the 'Multi-Faceted Abstraction' codesmell or not.
    /// </summary>
    public bool HasMultifacetedAbstraction {get; set;}

    /// <summary>
    /// A measure of the relative complexity this method has.
    /// </summary>
    public int CyclomaticComplexity {get; set;}

    /// <summary>
    /// The number of lines of code in the method.
    /// </summary>
    public int LinesOfCode {get; set;}

    /// <summary>
    /// The number of execution paths found in the method.
    /// </summary>
    public int PathCount {get; set;}

    /// <summary>
    /// The type returned by the method.
    /// </summary>
    public string TypeName { get; set; } = string.Empty;

    /// <summary>
    /// The language the method is written in.
    /// </summary>
    /// <remarks>
    /// As of this writing, this project has only targeted for the Java programming language.w
    /// </remarks>
    public string ProgrammingLanguage { get; set; } = "Java";

    /// <summary>
    /// The actual text content of the code being analyzed.
    /// </summary>
    public string CodeText {get; set;}
}