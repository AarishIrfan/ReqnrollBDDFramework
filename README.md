## ReqnrollBDDFramework

UI testing framework using Reqnroll, Selenium WebDriver and NUnit.


## Folder Structure

```

ReqnrollBDDFramework/
│
├─ bin/                        # Compiled binaries
├─ features/                   # Gherkin feature files
├─ StepDefinitions/            # Step definition files
├─ Logs/                       # Console or log output
└─ Reports/                    # Placeholder for future reports

````

---

## Getting Started

1. Clone the repository:

```bash
git clone https://github.com/AarishIrfan/ReqnrollBDDFramework.git
````

2. Open in **Visual Studio 2022** or later.

3. Restore NuGet packages:

* Reqnroll
* NUnit
* NUnit3TestAdapter
* Selenium.WebDriver
* Selenium.Support
* Selenium.WebDriver.ChromeDriver

4. Build the solution:

```bash
dotnet build
```

---

## Running Tests

* Open **Test Explorer** in Visual Studio.
* Build the solution (`Ctrl+Shift+B`).
* Run tests from **Test Explorer**.

Step execution messages and results will appear in **Test Explorer output**.

---

## Sample Login Scenario

**Feature File (`Login.feature`)**:

```gherkin
Feature: Login

  Scenario: Successful login with valid credentials
    Given I navigate to the login page
    When I enter valid username and password
    And I click the submit button
    Then I should be logged in successfully
    And the log out button should be displayed
```

**Step Definition (`LoginStepDefinitions.cs`)**:

```csharp
[Given("I navigate to the login page")]
public void GivenINavigateToTheLoginPage()
{
    driver = new ChromeDriver();
    driver.Manage().Window.Maximize();
    driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
}

```
