# Fact 13d43cee

Store id: ac12fdd1-9e83-4d4f-9211-beea0638b2d5

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
- posted_at: `2026-11-09T22:39:50.6474200+00:00`

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
  "id": "ac12fdd1-9e83-4d4f-9211-beea0638b2d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6474200+00:00"
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
  "subject_id": "6321fbfa-ceaf-47ee-8b31-86b75e9f158b",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections.local_setter_noop",
  "tags": [
    "entity:function"
  ],
  "text": "def local_setter_noop(obj, from_obj)"
}
```
