### Setup

- Put the appropriate `Coverlet.nupkg` in a local folder.
- Update `NuGet.config` so that the package source `local` is that local folder.

### Steps to Test (PowerShell 5 or 7)

```powershell
Remove-Item test -r; `
dotnet test --results-directory test `
  --coverlet --coverlet-output-format cobertura `
  --diagnostic --diagnostic-verbosity Trace; `
Get-Item test\log* `
| Select-Object -First 1 `
| Get-Content `
| Select-String WARNING -SimpleMatch -CaseSensitive
```

### Steps to Test (sh)

```bash
rm -r test; \
dotnet test --results-directory test \
  --coverlet --coverlet-output-format cobertura \
  --diagnostic --diagnostic-verbosity Trace; \
ls test/log_* | head -n 1 | xargs grep -F WARNING
```
