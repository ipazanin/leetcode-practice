#****************************************************
#					Make configuration
#****************************************************

.ONESHELL:

#****************************************************
#					Test
#****************************************************

test::
	dotnet run --project csharp/LeetCodePractice.Console/LeetCodePractice.Console.csproj
	dotnet test csharp/LeetCodePractice.sln
	cargo test --manifest-path rust/Cargo.toml