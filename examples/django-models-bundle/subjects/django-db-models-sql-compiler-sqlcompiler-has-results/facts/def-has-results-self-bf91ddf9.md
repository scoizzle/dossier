# Fact bf91ddf9

Store id: 08cbd415-2acc-4482-ae88-ddbb5b9b0879

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
- posted_at: `2026-11-09T23:44:57.6293040+00:00`

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
  "id": "08cbd415-2acc-4482-ae88-ddbb5b9b0879",
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
    "posted_at": "2026-11-09T23:44:57.6293040+00:00"
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
  "subject_id": "a2802d8b-bb28-4f42-81bd-613957fd0b6a",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.has_results",
  "tags": [
    "entity:method"
  ],
  "text": "def has_results(self)"
}
```
