# Fact 367cf63a

Store id: c85e0e0a-dfde-4851-bcbe-dff9ee61fe6a

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
- posted_at: `2026-11-09T22:39:41.6552740+00:00`

## Data

```json
{
  "end_line": 1479,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1476,
  "symbol": "Ref.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1476,"selector":"L1476-L1479","symbol":"Ref.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1479,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1476,
    "symbol": "Ref.relabeled_clone"
  },
  "id": "c85e0e0a-dfde-4851-bcbe-dff9ee61fe6a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6552740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1476,
        "selector": "L1476-L1479",
        "symbol": "Ref.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "47600a20-b069-4f95-897b-b9e5dde8f7ec",
  "subject_name": "django/db/models/expressions::Ref.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
