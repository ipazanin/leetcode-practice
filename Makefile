#****************************************************
#					Make configuration
#****************************************************

.ONESHELL:

#****************************************************
#					Run
#****************************************************

run::
	dotnet run --project csharp/LeetCodePractice.Console/LeetCodePractice.Console.csproj
	cargo test --manifest-path rust/Cargo.toml