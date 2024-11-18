This project is simply iterating through various elements in Dotnet (but not exclusively Dotnet specfic practices). Nothing fancy or usable is meant to come from this, just a bit of practice before an interview :P
obs. everything is "logged" in the Issues tab on Github with notes, examples, and other "thought" I had throughout this little project.

This includes:

- Conceptual ER diagram
- Project Architecture decisions
- SQLite: For local in-proccess storage
- EF Core: Working through ORM and specific SQLite controller to migrate and bridge the source C# code with the database file
    -   This includes mapping the ER diagram to a specific schema, modelled in C#
    -   Ensuring at least BCNF (normalization) to combat redudancy and anomalies
- LINQ vs Raw SQL: re-iterating syntax of declarative linq in a functional-ish chaining/pipelining (w. lazy execution and a standard syntax for other data sources)
    - Extend with an enumarable operation.. maybe
- MinimalAPI: exposing endpoints through MinimalAPI. This should work with some repository and consider asynchronous operations to not stall UI (which is not included here, but for good practice)
- Testing: Unit testing to some X coverage, ideally checked by SonarCloud and triggered by Github Actions



Project Configuration:

Branch Protection: Require pull requests on merge to main
Github Actions workflow: Build (not yet required to succeed on commits). TODO: add test requirements
SonarCloud: Not yet included. TODO: identify code smells and verify test coverage

- Monitoring and Logging? Could add prometheus metrics, Promtail logging and Grafana Dashboards.. at some point at least

Structure:
.. 


