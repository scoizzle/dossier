# Fact fef4d453

Store id: 2f72ad75-b58d-4014-8db6-9fbb5e1d9b76

## Text

```text
class KeyTransformEndsWith(KeyTransformTextLookupMixin, lookups.EndsWith)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.0557050+00:00`

## Data

```json
{
  "end_line": 701,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 700,
  "symbol": "KeyTransformEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":700,"selector":"L700-L701","symbol":"KeyTransformEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 701,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 700,
    "symbol": "KeyTransformEndsWith"
  },
  "id": "2f72ad75-b58d-4014-8db6-9fbb5e1d9b76",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0557050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 700,
        "selector": "L700-L701",
        "symbol": "KeyTransformEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "56ad9877-f5d1-4284-b355-37f565660dfc",
  "subject_name": "django/db/models/fields/json::KeyTransformEndsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformEndsWith(KeyTransformTextLookupMixin, lookups.EndsWith)"
}
```
