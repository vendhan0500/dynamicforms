using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ParticipantController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ParticipantController> _logger;

    public ParticipantController(ILogger<ParticipantController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetParticipantInfoFormField")]
    public IEnumerable<FormFieldsProperty> Get()
    {
       var fieldValues = new List<FormFieldsProperty>(){
        new FormFieldsProperty{
            Type = "text",
            Label = "First Name",
            Name = "firstname",
            Value = string.Empty,
            PlaceHolder = "Enter First Name",
            Validations = new List<ValidationModel>(){
                new ValidationModel{
                    Name = "required",
                    Validator = "required",
                    Message = "First Name is required"
                }
            }
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Middle Name",
            Name = "middlename",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Enter Middle Name"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Last Name",
            Name = "lastname",
            Value = string.Empty,
            Validations = new List<ValidationModel>(){
                new ValidationModel{
                    Name = "required",
                    Validator = "required",
                    Message = "Last Name is required"
                }
            },
            PlaceHolder = "Enter Last Name"
        },
        new FormFieldsProperty{
            Type = "radio",
            Label = "Please select your Gender",
            Name = "gender",
            Value = "true",
            Validations = new List<ValidationModel>(){
                new ValidationModel{
                    Name = "required",
                    Validator = "required",
                    Message = "Gender is required"
                }
            },
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "Male",
                    Value = "1"
                },
                new OptionModel{
                    Label = "Female",
                    Value = "2"
                },
                new OptionModel{
                    Label = "Others",
                    Value = "3"
                }
            }
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Register Email ID",
            Name = "email",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Enter Email"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Organization",
            Name = "organization",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Designation",
            Name = "designation",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Passport Number / National ID",
            Name = "passportnoOrNationalId",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Identification Document",
            Name = "identificationDocument",
            Value = "1",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "option 1",
                    Value = "1"
                },
                new OptionModel{
                    Label = "option 2",
                    Value = "2"
                },
                new OptionModel{
                    Label = "option 3",
                    Value = "3"
                }
            }
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Nationality / (ies)",
            Name = "nationality",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Place of Birth",
            Name = "placeofBirth",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Date of Birth",
            Name = "date",
            Value = "1",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "1",
                    Value = "1"
                },
                new OptionModel{
                    Label = "2",
                    Value = "2"
                },
                new OptionModel{
                    Label = "3",
                    Value = "3"
                },
                new OptionModel{
                    Label = "4",
                    Value = "4"
                },
                new OptionModel{
                    Label = "5",
                    Value = "5"
                }
            }
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "",
            Name = "month",
            Value = "1",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "Jan",
                    Value = "01"
                },
                new OptionModel{
                    Label = "Feb",
                    Value = "02"
                },
                new OptionModel{
                    Label = "Mar",
                    Value = "03"
                },
                new OptionModel{
                    Label = "Apr",
                    Value = "04"
                },
                new OptionModel{
                    Label = "May",
                    Value = "05"
                }
            }
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "",
            Name = "year",
            Value = "2024",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "2024",
                    Value = "2024"
                },
                new OptionModel{
                    Label = "2023",
                    Value = "2023"
                },
                new OptionModel{
                    Label = "2022",
                    Value = "2022"
                },
                new OptionModel{
                    Label = "2021",
                    Value = "2021"
                },
                new OptionModel{
                    Label = "2020",
                    Value = "2020"
                }
            }
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Current residential Address",
            Name = "address",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Telephone Number",
            Name = "telephoneno",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "PayPal Wallet name",
            Name = "walletname",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "PayPal country code",
            Name = "countrycode",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "PayPal Email ID / Phone Number",
            Name = "emailorphoneno",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Origin",
            Name = "origin",
            Value = "2024",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "2024",
                    Value = "2024"
                },
                new OptionModel{
                    Label = "2023",
                    Value = "2023"
                },
                new OptionModel{
                    Label = "2022",
                    Value = "2022"
                },
                new OptionModel{
                    Label = "2021",
                    Value = "2021"
                },
                new OptionModel{
                    Label = "2020",
                    Value = "2020"
                }
            }
        },
        new FormFieldsProperty{
            Type = "text",
            Label = "Departure Date/Time",
            Name = "deptdatetime",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
         new FormFieldsProperty{
            Type = "text",
            Label = "Destination Date/Time",
            Name = "destdatetime",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Seat / meal preference",
            Name = "seatormealpreference",
            Value = "2024",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "2024",
                    Value = "2024"
                },
                new OptionModel{
                    Label = "2023",
                    Value = "2023"
                },
                new OptionModel{
                    Label = "2022",
                    Value = "2022"
                },
                new OptionModel{
                    Label = "2021",
                    Value = "2021"
                },
                new OptionModel{
                    Label = "2020",
                    Value = "2020"
                }
            }
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Frequent Flier Details",
            Name = "flierdetails",
            Value = "2024",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "2024",
                    Value = "2024"
                },
                new OptionModel{
                    Label = "2023",
                    Value = "2023"
                },
                new OptionModel{
                    Label = "2022",
                    Value = "2022"
                },
                new OptionModel{
                    Label = "2021",
                    Value = "2021"
                },
                new OptionModel{
                    Label = "2020",
                    Value = "2020"
                }
            }
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Hotel Requirements",
            Name = "hotelrequirements",
            Value = "2024",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "2024",
                    Value = "2024"
                },
                new OptionModel{
                    Label = "2023",
                    Value = "2023"
                },
                new OptionModel{
                    Label = "2022",
                    Value = "2022"
                },
                new OptionModel{
                    Label = "2021",
                    Value = "2021"
                },
                new OptionModel{
                    Label = "2020",
                    Value = "2020"
                }
            }
        },
        new FormFieldsProperty{
            Type = "select",
            Label = "Document Type",
            Name = "doctype",
            Value = "2024",
            Validations = null,
            Options = new List<OptionModel>{
                new OptionModel{
                    Label = "2024",
                    Value = "2024"
                },
                new OptionModel{
                    Label = "2023",
                    Value = "2023"
                },
                new OptionModel{
                    Label = "2022",
                    Value = "2022"
                },
                new OptionModel{
                    Label = "2021",
                    Value = "2021"
                },
                new OptionModel{
                    Label = "2020",
                    Value = "2020"
                }
            }
        },
         new FormFieldsProperty{
            Type = "text",
            Label = "Identity Number",
            Name = "identityno",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Enter Identity Number"
        },
         new FormFieldsProperty{
            Type = "file",
            Label = "",
            Name = "file",
            Value = string.Empty,
            Validations = null,
        },
        new FormFieldsProperty{
            Type = "textarea",
            Label = "Comments",
            Name = "comments",
            Value = string.Empty,
            Validations = null,
            PlaceHolder = "Text Here"
        },
       };
       
       return fieldValues;
    }
}
