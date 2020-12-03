# Named parameters in test names not formatted

When using the pattern `{M}` as `DefaultTestNamePattern` in `runsettings`, the test name does not contain the parameters formatted as named parameters.

Expected test names from [NamedParameter.cs](./NamedParameter.cs):

- TestCase(parameter: "1, 2")
- TestCase(parameter: "Test")

Actual test names:

- TestCase{p}
- TestCase{p}
