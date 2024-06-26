# Multi
Do you trust my code? (Don't worry, it's not a virus. It's just *incredibly* useless.)

> This is an inside joke that somehow turned into this "project".

## Compiling 

> You need the dotnet framework installed.

### Set compiler environment variable
1. Go to `C:\Windows\Microsoft.NET\Framework\` then the latest release.
2. Copy the path e.g. `C:\Windows\Microsoft.NET\Framework\v4.0.30319`.
3. Search "env" and open `Edit the system environment variables`.
4. Click `Environment Variables...`.
5. Under `User variables for [User]`, select `Path`, then `Edit`.
6. Click `New` and paste the path.
7. Click `OK` to all prompts.

> Test by typing `csc` in a new terminal.

### To compile and run
1. Go to project and run `compile.bat`.
> Alternatively, you can run `.\compile.bat` in your terminal (confirm that you are in the correct directory).
2. This creates `Multi.exe`.


## Documentation

### Developer Documentation

#### Context Diagram
```mermaid
flowchart LR
    A[User]
    B((Multi))
    C[Magic Wizard]

    A -- Input      --> B -- Output --> A
    B -- Spell ID   --> C -- Result --> B
```

#### Social and Ethical Issues
- No copyright issues :)
- No stealing from places :)
- Ergonomic and intuitive :)
- I think AI write 95% of the code :(

#### Data Flow Diagram
```mermaid
flowchart LR
    A[User]
    B((Process Input))
    C((Validate Input))
    D((Run Algorithm))
    E((Navigate))
    G[Magic Wizard]

    A -- Data   --> B -- Result         --> A
    B -- Input  --> C -- Number or Err  --> B
    B -- Option --> E -- New Display    --> B
    B -- Data   --> D -- Result         --> B
    D -- ???    --> G -- ???            --> D
```

#### Version control
```mermaid
%%{init: { 'gitGraph': {'mainBranchName': 'nounontoi', 'showCommitLabel':false}} }%%
gitGraph
    commit
    branch TitanPlayz
    checkout TitanPlayz
    commit
    commit
    checkout nounontoi
    merge TitanPlayz
    checkout TitanPlayz
    commit
    commit
    checkout nounontoi
    merge TitanPlayz
    checkout TitanPlayz
    commit
    commit
    checkout nounontoi
    merge TitanPlayz
```

#### Developer Wellbeing
```mermaid
%%{init: {'themeVariables': { 'pie1': '#A00000', 'pie2': '#FFFF00', 'pie3': '#00FF00'}}}%%
pie title Insanity
    "Lost it" : 90
    "Coping" : 8
    "Sane" : 2
```

### User Documentation

#### Minimum hardware requirements
Windows 12 or Arch Linux (no Mac, iOS, Android, Samsung 651L Family Hub™ Smart Refrigerator, etc...).

#### Installation Guide
> To make room for the program, the user may choose to remove System32 from their computer.
1. If the user is running a Samsung 651L Family Hub™ Smart Refrigerator, they must first obtain a Windows 12 or Arch Linux computer through ethical or unethical means.

#### Quality Assurance
Correctness: Does it do what it is supposed to do?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Reliability: Does it do it all of the time?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Efficiency: Does it do it the best way possible?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Integrity: Is it secure?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Useability: Is it designed for the end user?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Maintainability: Can it be understood?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Flexibility: Can it be modified?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Testability: Can it be tested?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Portability: Will it work with other hardware?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Re-useability: Can parts of it be used in another project?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)

Interoperability: Will it work with other software?

![thumbs up small](https://github.com/nounontoi/Multi/assets/110803721/efdec3a5-6384-469b-9ed0-2f65abc9a246)