# Fact a2e8cc51

Store id: b6ade1ed-60ec-4019-8c44-b9b59dddc24d

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
- posted_at: `2026-11-09T23:44:57.4770610+00:00`

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
  "id": "b6ade1ed-60ec-4019-8c44-b9b59dddc24d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.4770610+00:00"
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
  "subject_id": "a44ed364-5c59-4475-86d4-b3a92d41ac3e",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.quote_name_unless_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def quote_name_unless_alias(self, name)"
}
```
