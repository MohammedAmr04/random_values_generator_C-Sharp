# random_values_generator_C-Sharp

A tiny .NET console utility that generates random values (numbers or strings).

## Features

- Generate a random 4-digit number.
- Generate a random 16-character string using printable ASCII characters.

## Prerequisites

- .NET 9 SDK (or compatible .NET SDK) installed. Verify with:

```bash
dotnet --version
```

## Build and run

From the project root folder run:

```bash
dotnet build
dotnet run
```

When the program starts you'll see a prompt asking for an option:

```
----------Start With Random Values Generator----------
What do you want?
[1] Generate random number
[2] Generate random string
```

Enter `1` to generate a random 4-digit number or `2` to generate a random 16-character string, then press Enter.

## Example output

- Option 1: `4827`
- Option 2: `AqZ#x9Lm>R2tYpW!`

## Notes

- The project is intentionally simple and single-file (`Program.cs`).
- Random values are generated using `System.Random`.

## Contributing

Feel free to open issues or submit pull requests for improvements.
