# Fact 5fc65c2f

Store id: fdcc3322-4433-4f3d-bcd9-789aaeb7afef

## Text

```text
def dates(self, field_name, kind, order="ASC")
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
- posted_at: `2026-11-09T22:39:49.5853410+00:00`

## Data

```json
{
  "end_line": 1643,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1625,
  "symbol": "QuerySet.dates"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1625,"selector":"L1625-L1643","symbol":"QuerySet.dates"}`

## Items

```json
[
  {
    "text": "Return a list of date objects representing all available dates for the given field_name, scoped to 'kind'.",
    "locator": {
      "line": 1626
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.dates](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1643,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1625,
    "symbol": "QuerySet.dates"
  },
  "id": "fdcc3322-4433-4f3d-bcd9-789aaeb7afef",
  "items": [
    {
      "locator": {
        "line": 1626
      },
      "text": "Return a list of date objects representing all available dates for the given field_name, scoped to 'kind'."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5853410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1625,
        "selector": "L1625-L1643",
        "symbol": "QuerySet.dates"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a4bf438f-a84b-4769-a89c-a847f70acbb0",
  "subject_name": "django/db/models/query::QuerySet.dates",
  "tags": [
    "entity:method"
  ],
  "text": "def dates(self, field_name, kind, order=\"ASC\")"
}
```
