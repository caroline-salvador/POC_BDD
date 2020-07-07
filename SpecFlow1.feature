Feature: Wikipedia Stock Validation

Scenario: Validate Google's Stock Symbol
	Given I have navigated to the "Alphabet_Inc." page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "GOOGL"

Scenario: Validate Microsoft's  Stock Symbol
	Given I have navigated to the "Microsoft" page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "MSFT"

Scenario: Validate Apple's  Stock Symbol
	Given I have navigated to the "Apple_Inc." page on Wikipedia
	Then the NASDAQ stock symbol on the page should be "AAPL"