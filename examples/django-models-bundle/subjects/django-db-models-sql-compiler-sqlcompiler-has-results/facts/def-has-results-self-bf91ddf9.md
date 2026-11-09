# Fact bf91ddf9

Store id: f47f4054-b6d5-4b65-a6ca-6ee8a790065e

## Text

```text
def has_results(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:05.9077870+00:00`

## Data

```json
{
  "end_line": 1611,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1606,
  "symbol": "SQLCompiler.has_results"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1606,"selector":"L1606-L1611","symbol":"SQLCompiler.has_results"}`

## Items

```json
[
  {
    "text": "Backends (e.g. NoSQL) can override this in order to use optimized versions of \"query has any results.\"",
    "locator": {
      "line": 1607
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.has_results](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1611,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1606,
    "symbol": "SQLCompiler.has_results"
  },
  "id": "f47f4054-b6d5-4b65-a6ca-6ee8a790065e",
  "items": [
    {
      "locator": {
        "line": 1607
      },
      "text": "Backends (e.g. NoSQL) can override this in order to use optimized versions of \"query has any results.\""
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.9077870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1606,
        "selector": "L1606-L1611",
        "symbol": "SQLCompiler.has_results"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "f29b1025-b106-4c8f-a79d-6c04ac2765b1",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.has_results",
  "tags": [
    "entity:method"
  ],
  "text": "def has_results(self)"
}
```
