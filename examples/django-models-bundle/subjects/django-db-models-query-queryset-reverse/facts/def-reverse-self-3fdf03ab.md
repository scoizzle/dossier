# Fact 3fdf03ab

Store id: e7d1160f-423d-454b-8509-5538f4bea5fa

## Text

```text
def reverse(self)
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
- posted_at: `2026-11-09T23:32:04.5934560+00:00`

## Data

```json
{
  "end_line": 1979,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1973,
  "symbol": "QuerySet.reverse"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1973,"selector":"L1973-L1979","symbol":"QuerySet.reverse"}`

## Items

```json
[
  {
    "text": "Reverse the ordering of the QuerySet.",
    "locator": {
      "line": 1974
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.reverse](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1979,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1973,
    "symbol": "QuerySet.reverse"
  },
  "id": "e7d1160f-423d-454b-8509-5538f4bea5fa",
  "items": [
    {
      "locator": {
        "line": 1974
      },
      "text": "Reverse the ordering of the QuerySet."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5934560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1973,
        "selector": "L1973-L1979",
        "symbol": "QuerySet.reverse"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "be424340-65ca-4185-bc7b-fd3a73eef0af",
  "subject_name": "django/db/models/query::QuerySet.reverse",
  "tags": [
    "entity:method"
  ],
  "text": "def reverse(self)"
}
```
