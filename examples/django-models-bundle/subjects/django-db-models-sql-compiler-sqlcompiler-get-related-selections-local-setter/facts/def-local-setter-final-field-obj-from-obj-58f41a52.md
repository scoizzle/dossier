# Fact 58f41a52

Store id: 84d7417a-9523-4245-aee5-445d0744ade0

## Text

```text
def local_setter(final_field, obj, from_obj)
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
- posted_at: `2026-11-09T23:32:05.8123990+00:00`

## Data

```json
{
  "end_line": 1355,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_related_selections",
  "start_line": 1352,
  "symbol": "SQLCompiler.get_related_selections.local_setter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1352,"selector":"L1352-L1355","symbol":"SQLCompiler.get_related_selections.local_setter"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_related_selections.local_setter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1355,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_related_selections",
    "start_line": 1352,
    "symbol": "SQLCompiler.get_related_selections.local_setter"
  },
  "id": "84d7417a-9523-4245-aee5-445d0744ade0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8123990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1352,
        "selector": "L1352-L1355",
        "symbol": "SQLCompiler.get_related_selections.local_setter"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "df167ebd-33ff-4e09-a9a9-7f5c8afc3e7a",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections.local_setter",
  "tags": [
    "entity:function"
  ],
  "text": "def local_setter(final_field, obj, from_obj)"
}
```
