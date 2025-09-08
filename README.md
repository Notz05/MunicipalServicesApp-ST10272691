# Municipal Services Application

A C# .NET Framework Windows Forms application designed to streamline municipal services in South Africa. This application provides an efficient and user-friendly platform for citizens to report issues and request various municipal services.

## Features

### Current Implementation
- **Report Issues**: Citizens can report municipal issues with detailed information
- **Location Input**: Text field for specifying the location of the issue
- **Category Selection**: Dropdown menu with predefined categories (Sanitation, Roads, Utilities, etc.)
- **Detailed Description**: Rich text box for comprehensive issue descriptions
- **File Attachments**: Support for attaching images and documents using OpenFileDialog
- **User Engagement**: Dynamic encouraging messages and progress indicators
- **Form Validation**: Comprehensive input validation with user-friendly error messages
- **Data Management**: Efficient storage and management of reported issues

### Future Features (Coming Soon)
- **Local Events and Announcements**: Access to community events and municipal announcements
- **Service Request Status**: Track the status of submitted service requests

## System Requirements

- **Operating System**: Windows 7 or later
- **Framework**: .NET Framework 4.8 or later
- **IDE**: Visual Studio 2017 or later (for development)
- **Memory**: Minimum 2GB RAM
- **Storage**: 50MB available space

## Installation and Setup

### For End Users

1. **Download the Application**
   - Download the compiled executable from the releases section
   - Extract to your preferred directory

2. **Run the Application**
   - Double-click `MunicipalServicesApplication.exe`
   - No additional installation required

### For Developers

1. **Clone or Download the Source Code**
   ```
   git clone [repository-url]
   ```

2. **Open in Visual Studio**
   - Open `MunicipalServicesApplication.sln` in Visual Studio
   - Ensure .NET Framework 4.8 is installed

3. **Build the Solution**
   - Right-click on the solution in Solution Explorer
   - Select "Build Solution" or press `Ctrl+Shift+B`

4. **Run the Application**
   - Press `F5` to run in debug mode
   - Or press `Ctrl+F5` to run without debugging

## How to Use the Application

### Main Menu
1. **Launch the Application**: The main menu displays three options
2. **Report Issues**: Click to access the issue reporting functionality
3. **Local Events**: Currently disabled (coming soon)
4. **Service Request Status**: Currently disabled (coming soon)

### Reporting an Issue

1. **Access Report Issues**
   - Click "Report Issues" from the main menu

2. **Fill in Issue Details**
   - **Location**: Enter the specific location where the issue occurred
   - **Category**: Select the appropriate category from the dropdown:
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
   - **Description**: Provide a detailed description of the issue

3. **Attach Supporting Files** (Optional)
   - Click "Attach Files" to add images or documents
   - Supported formats: All file types (images, PDFs, documents, etc.)
   - Multiple files can be attached
   - Use "Remove File" to delete selected attachments

4. **Submit the Report**
   - Click "Submit Report" to file the issue
   - A progress bar will show the submission progress
   - Confirmation message will display the assigned Issue ID

5. **Navigation Options**
   - **Back to Menu**: Return to the main menu
   - **Clear Form**: Reset all fields (with confirmation)

## Application Architecture

### Project Structure
```
MunicipalServicesApplication/
├── Models/
│   └── Issue.cs                 # Data model for reported issues
├── Services/
│   └── IssueManager.cs         # Business logic for issue management
├── Forms/
│   ├── Form1.cs                # Main menu form
│   ├── Form1.Designer.cs       # Main menu UI design
│   ├── ReportIssuesForm.cs     # Issue reporting form
│   └── ReportIssuesForm.Designer.cs # Issue reporting UI design
├── Properties/                  # Assembly and resource files
└── Program.cs                  # Application entry point
```

### Key Components

1. **Issue Model**: Represents a reported issue with properties for location, category, description, attachments, and metadata

2. **IssueManager Service**: Singleton pattern implementation for managing the collection of reported issues

3. **Main Menu Form**: Entry point with navigation to different application modules

4. **Report Issues Form**: Comprehensive form for issue reporting with validation and file attachment capabilities

## Design Features

### User Interface
- **Modern Design**: Clean, professional interface with consistent color scheme
- **Responsive Layout**: Adapts to different screen sizes and resolutions
- **Accessibility**: Clear labels, logical tab order, and keyboard navigation support
- **Visual Feedback**: Progress indicators, success messages, and error alerts

### User Experience
- **Intuitive Navigation**: Clear button labels and logical flow
- **Input Validation**: Real-time validation with helpful error messages
- **Engagement Features**: Encouraging messages to promote citizen participation
- **File Management**: Easy file attachment and removal functionality

### Technical Implementation
- **Data Structures**: Efficient use of Lists and custom objects for data management
- **Event Handling**: Comprehensive event handlers for all user interactions
- **Error Handling**: Robust error handling with user-friendly messages
- **Memory Management**: Proper disposal of resources and file handles

## Troubleshooting

### Common Issues

1. **Application Won't Start**
   - Ensure .NET Framework 4.8 is installed
   - Check Windows compatibility
   - Run as administrator if needed

2. **File Attachment Issues**
   - Verify file permissions
   - Check available disk space
   - Ensure file is not in use by another application

3. **Form Validation Errors**
   - All required fields must be completed
   - Location and description cannot be empty
   - Category must be selected

### Support
For technical support or bug reports, please contact the development team or submit an issue through the appropriate channels.

## Development Notes

### Code Standards
- **Naming Conventions**: PascalCase for public members, camelCase for private fields
- **Documentation**: XML comments for public methods and classes
- **Error Handling**: Try-catch blocks for file operations and external dependencies
- **UI Guidelines**: Consistent spacing, color scheme, and font usage

### Future Enhancements
- Database integration for persistent storage
- User authentication and profiles
- Email notifications for issue updates
- Mobile application companion
- Integration with municipal management systems
- Reporting and analytics dashboard

## License

This application is developed for educational purposes as part of the Portfolio of Evidence (PoE) project.

## Version History

- **v1.0.0**: Initial implementation with issue reporting functionality
- **Future versions**: Will include local events and service request status features

---

**© 2024 Municipal Services Application - Developed for PROG7313 PoE Part 2**
