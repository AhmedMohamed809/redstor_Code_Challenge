# Redstor Code Challenge
# Introduction
<p>As part of our recruitment process, we ask potential employees to take our “Code
Challenge”. This is a small project designed to allow you to showcase your software
development skills and demonstrate good object-oriented principles and design.
The Challenge.</p>
<p>
Implement the code for a supermarket checkout that calculates the total price of a number of
items. In a normal supermarket, items are identified using Stock Keeping Units (SKUs), but
in our store we’ll be using individual letters of the alphabet (A, B, C etc). Our goods are
priced individually, but some items also have multibuy offers. For example, item A might cost
60 individually, but if you buy three A’s then they’ll cost you 150. This week’s prices are as
follows:</p>
<p>
Item Unit Price Special Price
A 60 3 for 150
B 30 2 for 45
C 30
D 25
  </p>
  <p>
Items can be scanned in any order, so if we scan a B, an A, then another B, we’ll recognise
the offer for two B’s and price them at 45, giving a total price of 105. Because our store
changes its pricing frequently, we need to be able to pass in a set of pricing rules each time
we begin handling a checkout transaction.</p>
<p>
You may use any language and technologies to design and implement your solution. The
interface for the checkout should look similar to the following pseudocode:
checkout = new Checkout(pricingRules)
checkout.Scan(item)
checkout.Scan(item)
…
price = checkout.Total
Here are some example totals for sequences of items, which you may find useful for testing
your solution.
</p>
# Test  Unit

<b> I add MSTest Unit Test Project to the Solution Explorer as new project , And add the  project reference    </b>
<p> I used Microsoft documentation to learn about MSTest. </p>
<p>This is thie test reference from Microsoft learn <a>https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022</a> </p>
