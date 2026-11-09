# Fact 2008d256

Store id: 81b752ca-50e6-4c59-80ce-0a80c9ee18e7

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
- posted_at: `2026-11-09T23:32:05.6979400+00:00`

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
  "id": "81b752ca-50e6-4c59-80ce-0a80c9ee18e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6979400+00:00"
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
  "subject_id": "c8bf04aa-faa8-43e7-a3e5-1a8395c717c9",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_from_parent",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def get_select_from_parent(cls, klass_info)"
}
```
