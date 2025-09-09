# Municipal Services Application

This Windows Forms application, built using C# and the .NET Framework, is designed to enhance the delivery of municipal services in South Africa. It offers a streamlined and accessible interface for residents to report service-related issues and submit requests to local authorities.

## Features

### Current Capabilities
- **Issue Reporting**: Enables users to submit detailed reports on municipal problems  
- **Location Entry**: Text input for specifying where the issue occurred  
- **Category Selection**: Dropdown list with predefined service categories (e.g., Roads, Sanitation, Utilities)  
- **Issue Description**: Rich text field for elaborating on the nature of the problem  
- **File Uploads**: Allows users to attach images or documents via OpenFileDialog  
- **User Interaction**: Displays motivational prompts and progress indicators to encourage engagement  
- **Input Validation**: Ensures all fields are correctly completed, with clear error messages  
- **Data Handling**: Manages and stores submitted reports efficiently

### Planned Enhancements
- **Community Updates**: View local events and municipal announcements  
- **Request Tracking**: Monitor the progress of submitted service requests

## System Requirements

- **Supported OS**: Windows 7 or newer  
- **Framework Dependency**: .NET Framework 4.8 or above  
- **Development Environment**: Visual Studio 2017 or later  
- **Minimum RAM**: 2GB  
- **Disk Space**: At least 50MB free

## Installation and Setup

### For General Users

1. **Download the Executable**  
   - Locate the latest release and extract the files to your chosen folder

2. **Launch the Application**  
   - Run `MunicipalServicesApplication.exe` directly  
   - No installation steps required

### For Developers

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/Notz05/MunicipalServicesApp-ST10272691.git
   ```

2. **Open the Solution**  
   - Launch `MunicipalServicesApplication.sln` in Visual Studio  
   - Confirm that .NET Framework 4.8 is installed

3. **Build the Project**  
   - In Solution Explorer, right-click the solution  
   - Choose "Build Solution" or use `Ctrl+Shift+B`

4. **Run the Application**  
   - Use `F5` to start in debug mode  
   - Or `Ctrl+F5` to run without debugging

## Using the Application

### Main Menu Navigation

1. **Start the App**: The main interface presents three options  
2. **Report Issues**: Opens the issue submission form  
3. **Local Events**: Feature currently inactive (coming soon)  
4. **Request Status**: Feature currently inactive (coming soon)

### Submitting an Issue

1. **Open the Reporting Form**  
   - Select "Report Issues" from the main menu

2. **Enter Issue Details**  
   - **Location**: Specify where the issue occurred  
   - **Category**: Choose from the following options:  
     - Sanitation  
     - Roads  
     - Utilities  
     - Water Supply  
     - Electricity  
     - Street Lighting  
     - Parks and Recreation  
     - Public Safety  
     - Waste Management  
     - Other  
   - **Description**: Provide a thorough explanation of the issue

3. **Attach Files (Optional)**  
   - Use "Attach Files" to upload relevant images or documents  
   - All file types are supported  
   - Multiple attachments allowed  
   - Use "Remove File" to delete any selected files

4. **Submit the Report**  
   - Click "Submit Report"  
   - A progress bar will indicate submission status  
   - A confirmation message will display the assigned Issue ID

5. **Additional Options**  
   - **Back to Menu**: Return to the main screen  
   - **Clear Form**: Reset all fields (confirmation required)

## Application Architecture

### Project Layout
```
MunicipalServicesApplication/
├── Models/
│   └── Issue.cs                     # Defines the structure of an issue report
├── Services/
│   └── IssueManager.cs             # Handles business logic for issue processing
├── Forms/
│   ├── Form1.cs                    # Main menu functionality
│   ├── Form1.Designer.cs          # UI layout for main menu
│   ├── ReportIssuesForm.cs        # Issue reporting logic
│   └── ReportIssuesForm.Designer.cs # UI layout for issue reporting
├── Properties/                     # Application resources and settings
└── Program.cs                      # Entry point for application execution
```

### Core Components

1. **Issue Model**: Defines fields for location, category, description, attachments, and metadata  
2. **IssueManager**: Implements a singleton pattern to manage issue records  
3. **Main Menu Form**: Provides navigation to key modules  
4. **Report Issues Form**: Facilitates issue submission with validation and file support

## Design Highlights

### Interface Design
- **Professional Layout**: Clean and consistent visual design  
- **Responsive UI**: Adapts to various screen sizes and resolutions  
- **Accessibility**: Includes clear labels, logical tab order, and keyboard support  
- **Feedback Mechanisms**: Displays progress bars, success confirmations, and error alerts

### User Experience
- **Streamlined Navigation**: Clearly labeled buttons and intuitive flow  
- **Real-Time Validation**: Immediate feedback on input errors  
- **Engagement Tools**: Motivational prompts to encourage participation  
- **File Handling**: Simple interface for adding and removing attachments

### Technical Details
- **Data Structures**: Utilizes Lists and custom objects for efficient data storage  
- **Event Management**: Comprehensive handling of user interactions  
- **Error Management**: Graceful error handling with informative messages  
- **Resource Management**: Ensures proper disposal of system resources

## Troubleshooting

### Common Problems

1. **Application Fails to Launch**  
   - Verify .NET Framework 4.8 is installed  
   - Confirm OS compatibility  
   - Try running as administrator

2. **Issues with File Uploads**  
   - Check file permissions  
   - Ensure sufficient disk space  
   - Confirm the file is not open in another program

3. **Validation Errors**  
   - All mandatory fields must be completed  
   - Location and description cannot be blank  
   - A category must be selected

### Coding Standards
- **Naming**: PascalCase for public members, camelCase for private variables  
- **Documentation**: XML comments for public classes and methods  
- **Error Handling**: Use of try-catch blocks for external operations  
- **UI Consistency**: Uniform spacing, colors, and fonts throughout

## License

This software was developed for educational use as part of the Portfolio of Evidence (PoE) project.

## Version History

- **v1.0.0**: Initial release with core issue reporting functionality  
- **Upcoming Releases**: Will include support for local events and request tracking

---

**© 2025 Municipal Services Application – Developed for PROG7312 PoE**
