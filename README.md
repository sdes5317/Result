# aspnet-core
1. abp new Result --u none -m none -csf --version 6.0.3 --old
2. Removed HttpClient, HttpClient.UnitTest, Http, Host project.
3. Copy to domain and UT folder
4. Fixed the project's reference to new path.
5. Add domain to main project's http host and client.
6. Implemented domain's application and interface, enable main host project's.
   ```options.ConventionalControllers.Create(typeof(ResultApplicationModule).Assembly);```
