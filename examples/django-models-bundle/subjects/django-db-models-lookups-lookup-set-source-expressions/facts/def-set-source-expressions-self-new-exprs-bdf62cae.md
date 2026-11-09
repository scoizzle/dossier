# Fact bdf62cae

Store id: 53cf59e8-2a9b-4c01-b631-3d4f7d201fb3

## Text

```text
def set_source_expressions(self, new_exprs)
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
- posted_at: `2026-11-09T22:39:47.9873660+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 83,
  "symbol": "Lookup.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":83,"selector":"L83-L87","symbol":"Lookup.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 83,
    "symbol": "Lookup.set_source_expressions"
  },
  "id": "53cf59e8-2a9b-4c01-b631-3d4f7d201fb3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.9873660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 83,
        "selector": "L83-L87",
        "symbol": "Lookup.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "17336175-725a-489e-a6c8-8c44bcbcaa93",
  "subject_name": "django/db/models/lookups::Lookup.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, new_exprs)"
}
```
