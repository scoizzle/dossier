# Fact 827e8a81

Store id: 305547b7-405e-4083-b2ba-74adae168b37

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T22:39:41.6388330+00:00`

## Data

```json
{
  "end_line": 1398,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1397,
  "symbol": "ColPairs.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1397,"selector":"L1397-L1398","symbol":"ColPairs.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1398,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1397,
    "symbol": "ColPairs.__len__"
  },
  "id": "305547b7-405e-4083-b2ba-74adae168b37",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6388330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1397,
        "selector": "L1397-L1398",
        "symbol": "ColPairs.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1167732f-82be-4170-aadf-46a06b1403ea",
  "subject_name": "django/db/models/expressions::ColPairs.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
