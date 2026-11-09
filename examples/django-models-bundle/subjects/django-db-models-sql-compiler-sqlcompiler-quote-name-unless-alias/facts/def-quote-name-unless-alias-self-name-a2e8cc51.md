# Fact a2e8cc51

Store id: c51e5e98-c2b9-4be5-9ba4-0283ef6ea477

## Text

```text
def quote_name_unless_alias(self, name)
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
- posted_at: `2026-11-09T23:32:05.7265490+00:00`

## Data

```json
{
  "end_line": 590,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 581,
  "symbol": "SQLCompiler.quote_name_unless_alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":581,"selector":"L581-L590","symbol":"SQLCompiler.quote_name_unless_alias"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.quote_name_unless_alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 590,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 581,
    "symbol": "SQLCompiler.quote_name_unless_alias"
  },
  "id": "c51e5e98-c2b9-4be5-9ba4-0283ef6ea477",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7265490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 581,
        "selector": "L581-L590",
        "symbol": "SQLCompiler.quote_name_unless_alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "5e45f1c6-c364-4fe9-bfce-d6aeafc40507",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.quote_name_unless_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def quote_name_unless_alias(self, name)"
}
```
