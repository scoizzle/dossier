# Fact 7d393969

Store id: 78c90aa6-4296-4337-8020-56b75d2d3bc5

## Text

```text
def remote_setter(name, obj, from_obj)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:57.5710810+00:00`

## Data

```json
{
  "end_line": 1361,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_related_selections",
  "start_line": 1360,
  "symbol": "SQLCompiler.get_related_selections.remote_setter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1360,"selector":"L1360-L1361","symbol":"SQLCompiler.get_related_selections.remote_setter"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_related_selections.remote_setter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1361,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_related_selections",
    "start_line": 1360,
    "symbol": "SQLCompiler.get_related_selections.remote_setter"
  },
  "id": "78c90aa6-4296-4337-8020-56b75d2d3bc5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5710810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1360,
        "selector": "L1360-L1361",
        "symbol": "SQLCompiler.get_related_selections.remote_setter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "408a201d-f160-4365-a148-f997c3eb10cd",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections.remote_setter",
  "tags": [
    "entity:function"
  ],
  "text": "def remote_setter(name, obj, from_obj)"
}
```
