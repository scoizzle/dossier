# Fact 367cf63a

Store id: a19f0eb6-7005-4c8a-8660-7bca5fbd1aa9

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
- posted_at: `2026-11-09T23:44:49.5806060+00:00`

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
  "id": "a19f0eb6-7005-4c8a-8660-7bca5fbd1aa9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5806060+00:00"
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
  "subject_id": "44d3fa2d-1fad-4afd-824b-695a8a8ddf4c",
  "subject_name": "django/db/models/expressions::Ref.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
