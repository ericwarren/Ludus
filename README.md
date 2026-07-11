# Ludus

A *ludus* was a Roman training school — where gladiators practiced, not where they fought.

This is a monorepo of deliberate .NET/C# study projects. Each one re-implements
something that already exists in a battle-tested library, because the point is the
building, not the artifact.

**These are not production libraries.** If you need retry logic, use Polly.
If you need a log tailer, use `tail -f`.

## Projects

- **Ludus.Resurgo** — retry and circuit-breaker primitives. *(resurgo: "I rise again")*
- **Ludus.Cauda** — a tailer for pipe-delimited logs. *(cauda: "tail")*

## Why

Notes on what each project was for, what I got wrong the first time, and what I'd
do differently. See each project's README.

## License

MIT.
