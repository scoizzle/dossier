# Fact 2008d256

Store id: ea4912be-0863-4b35-96dd-937354a5649c

## Text

```text
def get_select_from_parent(cls, klass_info)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.5812870+00:00`

## Data

```json
{
  "end_line": 238,
  "entity_kind": "class_method",
  "parent": "SQLCompiler",
  "start_line": 233,
  "symbol": "SQLCompiler.get_select_from_parent"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":233,"selector":"L233-L238","symbol":"SQLCompiler.get_select_from_parent"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select_from_parent](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 238,
    "entity_kind": "class_method",
    "parent": "SQLCompiler",
    "start_line": 233,
    "symbol": "SQLCompiler.get_select_from_parent"
  },
  "id": "ea4912be-0863-4b35-96dd-937354a5649c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5812870+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 233,
        "selector": "L233-L238",
        "symbol": "SQLCompiler.get_select_from_parent"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "45c889b1-40c9-41dd-914e-24f417a0c3d5",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_from_parent",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def get_select_from_parent(cls, klass_info)"
}
```
