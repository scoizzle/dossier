# Fact 2c62b5f2

Store id: 2b55952c-8f76-4129-80c6-9684535b95a2

## Text

```text
def relabeled_clone(self, relabels)
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
- posted_at: `2026-11-09T22:39:41.6328910+00:00`

## Data

```json
{
  "end_line": 1377,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1372,
  "symbol": "Col.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1372,"selector":"L1372-L1377","symbol":"Col.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1377,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1372,
    "symbol": "Col.relabeled_clone"
  },
  "id": "2b55952c-8f76-4129-80c6-9684535b95a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6328910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1372,
        "selector": "L1372-L1377",
        "symbol": "Col.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "494b0419-3f90-4516-b1d7-54cb0389e403",
  "subject_name": "django/db/models/expressions::Col.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
