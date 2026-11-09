# Fact 87537179

Store id: 5c61d472-6a21-4454-b9e5-41dab3361cc7

## Text

```text
def _get_field_choices()
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
- posted_at: `2026-11-09T23:32:05.8015290+00:00`

## Data

```json
{
  "end_line": 1219,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_related_selections",
  "start_line": 1210,
  "symbol": "SQLCompiler.get_related_selections._get_field_choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1210,"selector":"L1210-L1219","symbol":"SQLCompiler.get_related_selections._get_field_choices"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_related_selections._get_field_choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1219,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_related_selections",
    "start_line": 1210,
    "symbol": "SQLCompiler.get_related_selections._get_field_choices"
  },
  "id": "5c61d472-6a21-4454-b9e5-41dab3361cc7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8015290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1210,
        "selector": "L1210-L1219",
        "symbol": "SQLCompiler.get_related_selections._get_field_choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "fb80c1df-8141-451f-bc29-61dc1a9a5080",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections._get_field_choices",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_field_choices()"
}
```
