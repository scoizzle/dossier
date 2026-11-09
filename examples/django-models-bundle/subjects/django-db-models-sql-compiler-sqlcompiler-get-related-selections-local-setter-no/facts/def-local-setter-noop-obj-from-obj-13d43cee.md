# Fact 13d43cee

Store id: b2d39379-5646-4bf3-a088-49ea54b8c7cb

## Text

```text
def local_setter_noop(obj, from_obj)
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
- posted_at: `2026-11-09T23:32:05.8200930+00:00`

## Data

```json
{
  "end_line": 1358,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_related_selections",
  "start_line": 1357,
  "symbol": "SQLCompiler.get_related_selections.local_setter_noop"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1357,"selector":"L1357-L1358","symbol":"SQLCompiler.get_related_selections.local_setter_noop"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_related_selections.local_setter_noop](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1358,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_related_selections",
    "start_line": 1357,
    "symbol": "SQLCompiler.get_related_selections.local_setter_noop"
  },
  "id": "b2d39379-5646-4bf3-a088-49ea54b8c7cb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8200930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1357,
        "selector": "L1357-L1358",
        "symbol": "SQLCompiler.get_related_selections.local_setter_noop"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "abd23ad3-a75a-4f66-a417-7fa5ca719eca",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections.local_setter_noop",
  "tags": [
    "entity:function"
  ],
  "text": "def local_setter_noop(obj, from_obj)"
}
```
