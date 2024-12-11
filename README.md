# Menu Component for Blazor

This project implements a reusable and customizable menu component using the Blazor framework. The component supports hierarchical nesting of menu items with no limit on depth, dynamic submenus, and an interactive user experience.

## Features

### General Features

- **Nested Menu Structure:** Supports root-level menu items and infinitely nested child menu items.

- **Dynamic Submenu Display:**

  - Submenus are displayed below their parent items for the first level.

  - Deeper nested submenus are displayed to the right of their immediate parent.

- **Interactive Behavior:**

  - Submenus appear when hovering over a parent item.

  - Submenus automatically close when the mouse moves away.

### Technical Features

- **Built with the latest stable version of the Blazor framework.**
  
- **Organized into two projects:**

  - Component Project: Contains the reusable menu component.

  - Sample App Project: Demonstrates the usage of the menu component with sample pages.

- **Fully customizable through markup and styles.**

## Getting Started

### Prerequisites

- **.NET 6.0 SDK or later installed on your system.**

- **A code editor like Visual Studio 2022 (recommended) or Visual Studio Code.**

### Installation

1. Clone the repository:

    `git clone https://github.com/AlexanderMarinov894/BlazorMenu`

2. Open the solution file `MenuComponent.sln` in Visual Studio.

3. Build the solution to restore all dependencies.

### Running the Sample App

1. Set the sample app project as the startup project.

2. Run the application:

  - In Visual Studio, press `F5` or click on the `Run` button.

  - Alternatively, use the .NET CLI:

      `dotnet run --project ProgressBlazorMenuTask`

3. Open the app in your browser to view the menu component in action.

## Usage

To use the menu component, define it in a `.razor` file as follows:

```razor
<Menu>
    <MenuItem Label="Item 1">
        <MenuItem Label="Item 1.1" />
        <MenuItem Label="Item 1.2">
            <MenuItem Label="Item 1.2.1" />
            <MenuItem Label="Item 1.2.2" />
        </MenuItem>
    </MenuItem>
    <MenuItem Label="Item 2" />
</Menu>
```

This configuration generates a menu with nested items that align to the requirements.

Alternatively, a C# datasource object can be passed to the component:

```C#
MenuModel menu = new MenuModel 
{
    Items = new List<MenuItemModel> 
    {
        new MenuItemModel
        {
            Text = "Item 1",
            Items = new List<MenuItemModel>
            {
                new MenuItemModel 
                {
                    Text = "Item 1.1"
                },
                new MenuItemModel
                {
                    Text = "Item 1.2",
                    Items = new List<MenuItemModel>
                    {
                        new MenuItemModel
                        {
                            Text = "Item 1.2.1"
                        },
                        new MenuItemModel
                        {
                            Text = "Item 1.2.2"
                        },
                    }
                }
            }
        },

        new MenuItemModel 
        {
            Text = "Item 2",
            Items = new List<MenuItemModel>
            {
                new MenuItemModel
                {
                    Text = "Item 2.1"
                }
            }
        },

        new MenuItemModel
        {
            Text = "Item 3"
        }
    }
};
```

```razor
<Menu Items="menu.Items"></Menu>
```

### Customization

- Add custom styles by modifying the CSS file in the component project.

- Extend functionality by adding parameters to the `Menu` or `MenuItem` components.
  - Menu
    - **Items:** Menu data source.
    - **MenuOpenType:** The action that will trigger a menu node expand. Supported actions are `MouseEnter` and `Click`.
  - MenuItem
    - **Items:** MenuItem data source; A list of MenuItems, to be nested in the current item.
    - **Text:** The text that will be displayed on the menu item.
    - **Icon:** A FontAwesome icon name, to be displayed behind the MenuItem Text.

## Design Decisions

### Component Architecture

- **Separation of Concerns:** The solution is split into a reusable component project and a sample app project to demonstrate flexibility and ensure clean project structure.

- **Blazor Framework:** Chosen for its ability to build dynamic, interactive UIs using C#.

### Styling

- Minimal default styles are applied for a clean, functional appearance.

- Additional effects like shadows and animations can be easily added by extending the CSS.

## Contact

For any questions or feedback, please open an issue in the repository.
