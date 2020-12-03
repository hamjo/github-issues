# Inherited tests not using derived class in full name

When using the pattern `{M}` as `DefaultTestNamePattern` in `runsettings`, the test name does not contain the name of the derived class being run for inherited tests.

Expected test name from [AbstractTests.cs](./AbstractTests.cs):

- inherited_test_name.DerivedClass.ShouldHaveDerivedClassesAsFullName

Actual test name:

- inherited_test_name.AbstractBaseClass.ShouldHaveDerivedClassesAsFullName

Expected test names from [ConcreteTests.cs](./ConcreteTests.cs):

- inherited_test_name.ConcreteBaseClass.ShouldHaveDerivedClassesAsFullName
- inherited_test_name.DerivedConcreteClass.ShouldHaveDerivedClassesAsFullName

Actual test name:

- inherited_test_name.ConcreteBaseClass.ShouldHaveDerivedClassesAsFullName
- inherited_test_name.ConcreteBaseClass.ShouldHaveDerivedClassesAsFullName
