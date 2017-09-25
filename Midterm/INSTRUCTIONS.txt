FOCUS: Use inheritance with classes, interfaces and properties.
- Create a new Console Application in you workspace.
- Don't use try, catch or finally blocks. That comes later. In fact, don't do anything that is not explicitly requested in the instructions since some things that seem needed or obvious might be specified in one of the extra credit sections.
- You’ll will define 2 classes and one interface  – SaverAccount ,GoldAccount, and IBankAccount. Define each class in its own file. The file name should be the class name. Rename Program.cs to BankAccounts.cs
- In the IBankAccount interface, define a payIn() method (feel free to name the payIn() method deposit()), if you prefer. It takes a decimal  as a parameter and returns void, a withdraw() method that takes a decimal as an argument and returns a boolean. Also, define a read only property named Balance.
- The GoldAccount implements IBankAccount. Provide code for the payIn() and withdraw() methods as well as the Balance property. The payIn() method adds the deposit amount to the balance and the withdraw() method decrements the balance. However, you can’t withdraw more than the balance. Produce a message, if there are insufficient funds. Override the ToString() method inherited from Object to produce a balance message (see sample output below). Use String.Format() to produce the balance message in currency format. You'll need to override the ToString() method and use something like this " String.Format("some text = {0,6:C}", your money field);. Your numbers may be different based on what values you used in the payIn and withDraw methods.
- Make the same changes to the SaverAccount.
- In BankAccounts, instantiate at least one account of each type as IBankAccount and invoke the payIn() and withdraw() methods.
- Test the application.
- End the application.
