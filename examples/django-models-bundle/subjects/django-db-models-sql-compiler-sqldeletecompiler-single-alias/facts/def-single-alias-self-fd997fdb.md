# Fact fd997fdb

Store id: 44eae92e-05a4-4b59-85c1-a2ed59778a7d

## Text

```text
def single_alias(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.7136090+00:00`

## Data

```json
{
  "end_line": 1996,
  "entity_kind": "method",
  "parent": "SQLDeleteCompiler",
  "start_line": 1992,
  "symbol": "SQLDeleteCompiler.single_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1992,"selector":"L1992-L1996","symbol":"SQLDeleteCompiler.single_alias"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLDeleteCompiler.single_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1996,
    "entity_kind": "method",
    "parent": "SQLDeleteCompiler",
    "start_line": 1992,
    "symbol": "SQLDeleteCompiler.single_alias"
  },
  "id": "44eae92e-05a4-4b59-85c1-a2ed59778a7d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7136090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1992,
        "selector": "L1992-L1996",
        "symbol": "SQLDeleteCompiler.single_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "ce601127-7a24-4612-a51d-40b398cbf1be",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler.single_alias",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def single_alias(self)"
}
```
