# Fact 0896cd16

Store id: 5f382341-e2d4-42e7-af7f-9fc2409045ad

## Text

```text
def none(self)
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
- posted_at: `2026-11-09T23:32:04.5313140+00:00`

## Data

```json
{
  "end_line": 1682,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1678,
  "symbol": "QuerySet.none"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1678,"selector":"L1678-L1682","symbol":"QuerySet.none"}`

## Items

```json
[
  {
    "text": "Return an empty QuerySet.",
    "locator": {
      "line": 1679
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.none](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1682,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1678,
    "symbol": "QuerySet.none"
  },
  "id": "5f382341-e2d4-42e7-af7f-9fc2409045ad",
  "items": [
    {
      "locator": {
        "line": 1679
      },
      "text": "Return an empty QuerySet."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5313140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1678,
        "selector": "L1678-L1682",
        "symbol": "QuerySet.none"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "8a179b51-d6ee-4234-9142-64111037cc87",
  "subject_name": "django/db/models/query::QuerySet.none",
  "tags": [
    "entity:method"
  ],
  "text": "def none(self)"
}
```
