namespace API;

public class FormFieldsProperty
{
    public string Type {get; set;}
    public string Label {get; set;}
    public string Name {get; set;}
    public string Value {get; set;}
    public string PlaceHolder {get; set;}
    public List<OptionModel>? Options {get; set;}
    public List<ValidationModel>? Validations {get; set;}

}
