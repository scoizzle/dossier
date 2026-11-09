# Fact 2c62b5f2

Store id: 7f895e8c-4e60-4132-b7a5-27b63f618924

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
- posted_at: `2026-11-09T23:31:55.8939950+00:00`

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
  "id": "7f895e8c-4e60-4132-b7a5-27b63f618924",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8939950+00:00"
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
  "subject_id": "dcf0d6d2-e070-493e-b8d4-2e0c922de60b",
  "subject_name": "django/db/models/expressions::Col.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
