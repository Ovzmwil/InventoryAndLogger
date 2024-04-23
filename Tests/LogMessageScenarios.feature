Feature: Log function

Scenario: Write log in file once time
    Given I provide the following parameters 
    | application.log | User logged in | INFO | 
    When I call the function LogMessage 
    Then a file called application.log should be created
    And the following informations should be in it
    | [yyyy/MM/dd HH:mm:ss] | [INFO] | User logged in |

Scenario: Write log file multiple times
    Given I provide the following parameters
    | application.log | User logged in | INFO | 
    And I call the function LogMessage
    And I provide the following parameters
    | application.log | Failed login attempt | WARNING | 
    When I call the function LogMessage
    Then a file called application.log should be created
    And the following informations should be in it
    | [yyyy/MM/dd HH:mm:ss] | [INFO] | User logged in |
    | [yyyy/MM/dd HH:mm:ss] | [WARNING] | Failed login attempt |