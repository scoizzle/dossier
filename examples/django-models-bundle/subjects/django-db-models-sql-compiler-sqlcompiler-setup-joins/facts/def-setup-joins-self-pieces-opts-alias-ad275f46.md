# Fact ad275f46

Store id: a1752493-70eb-45fe-969d-ec7c60a3154b

## Text

```text
def _setup_joins(self, pieces, opts, alias)
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
- posted_at: `2026-11-09T23:44:57.5339860+00:00`

## Data

```json
{
  "end_line": 1157,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1144,
  "symbol": "SQLCompiler._setup_joins"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1144,"selector":"L1144-L1157","symbol":"SQLCompiler._setup_joins"}`

## Items

```json
[
  {
    "text": "Helper method for get_order_by() and get_distinct().",
    "locator": {
      "line": 1145
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler._setup_joins](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1157,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1144,
    "symbol": "SQLCompiler._setup_joins"
  },
  "id": "a1752493-70eb-45fe-969d-ec7c60a3154b",
  "items": [
    {
      "locator": {
        "line": 1145
      },
      "text": "Helper method for get_order_by() and get_distinct()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5339860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1144,
        "selector": "L1144-L1157",
        "symbol": "SQLCompiler._setup_joins"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "f07a130f-b7e4-4a6c-a3ab-6b653f6d4d04",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler._setup_joins",
  "tags": [
    "entity:method"
  ],
  "text": "def _setup_joins(self, pieces, opts, alias)"
}
```
