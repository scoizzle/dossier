# Fact 50cabcb7

Store id: 3bf32ad0-41fc-4f8b-a7fc-f401d5159101

## Text

```text
def get_related_selections( self, select, select_mask, opts=None, root_alias=None, cur_depth=1, requested=None, restricted=None, )
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
- posted_at: `2026-11-09T22:39:50.6362450+00:00`

## Data

```json
{
  "end_line": 1424,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1193,
  "symbol": "SQLCompiler.get_related_selections"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1193,"selector":"L1193-L1424","symbol":"SQLCompiler.get_related_selections"}`

## Items

```json
[
  {
    "text": "Fill in the information needed for a select_related query. The current depth is measured as the number of connections away from the root model (for example, cur_depth=1 means we are looking at models with direct connections to the root model).",
    "locator": {
      "line": 1203
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_related_selections](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1424,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1193,
    "symbol": "SQLCompiler.get_related_selections"
  },
  "id": "3bf32ad0-41fc-4f8b-a7fc-f401d5159101",
  "items": [
    {
      "locator": {
        "line": 1203
      },
      "text": "Fill in the information needed for a select_related query. The current depth is measured as the number of connections away from the root model (for example, cur_depth=1 means we are looking at models with direct connections to the root model)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6362450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1193,
        "selector": "L1193-L1424",
        "symbol": "SQLCompiler.get_related_selections"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "5fd9a10c-2a2d-43c6-a139-84a80cdd8761",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections",
  "tags": [
    "entity:method"
  ],
  "text": "def get_related_selections( self, select, select_mask, opts=None, root_alias=None, cur_depth=1, requested=None, restricted=None, )"
}
```
