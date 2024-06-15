namespace Bhouse.Test.CodeQualityLearningModelTests.Models.Data;

/// <summary>
/// Represents a series of metrics collected for an individual class written in an
/// object-oriented programming language.
/// </summary>
public class ObjectOrientedClassMetrics
{
    /// <summary>
    /// The primary key identifier of the collected class metric.
    /// </summary>
    public int SampleId {get; set;}

    /// <summary>
    /// The primary key identifier of the SampleCodeReference where our class's code text is stored.
    /// </summary>
    public int SampleCodeReferenceId {get; set;}

    /// <summary>
    /// Flag representing of the class has a codesmell or not.
    /// </summary>
    public bool HasSmell {get; set;}

    /// <summary>
    /// Flag representing of the class has the 'Complex Methods' codesmell or not.
    /// </summary>
    public bool HasComplexMethod {get; set;}

    /// <summary>
    /// Flag representing of the class has the 'Long Parameter List' codesmell or not.
    /// </summary>
    public bool HasLongParameterList {get; set;}

    /// <summary>
    /// Flag representing of the class has the 'Multi-Faceted Abstraction' codesmell or not.
    /// </summary>
    public bool HasMultifacetedAbstraction {get; set;}

    /// <summary>
    /// A measure of the level or depth of inheritance this class has.
    /// </summary>
    /// <remarks>
    /// A 0 represents this class having no inheritance and is known as a 'root' class.
    /// Any number above 0 is the number of inheritance layers above this class.
    /// </remarks>
    public int DepthOfInheritanceTree {get; set;}

    /// <summary>
    /// The number of other class or methods that are dependent on this class.
    /// </summary>
    public int FanIn {get; set;}

    /// <summary>
    /// The number of dependencies the class has.
    /// </summary>
    public int FanOut {get; set;}

    /// <summary>
    /// A score of how closely the class's methods relate to one another.
    /// </summary>
    /// <remarks>
    /// Has a value between 0 and 1. The higher the value the less cohesive the methods are.
    /// </remarks>
    public double LackOfCohesionInMethods {get; set;}

    /// <summary>
    /// The number of lines of code in the class.
    /// </summary>
    public int LinesOfCode {get; set;}

    /// <summary>
    /// The number of classes in the class.
    /// </summary>
    public int NumberOfClasses {get; set;}

    /// <summary>
    /// The number of fields in the class.
    /// </summary>
    public int NumberOfFields {get; set;}

    /// <summary>
    /// The number of methods in the class.
    /// </summary>
    public int NumberOfMethods {get; set;}

    /// <summary>
    /// The number of public fields in the class.
    /// </summary>
    public int NumberOfPublicFields {get; set;}

    /// <summary>
    /// The number of public methods in the class.
    /// </summary>
    public int NumberOfPublicMethods {get; set;}

    /// <summary>
    /// The sum of operational complexity of all methods in the class.
    /// </summary>
    public int WeightedMethodsPerClass {get; set;}

    /// <summary>
    /// The type returned by the class method or property.
    /// </summary>
    public string TypeName { get; set; } = string.Empty;

    /// <summary>
    /// The language the class is written in.
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