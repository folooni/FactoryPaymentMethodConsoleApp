Factory Pattern

Scenario: We have different payment methods (that can be added to them in future). We need to implement the payment so we have single call by indicating which payment method we want and factory uses the proper concrete code for that payment.
          There is a single interface as  void pay(double amount);
          Then, tere are number of concrete implementation of the interface as in different payment methods; such as:
          - Google Pay
          - Credit Card
          - Pypal
          - etc. (other methods in future)
          Now we need a Factory that decides which payment method should process the payment.
