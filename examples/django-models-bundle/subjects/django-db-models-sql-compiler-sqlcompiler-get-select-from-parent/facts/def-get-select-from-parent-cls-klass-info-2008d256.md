# Fact 2008d256

Store id: 52a044c1-9fa4-4fd3-9c2b-7e9a7a0e4118

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
- posted_at: `2026-11-09T23:44:57.4428780+00:00`

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
  "id": "52a044c1-9fa4-4fd3-9c2b-7e9a7a0e4118",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.4428780+00:00"
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
  "subject_id": "41ee2ed2-8bfd-4c98-a6e1-63f3e9cbfc4b",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_from_parent",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def get_select_from_parent(cls, klass_info)"
}
```
