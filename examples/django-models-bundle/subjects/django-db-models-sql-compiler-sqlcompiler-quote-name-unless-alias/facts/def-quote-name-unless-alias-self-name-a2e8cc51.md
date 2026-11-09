# Fact a2e8cc51

Store id: 292a2a38-a8c1-4f5c-a85a-173bfb41421f

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
- posted_at: `2026-11-09T22:39:50.5998900+00:00`

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
  "id": "292a2a38-a8c1-4f5c-a85a-173bfb41421f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5998900+00:00"
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
  "subject_id": "e4eba519-26dd-42de-b928-189ff8eaabe3",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.quote_name_unless_alias",
  "tags": [
    "entity:method"
  ],
  "text": "def quote_name_unless_alias(self, name)"
}
```
