Feature: ProductListPage


@SmokeTest
Scenario Outline: TC08A. Check Product List Page block or elements are displayed
	When I open a '<productListPage>'
	Then PLP header appears
	And PLP top sorting well appears
	And PLP product thumbnails appears
	And PLP bottom sorting well appears

	Examples: 
	| productListPage                          |
	| index.php?rt=product/category&path=58_63 |
