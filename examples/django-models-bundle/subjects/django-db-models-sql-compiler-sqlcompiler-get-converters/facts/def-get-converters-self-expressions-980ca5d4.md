# Fact 980ca5d4

Store id: 0d9e74ee-aaa8-45d5-b162-b312cbb30d07

## Text

```text
def get_converters(self, expressions)
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
- posted_at: `2026-11-09T23:44:57.6003140+00:00`

## Data

```json
{
  "end_line": 1552,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1532,
  "symbol": "SQLCompiler.get_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1532,"selector":"L1532-L1552","symbol":"SQLCompiler.get_converters"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1552,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1532,
    "symbol": "SQLCompiler.get_converters"
  },
  "id": "0d9e74ee-aaa8-45d5-b162-b312cbb30d07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.6003140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1532,
        "selector": "L1532-L1552",
        "symbol": "SQLCompiler.get_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "dcb01eb9-1f22-46be-997a-b24db4adec81",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_converters(self, expressions)"
}
```
