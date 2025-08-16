Feature: Login
  Short summary: Verify login functionality on the Practice Test Automation site

  @positive
  Scenario: Successful login with valid credentials
    Given I navigate to the login page
    When I enter valid username and password
    And I click the submit button
    Then I should be logged in successfully
    And the log out button should be displayed
