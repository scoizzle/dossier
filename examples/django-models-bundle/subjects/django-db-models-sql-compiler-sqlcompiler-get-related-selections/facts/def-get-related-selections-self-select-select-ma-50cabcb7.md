# Fact 50cabcb7

Store id: 2d511807-e081-49f3-9d3e-b92d6a8cd2c8

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
- posted_at: `2026-11-09T23:32:05.7973310+00:00`

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
  "id": "2d511807-e081-49f3-9d3e-b92d6a8cd2c8",
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
    "posted_at": "2026-11-09T23:32:05.7973310+00:00"
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
  "subject_id": "9f9a5658-fc51-4b77-90e6-83be0a812ab9",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_related_selections",
  "tags": [
    "entity:method"
  ],
  "text": "def get_related_selections( self, select, select_mask, opts=None, root_alias=None, cur_depth=1, requested=None, restricted=None, )"
}
```
